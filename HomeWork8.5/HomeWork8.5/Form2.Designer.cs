
namespace HomeWork8._5
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_OrderNum = new System.Windows.Forms.TextBox();
            this.textBox_client = new System.Windows.Forms.TextBox();
            this.lab_ordernum = new System.Windows.Forms.Label();
            this.lab_Cilent = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_addDetail = new System.Windows.Forms.Button();
            this.btn_addGoods = new System.Windows.Forms.Button();
            this.textBox_Goods = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_number);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.btn_addDetail);
            this.panel1.Controls.Add(this.textBox_Goods);
            this.panel1.Controls.Add(this.btn_addGoods);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.lab_Cilent);
            this.panel1.Controls.Add(this.lab_ordernum);
            this.panel1.Controls.Add(this.textBox_client);
            this.panel1.Controls.Add(this.textBox_OrderNum);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 387);
            this.panel1.TabIndex = 1;
            // 
            // textBox_OrderNum
            // 
            this.textBox_OrderNum.Location = new System.Drawing.Point(112, 26);
            this.textBox_OrderNum.Name = "textBox_OrderNum";
            this.textBox_OrderNum.Size = new System.Drawing.Size(100, 25);
            this.textBox_OrderNum.TabIndex = 0;
            // 
            // textBox_client
            // 
            this.textBox_client.Location = new System.Drawing.Point(112, 113);
            this.textBox_client.Name = "textBox_client";
            this.textBox_client.Size = new System.Drawing.Size(100, 25);
            this.textBox_client.TabIndex = 2;
            // 
            // lab_ordernum
            // 
            this.lab_ordernum.AutoSize = true;
            this.lab_ordernum.Location = new System.Drawing.Point(28, 29);
            this.lab_ordernum.Name = "lab_ordernum";
            this.lab_ordernum.Size = new System.Drawing.Size(52, 15);
            this.lab_ordernum.TabIndex = 3;
            this.lab_ordernum.Text = "订单号";
            this.lab_ordernum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_Cilent
            // 
            this.lab_Cilent.AutoSize = true;
            this.lab_Cilent.Location = new System.Drawing.Point(28, 116);
            this.lab_Cilent.Name = "lab_Cilent";
            this.lab_Cilent.Size = new System.Drawing.Size(52, 15);
            this.lab_Cilent.TabIndex = 5;
            this.lab_Cilent.Text = "用户名";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(286, 29);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "删除订单";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_addDetail
            // 
            this.btn_addDetail.Location = new System.Drawing.Point(286, 323);
            this.btn_addDetail.Name = "btn_addDetail";
            this.btn_addDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_addDetail.TabIndex = 7;
            this.btn_addDetail.Text = "添加商品";
            this.btn_addDetail.UseVisualStyleBackColor = true;
            this.btn_addDetail.Click += new System.EventHandler(this.btn_addDetail_Click);
            // 
            // btn_addGoods
            // 
            this.btn_addGoods.Location = new System.Drawing.Point(286, 116);
            this.btn_addGoods.Name = "btn_addGoods";
            this.btn_addGoods.Size = new System.Drawing.Size(75, 23);
            this.btn_addGoods.TabIndex = 7;
            this.btn_addGoods.Text = "添加订单";
            this.btn_addGoods.UseVisualStyleBackColor = true;
            this.btn_addGoods.Click += new System.EventHandler(this.btn_addGoods_Click);
            // 
            // textBox_Goods
            // 
            this.textBox_Goods.Location = new System.Drawing.Point(112, 197);
            this.textBox_Goods.Name = "textBox_Goods";
            this.textBox_Goods.Size = new System.Drawing.Size(100, 25);
            this.textBox_Goods.TabIndex = 8;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(112, 259);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 25);
            this.textBox_price.TabIndex = 9;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(112, 321);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 25);
            this.textBox_number.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "单  价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "数  量";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_OrderNum;
        private System.Windows.Forms.Button btn_addDetail;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lab_Cilent;
        private System.Windows.Forms.Label lab_ordernum;
        private System.Windows.Forms.TextBox textBox_client;
        private System.Windows.Forms.Button btn_addGoods;
        private System.Windows.Forms.TextBox textBox_Goods;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}