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
using M64MMOrkestrator.Extensions;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator
{
    public partial class frmBezierM : Form
    {
        List<Vector3> points = new List<Vector3>();

        private bool holdingPoint;
        private int modifyingIndex = 0;

        private PointF spamtonPosition;

        private float progress;

        private Bitmap preview;
        private Pen oPen = new Pen(Color.BlueViolet);
        private Pen kPen = new Pen(Color.DimGray);
        private Brush fBrush = new SolidBrush(Color.NavajoWhite);

        PointF[] KeyPolygon(PointF origin)
        {
            return new PointF[]
            {
                new PointF(origin.X - 5, origin.Y),
                new PointF(origin.X, origin.Y + 5),
                new PointF(origin.X + 5, origin.Y),
                new PointF(origin.X, origin.Y - 5)
            };
        } 

        public frmBezierM()
        {
            InitializeComponent();
            preview = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            oPen.Width = 3;
            kPen.Width = 2;
            pictureBox1.Image = preview;
            Redraw();
        }

        public void Redraw()
        {
            PointF[] pts = MathExtensions.vec3ToPointFs(points.ToArray()).ToArray();
            using (Graphics g = Graphics.FromImage(preview))
            {
                g.Clear(Color.Black);
                if (points.Count == 0) return;
                g.DrawBeziers(oPen, pts);
                foreach (PointF pointx in pts)
                {
                    g.DrawPolygon(oPen, KeyPolygon(pointx));
                    g.FillPolygon(fBrush, KeyPolygon(pointx));
                }
                g.DrawImageUnscaled(Resources.spamton, new Point((int)spamtonPosition.X - Resources.spamton.Width/2, (int)spamtonPosition.Y - Resources.spamton.Height / 2));
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            points.Add(new Vector3());
            modifyingIndex = points.Count - 1;
            holdingPoint = true;
            points[modifyingIndex] = new Vector3(e.X, e.Y, 0);
            Redraw();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            holdingPoint = false;
            Redraw();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!holdingPoint) return;
            points[modifyingIndex] = new Vector3(e.X, e.Y, 0);
            Redraw();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            progress = 0;
            Redraw();
        }

        private void tmrTicker_Tick(object sender, EventArgs e)
        {
            if (progress < 100) progress += (float) (numericUpDown1.Value);
            else progress = 100;
            Vector3 pos = MathExtensions.BezierInterpolate(points.ToArray(), progress/100);
            spamtonPosition = new PointF(pos.X, pos.Y);
            Redraw();
            btnRestart.Text = $"restart ({progress})";
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            tmrTicker.Enabled = !tmrTicker.Enabled;
            btnBegin.Text = $"playing: {tmrTicker.Enabled}";
                
        }
    }
}
