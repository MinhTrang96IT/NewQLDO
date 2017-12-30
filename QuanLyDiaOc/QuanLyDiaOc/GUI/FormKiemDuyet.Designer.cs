namespace QuanLyDiaOc.GUI
{
    partial class FormKiemDuyet
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
            this.tabctrKiemDuyet = new System.Windows.Forms.TabControl();
            this.tabPhieuDangKy = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPhieuDangKy = new System.Windows.Forms.DataGridView();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrKiemDuyet.SuspendLayout();
            this.tabPhieuDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrKiemDuyet
            // 
            this.tabctrKiemDuyet.Controls.Add(this.tabPhieuDangKy);
            this.tabctrKiemDuyet.Controls.Add(this.tabPage2);
            this.tabctrKiemDuyet.Location = new System.Drawing.Point(104, 52);
            this.tabctrKiemDuyet.Name = "tabctrKiemDuyet";
            this.tabctrKiemDuyet.SelectedIndex = 0;
            this.tabctrKiemDuyet.Size = new System.Drawing.Size(973, 245);
            this.tabctrKiemDuyet.TabIndex = 0;
            this.tabctrKiemDuyet.SelectedIndexChanged += new System.EventHandler(this.tabctrKiemDuyet_SelectedIndexChanged);
            // 
            // tabPhieuDangKy
            // 
            this.tabPhieuDangKy.Controls.Add(this.dgvPhieuDangKy);
            this.tabPhieuDangKy.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuDangKy.Name = "tabPhieuDangKy";
            this.tabPhieuDangKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuDangKy.Size = new System.Drawing.Size(965, 219);
            this.tabPhieuDangKy.TabIndex = 0;
            this.tabPhieuDangKy.Text = "Phiếu đăng ký";
            this.tabPhieuDangKy.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuDangKy
            // 
            this.dgvPhieuDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhieuDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDangKy,
            this.TenKhachHang,
            this.MaDiaOc,
            this.TenNhanVien,
            this.NgayLap,
            this.TongTien,
            this.ChiTiet,
            this.TrangThaiKiemDuyet,
            this.XacNhan,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.SoLanGiaHan,
            this.DaTra,
            this.ConNo});
            this.dgvPhieuDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuDangKy.Location = new System.Drawing.Point(3, 3);
            this.dgvPhieuDangKy.Name = "dgvPhieuDangKy";
            this.dgvPhieuDangKy.Size = new System.Drawing.Size(959, 213);
            this.dgvPhieuDangKy.TabIndex = 0;
            this.dgvPhieuDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDangKy_CellContentClick);
            // 
            // MaPhieuDangKy
            // 
            this.MaPhieuDangKy.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKy.HeaderText = "Mã phiếu đăng ký";
            this.MaPhieuDangKy.Name = "MaPhieuDangKy";
            this.MaPhieuDangKy.Width = 98;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 102;
            // 
            // MaDiaOc
            // 
            this.MaDiaOc.DataPropertyName = "MaDiaOc";
            this.MaDiaOc.HeaderText = "Mã địa ốc";
            this.MaDiaOc.Name = "MaDiaOc";
            this.MaDiaOc.Width = 63;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Người lập phiếu";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 97;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 69;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TongTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TongTien.Width = 52;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTiet.Text = "Xem chi tiết";
            this.ChiTiet.UseColumnTextForButtonValue = true;
            this.ChiTiet.Width = 21;
            // 
            // TrangThaiKiemDuyet
            // 
            this.TrangThaiKiemDuyet.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.HeaderText = "Kiểm duyệt";
            this.TrangThaiKiemDuyet.Name = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.Width = 59;
            // 
            // XacNhan
            // 
            this.XacNhan.HeaderText = "Xác nhận";
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XacNhan.Text = "Gửi";
            this.XacNhan.UseColumnTextForButtonValue = true;
            this.XacNhan.Width = 72;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Column1";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Visible = false;
            this.NgayBatDau.Width = 73;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Column1";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Visible = false;
            this.NgayKetThuc.Width = 73;
            // 
            // SoLanGiaHan
            // 
            this.SoLanGiaHan.DataPropertyName = "SoLanGiaHan";
            this.SoLanGiaHan.HeaderText = "Column1";
            this.SoLanGiaHan.Name = "SoLanGiaHan";
            this.SoLanGiaHan.Visible = false;
            this.SoLanGiaHan.Width = 73;
            // 
            // DaTra
            // 
            this.DaTra.DataPropertyName = "DaTra";
            this.DaTra.HeaderText = "Column1";
            this.DaTra.Name = "DaTra";
            this.DaTra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DaTra.Visible = false;
            this.DaTra.Width = 54;
            // 
            // ConNo
            // 
            this.ConNo.DataPropertyName = "ConNo";
            this.ConNo.HeaderText = "Column1";
            this.ConNo.Name = "ConNo";
            this.ConNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ConNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConNo.Visible = false;
            this.ConNo.Width = 54;
            // 
            // FormKiemDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tabctrKiemDuyet);
            this.Name = "FormKiemDuyet";
            this.Text = "FormKiemDuyet";
            this.Load += new System.EventHandler(this.FormKiemDuyet_Load);
            this.tabctrKiemDuyet.ResumeLayout(false);
            this.tabPhieuDangKy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrKiemDuyet;
        private System.Windows.Forms.TabPage tabPhieuDangKy;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
        private System.Windows.Forms.DataGridViewButtonColumn XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConNo;
    }
}