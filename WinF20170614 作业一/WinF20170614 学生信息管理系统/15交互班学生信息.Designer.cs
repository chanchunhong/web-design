namespace WinF20170614
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnxiu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btntian = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(816, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnxiu
            // 
            this.btnxiu.Location = new System.Drawing.Point(268, 599);
            this.btnxiu.Name = "btnxiu";
            this.btnxiu.Size = new System.Drawing.Size(186, 36);
            this.btnxiu.TabIndex = 1;
            this.btnxiu.Text = "修改";
            this.btnxiu.UseVisualStyleBackColor = true;
            this.btnxiu.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 28);
            this.textBox1.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(829, 88);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 30);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "执行";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btntian
            // 
            this.btntian.Location = new System.Drawing.Point(592, 599);
            this.btntian.Name = "btntian";
            this.btntian.Size = new System.Drawing.Size(192, 36);
            this.btntian.TabIndex = 4;
            this.btntian.Text = "添加";
            this.btntian.UseVisualStyleBackColor = true;
            this.btntian.Click += new System.EventHandler(this.btntian_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(894, 599);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(190, 35);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(348, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "15信息与交互设计班学生信息表";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btntian);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnxiu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "15信息与交互设计班学生信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnxiu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btntian;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label1;
    }
}

