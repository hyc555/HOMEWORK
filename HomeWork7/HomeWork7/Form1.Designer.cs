
namespace HomeWork7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PenColor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LeftAngle = new System.Windows.Forms.TextBox();
            this.RightAngle = new System.Windows.Forms.TextBox();
            this.LeftLength = new System.Windows.Forms.TextBox();
            this.MainLength = new System.Windows.Forms.TextBox();
            this.RightLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PenColor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.LeftAngle);
            this.panel1.Controls.Add(this.RightAngle);
            this.panel1.Controls.Add(this.LeftLength);
            this.panel1.Controls.Add(this.MainLength);
            this.panel1.Controls.Add(this.RightLength);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(538, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.Items.AddRange(new object[] {
            "黑色",
            "蓝色",
            "红色",
            "绿色",
            "黄色",
            "橙色"});
            this.PenColor.Location = new System.Drawing.Point(117, 290);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(125, 28);
            this.PenColor.TabIndex = 15;
            this.PenColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 27);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LeftAngle
            // 
            this.LeftAngle.Location = new System.Drawing.Point(117, 245);
            this.LeftAngle.Name = "LeftAngle";
            this.LeftAngle.Size = new System.Drawing.Size(125, 27);
            this.LeftAngle.TabIndex = 13;
            this.LeftAngle.Text = "20";
            this.LeftAngle.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // RightAngle
            // 
            this.RightAngle.Location = new System.Drawing.Point(117, 197);
            this.RightAngle.Name = "RightAngle";
            this.RightAngle.Size = new System.Drawing.Size(125, 27);
            this.RightAngle.TabIndex = 12;
            this.RightAngle.Text = "30";
            this.RightAngle.TextChanged += new System.EventHandler(this.RightAngle_TextChanged);
            // 
            // LeftLength
            // 
            this.LeftLength.Location = new System.Drawing.Point(117, 150);
            this.LeftLength.Name = "LeftLength";
            this.LeftLength.Size = new System.Drawing.Size(125, 27);
            this.LeftLength.TabIndex = 11;
            this.LeftLength.Text = "0.7";
            this.LeftLength.TextChanged += new System.EventHandler(this.LeftLength_TextChanged);
            // 
            // MainLength
            // 
            this.MainLength.Location = new System.Drawing.Point(117, 57);
            this.MainLength.Name = "MainLength";
            this.MainLength.Size = new System.Drawing.Size(125, 27);
            this.MainLength.TabIndex = 10;
            this.MainLength.Text = "100";
            this.MainLength.TextChanged += new System.EventHandler(this.MainLength_TextChanged);
            // 
            // RightLength
            // 
            this.RightLength.Location = new System.Drawing.Point(117, 104);
            this.RightLength.Name = "RightLength";
            this.RightLength.Size = new System.Drawing.Size(125, 27);
            this.RightLength.TabIndex = 9;
            this.RightLength.Text = "0.6";
            this.RightLength.TextChanged += new System.EventHandler(this.RightLength_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "画笔颜色";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "右长度分支比";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "左分支角度";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "右分支角度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "左长度分支比";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RightAngle;
        private System.Windows.Forms.TextBox LeftLength;
        private System.Windows.Forms.TextBox MainLength;
        private System.Windows.Forms.TextBox RightLength;
        private System.Windows.Forms.TextBox LeftAngle;
        private System.Windows.Forms.ComboBox PenColor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

