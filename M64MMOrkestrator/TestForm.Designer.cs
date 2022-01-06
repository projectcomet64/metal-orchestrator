
namespace M64MMOrkestrator
{
    partial class TestForm
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
            this.btnEnsemble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCamMode = new System.Windows.Forms.NumericUpDown();
            this.lbCamInfo = new System.Windows.Forms.Label();
            this.lbMarioInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbChangeFocus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudChenji = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFocusMario = new System.Windows.Forms.CheckBox();
            this.cbLookAtMario = new System.Windows.Forms.CheckBox();
            this.cbAngleMode = new System.Windows.Forms.CheckBox();
            this.cbTwister = new System.Windows.Forms.CheckBox();
            this.nudDegPerFrame = new System.Windows.Forms.NumericUpDown();
            this.nudEllipsisSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTestBezier = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.nudChangleX = new System.Windows.Forms.NumericUpDown();
            this.nudChangleY = new System.Windows.Forms.NumericUpDown();
            this.tbChangeAngleMan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChenji)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDegPerFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEllipsisSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangleY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnsemble
            // 
            this.btnEnsemble.Location = new System.Drawing.Point(12, 12);
            this.btnEnsemble.Name = "btnEnsemble";
            this.btnEnsemble.Size = new System.Drawing.Size(75, 23);
            this.btnEnsemble.TabIndex = 0;
            this.btnEnsemble.Text = "ensemble";
            this.btnEnsemble.UseVisualStyleBackColor = true;
            this.btnEnsemble.Click += new System.EventHandler(this.btnEnsemble_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cam mode";
            // 
            // nudCamMode
            // 
            this.nudCamMode.Location = new System.Drawing.Point(235, 15);
            this.nudCamMode.Name = "nudCamMode";
            this.nudCamMode.Size = new System.Drawing.Size(59, 20);
            this.nudCamMode.TabIndex = 2;
            // 
            // lbCamInfo
            // 
            this.lbCamInfo.Location = new System.Drawing.Point(9, 53);
            this.lbCamInfo.Name = "lbCamInfo";
            this.lbCamInfo.Size = new System.Drawing.Size(148, 132);
            this.lbCamInfo.TabIndex = 3;
            this.lbCamInfo.Text = "camerainfo";
            // 
            // lbMarioInfo
            // 
            this.lbMarioInfo.Location = new System.Drawing.Point(173, 53);
            this.lbMarioInfo.Name = "lbMarioInfo";
            this.lbMarioInfo.Size = new System.Drawing.Size(164, 132);
            this.lbMarioInfo.TabIndex = 3;
            this.lbMarioInfo.Text = "marioposinfo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "+y";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "-y";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "+x";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "-x";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(208, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "+z";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(208, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 46);
            this.button6.TabIndex = 4;
            this.button6.Text = "-z";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tbChangeFocus
            // 
            this.tbChangeFocus.AutoSize = true;
            this.tbChangeFocus.Location = new System.Drawing.Point(353, 46);
            this.tbChangeFocus.Name = "tbChangeFocus";
            this.tbChangeFocus.Size = new System.Drawing.Size(99, 17);
            this.tbChangeFocus.TabIndex = 5;
            this.tbChangeFocus.Text = "changing focus";
            this.tbChangeFocus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "(if not, changing pos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "by";
            // 
            // nudChenji
            // 
            this.nudChenji.Location = new System.Drawing.Point(374, 115);
            this.nudChenji.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudChenji.Name = "nudChenji";
            this.nudChenji.Size = new System.Drawing.Size(120, 20);
            this.nudChenji.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.nudChenji);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tbChangeFocus);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbFocusMario
            // 
            this.cbFocusMario.AutoSize = true;
            this.cbFocusMario.Location = new System.Drawing.Point(12, 236);
            this.cbFocusMario.Name = "cbFocusMario";
            this.cbFocusMario.Size = new System.Drawing.Size(95, 17);
            this.cbFocusMario.TabIndex = 10;
            this.cbFocusMario.Text = "focus on mario";
            this.cbFocusMario.UseVisualStyleBackColor = true;
            this.cbFocusMario.CheckedChanged += new System.EventHandler(this.cbFocusMario_CheckedChanged);
            // 
            // cbLookAtMario
            // 
            this.cbLookAtMario.AutoSize = true;
            this.cbLookAtMario.Location = new System.Drawing.Point(12, 213);
            this.cbLookAtMario.Name = "cbLookAtMario";
            this.cbLookAtMario.Size = new System.Drawing.Size(86, 17);
            this.cbLookAtMario.TabIndex = 10;
            this.cbLookAtMario.Text = "look at mario";
            this.cbLookAtMario.UseVisualStyleBackColor = true;
            this.cbLookAtMario.CheckedChanged += new System.EventHandler(this.cbLookAtMario_CheckedChanged);
            // 
            // cbAngleMode
            // 
            this.cbAngleMode.AutoSize = true;
            this.cbAngleMode.Location = new System.Drawing.Point(113, 236);
            this.cbAngleMode.Name = "cbAngleMode";
            this.cbAngleMode.Size = new System.Drawing.Size(87, 17);
            this.cbAngleMode.TabIndex = 10;
            this.cbAngleMode.Text = "angled mode";
            this.cbAngleMode.UseVisualStyleBackColor = true;
            this.cbAngleMode.CheckedChanged += new System.EventHandler(this.cbAngleMode_CheckedChanged);
            // 
            // cbTwister
            // 
            this.cbTwister.AutoSize = true;
            this.cbTwister.Location = new System.Drawing.Point(343, 52);
            this.cbTwister.Name = "cbTwister";
            this.cbTwister.Size = new System.Drawing.Size(85, 17);
            this.cbTwister.TabIndex = 10;
            this.cbTwister.Text = "twister mode";
            this.cbTwister.UseVisualStyleBackColor = true;
            // 
            // nudDegPerFrame
            // 
            this.nudDegPerFrame.DecimalPlaces = 1;
            this.nudDegPerFrame.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDegPerFrame.Location = new System.Drawing.Point(343, 109);
            this.nudDegPerFrame.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDegPerFrame.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudDegPerFrame.Name = "nudDegPerFrame";
            this.nudDegPerFrame.Size = new System.Drawing.Size(120, 20);
            this.nudDegPerFrame.TabIndex = 8;
            // 
            // nudEllipsisSize
            // 
            this.nudEllipsisSize.DecimalPlaces = 1;
            this.nudEllipsisSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudEllipsisSize.Location = new System.Drawing.Point(343, 135);
            this.nudEllipsisSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudEllipsisSize.Name = "nudEllipsisSize";
            this.nudEllipsisSize.Size = new System.Drawing.Size(120, 20);
            this.nudEllipsisSize.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "degrees/frame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "circle size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "angle (+Y)";
            // 
            // btnTestBezier
            // 
            this.btnTestBezier.Location = new System.Drawing.Point(328, 12);
            this.btnTestBezier.Name = "btnTestBezier";
            this.btnTestBezier.Size = new System.Drawing.Size(75, 23);
            this.btnTestBezier.TabIndex = 13;
            this.btnTestBezier.Text = "test bezier";
            this.btnTestBezier.UseVisualStyleBackColor = true;
            this.btnTestBezier.Click += new System.EventHandler(this.btnTestBezier_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(409, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "timeline";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nudChangleX
            // 
            this.nudChangleX.DecimalPlaces = 1;
            this.nudChangleX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudChangleX.Location = new System.Drawing.Point(343, 225);
            this.nudChangleX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudChangleX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudChangleX.Name = "nudChangleX";
            this.nudChangleX.Size = new System.Drawing.Size(120, 20);
            this.nudChangleX.TabIndex = 8;
            // 
            // nudChangleY
            // 
            this.nudChangleY.DecimalPlaces = 1;
            this.nudChangleY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudChangleY.Location = new System.Drawing.Point(343, 251);
            this.nudChangleY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudChangleY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudChangleY.Name = "nudChangleY";
            this.nudChangleY.Size = new System.Drawing.Size(120, 20);
            this.nudChangleY.TabIndex = 8;
            // 
            // tbChangeAngleMan
            // 
            this.tbChangeAngleMan.AutoSize = true;
            this.tbChangeAngleMan.Location = new System.Drawing.Point(343, 168);
            this.tbChangeAngleMan.Name = "tbChangeAngleMan";
            this.tbChangeAngleMan.Size = new System.Drawing.Size(108, 17);
            this.tbChangeAngleMan.TabIndex = 10;
            this.tbChangeAngleMan.Text = "changle manually";
            this.tbChangeAngleMan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "angle (+Y)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Y";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 500);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnTestBezier);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbChangeAngleMan);
            this.Controls.Add(this.nudChangleY);
            this.Controls.Add(this.cbTwister);
            this.Controls.Add(this.nudChangleX);
            this.Controls.Add(this.nudEllipsisSize);
            this.Controls.Add(this.nudDegPerFrame);
            this.Controls.Add(this.cbAngleMode);
            this.Controls.Add(this.cbLookAtMario);
            this.Controls.Add(this.cbFocusMario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMarioInfo);
            this.Controls.Add(this.lbCamInfo);
            this.Controls.Add(this.nudCamMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnsemble);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCamMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChenji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDegPerFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEllipsisSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangleY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnsemble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCamMode;
        private System.Windows.Forms.Label lbCamInfo;
        private System.Windows.Forms.Label lbMarioInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox tbChangeFocus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudChenji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFocusMario;
        private System.Windows.Forms.CheckBox cbLookAtMario;
        private System.Windows.Forms.CheckBox cbAngleMode;
        private System.Windows.Forms.CheckBox cbTwister;
        private System.Windows.Forms.NumericUpDown nudDegPerFrame;
        private System.Windows.Forms.NumericUpDown nudEllipsisSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTestBezier;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown nudChangleX;
        private System.Windows.Forms.NumericUpDown nudChangleY;
        private System.Windows.Forms.CheckBox tbChangeAngleMan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}