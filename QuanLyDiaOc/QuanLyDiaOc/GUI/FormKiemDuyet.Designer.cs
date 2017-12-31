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
            this.dgvPhieuDangKy = new System.Windows.Forms.DataGridView();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LyDoKhongDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPhieuGiaHan = new System.Windows.Forms.TabPage();
            this.dgvPhieuGiaHan = new System.Windows.Forms.DataGridView();
            this.MaPhieuGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKyGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVienGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietGH = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrangThaiKiemDuyetGH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LyDoKhongDuyetGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhanGh = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NgayBatDauGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThucGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPhieuNgungDV = new System.Windows.Forms.TabPage();
            this.dgvNgungDichVu = new System.Windows.Forms.DataGridView();
            this.MaPhieuNgungDangKyDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKyNDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVienNDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapNDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietNDV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrangThaiKiemDuyetNDV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LyDoKhongDuyetNDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhanNDV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabChiTietQuangCao = new System.Windows.Forms.TabPage();
            this.dgvChiTietQuangCao = new System.Windows.Forms.DataGridView();
            this.tabBaiViet = new System.Windows.Forms.TabPage();
            this.tabDiaOc = new System.Windows.Forms.TabPage();
            this.tabctrKiemDuyet.SuspendLayout();
            this.tabPhieuDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangKy)).BeginInit();
            this.tabPhieuGiaHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).BeginInit();
            this.tabPhieuNgungDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgungDichVu)).BeginInit();
            this.tabChiTietQuangCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietQuangCao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrKiemDuyet
            // 
            this.tabctrKiemDuyet.Controls.Add(this.tabPhieuDangKy);
            this.tabctrKiemDuyet.Controls.Add(this.tabPhieuGiaHan);
            this.tabctrKiemDuyet.Controls.Add(this.tabPhieuNgungDV);
            this.tabctrKiemDuyet.Controls.Add(this.tabChiTietQuangCao);
            this.tabctrKiemDuyet.Controls.Add(this.tabBaiViet);
            this.tabctrKiemDuyet.Controls.Add(this.tabDiaOc);
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
            this.LyDoKhongDuyet,
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
            this.TrangThaiKiemDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiKiemDuyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TrangThaiKiemDuyet.Width = 78;
            // 
            // LyDoKhongDuyet
            // 
            this.LyDoKhongDuyet.DataPropertyName = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.HeaderText = "Lý do không kiểm duyệt";
            this.LyDoKhongDuyet.Name = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.Width = 109;
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
            // tabPhieuGiaHan
            // 
            this.tabPhieuGiaHan.Controls.Add(this.dgvPhieuGiaHan);
            this.tabPhieuGiaHan.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuGiaHan.Name = "tabPhieuGiaHan";
            this.tabPhieuGiaHan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuGiaHan.Size = new System.Drawing.Size(965, 219);
            this.tabPhieuGiaHan.TabIndex = 1;
            this.tabPhieuGiaHan.Text = "Phiếu gia hạn";
            this.tabPhieuGiaHan.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuGiaHan
            // 
            this.dgvPhieuGiaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGiaHan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuGiaHan,
            this.MaPhieuDangKyGH,
            this.TenNhanVienGH,
            this.NgayLapGH,
            this.TongTienGH,
            this.ChiTietGH,
            this.TrangThaiKiemDuyetGH,
            this.LyDoKhongDuyetGH,
            this.XacNhanGh,
            this.NgayBatDauGH,
            this.NgayKetThucGH});
            this.dgvPhieuGiaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuGiaHan.Location = new System.Drawing.Point(3, 3);
            this.dgvPhieuGiaHan.Name = "dgvPhieuGiaHan";
            this.dgvPhieuGiaHan.Size = new System.Drawing.Size(959, 213);
            this.dgvPhieuGiaHan.TabIndex = 0;
            this.dgvPhieuGiaHan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuGiaHan_CellContentClick);
            // 
            // MaPhieuGiaHan
            // 
            this.MaPhieuGiaHan.DataPropertyName = "MaPhieuGiaHan";
            this.MaPhieuGiaHan.HeaderText = "Mã phiếu gia hạn";
            this.MaPhieuGiaHan.Name = "MaPhieuGiaHan";
            // 
            // MaPhieuDangKyGH
            // 
            this.MaPhieuDangKyGH.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKyGH.HeaderText = "Mã phiếu đăng ký";
            this.MaPhieuDangKyGH.Name = "MaPhieuDangKyGH";
            // 
            // TenNhanVienGH
            // 
            this.TenNhanVienGH.DataPropertyName = "TenNhanVien";
            this.TenNhanVienGH.HeaderText = "Người lập";
            this.TenNhanVienGH.Name = "TenNhanVienGH";
            // 
            // NgayLapGH
            // 
            this.NgayLapGH.DataPropertyName = "NgayLap";
            this.NgayLapGH.HeaderText = "Ngày lập";
            this.NgayLapGH.Name = "NgayLapGH";
            // 
            // TongTienGH
            // 
            this.TongTienGH.DataPropertyName = "TongTien";
            this.TongTienGH.HeaderText = "Tổng tiền";
            this.TongTienGH.Name = "TongTienGH";
            this.TongTienGH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TongTienGH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChiTietGH
            // 
            this.ChiTietGH.HeaderText = "";
            this.ChiTietGH.Name = "ChiTietGH";
            this.ChiTietGH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTietGH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTietGH.Text = "Xem chi tiết";
            this.ChiTietGH.UseColumnTextForButtonValue = true;
            // 
            // TrangThaiKiemDuyetGH
            // 
            this.TrangThaiKiemDuyetGH.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyetGH.HeaderText = "Kiểm duyệt";
            this.TrangThaiKiemDuyetGH.Name = "TrangThaiKiemDuyetGH";
            // 
            // LyDoKhongDuyetGH
            // 
            this.LyDoKhongDuyetGH.DataPropertyName = "LyDoKhongDuyet";
            this.LyDoKhongDuyetGH.HeaderText = "Lý do không duyệt";
            this.LyDoKhongDuyetGH.Name = "LyDoKhongDuyetGH";
            // 
            // XacNhanGh
            // 
            this.XacNhanGh.HeaderText = "Xác nhận";
            this.XacNhanGh.Name = "XacNhanGh";
            this.XacNhanGh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XacNhanGh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XacNhanGh.Text = "Gửi";
            this.XacNhanGh.UseColumnTextForButtonValue = true;
            // 
            // NgayBatDauGH
            // 
            this.NgayBatDauGH.DataPropertyName = "NgayBatDau";
            this.NgayBatDauGH.HeaderText = "Column1";
            this.NgayBatDauGH.Name = "NgayBatDauGH";
            this.NgayBatDauGH.Visible = false;
            // 
            // NgayKetThucGH
            // 
            this.NgayKetThucGH.DataPropertyName = "NgayKetThuc";
            this.NgayKetThucGH.HeaderText = "Column1";
            this.NgayKetThucGH.Name = "NgayKetThucGH";
            this.NgayKetThucGH.Visible = false;
            // 
            // tabPhieuNgungDV
            // 
            this.tabPhieuNgungDV.Controls.Add(this.dgvNgungDichVu);
            this.tabPhieuNgungDV.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuNgungDV.Name = "tabPhieuNgungDV";
            this.tabPhieuNgungDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuNgungDV.Size = new System.Drawing.Size(965, 219);
            this.tabPhieuNgungDV.TabIndex = 2;
            this.tabPhieuNgungDV.Text = "Ngừng dịch vụ";
            this.tabPhieuNgungDV.UseVisualStyleBackColor = true;
            // 
            // dgvNgungDichVu
            // 
            this.dgvNgungDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgungDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNgungDangKyDichVu,
            this.MaPhieuDangKyNDV,
            this.TenNhanVienNDV,
            this.NgayLapNDV,
            this.LyDo,
            this.ChiTietNDV,
            this.TrangThaiKiemDuyetNDV,
            this.LyDoKhongDuyetNDV,
            this.XacNhanNDV});
            this.dgvNgungDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNgungDichVu.Location = new System.Drawing.Point(3, 3);
            this.dgvNgungDichVu.Name = "dgvNgungDichVu";
            this.dgvNgungDichVu.Size = new System.Drawing.Size(959, 213);
            this.dgvNgungDichVu.TabIndex = 0;
            this.dgvNgungDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgungDichVu_CellContentClick);
            // 
            // MaPhieuNgungDangKyDichVu
            // 
            this.MaPhieuNgungDangKyDichVu.DataPropertyName = "MaPhieuNgungDangKyDichVu";
            this.MaPhieuNgungDangKyDichVu.HeaderText = "Mã phiếu ngừng đăng ký DV";
            this.MaPhieuNgungDangKyDichVu.Name = "MaPhieuNgungDangKyDichVu";
            // 
            // MaPhieuDangKyNDV
            // 
            this.MaPhieuDangKyNDV.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKyNDV.HeaderText = "Mã phiếu đăng ký";
            this.MaPhieuDangKyNDV.Name = "MaPhieuDangKyNDV";
            // 
            // TenNhanVienNDV
            // 
            this.TenNhanVienNDV.DataPropertyName = "TenNhanVien";
            this.TenNhanVienNDV.HeaderText = "Người lập";
            this.TenNhanVienNDV.Name = "TenNhanVienNDV";
            // 
            // NgayLapNDV
            // 
            this.NgayLapNDV.DataPropertyName = "NgayLap";
            this.NgayLapNDV.HeaderText = "Ngày lập";
            this.NgayLapNDV.Name = "NgayLapNDV";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            // 
            // ChiTietNDV
            // 
            this.ChiTietNDV.HeaderText = "";
            this.ChiTietNDV.Name = "ChiTietNDV";
            this.ChiTietNDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTietNDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTietNDV.Text = "Xem chi tiết";
            this.ChiTietNDV.UseColumnTextForButtonValue = true;
            // 
            // TrangThaiKiemDuyetNDV
            // 
            this.TrangThaiKiemDuyetNDV.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyetNDV.HeaderText = "Trạng thái";
            this.TrangThaiKiemDuyetNDV.Name = "TrangThaiKiemDuyetNDV";
            this.TrangThaiKiemDuyetNDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiKiemDuyetNDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LyDoKhongDuyetNDV
            // 
            this.LyDoKhongDuyetNDV.DataPropertyName = "LyDoKhongDuyet";
            this.LyDoKhongDuyetNDV.HeaderText = "Lý do không duyệt";
            this.LyDoKhongDuyetNDV.Name = "LyDoKhongDuyetNDV";
            // 
            // XacNhanNDV
            // 
            this.XacNhanNDV.HeaderText = "Xác nhận";
            this.XacNhanNDV.Name = "XacNhanNDV";
            this.XacNhanNDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XacNhanNDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XacNhanNDV.Text = "Gửi";
            this.XacNhanNDV.UseColumnTextForButtonValue = true;
            // 
            // tabChiTietQuangCao
            // 
            this.tabChiTietQuangCao.Controls.Add(this.dgvChiTietQuangCao);
            this.tabChiTietQuangCao.Location = new System.Drawing.Point(4, 22);
            this.tabChiTietQuangCao.Name = "tabChiTietQuangCao";
            this.tabChiTietQuangCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTietQuangCao.Size = new System.Drawing.Size(965, 219);
            this.tabChiTietQuangCao.TabIndex = 3;
            this.tabChiTietQuangCao.Text = "Thông tin quảng cáo";
            this.tabChiTietQuangCao.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietQuangCao
            // 
            this.dgvChiTietQuangCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietQuangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietQuangCao.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTietQuangCao.Name = "dgvChiTietQuangCao";
            this.dgvChiTietQuangCao.Size = new System.Drawing.Size(959, 213);
            this.dgvChiTietQuangCao.TabIndex = 0;
            // 
            // tabBaiViet
            // 
            this.tabBaiViet.Location = new System.Drawing.Point(4, 22);
            this.tabBaiViet.Name = "tabBaiViet";
            this.tabBaiViet.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaiViet.Size = new System.Drawing.Size(965, 219);
            this.tabBaiViet.TabIndex = 4;
            this.tabBaiViet.Text = "Bài viết quảng cáo";
            this.tabBaiViet.UseVisualStyleBackColor = true;
            // 
            // tabDiaOc
            // 
            this.tabDiaOc.Location = new System.Drawing.Point(4, 22);
            this.tabDiaOc.Name = "tabDiaOc";
            this.tabDiaOc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiaOc.Size = new System.Drawing.Size(965, 219);
            this.tabDiaOc.TabIndex = 5;
            this.tabDiaOc.Text = "Địa ốc";
            this.tabDiaOc.UseVisualStyleBackColor = true;
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
            this.tabPhieuGiaHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).EndInit();
            this.tabPhieuNgungDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgungDichVu)).EndInit();
            this.tabChiTietQuangCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietQuangCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrKiemDuyet;
        private System.Windows.Forms.TabPage tabPhieuDangKy;
        private System.Windows.Forms.TabPage tabPhieuGiaHan;
        private System.Windows.Forms.DataGridView dgvPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKhongDuyet;
        private System.Windows.Forms.DataGridViewButtonColumn XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConNo;
        private System.Windows.Forms.DataGridView dgvPhieuGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKyGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVienGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienGH;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTietGH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyetGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKhongDuyetGH;
        private System.Windows.Forms.DataGridViewButtonColumn XacNhanGh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDauGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThucGH;
        private System.Windows.Forms.TabPage tabPhieuNgungDV;
        private System.Windows.Forms.DataGridView dgvNgungDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNgungDangKyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKyNDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVienNDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapNDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTietNDV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyetNDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKhongDuyetNDV;
        private System.Windows.Forms.DataGridViewButtonColumn XacNhanNDV;
        private System.Windows.Forms.TabPage tabChiTietQuangCao;
        private System.Windows.Forms.DataGridView dgvChiTietQuangCao;
        private System.Windows.Forms.TabPage tabBaiViet;
        private System.Windows.Forms.TabPage tabDiaOc;
    }
}