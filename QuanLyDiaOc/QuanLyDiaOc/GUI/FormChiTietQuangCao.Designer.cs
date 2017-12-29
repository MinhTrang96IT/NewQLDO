namespace QuanLyDiaOc.GUI
{
    partial class FormChiTietQuangCao
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
            this.label15 = new System.Windows.Forms.Label();
            this.gbDanhSanh = new System.Windows.Forms.GroupBox();
            this.dgvChiTietQuangCao = new System.Windows.Forms.DataGridView();
            this.MaChiTietQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhatHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.rbDaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbChuaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieuDangKy = new System.Windows.Forms.TextBox();
            this.btnThemViTri = new System.Windows.Forms.Button();
            this.btnThemBao = new System.Windows.Forms.Button();
            this.btnThemLoaiQuangCao = new System.Windows.Forms.Button();
            this.btnThemPhieuDangKy = new System.Windows.Forms.Button();
            this.btnQuanLyBaiViet = new System.Windows.Forms.Button();
            this.btnQuanLyHinhAnh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.cbBao = new System.Windows.Forms.ComboBox();
            this.cbLoaiQuangCao = new System.Windows.Forms.ComboBox();
            this.cbMaPhieuDangKy = new System.Windows.Forms.ComboBox();
            this.txtMaChiTietQuangCao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbDanhSanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietQuangCao)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Số lượng:";
            // 
            // gbDanhSanh
            // 
            this.gbDanhSanh.Controls.Add(this.dgvChiTietQuangCao);
            this.gbDanhSanh.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSanh.Name = "gbDanhSanh";
            this.gbDanhSanh.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSanh.TabIndex = 5;
            this.gbDanhSanh.TabStop = false;
            this.gbDanhSanh.Text = "Danh sách chi tiết quảng cáo";
            // 
            // dgvChiTietQuangCao
            // 
            this.dgvChiTietQuangCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvChiTietQuangCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietQuangCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietQuangCao,
            this.MaPhieuDangKy,
            this.TenLoaiQuangCao,
            this.TenViTri,
            this.TenBao,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.SoLuongPhatHanh,
            this.KichThuoc,
            this.TrangThaiKiemDuyet});
            this.dgvChiTietQuangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietQuangCao.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietQuangCao.Name = "dgvChiTietQuangCao";
            this.dgvChiTietQuangCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietQuangCao.Size = new System.Drawing.Size(967, 309);
            this.dgvChiTietQuangCao.TabIndex = 0;
            this.dgvChiTietQuangCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietQuangCao_CellClick_1);
            // 
            // MaChiTietQuangCao
            // 
            this.MaChiTietQuangCao.DataPropertyName = "MaChiTietQuangCao";
            this.MaChiTietQuangCao.HeaderText = "Mã chi tiết quảng cáo";
            this.MaChiTietQuangCao.Name = "MaChiTietQuangCao";
            this.MaChiTietQuangCao.Width = 107;
            // 
            // MaPhieuDangKy
            // 
            this.MaPhieuDangKy.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKy.HeaderText = "Mã phiếu đăng ký";
            this.MaPhieuDangKy.Name = "MaPhieuDangKy";
            this.MaPhieuDangKy.Width = 98;
            // 
            // TenLoaiQuangCao
            // 
            this.TenLoaiQuangCao.DataPropertyName = "TenLoaiQuangCao";
            this.TenLoaiQuangCao.HeaderText = "Tên loại quảng cáo";
            this.TenLoaiQuangCao.Name = "TenLoaiQuangCao";
            this.TenLoaiQuangCao.Width = 97;
            // 
            // TenViTri
            // 
            this.TenViTri.DataPropertyName = "TenViTri";
            this.TenViTri.HeaderText = "Tên vị trí";
            this.TenViTri.Name = "TenViTri";
            this.TenViTri.Width = 60;
            // 
            // TenBao
            // 
            this.TenBao.DataPropertyName = "TenBao";
            this.TenBao.HeaderText = "Tên báo";
            this.TenBao.Name = "TenBao";
            this.TenBao.Width = 51;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 72;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 72;
            // 
            // SoLuongPhatHanh
            // 
            this.SoLuongPhatHanh.DataPropertyName = "SoLuongPhatHanh";
            this.SoLuongPhatHanh.HeaderText = "Số lượng phát hành";
            this.SoLuongPhatHanh.Name = "SoLuongPhatHanh";
            this.SoLuongPhatHanh.Width = 93;
            // 
            // KichThuoc
            // 
            this.KichThuoc.DataPropertyName = "KichThuoc";
            this.KichThuoc.HeaderText = "Kích thước";
            this.KichThuoc.Name = "KichThuoc";
            this.KichThuoc.Width = 78;
            // 
            // TrangThaiKiemDuyet
            // 
            this.TrangThaiKiemDuyet.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.HeaderText = "Trạng thái kiểm duyệt";
            this.TrangThaiKiemDuyet.Name = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiKiemDuyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TrangThaiKiemDuyet.Width = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kích thước:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại quảng cáo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi tiết QC:";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.rbDaKiemDuyet);
            this.gbThongTin.Controls.Add(this.rbChuaKiemDuyet);
            this.gbThongTin.Controls.Add(this.label9);
            this.gbThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.dtpNgayBatDau);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.txtMaPhieuDangKy);
            this.gbThongTin.Controls.Add(this.btnThemViTri);
            this.gbThongTin.Controls.Add(this.btnThemBao);
            this.gbThongTin.Controls.Add(this.btnThemLoaiQuangCao);
            this.gbThongTin.Controls.Add(this.btnThemPhieuDangKy);
            this.gbThongTin.Controls.Add(this.btnQuanLyBaiViet);
            this.gbThongTin.Controls.Add(this.btnQuanLyHinhAnh);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.btnTaoMoi);
            this.gbThongTin.Controls.Add(this.txtSoLuong);
            this.gbThongTin.Controls.Add(this.txtChiPhi);
            this.gbThongTin.Controls.Add(this.txtKichThuoc);
            this.gbThongTin.Controls.Add(this.cbViTri);
            this.gbThongTin.Controls.Add(this.cbBao);
            this.gbThongTin.Controls.Add(this.cbLoaiQuangCao);
            this.gbThongTin.Controls.Add(this.cbMaPhieuDangKy);
            this.gbThongTin.Controls.Add(this.txtMaChiTietQuangCao);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.label15);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.label14);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Location = new System.Drawing.Point(105, 8);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(973, 245);
            this.gbThongTin.TabIndex = 4;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chi tiết quảng cáo";
            // 
            // rbDaKiemDuyet
            // 
            this.rbDaKiemDuyet.AutoSize = true;
            this.rbDaKiemDuyet.Location = new System.Drawing.Point(804, 145);
            this.rbDaKiemDuyet.Name = "rbDaKiemDuyet";
            this.rbDaKiemDuyet.Size = new System.Drawing.Size(93, 17);
            this.rbDaKiemDuyet.TabIndex = 42;
            this.rbDaKiemDuyet.Text = "Đã kiểm duyệt";
            this.rbDaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbChuaKiemDuyet
            // 
            this.rbChuaKiemDuyet.AutoSize = true;
            this.rbChuaKiemDuyet.Checked = true;
            this.rbChuaKiemDuyet.Location = new System.Drawing.Point(683, 145);
            this.rbChuaKiemDuyet.Name = "rbChuaKiemDuyet";
            this.rbChuaKiemDuyet.Size = new System.Drawing.Size(104, 17);
            this.rbChuaKiemDuyet.TabIndex = 41;
            this.rbChuaKiemDuyet.TabStop = true;
            this.rbChuaKiemDuyet.Text = "Chưa kiểm duyệt";
            this.rbChuaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Trạng thái:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(675, 80);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(184, 20);
            this.dtpNgayKetThuc.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(675, 47);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(184, 20);
            this.dtpNgayBatDau.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // txtMaPhieuDangKy
            // 
            this.txtMaPhieuDangKy.Location = new System.Drawing.Point(152, 72);
            this.txtMaPhieuDangKy.Name = "txtMaPhieuDangKy";
            this.txtMaPhieuDangKy.ReadOnly = true;
            this.txtMaPhieuDangKy.Size = new System.Drawing.Size(121, 20);
            this.txtMaPhieuDangKy.TabIndex = 37;
            // 
            // btnThemViTri
            // 
            this.btnThemViTri.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemViTri.Location = new System.Drawing.Point(279, 141);
            this.btnThemViTri.Name = "btnThemViTri";
            this.btnThemViTri.Size = new System.Drawing.Size(20, 20);
            this.btnThemViTri.TabIndex = 32;
            this.btnThemViTri.UseVisualStyleBackColor = true;
            this.btnThemViTri.Click += new System.EventHandler(this.btnThemViTri_Click);
            // 
            // btnThemBao
            // 
            this.btnThemBao.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemBao.Location = new System.Drawing.Point(546, 47);
            this.btnThemBao.Name = "btnThemBao";
            this.btnThemBao.Size = new System.Drawing.Size(20, 20);
            this.btnThemBao.TabIndex = 32;
            this.btnThemBao.UseVisualStyleBackColor = true;
            this.btnThemBao.Click += new System.EventHandler(this.btnThemBao_Click);
            // 
            // btnThemLoaiQuangCao
            // 
            this.btnThemLoaiQuangCao.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemLoaiQuangCao.Location = new System.Drawing.Point(279, 105);
            this.btnThemLoaiQuangCao.Name = "btnThemLoaiQuangCao";
            this.btnThemLoaiQuangCao.Size = new System.Drawing.Size(20, 20);
            this.btnThemLoaiQuangCao.TabIndex = 32;
            this.btnThemLoaiQuangCao.UseVisualStyleBackColor = true;
            this.btnThemLoaiQuangCao.Click += new System.EventHandler(this.btnThemLoaiQuangCao_Click);
            // 
            // btnThemPhieuDangKy
            // 
            this.btnThemPhieuDangKy.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemPhieuDangKy.Location = new System.Drawing.Point(279, 72);
            this.btnThemPhieuDangKy.Name = "btnThemPhieuDangKy";
            this.btnThemPhieuDangKy.Size = new System.Drawing.Size(20, 20);
            this.btnThemPhieuDangKy.TabIndex = 31;
            this.btnThemPhieuDangKy.UseVisualStyleBackColor = true;
            this.btnThemPhieuDangKy.Click += new System.EventHandler(this.btnThemPhieuDangKy_Click);
            // 
            // btnQuanLyBaiViet
            // 
            this.btnQuanLyBaiViet.Location = new System.Drawing.Point(842, 191);
            this.btnQuanLyBaiViet.Name = "btnQuanLyBaiViet";
            this.btnQuanLyBaiViet.Size = new System.Drawing.Size(101, 38);
            this.btnQuanLyBaiViet.TabIndex = 28;
            this.btnQuanLyBaiViet.Text = "Quản lý bài viết";
            this.btnQuanLyBaiViet.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyHinhAnh
            // 
            this.btnQuanLyHinhAnh.Location = new System.Drawing.Point(702, 191);
            this.btnQuanLyHinhAnh.Name = "btnQuanLyHinhAnh";
            this.btnQuanLyHinhAnh.Size = new System.Drawing.Size(113, 38);
            this.btnQuanLyHinhAnh.TabIndex = 28;
            this.btnQuanLyHinhAnh.Text = "Quản lý hình ảnh";
            this.btnQuanLyHinhAnh.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(508, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(325, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(230, 206);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 25;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(417, 87);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuong.TabIndex = 16;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(675, 110);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(184, 20);
            this.txtChiPhi.TabIndex = 16;
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(417, 128);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(121, 20);
            this.txtKichThuoc.TabIndex = 16;
            // 
            // cbViTri
            // 
            this.cbViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Location = new System.Drawing.Point(152, 140);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(121, 21);
            this.cbViTri.TabIndex = 15;
            // 
            // cbBao
            // 
            this.cbBao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBao.FormattingEnabled = true;
            this.cbBao.Location = new System.Drawing.Point(416, 46);
            this.cbBao.Name = "cbBao";
            this.cbBao.Size = new System.Drawing.Size(121, 21);
            this.cbBao.TabIndex = 15;
            // 
            // cbLoaiQuangCao
            // 
            this.cbLoaiQuangCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiQuangCao.FormattingEnabled = true;
            this.cbLoaiQuangCao.Location = new System.Drawing.Point(152, 104);
            this.cbLoaiQuangCao.Name = "cbLoaiQuangCao";
            this.cbLoaiQuangCao.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiQuangCao.TabIndex = 15;
            // 
            // cbMaPhieuDangKy
            // 
            this.cbMaPhieuDangKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieuDangKy.FormattingEnabled = true;
            this.cbMaPhieuDangKy.Location = new System.Drawing.Point(152, 72);
            this.cbMaPhieuDangKy.Name = "cbMaPhieuDangKy";
            this.cbMaPhieuDangKy.Size = new System.Drawing.Size(121, 21);
            this.cbMaPhieuDangKy.TabIndex = 14;
            // 
            // txtMaChiTietQuangCao
            // 
            this.txtMaChiTietQuangCao.Enabled = false;
            this.txtMaChiTietQuangCao.Location = new System.Drawing.Point(152, 36);
            this.txtMaChiTietQuangCao.Name = "txtMaChiTietQuangCao";
            this.txtMaChiTietQuangCao.Size = new System.Drawing.Size(121, 20);
            this.txtMaChiTietQuangCao.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chi phí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Báo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Vị trí:";
            // 
            // FormChiTietQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSanh);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormChiTietQuangCao";
            this.Text = "Chi tiết quảng cáo";
            this.Load += new System.EventHandler(this.FormChiTietQuangCao_Load);
            this.gbDanhSanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietQuangCao)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbDanhSanh;
        private System.Windows.Forms.DataGridView dgvChiTietQuangCao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnThemViTri;
        private System.Windows.Forms.Button btnThemLoaiQuangCao;
        private System.Windows.Forms.Button btnThemPhieuDangKy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.ComboBox cbViTri;
        private System.Windows.Forms.ComboBox cbLoaiQuangCao;
        private System.Windows.Forms.ComboBox cbMaPhieuDangKy;
        private System.Windows.Forms.TextBox txtMaChiTietQuangCao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaPhieuDangKy;
        private System.Windows.Forms.Button btnThemBao;
        private System.Windows.Forms.ComboBox cbBao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbDaKiemDuyet;
        private System.Windows.Forms.RadioButton rbChuaKiemDuyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQuanLyBaiViet;
        private System.Windows.Forms.Button btnQuanLyHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhatHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
    }
}