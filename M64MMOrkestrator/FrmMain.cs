using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Utils;
using M64MMOrkestrator.Controls;
using M64MMOrkestrator.KIO;

namespace M64MMOrkestrator
{
    public partial class FrmMain : Form
    {
        private bool _isMouseDownOnPanel;
        private Vector3 _lastVector3;
        private Vector3 _lastLookAtVector3;
        private Point LastClickedOn;
        private XYAngle _lastAngle;
        public FrmMain()
        {
            InitializeComponent();
            TimelineRenderer tL = new TimelineRenderer(KIOBase.mainTL);
            pnlTimeline.Controls.Add(tL);
            tL.Dock = DockStyle.Fill;
        }

        public void ChangeEnsembleStatus(KIOStatus status)
        {
            switch (status)
            {
                case KIOStatus.NOT_READY:
                    {
                        lbStatus.Text = "Status: Not ready yet. Emulator probably not opened";
                        btnEnsemble.Enabled = false;
                        break;
                    }
                case KIOStatus.DIRTY:
                    {
                        lbStatus.Text = "Status: Disabled; game was likely running when KI-O first started.";
                        btnEnsemble.Enabled = true;
                        break;
                    }
                case KIOStatus.HOLDON:
                    {
                        lbStatus.Text = "Status: Waiting for you to enter a door or exit a level.";
                        btnEnsemble.Enabled = false;
                        break;
                    }
                case KIOStatus.READY:
                    {
                        lbStatus.Text = "Status: Ready.";
                        break;
                    }
            }
            cbSHF.Checked = false;
        }

        Vector3 NewXYOffset(float xpos, float ypos)
        {
            float CLX = (float)Math.Sin(KIOBase.CamAngle.X * XYAngle.DEG_TO_RAD);
            float CLZ = (float)Math.Cos(KIOBase.CamAngle.X * XYAngle.DEG_TO_RAD);
            Vector3 offs = new Vector3(xpos / pnlPosChange.Width * CLX,
                ypos / pnlPosChange.Height, xpos / pnlPosChange.Width * CLZ);
            
            offs = offs * tbSpd.Value / 2;
            return offs;
        }

        XYAngle AnglXYOffset(float xpos, float ypos)
        {
            XYAngle offs = new XYAngle(xpos / pnlPosChange.Width,
                -ypos / pnlPosChange.Height);
            Debug.WriteLine($"NEW XANGLE: {offs}");
            offs = offs * 3.6f * tbSpd.Value;
            return offs;
        }

        Vector3 NewZOffset(float ypos)
        {
            Vector3 offs = new Vector3(0, 0, ypos / pnlPosChange.Height);
            offs = offs * KIOBase.CamAngle.LookAtFromPosition(Vector3.Zero, 1) * tbSpd.Value/2;
            return offs;
        }

        private void pnlPosChange_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedOn = new Point(e.X, e.Y);
            _lastVector3 = KIOBase.CamPos;
            _lastLookAtVector3 = KIOBase.CamLookAtPos;
            _isMouseDownOnPanel = true;
        }

        private void pnlPosChange_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDownOnPanel)
            {
                KIOBase.CamPos = _lastVector3 + NewXYOffset(e.X - LastClickedOn.X, e.Y - LastClickedOn.Y);
                KIOBase.CamLookAtPos = _lastLookAtVector3 + NewXYOffset(e.X - LastClickedOn.X, e.Y - LastClickedOn.Y);
            }
        }

        private void pnlPosChange_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
        }

        private void pnlZPos_MouseDown(object sender, MouseEventArgs e)
        {
            _lastVector3 = KIOBase.CamPos;
            _lastLookAtVector3 = KIOBase.CamLookAtPos;
            _isMouseDownOnPanel = true;
        }

        private void pnlZPos_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDownOnPanel)
            {
                KIOBase.CamPos = _lastVector3 + NewZOffset(e.Y);
                KIOBase.CamLookAtPos = _lastLookAtVector3 + NewZOffset(e.Y);
            }
        }

        private void pnlZPos_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ChangeEnsembleStatus(KIOBase.Status);
        }

        private void cbSHF_CheckedChanged(object sender, EventArgs e)
        {
            if (KIOBase.Status != KIOStatus.READY && cbSHF.Checked)
            {
                MessageBox.Show("KI-O is not ready. Go to the Ensemble tab.");
                cbSHF.Checked = !cbSHF.Checked;
                return;
            }
            gbControls.Enabled = cbSHF.Checked;
            Core.WriteBytes(Core.BaseAddress + 0x3E0000, (cbSHF.Checked ? BitConverter.GetBytes((short)03) : BitConverter.GetBytes((short)00)));
        }

        private void btnEnsemble_Click(object sender, EventArgs e)
        {
            KIOBase.Ensemble();
        }

        private void pnlRotBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDownOnPanel = false;
        }

        private void pnlRotBox_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedOn = new Point(e.X, e.Y);
            _lastAngle = KIOBase.CamAngle;
            _isMouseDownOnPanel = true;
        }

        private void pnlRotBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDownOnPanel)
            {
                Debug.WriteLine($"Last XANGLE: {_lastAngle}");
                KIOBase.CamAngle = _lastAngle + AnglXYOffset(e.X - LastClickedOn.X, e.Y - LastClickedOn.Y);
            }
        }

        private void pnlRotBox_Click(object sender, EventArgs e)
        {
            _lastAngle = KIOBase.CamAngle;
            Debug.WriteLine($"Last XANGLE: {_lastAngle}");
            KIOBase.CamAngle = _lastAngle + AnglXYOffset(0, 0);
        }
    }
}
