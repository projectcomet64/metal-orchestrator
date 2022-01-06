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
using M64MMOrkestrator.Controls;
using M64MMOrkestrator.KIO;

namespace M64MMOrkestrator
{
    public partial class frmTimelineB : Form
    {
        public void UpdateAllLabels()
        {
            lbTbSynchro.Text = $"Synchronized: ${KIOBase.mainTL.Synchronize}";
            lbTlFrame.Text = $"Timeline frame: ${KIOBase.mainTL.TrackheadPosition}";
        }

        public frmTimelineB()
        {
            InitializeComponent();
            Updatebindings();
            UpdateAllLabels();
            TimelineRenderer tL = new TimelineRenderer(KIOBase.mainTL);
            pnlTimeline.Controls.Add(tL);
            tL.Dock = DockStyle.Fill;
        }

        public void Updatebindings()
        {
            lbTlRotation.Items.Clear();
            lbTlPosition.Items.Clear();
            lbTlRotation.Items.AddRange(KIOBase.angleKeyframeRack.OrderedKeyframes.ToArray());
            lbTlPosition.Items.AddRange(KIOBase.camPosKeyframeRack.OrderedKeyframes.ToArray());
        }

        private void btnAddKf_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.AddAllCurrentValuesToRacks();
            Updatebindings();
        }

        private void btnRemKf_Click(object sender, EventArgs e)
        {
            if (lbTlRotation.SelectedItem != null)
            {
                KIOBase.angleKeyframeRack.Remove((Keyframe<XYAngle>) lbTlRotation.SelectedItem);
            }
            if (lbTlPosition.SelectedItem != null)
            {
                KIOBase.camPosKeyframeRack.Remove((Keyframe<Vector3>)lbTlPosition.SelectedItem);
            }
            Updatebindings();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.Synchronize = !KIOBase.mainTL.Synchronize;
        }

        private void btnFrameback_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.TrackheadPosition--;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.TrackheadPosition++;
        }

        private void lbTimelineMax_ValueChanged(object sender, EventArgs e)
        {
            KIOBase.mainTL.Length = (int)((NumericUpDown)sender).Value;
        }

        private void btnTlZero_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.TrackheadPosition = 0;
        }

        private void btnPlaypause_Click(object sender, EventArgs e)
        {
            KIOBase.mainTL.Playing = !KIOBase.mainTL.Playing;
        }
    }
}
