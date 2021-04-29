
namespace HomewWork9
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSuccessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bds_urldata = new System.Windows.Forms.BindingSource(this.components);
            this.tb_startuml = new System.Windows.Forms.TextBox();
            this.btn_crawl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_urldata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn,
            this.isSuccessDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bds_urldata;
            this.dataGridView1.Location = new System.Drawing.Point(115, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(406, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 125;
            // 
            // isSuccessDataGridViewCheckBoxColumn
            // 
            this.isSuccessDataGridViewCheckBoxColumn.DataPropertyName = "IsSuccess";
            this.isSuccessDataGridViewCheckBoxColumn.HeaderText = "IsSuccess";
            this.isSuccessDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isSuccessDataGridViewCheckBoxColumn.Name = "isSuccessDataGridViewCheckBoxColumn";
            this.isSuccessDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bds_urldata
            // 
            this.bds_urldata.DataSource = typeof(HomewWork9.UrlData);
            // 
            // tb_startuml
            // 
            this.tb_startuml.Location = new System.Drawing.Point(172, 65);
            this.tb_startuml.Name = "tb_startuml";
            this.tb_startuml.Size = new System.Drawing.Size(100, 25);
            this.tb_startuml.TabIndex = 1;
            // 
            // btn_crawl
            // 
            this.btn_crawl.Location = new System.Drawing.Point(369, 64);
            this.btn_crawl.Name = "btn_crawl";
            this.btn_crawl.Size = new System.Drawing.Size(75, 23);
            this.btn_crawl.TabIndex = 2;
            this.btn_crawl.Text = "Crawl";
            this.btn_crawl.UseVisualStyleBackColor = true;
            this.btn_crawl.Click += new System.EventHandler(this.btn_crawl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_crawl);
            this.Controls.Add(this.tb_startuml);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_urldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bds_urldata;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSuccessDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox tb_startuml;
        private System.Windows.Forms.Button btn_crawl;
    }
}

