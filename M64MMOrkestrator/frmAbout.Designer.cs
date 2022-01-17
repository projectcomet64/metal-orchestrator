
namespace M64MMOrkestrator
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComet = new System.Windows.Forms.Button();
            this.btnGh = new System.Windows.Forms.Button();
            this.btnPatreon = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::M64MMOrkestrator.Properties.Resources.orchestrator_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "METAL Orchestrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codename KI-O -- For M64MM3 Beta 1 // by GlitchyPSI @ Project Comet\r\n";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(220, 64);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(102, 13);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "Version: Thy Mother";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 209);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnComet
            // 
            this.btnComet.Location = new System.Drawing.Point(12, 218);
            this.btnComet.Name = "btnComet";
            this.btnComet.Size = new System.Drawing.Size(200, 23);
            this.btnComet.TabIndex = 5;
            this.btnComet.Text = "More Project Comet stuff";
            this.btnComet.UseVisualStyleBackColor = true;
            // 
            // btnGh
            // 
            this.btnGh.Location = new System.Drawing.Point(12, 276);
            this.btnGh.Name = "btnGh";
            this.btnGh.Size = new System.Drawing.Size(200, 23);
            this.btnGh.TabIndex = 6;
            this.btnGh.Text = "Orchestrator Github";
            this.btnGh.UseVisualStyleBackColor = true;
            // 
            // btnPatreon
            // 
            this.btnPatreon.Location = new System.Drawing.Point(12, 305);
            this.btnPatreon.Name = "btnPatreon";
            this.btnPatreon.Size = new System.Drawing.Size(200, 23);
            this.btnPatreon.TabIndex = 7;
            this.btnPatreon.Text = "Patreon";
            this.btnPatreon.UseVisualStyleBackColor = true;
            // 
            // btnYoutube
            // 
            this.btnYoutube.Location = new System.Drawing.Point(12, 334);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(200, 23);
            this.btnYoutube.TabIndex = 8;
            this.btnYoutube.Text = "Youtube";
            this.btnYoutube.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Report bugs in Github!)";
            // 
            // btnDiscord
            // 
            this.btnDiscord.Location = new System.Drawing.Point(12, 247);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(200, 23);
            this.btnDiscord.TabIndex = 10;
            this.btnDiscord.Text = "Project Comet Discord";
            this.btnDiscord.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(656, 329);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 364);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.btnPatreon);
            this.Controls.Add(this.btnGh);
            this.Controls.Add(this.btnComet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Text = "About KI-O...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComet;
        private System.Windows.Forms.Button btnGh;
        private System.Windows.Forms.Button btnPatreon;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnOK;
    }
}