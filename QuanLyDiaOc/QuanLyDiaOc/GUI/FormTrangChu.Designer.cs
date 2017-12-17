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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngưngĐăngKýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHạnĐăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐịaỐcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địaỐcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlChinh
            // 
            this.tabCtlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtlChinh.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtlChinh.Location = new System.Drawing.Point(0, 24);
            this.tabCtlChinh.Name = "tabCtlChinh";
            this.tabCtlChinh.SelectedIndex = 0;
            this.tabCtlChinh.Size = new System.Drawing.Size(685, 312);
            this.tabCtlChinh.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtlChinh.TabIndex = 1;
            this.tabCtlChinh.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCtlChinh_DrawItem);
            this.tabCtlChinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabCtlChinh_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nghiepVuToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.loạiĐịaỐcToolStripMenuItem,
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
            // loạiĐịaỐcToolStripMenuItem
            // 
            this.loạiĐịaỐcToolStripMenuItem.Name = "loạiĐịaỐcToolStripMenuItem";
            this.loạiĐịaỐcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loạiĐịaỐcToolStripMenuItem.Text = "Loại địa ốc";
            // 
            // địaỐcToolStripMenuItem
            // 
            this.địaỐcToolStripMenuItem.Name = "địaỐcToolStripMenuItem";
            this.địaỐcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.địaỐcToolStripMenuItem.Text = "Địa ốc";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 336);
            this.Controls.Add(this.tabCtlChinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtlChinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngưngĐăngKýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaHạnĐăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiĐịaỐcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địaỐcToolStripMenuItem;
    }
}