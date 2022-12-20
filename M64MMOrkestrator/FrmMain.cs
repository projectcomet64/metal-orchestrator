using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Utils;
using Keyshift.Forms.Controls;
using Keyshift.Core;
using Keyshift.Core.Classes;
using Keyshift.Core.Classes.Rack.Types;
using Keyshift.Core.Interfaces;

namespace M64MMOrkestrator
{
    public partial class FrmMain : Form
    {
        private bool _isMouseDownOnPanel;
        private TimelineRenderer _tL;
        private Vector3 _lastVector3;
        private Vector3 _lastLookAtVector3;
        private PointF LastClickedOn;
        private XYAngle _lastAngle;
        private bool _shifting;
        private HistoryManager _history;
        private IReversibleChange[] _compoundChangeArray => _history.UndoArray.Reverse().Concat(_history.RedoArray).ToArray();

        public FrmMain()
        {
            InitializeComponent();
            _history = new HistoryManager();
            KIOBase.mainTL.History = _history;
            _tL = new TimelineRenderer(KIOBase.mainTL);
            pnlTimeline.Controls.Add(_tL);
            _tL.Dock = DockStyle.Fill;
            tsmLookBehind.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(180, 0); };
            tsmLookForward.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(0, 0); };
            // spooky euler angles singularity:
            // https://www.euclideanspace.com/maths/geometry/rotations/euler/singularity/index.htm

            // I'm keeping XY (Yawpitch) angle representation instead of quaternion just because it's easy.
            // when KI-O becomes part of M64MM as Orchestrator, I will make XYZ Euler be backed by Quaternion for things like rotations.
            tsmLookDown.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(0, -89.999f); };
            tsmLookUp.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(0, 89.999f); };
            tsmLookLeft.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(90, 0); };
            tsmLookRight.Click += (a, b) => { KIOBase.CamAngle = new XYAngle(-90, 0); };

            // Undo/Redo binding
            _history.AfterUndo += (s, e) => { UpdateUndoRedoList(); };
            _history.AfterRedo += (s, e) => { UpdateUndoRedoList(); };
            _history.AfterPush += (s, e) => { UpdateUndoRedoList(); };
            _history.Erasure += (s, e) => { UpdateUndoRedoList(); };
            KIOBase.mainTL.OnTimelineLoaded += (sender, args) => { _history.EraseHistory(); };
        }

        public void ChangeEnsembleStatus(KIOStatus status)
        {
            switch (status)
            {
                case KIOStatus.NOT_READY:
                    {
                        lbStatus.Text = "Status: Not ready yet. Emulator probably hasn't started SM64 yet.";
                        btnEnsemble.Enabled = false;
                        cbSHF.Checked = false;
                        break;
                    }
                case KIOStatus.DIRTY:
                    {
                        lbStatus.Text = "Status: Disabled; game was likely running when KI-O first started or you loaded a savestate with KI-O disabled.";
                        btnEnsemble.Enabled = true;
                        cbSHF.Checked = false;
                        break;
                    }
                case KIOStatus.WTF:
                    {
                        lbStatus.Text = "Status: !?!? (You probably have GlideN Framebuffer enabled. Disable it in Graphics Settings and reopen PJ64)";
                        btnEnsemble.Enabled = false;
                        cbSHF.Checked = false;
                        break;
                    }
                case KIOStatus.HOLDON:
                    {
                        lbStatus.Text = "Status: Waiting for you to enter a door, exit a level or start the game.";
                        btnEnsemble.Enabled = false;
                        cbSHF.Checked = false;
                        break;
                    }
                case KIOStatus.READY:
                    {
                        lbStatus.Text = "Status: Ready to rock.";
                        btnEnsemble.Enabled = false;
                        cbSHF.Checked = false;
                        break;
                    }
            }
            cbSHF.Checked = false;
        }

        Vector3 NewXYOffset(float xpos, float ypos)
        {
            float CLX = (float)Math.Cos(KIOBase.CamAngle.X * XYAngle.DEG_TO_RAD);
            float CLZ = (float)Math.Sin(-KIOBase.CamAngle.X * XYAngle.DEG_TO_RAD);
            Vector3 offs = new Vector3(xpos / pnlPosChange.Width * CLX,
                ypos / pnlPosChange.Height, xpos / pnlPosChange.Width * CLZ);

            offs = offs * tbSpd.Value / 2 * 20;
            return offs;
        }

        XYAngle AnglXYOffset(float xpos, float ypos)
        {
            XYAngle offs = new XYAngle(-xpos / pnlPosChange.Width,
                -ypos / pnlPosChange.Height);
            Debug.WriteLine($"NEW XANGLE: {offs}");
            offs = offs * 0.8f * tbSpd.Value;
            return offs;
        }

        Vector3 NewZOffset(float ypos)
        {
            Vector3 offs = _lastAngle.LookAtFromPosition(Vector3.Zero, 20) * (-ypos / pnlZPos.Height) * tbSpd.Value / 2;
            return offs;
        }

        private void pnlPosChange_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedOn = new Point(e.X, e.Y);
            _lastAngle = KIOBase.CamAngle;
            _lastVector3 = KIOBase.CamPos;
            _isMouseDownOnPanel = true;
        }

        private void pnlPosChange_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDownOnPanel) return;

            float xDiff = e.X - LastClickedOn.X;
            float yDiff = e.Y - LastClickedOn.Y;

            // if shifting then lock to one direction
            if (_shifting)
            {
                xDiff = (Math.Abs(xDiff) > Math.Abs(yDiff) ? xDiff : 0);
                yDiff = (Math.Abs(xDiff) < Math.Abs(yDiff) ? yDiff : 0);
            }

            KIOBase.CamPos = _lastVector3 + NewXYOffset(xDiff, yDiff);
            KIOBase.CamAngle = _lastAngle;
        }

        private void pnlPosChange_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
            if (cbAddOnChange.Checked)
            {
                KIOBase.camPosKeyframeRack.AddCurrentStateAtPosition(KIOBase.mainTL.TrackheadPosition);
                _tL.Redraw();
            }
        }

        private void pnlZPos_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedOn = new PointF(e.X, e.Y);
            _lastVector3 = KIOBase.CamPos;
            _lastAngle = KIOBase.CamAngle;
            _isMouseDownOnPanel = true;
        }

        private void pnlZPos_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDownOnPanel)
            {
                KIOBase.CamPos = _lastVector3 + NewZOffset(e.Y - LastClickedOn.Y);
                KIOBase.CamAngle = _lastAngle;
            }
        }

        private void pnlZPos_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
            if (cbAddOnChange.Checked)
            {
                KIOBase.camPosKeyframeRack.AddCurrentStateAtPosition(KIOBase.mainTL.TrackheadPosition);
                _tL.Redraw();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            // if not beta 1 or greater, will die
            Core.UsingTurbo = true;
            Core.UsingTurbo = false;
            base.OnShown(e);
            ChangeEnsembleStatus(KIOBase.Status);
            _tL.Redraw();
        }

        public void UpdateValues()
        {
            if (KIOBase.Status == KIOStatus.READY)
            {
                lbInfo.Text =
                    $"Camera is standing at:\n{KIOBase.CamPos}\n\nLooking towards (yaw, pitch):\n{KIOBase.CamAngle}\n\nMario is standing at: \n{KIOBase.MarioPos}";
            }
            else
            {
                lbInfo.Text = "Waiting for Godot (for Orchestrator to be ready)";
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void cbSHF_CheckedChanged(object sender, EventArgs e)
        {
            if (KIOBase.Status != KIOStatus.READY && cbSHF.Checked)
            {
                MessageBox.Show("Orchestrator is not ready. Go to the Orchestrator tab and click Ensemble.");
                cbSHF.Checked = !cbSHF.Checked;
            }
            else
            {
                gbControls.Enabled = cbSHF.Checked;
                Core.ToggleCameraSoftFreeze();
                KIOBase.CamAngle = XYAngle.FromVectorPair(KIOBase.CamPos, KIOBase.CamLookAtPos);
                Core.WriteBytes(Core.BaseAddress + 0x3E0000, (cbSHF.Checked ? BitConverter.GetBytes((short)03) : BitConverter.GetBytes((short)00)));
            }

        }

        private void btnEnsemble_Click(object sender, EventArgs e)
        {
            KIOBase.Ensemble();
        }

        private void pnlRotBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
            if (cbAddOnChange.Checked)
            {
                KIOBase.angleKeyframeRack.AddCurrentStateAtPosition(KIOBase.mainTL.TrackheadPosition);
                _tL.Redraw();
            }
        }

        private void pnlRotBox_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedOn = new Point(e.X, e.Y);
            _lastAngle = KIOBase.CamAngle;
            _isMouseDownOnPanel = true;
        }

        private void pnlRotBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDownOnPanel) return;

            float xDiff = e.X - LastClickedOn.X;
            float yDiff = e.Y - LastClickedOn.Y;
            // if shifting then lock to one direction
            if (_shifting)
            {
                xDiff = (Math.Abs(xDiff) > Math.Abs(yDiff) ? xDiff : 0);
                yDiff = (Math.Abs(xDiff) < Math.Abs(yDiff) ? yDiff : 0);
            }

            KIOBase.CamAngle = _lastAngle + AnglXYOffset(xDiff, yDiff);
        }

        private void pnlRotBox_Click(object sender, EventArgs e)
        {
            _lastAngle = KIOBase.CamAngle;
            KIOBase.CamAngle = _lastAngle + AnglXYOffset(0, 0);
        }

        private void btnResetSpd_Click(object sender, EventArgs e)
        {
            tbSpd.Value = 100;
        }

        private void btnCloseMario_Click(object sender, EventArgs e)
        {
            KIOBase.CamPos = KIOBase.MarioPos - KIOBase.CamAngle.LookAtFromPosition(Vector3.Zero, 400f);
            KIOBase.CamLookAtPos = KIOBase.MarioPos;
            KIOBase.CamAngle = XYAngle.FromVectorPair(KIOBase.CamPos, KIOBase.CamLookAtPos);
        }

        private void btnLookTowards_Click(object sender, EventArgs e)
        {
            cmsDirection.Show((Control)sender, ((Control)sender).Bounds.Width / 2, ((Control)sender).Bounds.Height / 2);
        }

        private void saveTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonTl = KIOBase.mainTL.SerializeToJson();
            SaveFileDialog _sfd = new SaveFileDialog();
            _sfd.Title = "Save Timeline JSON...";
            _sfd.AddExtension = true;
            _sfd.Filter = "Timeline JSON (*.json)|*.json";
            DialogResult result = _sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(_sfd.FileName, jsonTl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Couldn't write the file!\nError: {ex.Message}");
                }
            }
        }

        private void loadTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Title = "Save Timeline JSON...";
            ofd.AddExtension = true;
            ofd.Filter = "Timeline JSON (*.json)|*.json";
            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK) return;
            bool couldLoad = KIOBase.mainTL.DeserializeFromJson(File.ReadAllText(ofd.FileName));
            if (!couldLoad) MessageBox.Show("Error while loading into Timeline. Probably corrupt JSON.");

        }

        private void aboutKIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout _about = new frmAbout();
            _about.ShowDialog();
        }

        private void btnWipe_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show(
                    "Are you sure you want to do that\nIt really is not undoable! At least save your progress in File > Save Timeline...",
                    "Hol up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                KIOBase.mainTL.WipeEverything();
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            _shifting = e.Shift;
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            _shifting = e.Shift;
        }

        private void tbSpd_ValueChanged(object sender, EventArgs e)
        {
            lbSpd.Text = $"{tbSpd.Value}%";
        }

        private void btnCollapseTl_Click(object sender, EventArgs e)
        {
            bool collapse = !scMain.Panel2Collapsed;
            int newHeight;

            //lol
            if (collapse)
            {
                newHeight = (Height - scMain.Panel2.Height);
                scMain.Panel2Collapsed = true;
            }
            else
            {
                scMain.Panel2Collapsed = collapse;
                newHeight = (Height + scMain.Panel2.Height);

            }
            Height = newHeight;

        }

        private void UpdateUndoRedoList() {
            lbUndoRedo.Items.Clear();
            lbUndoRedo.Items.AddRange(_compoundChangeArray);
            lbUndoRedo.TopIndex = _history.UndoArray.Length - 1;
        }

        private void lbUndoRedo_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index < 0) return;
            bool isRedo = e.Index > _history.UndoArray.Length - 1;
            Font usedFont = (!isRedo ? ((Control)sender).Font : new Font(((Control)sender).Font, FontStyle.Italic));
            using (Graphics g = e.Graphics)
            {
                g.FillRectangle(new SolidBrush(((Control)sender).BackColor), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                string itemText = ((IReversibleChange)((ListBox)sender).Items[e.Index]).ToString();
                SizeF stringMeasure =
                    g.MeasureString(itemText,
                        ((Control)sender).Font, e.Bounds.Size);
                g.DrawString(itemText, usedFont,
                    new SolidBrush((!isRedo ? SystemColors.ControlText : SystemColors.GrayText)),
                    new RectangleF(e.Bounds.X + 4, e.Bounds.Y + 4, e.Bounds.Width - 8, e.Bounds.Width - 4));
            }
        }

        private void lbUndoRedo_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;
            using Graphics g = e.Graphics;
            SizeF stringMeasure =
                g.MeasureString(((IReversibleChange)((ListBox)sender).Items[e.Index]).ToString(), ((Control)sender).Font);

            e.ItemHeight = (int)stringMeasure.Height + 8;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            _history.EraseHistory();
        }
    }
}
