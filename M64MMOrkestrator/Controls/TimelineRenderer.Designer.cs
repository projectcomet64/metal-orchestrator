
namespace M64MMOrkestrator.Controls
{
    partial class TimelineRenderer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineRenderer));
            this.scControls = new System.Windows.Forms.SplitContainer();
            this.scTimelineSplit = new System.Windows.Forms.SplitContainer();
            this.scRackTitles = new System.Windows.Forms.SplitContainer();
            this.lbTimecode = new System.Windows.Forms.Label();
            this.lbRackTitles = new System.Windows.Forms.ListBox();
            this.pnlRacks = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnStepback = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSandwichOpts = new System.Windows.Forms.Button();
            this.btnNudgeR = new System.Windows.Forms.Button();
            this.btnNudgeL = new System.Windows.Forms.Button();
            this.btnSelectKf = new System.Windows.Forms.Button();
            this.btnRemoveKf = new System.Windows.Forms.Button();
            this.btnAddKf = new System.Windows.Forms.Button();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.ttButtonInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cmsKeyframeSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miInterpolation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLinear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSmooth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHold = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmBezier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDiscardCommits = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scControls)).BeginInit();
            this.scControls.Panel1.SuspendLayout();
            this.scControls.Panel2.SuspendLayout();
            this.scControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTimelineSplit)).BeginInit();
            this.scTimelineSplit.Panel1.SuspendLayout();
            this.scTimelineSplit.Panel2.SuspendLayout();
            this.scTimelineSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRackTitles)).BeginInit();
            this.scRackTitles.Panel1.SuspendLayout();
            this.scRackTitles.Panel2.SuspendLayout();
            this.scRackTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.cmsKeyframeSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // scControls
            // 
            this.scControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scControls.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scControls.IsSplitterFixed = true;
            this.scControls.Location = new System.Drawing.Point(0, 0);
            this.scControls.Margin = new System.Windows.Forms.Padding(0);
            this.scControls.Name = "scControls";
            this.scControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scControls.Panel1
            // 
            this.scControls.Panel1.AutoScroll = true;
            this.scControls.Panel1.Controls.Add(this.scTimelineSplit);
            // 
            // scControls.Panel2
            // 
            this.scControls.Panel2.Controls.Add(this.btnEnd);
            this.scControls.Panel2.Controls.Add(this.btnPlay);
            this.scControls.Panel2.Controls.Add(this.btnAdvance);
            this.scControls.Panel2.Controls.Add(this.btnStepback);
            this.scControls.Panel2.Controls.Add(this.btnStop);
            this.scControls.Panel2.Controls.Add(this.btnStart);
            this.scControls.Panel2.Controls.Add(this.btnSandwichOpts);
            this.scControls.Panel2.Controls.Add(this.btnNudgeR);
            this.scControls.Panel2.Controls.Add(this.btnNudgeL);
            this.scControls.Panel2.Controls.Add(this.btnSelectKf);
            this.scControls.Panel2.Controls.Add(this.btnRemoveKf);
            this.scControls.Panel2.Controls.Add(this.btnAddKf);
            this.scControls.Panel2.Controls.Add(this.tbZoom);
            this.scControls.Panel2MinSize = 32;
            this.scControls.Size = new System.Drawing.Size(971, 523);
            this.scControls.SplitterDistance = 490;
            this.scControls.SplitterWidth = 1;
            this.scControls.TabIndex = 0;
            // 
            // scTimelineSplit
            // 
            this.scTimelineSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scTimelineSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scTimelineSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scTimelineSplit.Location = new System.Drawing.Point(0, 0);
            this.scTimelineSplit.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.scTimelineSplit.Name = "scTimelineSplit";
            // 
            // scTimelineSplit.Panel1
            // 
            this.scTimelineSplit.Panel1.Controls.Add(this.scRackTitles);
            this.scTimelineSplit.Panel1MinSize = 200;
            // 
            // scTimelineSplit.Panel2
            // 
            this.scTimelineSplit.Panel2.AutoScroll = true;
            this.scTimelineSplit.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scTimelineSplit.Panel2.BackgroundImage")));
            this.scTimelineSplit.Panel2.Controls.Add(this.pnlRacks);
            this.scTimelineSplit.Panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scTimelineSplit_Panel2_Scroll);
            this.scTimelineSplit.Panel2MinSize = 220;
            this.scTimelineSplit.Size = new System.Drawing.Size(971, 490);
            this.scTimelineSplit.SplitterDistance = 200;
            this.scTimelineSplit.SplitterWidth = 2;
            this.scTimelineSplit.TabIndex = 1;
            // 
            // scRackTitles
            // 
            this.scRackTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRackTitles.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRackTitles.IsSplitterFixed = true;
            this.scRackTitles.Location = new System.Drawing.Point(0, 0);
            this.scRackTitles.Margin = new System.Windows.Forms.Padding(0);
            this.scRackTitles.Name = "scRackTitles";
            this.scRackTitles.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRackTitles.Panel1
            // 
            this.scRackTitles.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scRackTitles.Panel1.Controls.Add(this.lbTimecode);
            this.scRackTitles.Panel1MinSize = 31;
            // 
            // scRackTitles.Panel2
            // 
            this.scRackTitles.Panel2.Controls.Add(this.lbRackTitles);
            this.scRackTitles.Panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scRackTitles_Panel2_Scroll);
            this.scRackTitles.Size = new System.Drawing.Size(198, 488);
            this.scRackTitles.SplitterDistance = 31;
            this.scRackTitles.SplitterWidth = 1;
            this.scRackTitles.TabIndex = 1;
            // 
            // lbTimecode
            // 
            this.lbTimecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTimecode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimecode.Location = new System.Drawing.Point(0, 0);
            this.lbTimecode.Name = "lbTimecode";
            this.lbTimecode.Size = new System.Drawing.Size(198, 31);
            this.lbTimecode.TabIndex = 0;
            this.lbTimecode.Text = "00:00:00.00";
            this.lbTimecode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRackTitles
            // 
            this.lbRackTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRackTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRackTitles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbRackTitles.FormattingEnabled = true;
            this.lbRackTitles.ItemHeight = 24;
            this.lbRackTitles.Location = new System.Drawing.Point(0, 0);
            this.lbRackTitles.Margin = new System.Windows.Forms.Padding(0);
            this.lbRackTitles.Name = "lbRackTitles";
            this.lbRackTitles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRackTitles.Size = new System.Drawing.Size(198, 216);
            this.lbRackTitles.TabIndex = 1;
            this.lbRackTitles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbRackTitles_DrawItem);
            this.lbRackTitles.SelectedValueChanged += new System.EventHandler(this.lbRackTitles_SelectedValueChanged);
            // 
            // pnlRacks
            // 
            this.pnlRacks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRacks.Location = new System.Drawing.Point(0, 0);
            this.pnlRacks.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRacks.Name = "pnlRacks";
            this.pnlRacks.Size = new System.Drawing.Size(284, 470);
            this.pnlRacks.TabIndex = 0;
            this.pnlRacks.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRacks_Paint);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnd.Image = global::M64MMOrkestrator.Properties.Resources.end;
            this.btnEnd.Location = new System.Drawing.Point(184, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(30, 30);
            this.btnEnd.TabIndex = 9;
            this.ttButtonInfo.SetToolTip(this.btnEnd, "Jump to End");
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Image = global::M64MMOrkestrator.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(76, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 9;
            this.ttButtonInfo.SetToolTip(this.btnPlay, "Play/Pause");
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdvance.Image = ((System.Drawing.Image)(resources.GetObject("btnAdvance.Image")));
            this.btnAdvance.Location = new System.Drawing.Point(148, 2);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(30, 30);
            this.btnAdvance.TabIndex = 8;
            this.ttButtonInfo.SetToolTip(this.btnAdvance, "Advance Frame");
            this.btnAdvance.UseVisualStyleBackColor = true;
            // 
            // btnStepback
            // 
            this.btnStepback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStepback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStepback.Image = ((System.Drawing.Image)(resources.GetObject("btnStepback.Image")));
            this.btnStepback.Location = new System.Drawing.Point(40, 2);
            this.btnStepback.Name = "btnStepback";
            this.btnStepback.Size = new System.Drawing.Size(30, 30);
            this.btnStepback.TabIndex = 8;
            this.ttButtonInfo.SetToolTip(this.btnStepback, "Stepback Frame");
            this.btnStepback.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Image = global::M64MMOrkestrator.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(112, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 7;
            this.ttButtonInfo.SetToolTip(this.btnStop, "Stop");
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Image = global::M64MMOrkestrator.Properties.Resources.begin;
            this.btnStart.Location = new System.Drawing.Point(4, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 30);
            this.btnStart.TabIndex = 7;
            this.ttButtonInfo.SetToolTip(this.btnStart, "Jump to Start");
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSandwichOpts
            // 
            this.btnSandwichOpts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSandwichOpts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSandwichOpts.Image = global::M64MMOrkestrator.Properties.Resources.sandwich;
            this.btnSandwichOpts.Location = new System.Drawing.Point(507, 3);
            this.btnSandwichOpts.Name = "btnSandwichOpts";
            this.btnSandwichOpts.Size = new System.Drawing.Size(30, 30);
            this.btnSandwichOpts.TabIndex = 6;
            this.ttButtonInfo.SetToolTip(this.btnSandwichOpts, "Keyframe Options");
            this.btnSandwichOpts.UseVisualStyleBackColor = true;
            this.btnSandwichOpts.Click += new System.EventHandler(this.btnSandwichOpts_Click);
            // 
            // btnNudgeR
            // 
            this.btnNudgeR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNudgeR.Image = global::M64MMOrkestrator.Properties.Resources.nudgeKfRight;
            this.btnNudgeR.Location = new System.Drawing.Point(687, 3);
            this.btnNudgeR.Name = "btnNudgeR";
            this.btnNudgeR.Size = new System.Drawing.Size(30, 30);
            this.btnNudgeR.TabIndex = 5;
            this.btnNudgeR.Text = " ";
            this.ttButtonInfo.SetToolTip(this.btnNudgeR, "Move selected keyframes one frame forward");
            this.btnNudgeR.UseVisualStyleBackColor = true;
            this.btnNudgeR.Click += new System.EventHandler(this.btnNudgeR_Click);
            // 
            // btnNudgeL
            // 
            this.btnNudgeL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNudgeL.Image = global::M64MMOrkestrator.Properties.Resources.nudgeKfLeft;
            this.btnNudgeL.Location = new System.Drawing.Point(651, 3);
            this.btnNudgeL.Name = "btnNudgeL";
            this.btnNudgeL.Size = new System.Drawing.Size(30, 30);
            this.btnNudgeL.TabIndex = 4;
            this.btnNudgeL.Text = " ";
            this.ttButtonInfo.SetToolTip(this.btnNudgeL, "Move selected keyframes one frame back");
            this.btnNudgeL.UseVisualStyleBackColor = true;
            this.btnNudgeL.Click += new System.EventHandler(this.btnNudgeL_Click);
            // 
            // btnSelectKf
            // 
            this.btnSelectKf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectKf.Image = global::M64MMOrkestrator.Properties.Resources.selectKeyframes;
            this.btnSelectKf.Location = new System.Drawing.Point(543, 3);
            this.btnSelectKf.Name = "btnSelectKf";
            this.btnSelectKf.Size = new System.Drawing.Size(30, 30);
            this.btnSelectKf.TabIndex = 3;
            this.btnSelectKf.Text = " ";
            this.ttButtonInfo.SetToolTip(this.btnSelectKf, "Select Keyframes under trackhead");
            this.btnSelectKf.UseVisualStyleBackColor = true;
            this.btnSelectKf.Click += new System.EventHandler(this.btnSelectKf_Click);
            // 
            // btnRemoveKf
            // 
            this.btnRemoveKf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveKf.Image = global::M64MMOrkestrator.Properties.Resources.deleteKf;
            this.btnRemoveKf.Location = new System.Drawing.Point(615, 3);
            this.btnRemoveKf.Name = "btnRemoveKf";
            this.btnRemoveKf.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveKf.TabIndex = 2;
            this.btnRemoveKf.Text = " ";
            this.ttButtonInfo.SetToolTip(this.btnRemoveKf, "Remove Keyframes\r\n\r\n(Removes selected, if none selected, those in active racks un" +
        "der the track head.)");
            this.btnRemoveKf.UseVisualStyleBackColor = true;
            this.btnRemoveKf.Click += new System.EventHandler(this.btnRemoveKf_Click);
            // 
            // btnAddKf
            // 
            this.btnAddKf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKf.Image = global::M64MMOrkestrator.Properties.Resources.addKf;
            this.btnAddKf.Location = new System.Drawing.Point(579, 3);
            this.btnAddKf.Name = "btnAddKf";
            this.btnAddKf.Size = new System.Drawing.Size(30, 30);
            this.btnAddKf.TabIndex = 1;
            this.ttButtonInfo.SetToolTip(this.btnAddKf, "Add Keyframes from Current Values");
            this.btnAddKf.UseVisualStyleBackColor = true;
            this.btnAddKf.Click += new System.EventHandler(this.btnAddKf_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoom.AutoSize = false;
            this.tbZoom.Location = new System.Drawing.Point(723, 6);
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(169, 27);
            this.tbZoom.TabIndex = 0;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // cmsKeyframeSettings
            // 
            this.cmsKeyframeSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInterpolation,
            this.toolStripSeparator2,
            this.tsmDiscardCommits});
            this.cmsKeyframeSettings.Name = "cmsKeyframeSettings";
            this.cmsKeyframeSettings.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsKeyframeSettings.Size = new System.Drawing.Size(208, 76);
            // 
            // miInterpolation
            // 
            this.miInterpolation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLinear,
            this.tsmFast,
            this.tsmSlow,
            this.tsmSmooth,
            this.tsmSharp,
            this.tsmHold,
            this.toolStripSeparator1,
            this.tsmBezier});
            this.miInterpolation.Name = "miInterpolation";
            this.miInterpolation.Size = new System.Drawing.Size(207, 22);
            this.miInterpolation.Text = "Keyframe interpolation...";
            // 
            // tsmLinear
            // 
            this.tsmLinear.Name = "tsmLinear";
            this.tsmLinear.Size = new System.Drawing.Size(116, 22);
            this.tsmLinear.Text = "Linear";
            // 
            // tsmFast
            // 
            this.tsmFast.Name = "tsmFast";
            this.tsmFast.Size = new System.Drawing.Size(116, 22);
            this.tsmFast.Text = "Fast";
            // 
            // tsmSlow
            // 
            this.tsmSlow.Name = "tsmSlow";
            this.tsmSlow.Size = new System.Drawing.Size(116, 22);
            this.tsmSlow.Text = "Slow";
            // 
            // tsmSmooth
            // 
            this.tsmSmooth.Name = "tsmSmooth";
            this.tsmSmooth.Size = new System.Drawing.Size(116, 22);
            this.tsmSmooth.Text = "Smooth";
            // 
            // tsmSharp
            // 
            this.tsmSharp.Name = "tsmSharp";
            this.tsmSharp.Size = new System.Drawing.Size(116, 22);
            this.tsmSharp.Text = "Sharp";
            // 
            // tsmHold
            // 
            this.tsmHold.Name = "tsmHold";
            this.tsmHold.Size = new System.Drawing.Size(116, 22);
            this.tsmHold.Text = "Hold";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // tsmBezier
            // 
            this.tsmBezier.Name = "tsmBezier";
            this.tsmBezier.Size = new System.Drawing.Size(116, 22);
            this.tsmBezier.Text = "Bezier...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmDiscardCommits
            // 
            this.tsmDiscardCommits.Name = "tsmDiscardCommits";
            this.tsmDiscardCommits.Size = new System.Drawing.Size(207, 22);
            this.tsmDiscardCommits.Text = "Discard pending changes";
            // 
            // TimelineRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scControls);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(420, 128);
            this.Name = "TimelineRenderer";
            this.Size = new System.Drawing.Size(971, 523);
            this.scControls.Panel1.ResumeLayout(false);
            this.scControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scControls)).EndInit();
            this.scControls.ResumeLayout(false);
            this.scTimelineSplit.Panel1.ResumeLayout(false);
            this.scTimelineSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTimelineSplit)).EndInit();
            this.scTimelineSplit.ResumeLayout(false);
            this.scRackTitles.Panel1.ResumeLayout(false);
            this.scRackTitles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRackTitles)).EndInit();
            this.scRackTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.cmsKeyframeSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scControls;
        private System.Windows.Forms.SplitContainer scTimelineSplit;
        private System.Windows.Forms.SplitContainer scRackTitles;
        private System.Windows.Forms.Label lbTimecode;
        private System.Windows.Forms.ListBox lbRackTitles;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.Panel pnlRacks;
        private System.Windows.Forms.Button btnNudgeR;
        private System.Windows.Forms.Button btnNudgeL;
        private System.Windows.Forms.Button btnSelectKf;
        private System.Windows.Forms.Button btnRemoveKf;
        private System.Windows.Forms.Button btnAddKf;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ToolTip ttButtonInfo;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnStepback;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSandwichOpts;
        private System.Windows.Forms.ContextMenuStrip cmsKeyframeSettings;
        private System.Windows.Forms.ToolStripMenuItem miInterpolation;
        private System.Windows.Forms.ToolStripMenuItem tsmLinear;
        private System.Windows.Forms.ToolStripMenuItem tsmFast;
        private System.Windows.Forms.ToolStripMenuItem tsmSlow;
        private System.Windows.Forms.ToolStripMenuItem tsmSmooth;
        private System.Windows.Forms.ToolStripMenuItem tsmSharp;
        private System.Windows.Forms.ToolStripMenuItem tsmHold;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmBezier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmDiscardCommits;
    }
}
