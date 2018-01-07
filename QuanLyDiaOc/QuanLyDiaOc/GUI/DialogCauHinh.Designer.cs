namespace QuanLyDiaOc.GUI
{
    partial class DialogCauHinh
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
            this.txtChuoiKetNoi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn hãy nhập chuỗi kết nối mới nếu bạn có một database khác của mình";
            // 
            // txtChuoiKetNoi
            // 
            this.txtChuoiKetNoi.Location = new System.Drawing.Point(45, 43);
            this.txtChuoiKetNoi.Multiline = true;
            this.txtChuoiKetNoi.Name = "txtChuoiKetNoi";
            this.txtChuoiKetNoi.Size = new System.Drawing.Size(350, 70);
            this.txtChuoiKetNoi.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(45, 119);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // DialogCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 182);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtChuoiKetNoi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChuoiKetNoi;
        private System.Windows.Forms.Button btnCapNhat;
    }
}