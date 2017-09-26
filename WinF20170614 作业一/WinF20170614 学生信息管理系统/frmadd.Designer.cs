namespace WinF20170614
{
    partial class frmadd
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
            this.labname = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.labsex = new System.Windows.Forms.Label();
            this.textsex = new System.Windows.Forms.TextBox();
            this.labage = new System.Windows.Forms.Label();
            this.texage = new System.Windows.Forms.TextBox();
            this.labadress = new System.Windows.Forms.Label();
            this.textagress = new System.Windows.Forms.TextBox();
            this.labins = new System.Windows.Forms.Label();
            this.textins = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(19, 28);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(44, 18);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(89, 22);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(308, 28);
            this.textname.TabIndex = 1;
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.Location = new System.Drawing.Point(19, 79);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(44, 18);
            this.labsex.TabIndex = 2;
            this.labsex.Text = "性别";
            // 
            // textsex
            // 
            this.textsex.Location = new System.Drawing.Point(89, 76);
            this.textsex.Name = "textsex";
            this.textsex.Size = new System.Drawing.Size(308, 28);
            this.textsex.TabIndex = 3;
            // 
            // labage
            // 
            this.labage.AutoSize = true;
            this.labage.Location = new System.Drawing.Point(19, 160);
            this.labage.Name = "labage";
            this.labage.Size = new System.Drawing.Size(44, 18);
            this.labage.TabIndex = 4;
            this.labage.Text = "年龄";
            // 
            // texage
            // 
            this.texage.Location = new System.Drawing.Point(89, 157);
            this.texage.Name = "texage";
            this.texage.Size = new System.Drawing.Size(308, 28);
            this.texage.TabIndex = 5;
            // 
            // labadress
            // 
            this.labadress.AutoSize = true;
            this.labadress.Location = new System.Drawing.Point(19, 239);
            this.labadress.Name = "labadress";
            this.labadress.Size = new System.Drawing.Size(44, 18);
            this.labadress.TabIndex = 6;
            this.labadress.Text = "住址";
            // 
            // textagress
            // 
            this.textagress.Location = new System.Drawing.Point(89, 229);
            this.textagress.Name = "textagress";
            this.textagress.Size = new System.Drawing.Size(308, 28);
            this.textagress.TabIndex = 7;
            // 
            // labins
            // 
            this.labins.AutoSize = true;
            this.labins.Location = new System.Drawing.Point(19, 317);
            this.labins.Name = "labins";
            this.labins.Size = new System.Drawing.Size(44, 18);
            this.labins.TabIndex = 8;
            this.labins.Text = "兴趣";
            // 
            // textins
            // 
            this.textins.Location = new System.Drawing.Point(89, 307);
            this.textins.Name = "textins";
            this.textins.Size = new System.Drawing.Size(308, 28);
            this.textins.TabIndex = 9;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(168, 353);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(132, 39);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.textins);
            this.Controls.Add(this.labins);
            this.Controls.Add(this.textagress);
            this.Controls.Add(this.labadress);
            this.Controls.Add(this.texage);
            this.Controls.Add(this.labage);
            this.Controls.Add(this.textsex);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.labname);
            this.Name = "frmadd";
            this.Text = "添加信息";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.TextBox textsex;
        private System.Windows.Forms.Label labage;
        private System.Windows.Forms.TextBox texage;
        private System.Windows.Forms.Label labadress;
        private System.Windows.Forms.TextBox textagress;
        private System.Windows.Forms.Label labins;
        private System.Windows.Forms.TextBox textins;
        private System.Windows.Forms.Button btnok;
    }
}