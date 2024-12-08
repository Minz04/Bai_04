namespace Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_msnv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_luongcb = new System.Windows.Forms.TextBox();
            this.btn_agree = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương cơ bản";
            // 
            // txt_msnv
            // 
            this.txt_msnv.Location = new System.Drawing.Point(163, 27);
            this.txt_msnv.Name = "txt_msnv";
            this.txt_msnv.Size = new System.Drawing.Size(296, 20);
            this.txt_msnv.TabIndex = 3;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(163, 73);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(296, 20);
            this.txt_tennv.TabIndex = 4;
            // 
            // txt_luongcb
            // 
            this.txt_luongcb.Location = new System.Drawing.Point(163, 121);
            this.txt_luongcb.Name = "txt_luongcb";
            this.txt_luongcb.Size = new System.Drawing.Size(296, 20);
            this.txt_luongcb.TabIndex = 5;
            // 
            // btn_agree
            // 
            this.btn_agree.Location = new System.Drawing.Point(69, 174);
            this.btn_agree.Name = "btn_agree";
            this.btn_agree.Size = new System.Drawing.Size(112, 27);
            this.btn_agree.TabIndex = 6;
            this.btn_agree.Text = "Đồng ý";
            this.btn_agree.UseVisualStyleBackColor = true;
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(316, 174);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(112, 27);
            this.btn_skip.TabIndex = 7;
            this.btn_skip.Text = "Bỏ qua";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 233);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.btn_agree);
            this.Controls.Add(this.txt_luongcb);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_msnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "NhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_msnv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_luongcb;
        private System.Windows.Forms.Button btn_agree;
        private System.Windows.Forms.Button btn_skip;
    }
}