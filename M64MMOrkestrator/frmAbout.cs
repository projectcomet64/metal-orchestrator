using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MMOrkestrator.Properties;

namespace M64MMOrkestrator
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lbVersion.Text = $"Version: {ProductVersion}{Resources.postVersionDecorator}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComet_Click(object sender, EventArgs e)
        {
            Process.Start("https://comet.glitchypsi.xyz");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://comet.glitchypsi.xyz/discord");
        }

        private void btnGh_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/projectcomet64/metal-orchestrator");
        }

        private void btnPatreon_Click(object sender, EventArgs e)
        {
            Process.Start("https://patreon.com/GlitchyPSI");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/GlitchyPSI");
        }
    }
}
