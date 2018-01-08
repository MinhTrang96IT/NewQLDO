namespace QuanLyDiaOc.GUI
{
    partial class FormPhieuGiaHan
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
            this.rbDaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbChuaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dgvPhieuGiaHan = new System.Windows.Forms.DataGridView();
            this.MaPhieuGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoKhongDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemMaPhieuDangKy = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbMaPhieuDangKy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnHuyDichVu = new System.Windows.Forms.Button();
            this.btnXuatHopDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.txtMaPhieuDangKy = new System.Windows.Forms.TextBox();
            this.txtPhanTramGiaHan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuGiaHan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).BeginInit();
            this.gbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDaKiemDuyet
            // 
            this.rbDaKiemDuyet.AutoSize = true;
            this.rbDaKiemDuyet.Enabled = false;
            this.rbDaKiemDuyet.Location = new System.Drawing.Point(863, 58);
            this.rbDaKiemDuyet.Name = "rbDaKiemDuyet";
            this.rbDaKiemDuyet.Size = new System.Drawing.Size(93, 17);
            this.rbDaKiemDuyet.TabIndex = 52;
            this.rbDaKiemDuyet.Text = "Đã kiểm duyệt";
            this.rbDaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbChuaKiemDuyet
            // 
            this.rbChuaKiemDuyet.AutoSize = true;
            this.rbChuaKiemDuyet.Checked = true;
            this.rbChuaKiemDuyet.Enabled = false;
            this.rbChuaKiemDuyet.Location = new System.Drawing.Point(749, 58);
            this.rbChuaKiemDuyet.Name = "rbChuaKiemDuyet";
            this.rbChuaKiemDuyet.Size = new System.Drawing.Size(104, 17);
            this.rbChuaKiemDuyet.TabIndex = 51;
            this.rbChuaKiemDuyet.TabStop = true;
            this.rbChuaKiemDuyet.Text = "Chưa kiểm duyệt";
            this.rbChuaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Trạng thái:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(431, 85);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(190, 20);
            this.dtpNgayKetThuc.TabIndex = 47;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(431, 57);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(190, 20);
            this.dtpNgayBatDau.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(123, 146);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(184, 20);
            this.dtpNgayLapPhieu.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ngày lập phiếu:";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemNhanVien.Location = new System.Drawing.Point(271, 116);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(20, 20);
            this.btnThemNhanVien.TabIndex = 40;
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSachKH.Controls.Add(this.dgvPhieuGiaHan);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 17;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách phiếu gia hạn";
            // 
            // dgvPhieuGiaHan
            // 
            this.dgvPhieuGiaHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhieuGiaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGiaHan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuGiaHan,
            this.MaPhieuDangKy,
            this.TenNhanVien,
            this.NgayLap,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TrangThaiKiemDuyet,
            this.TongTien,
            this.LyDoKhongDuyet});
            this.dgvPhieuGiaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuGiaHan.Location = new System.Drawing.Point(3, 16);
            this.dgvPhieuGiaHan.Name = "dgvPhieuGiaHan";
            this.dgvPhieuGiaHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuGiaHan.Size = new System.Drawing.Size(967, 309);
            this.dgvPhieuGiaHan.TabIndex = 0;
            this.dgvPhieuGiaHan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuGiaHan_CellClick);
            // 
            // MaPhieuGiaHan
            // 
            this.MaPhieuGiaHan.DataPropertyName = "MaPhieuGiaHan";
            this.MaPhieuGiaHan.HeaderText = "Mã phiếu gia hạn";
            this.MaPhieuGiaHan.Name = "MaPhieuGiaHan";
            this.MaPhieuGiaHan.Width = 88;
            // 
            // MaPhieuDangKy
            // 
            this.MaPhieuDangKy.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKy.HeaderText = "Mã phiếu đăng ký";
            this.MaPhieuDangKy.Name = "MaPhieuDangKy";
            this.MaPhieuDangKy.Width = 98;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 93;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 69;
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
            // TrangThaiKiemDuyet
            // 
            this.TrangThaiKiemDuyet.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.HeaderText = "Trạng thái kiểm duyệt";
            this.TrangThaiKiemDuyet.Name = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiKiemDuyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TrangThaiKiemDuyet.Width = 99;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 71;
            // 
            // LyDoKhongDuyet
            // 
            this.LyDoKhongDuyet.DataPropertyName = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.HeaderText = "Lý do không duyệt";
            this.LyDoKhongDuyet.Name = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.Width = 110;
            // 
            // btnThemMaPhieuDangKy
            // 
            this.btnThemMaPhieuDangKy.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemMaPhieuDangKy.Location = new System.Drawing.Point(271, 87);
            this.btnThemMaPhieuDangKy.Name = "btnThemMaPhieuDangKy";
            this.btnThemMaPhieuDangKy.Size = new System.Drawing.Size(20, 20);
            this.btnThemMaPhieuDangKy.TabIndex = 39;
            this.btnThemMaPhieuDangKy.UseVisualStyleBackColor = true;
            this.btnThemMaPhieuDangKy.Click += new System.EventHandler(this.btnThemMaPhieuDangKy_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(123, 116);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(139, 21);
            this.cbNhanVien.TabIndex = 37;
            // 
            // cbMaPhieuDangKy
            // 
            this.cbMaPhieuDangKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieuDangKy.FormattingEnabled = true;
            this.cbMaPhieuDangKy.Location = new System.Drawing.Point(123, 84);
            this.cbMaPhieuDangKy.Name = "cbMaPhieuDangKy";
            this.cbMaPhieuDangKy.Size = new System.Drawing.Size(139, 21);
            this.cbMaPhieuDangKy.TabIndex = 36;
            this.cbMaPhieuDangKy.SelectedIndexChanged += new System.EventHandler(this.cbMaPhieuDangKy_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã phiếu đăng ký:";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(339, 207);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(615, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(521, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(806, 93);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(104, 23);
            this.btnXuatHoaDon.TabIndex = 17;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHuyDichVu
            // 
            this.btnHuyDichVu.Location = new System.Drawing.Point(806, 171);
            this.btnHuyDichVu.Name = "btnHuyDichVu";
            this.btnHuyDichVu.Size = new System.Drawing.Size(104, 23);
            this.btnHuyDichVu.TabIndex = 17;
            this.btnHuyDichVu.Text = "Hủy dịch vụ";
            this.btnHuyDichVu.UseVisualStyleBackColor = true;
            // 
            // btnXuatHopDong
            // 
            this.btnXuatHopDong.Location = new System.Drawing.Point(806, 133);
            this.btnXuatHopDong.Name = "btnXuatHopDong";
            this.btnXuatHopDong.Size = new System.Drawing.Size(104, 23);
            this.btnXuatHopDong.TabIndex = 17;
            this.btnXuatHopDong.Text = "Xuất hợp đồng";
            this.btnXuatHopDong.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(431, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(431, 120);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(190, 20);
            this.txtTongTien.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu gia hạn:";
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbThongTinKH.Controls.Add(this.txtMaPhieuDangKy);
            this.gbThongTinKH.Controls.Add(this.txtPhanTramGiaHan);
            this.gbThongTinKH.Controls.Add(this.label4);
            this.gbThongTinKH.Controls.Add(this.rbDaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.rbChuaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.label10);
            this.gbThongTinKH.Controls.Add(this.dtpNgayKetThuc);
            this.gbThongTinKH.Controls.Add(this.label6);
            this.gbThongTinKH.Controls.Add(this.dtpNgayBatDau);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.dtpNgayLapPhieu);
            this.gbThongTinKH.Controls.Add(this.label7);
            this.gbThongTinKH.Controls.Add(this.btnThemNhanVien);
            this.gbThongTinKH.Controls.Add(this.btnThemMaPhieuDangKy);
            this.gbThongTinKH.Controls.Add(this.cbNhanVien);
            this.gbThongTinKH.Controls.Add(this.cbMaPhieuDangKy);
            this.gbThongTinKH.Controls.Add(this.label14);
            this.gbThongTinKH.Controls.Add(this.label5);
            this.gbThongTinKH.Controls.Add(this.btnTaoMoi);
            this.gbThongTinKH.Controls.Add(this.btnSua);
            this.gbThongTinKH.Controls.Add(this.btnXoa);
            this.gbThongTinKH.Controls.Add(this.btnXuatHoaDon);
            this.gbThongTinKH.Controls.Add(this.btnHuyDichVu);
            this.gbThongTinKH.Controls.Add(this.btnXuatHopDong);
            this.gbThongTinKH.Controls.Add(this.btnThem);
            this.gbThongTinKH.Controls.Add(this.txtTongTien);
            this.gbThongTinKH.Controls.Add(this.txtMaPhieuGiaHan);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 16;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin phiếu gia hạn";
            // 
            // txtMaPhieuDangKy
            // 
            this.txtMaPhieuDangKy.Location = new System.Drawing.Point(123, 84);
            this.txtMaPhieuDangKy.Name = "txtMaPhieuDangKy";
            this.txtMaPhieuDangKy.ReadOnly = true;
            this.txtMaPhieuDangKy.Size = new System.Drawing.Size(139, 20);
            this.txtMaPhieuDangKy.TabIndex = 55;
            // 
            // txtPhanTramGiaHan
            // 
            this.txtPhanTramGiaHan.Enabled = false;
            this.txtPhanTramGiaHan.Location = new System.Drawing.Point(431, 149);
            this.txtPhanTramGiaHan.Name = "txtPhanTramGiaHan";
            this.txtPhanTramGiaHan.Size = new System.Drawing.Size(87, 20);
            this.txtPhanTramGiaHan.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "% Gia hạn:";
            // 
            // txtMaPhieuGiaHan
            // 
            this.txtMaPhieuGiaHan.Enabled = false;
            this.txtMaPhieuGiaHan.Location = new System.Drawing.Point(123, 53);
            this.txtMaPhieuGiaHan.Name = "txtMaPhieuGiaHan";
            this.txtMaPhieuGiaHan.Size = new System.Drawing.Size(139, 20);
            this.txtMaPhieuGiaHan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi phí:";
            // 
            // FormPhieuGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachKH);
            this.Controls.Add(this.gbThongTinKH);
            this.Name = "FormPhieuGiaHan";
            this.Text = "Form Phiếu Gia Hạn";
            this.Load += new System.EventHandler(this.FormPhieuGiaHan_Load);
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiaHan)).EndInit();
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDaKiemDuyet;
        private System.Windows.Forms.RadioButton rbChuaKiemDuyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvPhieuGiaHan;
        private System.Windows.Forms.Button btnThemMaPhieuDangKy;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbMaPhieuDangKy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnHuyDichVu;
        private System.Windows.Forms.Button btnXuatHopDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.TextBox txtMaPhieuGiaHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKhongDuyet;
        private System.Windows.Forms.TextBox txtPhanTramGiaHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieuDangKy;
    }
}