
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineRenderer));
            this.scControls = new System.Windows.Forms.SplitContainer();
            this.scTimelineSplit = new System.Windows.Forms.SplitContainer();
            this.scRackTitles = new System.Windows.Forms.SplitContainer();
            this.lbTimecode = new System.Windows.Forms.Label();
            this.lbRackTitles = new System.Windows.Forms.ListBox();
            this.pnlRacks = new System.Windows.Forms.Panel();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.btnNudgeR = new System.Windows.Forms.Button();
            this.btnNudgeL = new System.Windows.Forms.Button();
            this.btnSelectKf = new System.Windows.Forms.Button();
            this.btnRemoveKf = new System.Windows.Forms.Button();
            this.btnAddKf = new System.Windows.Forms.Button();
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
            this.scControls.Panel2.Controls.Add(this.btnNudgeR);
            this.scControls.Panel2.Controls.Add(this.btnNudgeL);
            this.scControls.Panel2.Controls.Add(this.btnSelectKf);
            this.scControls.Panel2.Controls.Add(this.btnRemoveKf);
            this.scControls.Panel2.Controls.Add(this.btnAddKf);
            this.scControls.Panel2.Controls.Add(this.tbZoom);
            this.scControls.Panel2MinSize = 32;
            this.scControls.Size = new System.Drawing.Size(971, 523);
            this.scControls.SplitterDistance = 484;
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
            this.scTimelineSplit.Size = new System.Drawing.Size(971, 484);
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
            this.scRackTitles.Size = new System.Drawing.Size(198, 482);
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
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoom.AutoSize = false;
            this.tbZoom.Location = new System.Drawing.Point(808, 17);
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(160, 24);
            this.tbZoom.TabIndex = 0;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // btnNudgeR
            // 
            this.btnNudgeR.Image = global::M64MMOrkestrator.Properties.Resources.nudgeKfRight;
            this.btnNudgeR.Location = new System.Drawing.Point(147, 5);
            this.btnNudgeR.Name = "btnNudgeR";
            this.btnNudgeR.Size = new System.Drawing.Size(30, 30);
            this.btnNudgeR.TabIndex = 5;
            this.btnNudgeR.Text = " ";
            this.btnNudgeR.UseVisualStyleBackColor = true;
            this.btnNudgeR.Click += new System.EventHandler(this.btnNudgeR_Click);
            // 
            // btnNudgeL
            // 
            this.btnNudgeL.Image = global::M64MMOrkestrator.Properties.Resources.nudgeKfLeft;
            this.btnNudgeL.Location = new System.Drawing.Point(111, 5);
            this.btnNudgeL.Name = "btnNudgeL";
            this.btnNudgeL.Size = new System.Drawing.Size(30, 30);
            this.btnNudgeL.TabIndex = 4;
            this.btnNudgeL.Text = " ";
            this.btnNudgeL.UseVisualStyleBackColor = true;
            this.btnNudgeL.Click += new System.EventHandler(this.btnNudgeL_Click);
            // 
            // btnSelectKf
            // 
            this.btnSelectKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectKf.Image = global::M64MMOrkestrator.Properties.Resources.selectKeyframes;
            this.btnSelectKf.Location = new System.Drawing.Point(75, 5);
            this.btnSelectKf.Name = "btnSelectKf";
            this.btnSelectKf.Size = new System.Drawing.Size(30, 30);
            this.btnSelectKf.TabIndex = 3;
            this.btnSelectKf.Text = " ";
            this.btnSelectKf.UseVisualStyleBackColor = true;
            this.btnSelectKf.Click += new System.EventHandler(this.btnSelectKf_Click);
            // 
            // btnRemoveKf
            // 
            this.btnRemoveKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveKf.Image = global::M64MMOrkestrator.Properties.Resources.deleteKf;
            this.btnRemoveKf.Location = new System.Drawing.Point(39, 5);
            this.btnRemoveKf.Name = "btnRemoveKf";
            this.btnRemoveKf.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveKf.TabIndex = 2;
            this.btnRemoveKf.Text = " ";
            this.btnRemoveKf.UseVisualStyleBackColor = true;
            // 
            // btnAddKf
            // 
            this.btnAddKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKf.Image = global::M64MMOrkestrator.Properties.Resources.addKf;
            this.btnAddKf.Location = new System.Drawing.Point(3, 5);
            this.btnAddKf.Name = "btnAddKf";
            this.btnAddKf.Size = new System.Drawing.Size(30, 30);
            this.btnAddKf.TabIndex = 1;
            this.btnAddKf.UseVisualStyleBackColor = true;
            this.btnAddKf.Click += new System.EventHandler(this.btnAddKf_Click);
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
    }
}
