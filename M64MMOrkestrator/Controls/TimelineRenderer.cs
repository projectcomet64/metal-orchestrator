using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.KIO;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator.Controls
{
    public partial class TimelineRenderer : UserControl
    {
        private Brush headerBrush = new SolidBrush(Color.FromArgb(150, 0, 0, 0));
        private Brush frameNumBrush = new SolidBrush(Color.White);

        private Brush checkerboardBrush =
            new HatchBrush(HatchStyle.LargeCheckerBoard, Color.FromArgb(128, 255, 255, 255), Color.FromArgb(64, 255, 255, 255));
        private Brush trackevenBrush = new SolidBrush(Color.FromArgb(0x717171));
        private Brush trackoddBrush = new SolidBrush(Color.FromArgb(0x5b5b5b));
        private Brush trackHeadBrush = new SolidBrush(Color.White);
        private Pen trackHeadPen = new Pen(Color.Black);
        private Pen trackBodyPen = new Pen(Color.FromArgb(255, 82, 135, 255));
        private Pen frameCountPen = new Pen(Color.LightGray, 1);
        private BindingSource _tlBs = new BindingSource();

        private int frameSizeInPixels;

        private Timeline _tl;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public TimelineRenderer(Timeline tl)
        {
            _tl = tl;
            _tlBs.DataSource = _tl.KeyframeRacks;
            InitializeComponent();

            tsmDiscardCommits.Click += (a, b) => _tl.ClearStagedKeyframes();
            tsmLinear.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Linear);
            tsmSlow.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Slow);
            tsmFast.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Fast);
            tsmSharp.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Sharp);
            tsmSmooth.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Smooth);
            tsmHold.Click += (a, b) => _tl.SetSelectedKeyframeInterpolation(KeyframeType.Hold);

            lbRackTitles.DataSource = _tlBs;
            lbRackTitles.DisplayMember = "Value";
            lbRackTitles.ValueMember = "Key";

            tbZoom.Maximum = pnlRacks.Width / 3;
            tbZoom.Value = tbZoom.Maximum;
            tbZoom.Minimum = Math.Min(_tl.Length / pnlRacks.Width, 1);

            frameSizeInPixels = tbZoom.Value;
            lbRackTitles.Height = lbRackTitles.ItemHeight * (lbRackTitles.Items.Count+1);
            pnlRacks.Height = scRackTitles.Panel1.Height + lbRackTitles.Height + 4;
            
            scRackTitles.Panel2.AutoScrollPosition = new Point(0, 0);
            scRackTitles.Panel2.VerticalScroll.Maximum = 999;
            _tl.OnTrackheadChanged += (tl, e) => Redraw();
            _tl.OnChangesCancelled += (tl, e) => Redraw();
            _tl.OnChangesCommitted += (tl, e) => Redraw();
            _tl.OnKeyframeBulkChanged += (tl, e) => Redraw();
            _tl.OnKeyframeChanged += (tl, e) => Redraw();
            _tl.OnTimelineLoaded += (tl, e) => Redraw();
            _tl.Length = (int)nudLength.Value;
            pnlRacks.Width = _tl.Length * frameSizeInPixels;

            trackHeadPen.Width = 1;
            trackBodyPen.Width = 2;
            Redraw();
        }

        public void Redraw()
        {
            if (!IsHandleCreated) return;
            BeginInvoke(new MethodInvoker(() => {
                lbTimecode.Text = _tl.TimecodeString();
                pnlRacks.Refresh();
            }));
            
        }

        private void pnlRacks_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                int headerHeight = 32;

                // Clear background of panel
                g.Clear(Color.DarkSlateGray);
                g.FillRectangle(checkerboardBrush, new Rectangle(0, headerHeight + 5, pnlRacks.Width, pnlRacks.Height - headerHeight));
                Font frameFont = new Font(Font.FontFamily, 8, FontStyle.Regular);
                
                // Calculate the separation between framenumbers
                int framenumModulo = (int)Math.Max(Math.Round(g.MeasureString("999", frameFont).Width / frameSizeInPixels * 1.5), 1);


                // Make header and framelines
                g.FillRectangle(headerBrush, new Rectangle(0, 0, pnlRacks.Width, headerHeight));
                for (int i = 0; i <= _tl.Length; i++)
                {
                    g.DrawLine(frameCountPen, 0 + frameSizeInPixels * i, headerHeight - 1, 0 + frameSizeInPixels * i, (i % framenumModulo == 0 ? headerHeight - 13 : headerHeight - 4));
                    if (i % framenumModulo == 0)
                    {
                        SizeF nmeasure = g.MeasureString(i.ToString(), frameFont);
                        g.DrawString(i.ToString(), frameFont, frameNumBrush, i * frameSizeInPixels, headerHeight - 10 - (nmeasure.Height / 2));
                    }
                }
                g.DrawLine(frameCountPen, 0, headerHeight, pnlRacks.Width, headerHeight);

                // Flatten the keyframe racks to an array
                // TODO: Potentially give the user a way to organize the racks however they want
                KeyValuePair<string, KeyframeRack>[] krArray = _tl.KeyframeRacks.Cast<KeyValuePair<string, KeyframeRack>>().ToArray();

                // Draw the racks with alternating colors
                for (int i = 0; i < krArray.Count(); i++)
                {
                    g.FillRectangle((i % 2 == 0 ? new SolidBrush(Color.FromArgb(97,97,97)) : new SolidBrush(Color.FromArgb(50,50,50))), new Rectangle(0, 0 + 35 + (i * 24), pnlRacks.Width, 24));
                    
                }

                // Why do I repeat the same loop? Painter's algorithm
                // Keyframes go over the racks and so any modifiers
                for (int i = 0; i < krArray.Count(); i++)
                {
                    foreach (Keyframe kf in krArray[i].Value.OrderedGenericList)
                    {
                        if (_tl.UncommittedRackChanges[krArray[i].Key] != null && _tl.UncommittedRackChanges[krArray[i].Key].Keyframes.Contains(kf))
                        {
                            int delta = _tl.UncommittedRackChanges[krArray[i].Key].Delta;
                            g.DrawImageUnscaled(
                                (_tl.UncommittedRackChanges[krArray[i].Key].NewInterpolation == null
                                    ? Keyframe.KeyframeInterp[kf.InterpolationType]
                                    : Keyframe.KeyframeInterp[(KeyframeType)_tl.UncommittedRackChanges[krArray[i].Key].NewInterpolation]),
                                (int)((kf.Position + delta) * frameSizeInPixels) - 12, 0 + 33 + (i * 24) - 8);
                            g.DrawImageUnscaled(Resources.moveKeyframes, (int)((kf.Position + delta) * frameSizeInPixels) - 12 + 8, 35 + (i * 24));
                            continue;
                        }

                        g.DrawImageUnscaled(Keyframe.KeyframeInterp[kf.InterpolationType], (int)(kf.Position * frameSizeInPixels) - 12, 0 + 35 + (i * 24));
                        if (_tl.SelectedKeyframes.Contains(kf))
                        {
                            g.DrawImageUnscaled(Resources.fSelected, (int)(kf.Position * frameSizeInPixels) - 12 + 8, 35 + (i * 24) + 8);
                        }
                    }
                }

                
                GraphicsPath trackheadPath = new GraphicsPath();
                trackheadPath.AddPolygon(new PointF[]
                {
                    new(_tl.TrackheadPosition * frameSizeInPixels - 5, 14),
                    new(_tl.TrackheadPosition * frameSizeInPixels - 5, 25),
                    new(_tl.TrackheadPosition * frameSizeInPixels, 32),
                    new(_tl.TrackheadPosition * frameSizeInPixels + 6, 25),
                    new(_tl.TrackheadPosition * frameSizeInPixels + 6, 14)
                });

                g.DrawLine(trackBodyPen, _tl.TrackheadPosition * frameSizeInPixels, 32, _tl.TrackheadPosition * frameSizeInPixels, pnlRacks.Height);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(trackHeadBrush, trackheadPath);
                g.DrawPath(trackHeadPen, trackheadPath);
                g.SmoothingMode = SmoothingMode.HighSpeed;
            }
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            frameSizeInPixels = tbZoom.Value;
            pnlRacks.Width = _tl.Length * frameSizeInPixels + (frameSizeInPixels) + (int)(Font.Height * _tl.Length.ToString().Length / 2);
            Redraw();
        }

        private void scRackTitles_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            scRackTitles.Panel1.VerticalScroll.Value = e.NewValue;
        }

        private void lbRackTitles_SelectedValueChanged(object sender, EventArgs e)
        {
            _tl.SelectedRacks.Clear();
            _tl.SelectedRacks.AddRange(lbRackTitles.SelectedItems.Cast<KeyValuePair<string, KeyframeRack>>().Select(x => x.Key));
        }

        private void lbRackTitles_DrawItem(object sender, DrawItemEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
                e.DrawBackground();

                SolidBrush blackbrush = new(Color.Black);
                SolidBrush whitebrush = new(Color.White);

                g.DrawString(lbRackTitles.Items.Cast<KeyValuePair<string, KeyframeRack>>().ToArray()[e.Index].Value.Name, Font, (isSelected ? whitebrush : blackbrush) , 12f, e.Bounds.Top + e.Bounds.Height / 2f - Font.Height/2);
                e.DrawFocusRectangle();
            }
        }

        private void btnAddKf_Click(object sender, EventArgs e)
        {
            _tl.AddAllCurrentValuesToRacks();
            Redraw();
        }

        private void btnSelectKf_Click(object sender, EventArgs e)
        {
            _tl.CommitAllStaged();
            _tl.SelectedKeyframes.Clear();
            // woah! antidupes!
            _tl.SelectedKeyframes.AddRange(_tl.GetKeyframesAtTrackhead().Except(_tl.SelectedKeyframes.ToArray()));
            Redraw();
        }

        private void btnNudgeL_Click(object sender, EventArgs e)
        {
            _tl.StageSelectedKeyframes();
            _tl.MoveAllDeltas(false);
            Redraw();
        }

        private void btnNudgeR_Click(object sender, EventArgs e)
        {
            _tl.StageSelectedKeyframes();
            _tl.MoveAllDeltas(true);
            Redraw();
        }

        private void scTimelineSplit_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                scRackTitles.VerticalScroll.Value = e.NewValue;
            }
        }

        private void btnRemoveKf_Click(object sender, EventArgs e)
        {
            if (_tl.StagedKeyframesPresent)
            {
                _tl.DeleteAllStaged();
            }
            else
            {
                _tl.DeleteKeyframesAtTrackhead();
            }
        }

        private void btnSandwichOpts_Click(object sender, EventArgs e)
        {
            miInterpolation.Enabled = _tl.StagedKeyframesPresent || _tl.SelectedKeyframes.Count > 0;
                cmsKeyframeSettings.Show((Control)sender, (int)((Control)sender).Bounds.Width / 2, (int)((Control)sender).Bounds.Height / 2);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _tl.Playing = !_tl.Playing;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _tl.Playing = false;
            _tl.TrackheadPosition = 0;
        }

        private void btnStepback_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition--;
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition = 0;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition = _tl.Length;
        }

        private void btnBackKf_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition = _tl.GetImmediateKeyframePosition(false);
        }

        private void btnFrontKf_Click(object sender, EventArgs e)
        {
            _tl.TrackheadPosition = _tl.GetImmediateKeyframePosition(true);
        }

        private void cbSync_CheckedChanged(object sender, EventArgs e)
        {
            _tl.Synchronize = cbSync.Checked;
        }

        private void nudLength_ValueChanged(object sender, EventArgs e)
        {
            _tl.Length = (int)((NumericUpDown)sender).Value;
        }

        private void whyCantIControlTheTimelineWithTheMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNazOops oops = new FrmNazOops();
            oops.ShowDialog(this);
        }

        private void pnlRacks_MouseClick(object sender, MouseEventArgs e)
        {
            Control me = (Control) sender;
            cmsWhy.Show(me.PointToScreen(new Point(e.X, e.Y)));
        }
    }
}
