
namespace M64MMOrkestrator
{
    partial class FrmNazOops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNazOops));
            this.label1 = new System.Windows.Forms.Label();
            this.pbNaz = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlright = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porynaz II";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbNaz
            // 
            this.pbNaz.Image = global::M64MMOrkestrator.Properties.Resources.nazoops;
            this.pbNaz.Location = new System.Drawing.Point(12, 12);
            this.pbNaz.Name = "pbNaz";
            this.pbNaz.Size = new System.Drawing.Size(200, 200);
            this.pbNaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNaz.TabIndex = 0;
            this.pbNaz.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 208);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnAlright
            // 
            this.btnAlright.Location = new System.Drawing.Point(659, 233);
            this.btnAlright.Name = "btnAlright";
            this.btnAlright.Size = new System.Drawing.Size(75, 23);
            this.btnAlright.TabIndex = 3;
            this.btnAlright.Text = "Alright";
            this.btnAlright.UseVisualStyleBackColor = true;
            this.btnAlright.Click += new System.EventHandler(this.btnAlright_Click);
            // 
            // FrmNazOops
            // 
            this.AcceptButton = this.btnAlright;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 265);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlright);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNaz);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNazOops";
            this.Text = "Why can\'t I save or use the Timeline with the mouse?";
            ((System.ComponentModel.ISupportInitialize)(this.pbNaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlright;
    }
}