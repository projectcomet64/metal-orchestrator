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
        private Brush headerBrush = new SolidBrush(Color.DarkGray);
        private Brush trackevenBrush = new SolidBrush(Color.FromArgb(0x717171));
        private Brush trackoddBrush = new SolidBrush(Color.FromArgb(0x5b5b5b));
        private Brush trackHeadBrush = new SolidBrush(Color.FromArgb(255, 53, 104, 216));
        private Pen trackHeadPen = new Pen(Color.FromArgb(255, 13, 68, 191));
        private Pen trackBodyPen = new Pen(Color.FromArgb(255, 52, 112, 246));
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
            lbRackTitles.DataSource = _tlBs;
            lbRackTitles.DisplayMember = "Value";
            lbRackTitles.ValueMember = "Key";

            tbZoom.Maximum = pnlRacks.Width / 3;
            tbZoom.Value = tbZoom.Maximum;
            tbZoom.Minimum = Math.Min(_tl.Length / pnlRacks.Width, 1);

            frameSizeInPixels = tbZoom.Value;
            pnlRacks.Width = _tl.Length * frameSizeInPixels;
            lbRackTitles.Height = lbRackTitles.ItemHeight * lbRackTitles.Items.Count;
            pnlRacks.Height = scRackTitles.Panel1.Height + lbRackTitles.Height + 4;
            
            scRackTitles.Panel2.AutoScrollPosition = new Point(0, 0);
            scRackTitles.Panel2.VerticalScroll.Maximum = 999;
            _tl.OnTrackheadChanged += (time) => Redraw();
            trackHeadPen.Width = 2;
            trackBodyPen.Width = 2;
            Redraw();
        }

        public void Redraw()
        {
            lbTimecode.Text = _tl.TimecodeString();
            pnlRacks.Refresh();
        }

        private void pnlRacks_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                // Clear background of panel
                g.Clear(Color.DarkSlateGray);

                // Make header and framelines
                g.FillRectangle(headerBrush, new Rectangle(0, 0, pnlRacks.Width, 32));
                for (int i = 0; i < _tl.Length; i++)
                {
                    g.DrawLine(frameCountPen, 0 + frameSizeInPixels * i, 31, 0 + frameSizeInPixels * i, 16);
                }

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
                            g.DrawImageUnscaled(Keyframe.KeyframeInterp[kf.InterpolationType], (int)((kf.Position + delta) * frameSizeInPixels) - 12, 0 + 33 + (i * 24) - 8);
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
                    new(_tl.TrackheadPosition * frameSizeInPixels - 4, 25),
                    new(_tl.TrackheadPosition * frameSizeInPixels + 4, 25),
                    new(_tl.TrackheadPosition * frameSizeInPixels, 32)
                });

                g.DrawLine(trackBodyPen, _tl.TrackheadPosition * frameSizeInPixels, 32, _tl.TrackheadPosition * frameSizeInPixels, pnlRacks.Height);
                g.FillPath(trackHeadBrush, trackheadPath);
                g.DrawPath(trackHeadPen, trackheadPath);

            }
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            frameSizeInPixels = tbZoom.Value;
            pnlRacks.Width = _tl.Length * frameSizeInPixels;
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
            Redraw();
        }

        private void btnSelectKf_Click(object sender, EventArgs e)
        {
            _tl.CommitAllChanges();
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
    }
}
