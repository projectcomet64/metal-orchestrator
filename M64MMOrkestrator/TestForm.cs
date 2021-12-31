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

namespace M64MMOrkestrator
{
    public partial class TestForm : Form
    {
        private float _angle;

        public float Angle
        {
            get => _angle;
            set
            {
                _angle = value;

                if (value < 0)
                {
                    _angle = 360 - value;
                }
                if (value > 360)
                {
                    _angle = value - 360;
                }
            }
        }
        public Vector3 MarioPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] marioposVals = Core.ReadBytes(Core.BaseAddress + 0x33B1AC, 12);
                v.X = BitConverter.ToSingle(marioposVals, 0);
                v.Y = BitConverter.ToSingle(marioposVals, 4);
                v.Z = BitConverter.ToSingle(marioposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x33B1AC, fullvals, false);
            }
        }

        public Vector3 CamPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] camposVals = Core.ReadBytes(Core.BaseAddress + 0x3E0004, 12);
                v.X = BitConverter.ToSingle(camposVals, 0);
                v.Y = BitConverter.ToSingle(camposVals, 4);
                v.Z = BitConverter.ToSingle(camposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x3E0004, fullvals, false);
            }
        }

        public Vector3 CamLookAtPos
        {
            get
            {
                Vector3 v = new Vector3();
                byte[] camposVals = Core.ReadBytes(Core.BaseAddress + 0x3E0010, 12);
                v.X = BitConverter.ToSingle(camposVals, 0);
                v.Y = BitConverter.ToSingle(camposVals, 4);
                v.Z = BitConverter.ToSingle(camposVals, 8);
                return v;
            }

            set
            {
                byte[] valsX = BitConverter.GetBytes(value.X);
                byte[] valsY = BitConverter.GetBytes(value.Y);
                byte[] valsZ = BitConverter.GetBytes(value.Z);
                byte[] fullvals = new byte[valsX.Length * 3];
                valsX.CopyTo(fullvals, 0);
                valsY.CopyTo(fullvals, 4);
                valsZ.CopyTo(fullvals, 8);
                Core.WriteBytes(Core.BaseAddress + 0x3E0010, fullvals, false);
            }
        }

        public void UpdateVals()
        {
            Vector3 pos = MarioPos;
            Vector3 camPos = CamPos;
            Vector3 lookAtCamPos = CamLookAtPos;
            lbMarioInfo.Text = $"Mario Pos Info:\nX: {pos.X}\nY: {pos.Y}\nZ: {pos.Z}";
            lbCamInfo.Text = $"Hacked Cam Pos Info:\nX: {camPos.X}\nY: {camPos.Y}\nZ: {camPos.Z}\nHacked Cam Pos LookAt Info:\nX: {lookAtCamPos.X}\nY: {lookAtCamPos.Y}\nZ: {lookAtCamPos.Z}";

            if (cbFocusMario.Checked)
            {
                // Remember to make XCamPos a Vector3 too so you don't have to make so many calls
                CamPos = pos;
            }

            if (cbLookAtMario.Checked)
            {
                // Remember to make XCamPos a Vector3 too so you don't have to make so many calls
                CamLookAtPos = pos;
            }

            if (cbAngleMode.Checked)
            {
                pos.Z += 280;
                pos.Y += 240;
                CamLookAtPos = pos;
                pos.Z += 70;
                pos.Y += 30;
                CamPos = pos;
            }

            if (cbTwister.Checked)
            {
                Angle += (float)nudDegPerFrame.Value;
                CamLookAtPos = MakeAngleFromPos(camPos, Angle, (float)nudEllipsisSize.Value);
            }
        }

        public TestForm()
        {
            InitializeComponent();
        }

        private void btnEnsemble_Click(object sender, EventArgs e)
        {
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x6316c, Resources._6316c, true);
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x31440, Resources._31440, true);
            Core.WriteBytes(Core.BaseAddress + 0x245000 + 0x42ce0, Resources._42ce0, true);


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
    }

    public struct CameraPosition
    {
        public Vector3 Position;

        public Vector3 LookingAt;

    }
}
