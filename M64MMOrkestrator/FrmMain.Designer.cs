
namespace M64MMOrkestrator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTimeline = new System.Windows.Forms.Panel();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnsemble = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbOrk = new System.Windows.Forms.TabPage();
            this.tbCam = new System.Windows.Forms.TabPage();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.pnlPosChange = new System.Windows.Forms.Panel();
            this.tbDistance = new System.Windows.Forms.TrackBar();
            this.pnlZPos = new System.Windows.Forms.Panel();
            this.cbFollowDistance = new System.Windows.Forms.CheckBox();
            this.pnlRotBox = new System.Windows.Forms.Panel();
            this.btnLookTowards = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseMario = new System.Windows.Forms.Button();
            this.tbSpd = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetSpd = new System.Windows.Forms.Button();
            this.cbSHF = new System.Windows.Forms.CheckBox();
            this.cmsDirection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLookUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookForward = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookBehind = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbOrk.SuspendLayout();
            this.tbCam.SuspendLayout();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpd)).BeginInit();
            this.cmsDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimeline
            // 
            this.pnlTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimeline.Location = new System.Drawing.Point(12, 311);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(640, 180);
            this.pnlTimeline.TabIndex = 13;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutKIOToolStripMenuItem});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMainMenu.Size = new System.Drawing.Size(664, 23);
            this.msMainMenu.TabIndex = 14;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTimelineToolStripMenuItem,
            this.loadTimelineToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTimelineToolStripMenuItem
            // 
            this.saveTimelineToolStripMenuItem.Enabled = false;
            this.saveTimelineToolStripMenuItem.Name = "saveTimelineToolStripMenuItem";
            this.saveTimelineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveTimelineToolStripMenuItem.Text = "Save Timeline...";
            // 
            // loadTimelineToolStripMenuItem
            // 
            this.loadTimelineToolStripMenuItem.Enabled = false;
            this.loadTimelineToolStripMenuItem.Name = "loadTimelineToolStripMenuItem";
            this.loadTimelineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadTimelineToolStripMenuItem.Text = "Load Timeline...";
            // 
            // aboutKIOToolStripMenuItem
            // 
            this.aboutKIOToolStripMenuItem.Name = "aboutKIOToolStripMenuItem";
            this.aboutKIOToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.aboutKIOToolStripMenuItem.Text = "About KI-O...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orchestrator needs to write the code for freecam before use.\r\n\r\nIf none of the co" +
    "ntrols or Timeline work, you might need to. Click this.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnsemble
            // 
            this.btnEnsemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnsemble.Location = new System.Drawing.Point(285, 49);
            this.btnEnsemble.Name = "btnEnsemble";
            this.btnEnsemble.Size = new System.Drawing.Size(75, 23);
            this.btnEnsemble.TabIndex = 1;
            this.btnEnsemble.Text = "Ensemble";
            this.btnEnsemble.UseVisualStyleBackColor = true;
            this.btnEnsemble.Click += new System.EventHandler(this.btnEnsemble_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(77, 75);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(490, 31);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: Not Ready";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbOrk);
            this.tbcMain.Controls.Add(this.tbCam);
            this.tbcMain.Location = new System.Drawing.Point(12, 27);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(640, 278);
            this.tbcMain.TabIndex = 16;
            // 
            // tbOrk
            // 
            this.tbOrk.Controls.Add(this.lbStatus);
            this.tbOrk.Controls.Add(this.btnEnsemble);
            this.tbOrk.Controls.Add(this.label1);
            this.tbOrk.Location = new System.Drawing.Point(4, 22);
            this.tbOrk.Name = "tbOrk";
            this.tbOrk.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrk.Size = new System.Drawing.Size(632, 252);
            this.tbOrk.TabIndex = 0;
            this.tbOrk.Text = "Orchestrator";
            this.tbOrk.UseVisualStyleBackColor = true;
            // 
            // tbCam
            // 
            this.tbCam.AutoScroll = true;
            this.tbCam.Controls.Add(this.gbControls);
            this.tbCam.Controls.Add(this.cbSHF);
            this.tbCam.Location = new System.Drawing.Point(4, 22);
            this.tbCam.Name = "tbCam";
            this.tbCam.Padding = new System.Windows.Forms.Padding(3);
            this.tbCam.Size = new System.Drawing.Size(632, 252);
            this.tbCam.TabIndex = 1;
            this.tbCam.Text = "Camera Controls";
            this.tbCam.UseVisualStyleBackColor = true;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.pnlPosChange);
            this.gbControls.Controls.Add(this.tbDistance);
            this.gbControls.Controls.Add(this.pnlZPos);
            this.gbControls.Controls.Add(this.cbFollowDistance);
            this.gbControls.Controls.Add(this.pnlRotBox);
            this.gbControls.Controls.Add(this.btnLookTowards);
            this.gbControls.Controls.Add(this.label3);
            this.gbControls.Controls.Add(this.btnCloseMario);
            this.gbControls.Controls.Add(this.tbSpd);
            this.gbControls.Controls.Add(this.label4);
            this.gbControls.Controls.Add(this.btnResetSpd);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(6, 34);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(617, 215);
            this.gbControls.TabIndex = 11;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // pnlPosChange
            // 
            this.pnlPosChange.BackgroundImage = global::M64MMOrkestrator.Properties.Resources.posBox;
            this.pnlPosChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPosChange.Location = new System.Drawing.Point(6, 19);
            this.pnlPosChange.Name = "pnlPosChange";
            this.pnlPosChange.Size = new System.Drawing.Size(128, 128);
            this.pnlPosChange.TabIndex = 0;
            this.pnlPosChange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPosChange_MouseDown);
            this.pnlPosChange.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPosChange_MouseMove);
            this.pnlPosChange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPosChange_MouseUp);
            // 
            // tbDistance
            // 
            this.tbDistance.AutoSize = false;
            this.tbDistance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDistance.Enabled = false;
            this.tbDistance.Location = new System.Drawing.Point(463, 185);
            this.tbDistance.Maximum = 600;
            this.tbDistance.Minimum = 20;
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(148, 22);
            this.tbDistance.TabIndex = 10;
            this.tbDistance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDistance.Value = 100;
            // 
            // pnlZPos
            // 
            this.pnlZPos.BackgroundImage = global::M64MMOrkestrator.Properties.Resources.zxBox;
            this.pnlZPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlZPos.Location = new System.Drawing.Point(140, 19);
            this.pnlZPos.Name = "pnlZPos";
            this.pnlZPos.Size = new System.Drawing.Size(25, 128);
            this.pnlZPos.TabIndex = 1;
            this.pnlZPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlZPos_MouseDown);
            this.pnlZPos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlZPos_MouseMove);
            this.pnlZPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlZPos_MouseUp);
            // 
            // cbFollowDistance
            // 
            this.cbFollowDistance.AutoSize = true;
            this.cbFollowDistance.Location = new System.Drawing.Point(308, 187);
            this.cbFollowDistance.Name = "cbFollowDistance";
            this.cbFollowDistance.Size = new System.Drawing.Size(149, 17);
            this.cbFollowDistance.TabIndex = 9;
            this.cbFollowDistance.Text = "Follow Mario at a distance";
            this.cbFollowDistance.UseVisualStyleBackColor = true;
            // 
            // pnlRotBox
            // 
            this.pnlRotBox.BackgroundImage = global::M64MMOrkestrator.Properties.Resources.rotBox;
            this.pnlRotBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRotBox.Location = new System.Drawing.Point(171, 19);
            this.pnlRotBox.Name = "pnlRotBox";
            this.pnlRotBox.Size = new System.Drawing.Size(128, 128);
            this.pnlRotBox.TabIndex = 1;
            this.pnlRotBox.Click += new System.EventHandler(this.pnlRotBox_Click);
            this.pnlRotBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseDown);
            this.pnlRotBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseMove);
            this.pnlRotBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlRotBox_MouseUp);
            // 
            // btnLookTowards
            // 
            this.btnLookTowards.Location = new System.Drawing.Point(463, 152);
            this.btnLookTowards.Name = "btnLookTowards";
            this.btnLookTowards.Size = new System.Drawing.Size(148, 23);
            this.btnLookTowards.TabIndex = 8;
            this.btnLookTowards.Text = "Look towards direction...";
            this.btnLookTowards.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(305, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 128);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCloseMario
            // 
            this.btnCloseMario.Location = new System.Drawing.Point(308, 152);
            this.btnCloseMario.Name = "btnCloseMario";
            this.btnCloseMario.Size = new System.Drawing.Size(149, 23);
            this.btnCloseMario.TabIndex = 7;
            this.btnCloseMario.Text = "Get close to Mario";
            this.btnCloseMario.UseVisualStyleBackColor = true;
            // 
            // tbSpd
            // 
            this.tbSpd.AutoSize = false;
            this.tbSpd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSpd.Location = new System.Drawing.Point(55, 153);
            this.tbSpd.Maximum = 600;
            this.tbSpd.Minimum = 20;
            this.tbSpd.Name = "tbSpd";
            this.tbSpd.Size = new System.Drawing.Size(186, 22);
            this.tbSpd.TabIndex = 3;
            this.tbSpd.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpd.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Speed";
            // 
            // btnResetSpd
            // 
            this.btnResetSpd.Location = new System.Drawing.Point(247, 153);
            this.btnResetSpd.Name = "btnResetSpd";
            this.btnResetSpd.Size = new System.Drawing.Size(55, 23);
            this.btnResetSpd.TabIndex = 5;
            this.btnResetSpd.Text = "100%";
            this.btnResetSpd.UseVisualStyleBackColor = true;
            // 
            // cbSHF
            // 
            this.cbSHF.AutoSize = true;
            this.cbSHF.Location = new System.Drawing.Point(11, 11);
            this.cbSHF.Name = "cbSHF";
            this.cbSHF.Size = new System.Drawing.Size(206, 17);
            this.cbSHF.TabIndex = 6;
            this.cbSHF.Text = "Super Hard Freeze (Enables Freecam)";
            this.cbSHF.UseVisualStyleBackColor = true;
            this.cbSHF.CheckedChanged += new System.EventHandler(this.cbSHF_CheckedChanged);
            // 
            // cmsDirection
            // 
            this.cmsDirection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLookUp,
            this.tsmLookDown,
            this.tsmLookLeft,
            this.tsmLookRight,
            this.tsmLookForward,
            this.tsmLookBehind});
            this.cmsDirection.Name = "cmsDirection";
            this.cmsDirection.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsDirection.Size = new System.Drawing.Size(118, 136);
            // 
            // tsmLookUp
            // 
            this.tsmLookUp.Name = "tsmLookUp";
            this.tsmLookUp.Size = new System.Drawing.Size(117, 22);
            this.tsmLookUp.Text = "Up";
            // 
            // tsmLookDown
            // 
            this.tsmLookDown.Name = "tsmLookDown";
            this.tsmLookDown.Size = new System.Drawing.Size(117, 22);
            this.tsmLookDown.Text = "Down";
            // 
            // tsmLookLeft
            // 
            this.tsmLookLeft.Name = "tsmLookLeft";
            this.tsmLookLeft.Size = new System.Drawing.Size(117, 22);
            this.tsmLookLeft.Text = "Left";
            // 
            // tsmLookRight
            // 
            this.tsmLookRight.Name = "tsmLookRight";
            this.tsmLookRight.Size = new System.Drawing.Size(117, 22);
            this.tsmLookRight.Text = "Right";
            // 
            // tsmLookForward
            // 
            this.tsmLookForward.Name = "tsmLookForward";
            this.tsmLookForward.Size = new System.Drawing.Size(117, 22);
            this.tsmLookForward.Text = "Forward";
            // 
            // tsmLookBehind
            // 
            this.tsmLookBehind.Name = "tsmLookBehind";
            this.tsmLookBehind.Size = new System.Drawing.Size(117, 22);
            this.tsmLookBehind.Text = "Behind";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 503);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.pnlTimeline);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 470);
            this.Name = "FrmMain";
            this.Text = "M64MM KI-O";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbOrk.ResumeLayout(false);
            this.tbCam.ResumeLayout(false);
            this.tbCam.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpd)).EndInit();
            this.cmsDirection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTimeline;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutKIOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnsemble;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbOrk;
        private System.Windows.Forms.TabPage tbCam;
        private System.Windows.Forms.TrackBar tbDistance;
        private System.Windows.Forms.CheckBox cbFollowDistance;
        private System.Windows.Forms.Button btnLookTowards;
        private System.Windows.Forms.Button btnCloseMario;
        private System.Windows.Forms.CheckBox cbSHF;
        private System.Windows.Forms.Button btnResetSpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbSpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRotBox;
        private System.Windows.Forms.Panel pnlZPos;
        private System.Windows.Forms.Panel pnlPosChange;
        private System.Windows.Forms.ContextMenuStrip cmsDirection;
        private System.Windows.Forms.ToolStripMenuItem tsmLookUp;
        private System.Windows.Forms.ToolStripMenuItem tsmLookDown;
        private System.Windows.Forms.ToolStripMenuItem tsmLookLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmLookRight;
        private System.Windows.Forms.ToolStripMenuItem tsmLookForward;
        private System.Windows.Forms.ToolStripMenuItem tsmLookBehind;
        private System.Windows.Forms.GroupBox gbControls;
    }
}