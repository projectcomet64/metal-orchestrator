
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
            this.cbAddOnChange = new System.Windows.Forms.CheckBox();
            this.pnlPosChange = new System.Windows.Forms.Panel();
            this.pnlZPos = new System.Windows.Forms.Panel();
            this.pnlRotBox = new System.Windows.Forms.Panel();
            this.btnLookTowards = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseMario = new System.Windows.Forms.Button();
            this.tbSpd = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetSpd = new System.Windows.Forms.Button();
            this.cbSHF = new System.Windows.Forms.CheckBox();
            this.tbpTimelineControls = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWipe = new System.Windows.Forms.Button();
            this.cmsDirection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLookUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookForward = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookBehind = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbOrk.SuspendLayout();
            this.tbCam.SuspendLayout();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpd)).BeginInit();
            this.tbpTimelineControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsDirection.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimeline
            // 
            this.pnlTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimeline.Location = new System.Drawing.Point(12, 303);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(1060, 180);
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
            this.msMainMenu.Size = new System.Drawing.Size(1084, 23);
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
            this.saveTimelineToolStripMenuItem.Name = "saveTimelineToolStripMenuItem";
            this.saveTimelineToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.saveTimelineToolStripMenuItem.Text = "Save Timeline (You can\'t, click to find out why)...";
            this.saveTimelineToolStripMenuItem.Click += new System.EventHandler(this.saveTimelineToolStripMenuItem_Click);
            // 
            // loadTimelineToolStripMenuItem
            // 
            this.loadTimelineToolStripMenuItem.Name = "loadTimelineToolStripMenuItem";
            this.loadTimelineToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.loadTimelineToolStripMenuItem.Text = "Load Timeline...";
            this.loadTimelineToolStripMenuItem.Click += new System.EventHandler(this.loadTimelineToolStripMenuItem_Click);
            // 
            // aboutKIOToolStripMenuItem
            // 
            this.aboutKIOToolStripMenuItem.Name = "aboutKIOToolStripMenuItem";
            this.aboutKIOToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.aboutKIOToolStripMenuItem.Text = "About KI-O...";
            this.aboutKIOToolStripMenuItem.Click += new System.EventHandler(this.aboutKIOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orchestrator needs to write the code for freecam before use.\r\n\r\nIf none of the co" +
    "ntrols or Timeline work, you might need to click this.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnsemble
            // 
            this.btnEnsemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnsemble.Location = new System.Drawing.Point(285, 49);
            this.btnEnsemble.Name = "btnEnsemble";
            this.btnEnsemble.Size = new System.Drawing.Size(495, 23);
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
            this.lbStatus.Size = new System.Drawing.Size(910, 69);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: Not Ready";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbOrk);
            this.tbcMain.Controls.Add(this.tbCam);
            this.tbcMain.Controls.Add(this.tbpTimelineControls);
            this.tbcMain.Location = new System.Drawing.Point(12, 27);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1060, 270);
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
            this.tbOrk.Size = new System.Drawing.Size(1052, 244);
            this.tbOrk.TabIndex = 0;
            this.tbOrk.Text = "Orchestrator";
            this.tbOrk.UseVisualStyleBackColor = true;
            // 
            // tbCam
            // 
            this.tbCam.AutoScroll = true;
            this.tbCam.Controls.Add(this.gbInfo);
            this.tbCam.Controls.Add(this.gbControls);
            this.tbCam.Controls.Add(this.cbSHF);
            this.tbCam.Location = new System.Drawing.Point(4, 22);
            this.tbCam.Name = "tbCam";
            this.tbCam.Padding = new System.Windows.Forms.Padding(3);
            this.tbCam.Size = new System.Drawing.Size(1052, 244);
            this.tbCam.TabIndex = 1;
            this.tbCam.Text = "Camera Controls";
            this.tbCam.UseVisualStyleBackColor = true;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.cbAddOnChange);
            this.gbControls.Controls.Add(this.pnlPosChange);
            this.gbControls.Controls.Add(this.pnlZPos);
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
            this.gbControls.Size = new System.Drawing.Size(771, 198);
            this.gbControls.TabIndex = 11;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // cbAddOnChange
            // 
            this.cbAddOnChange.AutoSize = true;
            this.cbAddOnChange.Location = new System.Drawing.Point(308, 157);
            this.cbAddOnChange.Name = "cbAddOnChange";
            this.cbAddOnChange.Size = new System.Drawing.Size(137, 17);
            this.cbAddOnChange.TabIndex = 9;
            this.cbAddOnChange.Text = "Keyframe Record mode";
            this.cbAddOnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttInfo.SetToolTip(this.cbAddOnChange, "Every time you use the Position or Rotation controls, a Keyframe will be added or" +
        " replaced in the current location of the trackhead.");
            this.cbAddOnChange.UseVisualStyleBackColor = true;
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
            this.btnLookTowards.Location = new System.Drawing.Point(606, 151);
            this.btnLookTowards.Name = "btnLookTowards";
            this.btnLookTowards.Size = new System.Drawing.Size(148, 23);
            this.btnLookTowards.TabIndex = 8;
            this.btnLookTowards.Text = "Look towards direction...";
            this.ttInfo.SetToolTip(this.btnLookTowards, "Look towards a specific direction from the current camera position.");
            this.btnLookTowards.UseVisualStyleBackColor = true;
            this.btnLookTowards.Click += new System.EventHandler(this.btnLookTowards_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(305, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 128);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCloseMario
            // 
            this.btnCloseMario.Location = new System.Drawing.Point(451, 152);
            this.btnCloseMario.Name = "btnCloseMario";
            this.btnCloseMario.Size = new System.Drawing.Size(149, 23);
            this.btnCloseMario.TabIndex = 7;
            this.btnCloseMario.Text = "Get close to Mario";
            this.ttInfo.SetToolTip(this.btnCloseMario, "Gets close to Mario using the last angle the program remembers.");
            this.btnCloseMario.UseVisualStyleBackColor = true;
            this.btnCloseMario.Click += new System.EventHandler(this.btnCloseMario_Click);
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
            this.ttInfo.SetToolTip(this.tbSpd, "Sets the speed at which the camera controls change the camera.");
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
            this.ttInfo.SetToolTip(this.btnResetSpd, "Sets speed back to 100%");
            this.btnResetSpd.UseVisualStyleBackColor = true;
            this.btnResetSpd.Click += new System.EventHandler(this.btnResetSpd_Click);
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
            // tbpTimelineControls
            // 
            this.tbpTimelineControls.Controls.Add(this.groupBox1);
            this.tbpTimelineControls.Location = new System.Drawing.Point(4, 22);
            this.tbpTimelineControls.Name = "tbpTimelineControls";
            this.tbpTimelineControls.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTimelineControls.Size = new System.Drawing.Size(1052, 244);
            this.tbpTimelineControls.TabIndex = 2;
            this.tbpTimelineControls.Text = "Timeline Controls";
            this.tbpTimelineControls.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWipe);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timeline";
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(171, 29);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(273, 23);
            this.btnWipe.TabIndex = 0;
            this.btnWipe.Text = "Wipe Timeline (no undo!)";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
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
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.lbInfo);
            this.gbInfo.Location = new System.Drawing.Point(783, 34);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(263, 198);
            this.gbInfo.TabIndex = 12;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(6, 16);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(228, 13);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Waiting for Godot (for Orchestrator to be ready)\r\n";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 495);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.pnlTimeline);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2048, 534);
            this.MinimumSize = new System.Drawing.Size(1100, 262);
            this.Name = "FrmMain";
            this.Text = "METAL Orchestrator";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbOrk.ResumeLayout(false);
            this.tbCam.ResumeLayout(false);
            this.tbCam.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpd)).EndInit();
            this.tbpTimelineControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cmsDirection.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
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
        private System.Windows.Forms.TabPage tbpTimelineControls;
        private System.Windows.Forms.CheckBox cbAddOnChange;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbInfo;
    }
}