
namespace M64MMOrkestrator
{
    partial class frmTimelineB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimelineB));
            this.lbTlPosition = new System.Windows.Forms.ListBox();
            this.lbTlRotation = new System.Windows.Forms.ListBox();
            this.lbTlFrame = new System.Windows.Forms.Label();
            this.lbTbSynchro = new System.Windows.Forms.Label();
            this.btnFrameback = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnPlaypause = new System.Windows.Forms.Button();
            this.btnAddKf = new System.Windows.Forms.Button();
            this.btnRemKf = new System.Windows.Forms.Button();
            this.lbTimelineMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTlZero = new System.Windows.Forms.Button();
            this.pnlTimeline = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lbTimelineMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTlPosition
            // 
            this.lbTlPosition.FormattingEnabled = true;
            this.lbTlPosition.Location = new System.Drawing.Point(12, 69);
            this.lbTlPosition.Name = "lbTlPosition";
            this.lbTlPosition.Size = new System.Drawing.Size(151, 238);
            this.lbTlPosition.TabIndex = 0;
            // 
            // lbTlRotation
            // 
            this.lbTlRotation.FormattingEnabled = true;
            this.lbTlRotation.Location = new System.Drawing.Point(169, 69);
            this.lbTlRotation.Name = "lbTlRotation";
            this.lbTlRotation.Size = new System.Drawing.Size(151, 238);
            this.lbTlRotation.TabIndex = 1;
            // 
            // lbTlFrame
            // 
            this.lbTlFrame.AutoSize = true;
            this.lbTlFrame.Location = new System.Drawing.Point(326, 80);
            this.lbTlFrame.Name = "lbTlFrame";
            this.lbTlFrame.Size = new System.Drawing.Size(93, 13);
            this.lbTlFrame.TabIndex = 2;
            this.lbTlFrame.Text = "Timeline frame: ??";
            // 
            // lbTbSynchro
            // 
            this.lbTbSynchro.AutoSize = true;
            this.lbTbSynchro.Location = new System.Drawing.Point(326, 106);
            this.lbTbSynchro.Name = "lbTbSynchro";
            this.lbTbSynchro.Size = new System.Drawing.Size(71, 13);
            this.lbTbSynchro.TabIndex = 3;
            this.lbTbSynchro.Text = "Synchronized";
            // 
            // btnFrameback
            // 
            this.btnFrameback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFrameback.Location = new System.Drawing.Point(367, 131);
            this.btnFrameback.Name = "btnFrameback";
            this.btnFrameback.Size = new System.Drawing.Size(32, 32);
            this.btnFrameback.TabIndex = 5;
            this.btnFrameback.Text = "<";
            this.btnFrameback.UseVisualStyleBackColor = true;
            this.btnFrameback.Click += new System.EventHandler(this.btnFrameback_Click);
            // 
            // btnSync
            // 
            this.btnSync.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSync.BackgroundImage")));
            this.btnSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSync.Location = new System.Drawing.Point(326, 275);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(32, 32);
            this.btnSync.TabIndex = 4;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.Location = new System.Drawing.Point(441, 131);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(32, 32);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnPlaypause
            // 
            this.btnPlaypause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaypause.Location = new System.Drawing.Point(403, 131);
            this.btnPlaypause.Name = "btnPlaypause";
            this.btnPlaypause.Size = new System.Drawing.Size(32, 32);
            this.btnPlaypause.TabIndex = 7;
            this.btnPlaypause.Text = "Pp";
            this.btnPlaypause.UseVisualStyleBackColor = true;
            this.btnPlaypause.Click += new System.EventHandler(this.btnPlaypause_Click);
            // 
            // btnAddKf
            // 
            this.btnAddKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKf.Location = new System.Drawing.Point(329, 169);
            this.btnAddKf.Name = "btnAddKf";
            this.btnAddKf.Size = new System.Drawing.Size(32, 32);
            this.btnAddKf.TabIndex = 8;
            this.btnAddKf.Text = "+";
            this.btnAddKf.UseVisualStyleBackColor = true;
            this.btnAddKf.Click += new System.EventHandler(this.btnAddKf_Click);
            // 
            // btnRemKf
            // 
            this.btnRemKf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemKf.Location = new System.Drawing.Point(329, 207);
            this.btnRemKf.Name = "btnRemKf";
            this.btnRemKf.Size = new System.Drawing.Size(108, 32);
            this.btnRemKf.TabIndex = 9;
            this.btnRemKf.Text = "- (selected from list)";
            this.btnRemKf.UseVisualStyleBackColor = true;
            this.btnRemKf.Click += new System.EventHandler(this.btnRemKf_Click);
            // 
            // lbTimelineMax
            // 
            this.lbTimelineMax.Location = new System.Drawing.Point(329, 46);
            this.lbTimelineMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lbTimelineMax.Name = "lbTimelineMax";
            this.lbTimelineMax.Size = new System.Drawing.Size(120, 20);
            this.lbTimelineMax.TabIndex = 10;
            this.lbTimelineMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lbTimelineMax.ValueChanged += new System.EventHandler(this.lbTimelineMax_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Maximum preferred for Timeline";
            // 
            // btnTlZero
            // 
            this.btnTlZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTlZero.Location = new System.Drawing.Point(329, 131);
            this.btnTlZero.Name = "btnTlZero";
            this.btnTlZero.Size = new System.Drawing.Size(32, 32);
            this.btnTlZero.TabIndex = 12;
            this.btnTlZero.Text = "0";
            this.btnTlZero.UseVisualStyleBackColor = true;
            this.btnTlZero.Click += new System.EventHandler(this.btnTlZero_Click);
            // 
            // pnlTimeline
            // 
            this.pnlTimeline.Location = new System.Drawing.Point(12, 313);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(1009, 243);
            this.pnlTimeline.TabIndex = 13;
            // 
            // frmTimelineB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 568);
            this.Controls.Add(this.pnlTimeline);
            this.Controls.Add(this.btnTlZero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimelineMax);
            this.Controls.Add(this.btnRemKf);
            this.Controls.Add(this.btnAddKf);
            this.Controls.Add(this.btnPlaypause);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnFrameback);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.lbTbSynchro);
            this.Controls.Add(this.lbTlFrame);
            this.Controls.Add(this.lbTlRotation);
            this.Controls.Add(this.lbTlPosition);
            this.Name = "frmTimelineB";
            this.Text = "frmTimelineB";
            ((System.ComponentModel.ISupportInitialize)(this.lbTimelineMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTlPosition;
        private System.Windows.Forms.ListBox lbTlRotation;
        private System.Windows.Forms.Label lbTlFrame;
        private System.Windows.Forms.Label lbTbSynchro;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnFrameback;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPlaypause;
        private System.Windows.Forms.Button btnAddKf;
        private System.Windows.Forms.Button btnRemKf;
        private System.Windows.Forms.NumericUpDown lbTimelineMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTlZero;
        private System.Windows.Forms.Panel pnlTimeline;
    }
}