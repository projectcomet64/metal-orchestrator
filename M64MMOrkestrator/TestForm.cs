using M64MM.Utils;
using M64MMOrkestrator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyshift.Core.Classes.Rack.Types;

namespace M64MMOrkestrator
{
    public partial class TestForm : Form
    {

        public void UpdateVals()
        {
            Vector3 pos = KIOBase.MarioPos;
            Vector3 camPos = KIOBase.CamPos;
            Vector3 lookAtCamPos = KIOBase.CamLookAtPos;
            XYAngle camXyAngle = KIOBase.CamAngle;
            lbMarioInfo.Text = $"Mario Pos Info:\nX: {pos.X}\nY: {pos.Y}\nZ: {pos.Z}";
            lbCamInfo.Text = $"Hacked Cam Pos Info:\nX: {camPos.X}\nY: {camPos.Y}\nZ: {camPos.Z}\nHacked Cam Pos LookAt Info:\nX: {lookAtCamPos.X} // DEG: {camXyAngle.X}\nY: {lookAtCamPos.Y} // DEG: {camXyAngle.Y}\nZ: {lookAtCamPos.Z}";

            if (cbFocusMario.Checked)
            {
                // Remember to make XCamPos a Vector3 too so you don't have to make so many calls
                KIOBase.CamPos = pos;
            }

            if (cbLookAtMario.Checked)
            {
                // Remember to make XCamPos a Vector3 too so you don't have to make so many calls
                KIOBase.CamLookAtPos = pos;
            }

            if (cbAngleMode.Checked)
            {
                pos.Z += 280;
                pos.Y += 240;
                KIOBase.CamLookAtPos = pos;
                pos.Z += 70;
                pos.Y += 30;
                KIOBase.CamPos = pos;
            }

            if (tbChangeAngleMan.Checked)
            {
                KIOBase.CamAngle = new XYAngle((float)nudChangleX.Value, (float)nudChangleY.Value);
                //KIOBase.CamLookAtPos = KIOBase.CamAngle.LookAtFromPosition(pos);
            }

            if (cbTwister.Checked)
            {
                KIOBase.CamAngle = KIOBase.CamAngle + new XYAngle((float)nudDegPerFrame.Value, 0);
                //KIOBase.CamLookAtPos = KIOBase.CamAngle.LookAtFromPosition(pos);
            }
        }

        public TestForm()
        {
            InitializeComponent();
        }

        private void btnEnsemble_Click(object sender, EventArgs e)
        {
            KIOBase.Init();

        }

        private void cbFocusMario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFocusMario.Checked && cbFocusMario.Checked)
            {
                cbLookAtMario.Checked = !cbFocusMario.Checked;
            }
        }

        private void cbLookAtMario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLookAtMario.Checked && cbFocusMario.Checked)
            {
                cbFocusMario.Checked = !cbLookAtMario.Checked;
            }
        }

        private void cbAngleMode_CheckedChanged(object sender, EventArgs e)
        {
            cbFocusMario.Checked = cbLookAtMario.Checked = false;
        }

        /// <summary>
        /// gets position in circle rotating in +Y axis given degrees
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="degrees"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        Vector3 MakeAngleFromPos(Vector3 pos, float degrees, float size)
        {
            pos.Z += (float)(Math.Sin(degrees / 360 * Math.PI * 2) * size);
            pos.X += (float)(Math.Cos(degrees / 360 * Math.PI * 2) * size);
            return pos;
        }

        private void btnTestBezier_Click(object sender, EventArgs e)
        {
            frmBezierM fb = new frmBezierM();
            fb.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KIOBase.MainForm?.Show();
        }
    }

    public struct CameraPosition
    {
        public Vector3 Position;

        public Vector3 LookingAt;

    }
}
