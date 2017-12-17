namespace QuanLyDiaOc.GUI
{
    partial class FormTrangChu
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
            this.tabCtlChinh = new System.Windows.Forms.TabControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngưngĐăngKýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHạnĐăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địaỐcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNguoiDung = new System.Windows.Forms.Label();
            this.địaỐcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐịaỐcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlChinh
            // 
            this.tabCtlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlChinh.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtlChinh.Location = new System.Drawing.Point(0, 24);
            this.tabCtlChinh.Name = "tabCtlChinh";
            this.tabCtlChinh.SelectedIndex = 0;
            this.tabCtlChinh.Size = new System.Drawing.Size(685, 399);
            this.tabCtlChinh.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtlChinh.TabIndex = 1;
            this.tabCtlChinh.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCtlChinh_DrawItem);
            this.tabCtlChinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabCtlChinh_MouseDown);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nghiepVuToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(685, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // nghiepVuToolStripMenuItem
            // 
            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demoToolStripMenuItem,
            this.ngưngĐăngKýDịchVụToolStripMenuItem,
            this.giaHạnĐăngKýToolStripMenuItem});
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiepVuToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.demoToolStripMenuItem.Text = "Đăng ký quảng cáo";
            this.demoToolStripMenuItem.Click += new System.EventHandler(this.demoToolStripMenuItem_Click);
            // 
            // ngưngĐăngKýDịchVụToolStripMenuItem
            // 
            this.ngưngĐăngKýDịchVụToolStripMenuItem.Name = "ngưngĐăngKýDịchVụToolStripMenuItem";
            this.ngưngĐăngKýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ngưngĐăngKýDịchVụToolStripMenuItem.Text = "Ngưng đăng ký dịch vụ";
            // 
            // giaHạnĐăngKýToolStripMenuItem
            // 
            this.giaHạnĐăngKýToolStripMenuItem.Name = "giaHạnĐăngKýToolStripMenuItem";
            this.giaHạnĐăngKýToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.giaHạnĐăngKýToolStripMenuItem.Text = "Gia hạn đăng ký";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.địaỐcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // địaỐcToolStripMenuItem
            // 
            this.địaỐcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.địaỐcToolStripMenuItem1,
            this.loạiĐịaỐcToolStripMenuItem});
            this.địaỐcToolStripMenuItem.Name = "địaỐcToolStripMenuItem";
            this.địaỐcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.địaỐcToolStripMenuItem.Text = "Địa ốc";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhóm TaHiTu";
            // 
            // lbNguoiDung
            // 
            this.lbNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNguoiDung.Location = new System.Drawing.Point(274, 401);
            this.lbNguoiDung.Name = "lbNguoiDung";
            this.lbNguoiDung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbNguoiDung.Size = new System.Drawing.Size(400, 13);
            this.lbNguoiDung.TabIndex = 3;
            this.lbNguoiDung.Text = "Người dùng: Trần Thị Minh Trang - Giám đốc";
            this.lbNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // địaỐcToolStripMenuItem1
            // 
            this.địaỐcToolStripMenuItem1.Name = "địaỐcToolStripMenuItem1";
            this.địaỐcToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.địaỐcToolStripMenuItem1.Text = "Địa ốc";
            // 
            // loạiĐịaỐcToolStripMenuItem
            // 
            this.loạiĐịaỐcToolStripMenuItem.Name = "loạiĐịaỐcToolStripMenuItem";
            this.loạiĐịaỐcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loạiĐịaỐcToolStripMenuItem.Text = "Loại địa ốc";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.lbNguoiDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabCtlChinh);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtlChinh;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngưngĐăngKýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaHạnĐăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địaỐcToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem địaỐcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loạiĐịaỐcToolStripMenuItem;
    }
}