namespace QuanLyDiaOc.GUI
{
    partial class FormHuyDangKy
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
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLyDoNgung = new System.Windows.Forms.TextBox();
            this.txtMaNgungDichVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dgvHuyDangKy = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbMaPhieuDangKy = new System.Windows.Forms.ComboBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbChuaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.MaPhieuNgungDangKyDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbThongTinKH.SuspendLayout();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Controls.Add(this.rbDaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.rbChuaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.label6);
            this.gbThongTinKH.Controls.Add(this.dtpNgayLapPhieu);
            this.gbThongTinKH.Controls.Add(this.cbMaPhieuDangKy);
            this.gbThongTinKH.Controls.Add(this.btnThemNhanVien);
            this.gbThongTinKH.Controls.Add(this.cbNhanVien);
            this.gbThongTinKH.Controls.Add(this.label9);
            this.gbThongTinKH.Controls.Add(this.txtTimKiem);
            this.gbThongTinKH.Controls.Add(this.btnTaoMoi);
            this.gbThongTinKH.Controls.Add(this.btnSua);
            this.gbThongTinKH.Controls.Add(this.btnXoa);
            this.gbThongTinKH.Controls.Add(this.btnThem);
            this.gbThongTinKH.Controls.Add(this.txtLyDoNgung);
            this.gbThongTinKH.Controls.Add(this.label5);
            this.gbThongTinKH.Controls.Add(this.txtMaNgungDichVu);
            this.gbThongTinKH.Controls.Add(this.label4);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 14;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin ngưng đăng ký dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(619, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(638, 191);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(168, 192);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(444, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(260, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLyDoNgung
            // 
            this.txtLyDoNgung.Location = new System.Drawing.Point(507, 41);
            this.txtLyDoNgung.Multiline = true;
            this.txtLyDoNgung.Name = "txtLyDoNgung";
            this.txtLyDoNgung.Size = new System.Drawing.Size(379, 81);
            this.txtLyDoNgung.TabIndex = 13;
            // 
            // txtMaNgungDichVu
            // 
            this.txtMaNgungDichVu.Enabled = false;
            this.txtMaNgungDichVu.Location = new System.Drawing.Point(198, 41);
            this.txtMaNgungDichVu.Name = "txtMaNgungDichVu";
            this.txtMaNgungDichVu.Size = new System.Drawing.Size(139, 20);
            this.txtMaNgungDichVu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lý do ngưng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu ngưng:";
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Controls.Add(this.dgvHuyDangKy);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 15;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách phiếu ngưng đăng ký dịch vụ";
            // 
            // dgvHuyDangKy
            // 
            this.dgvHuyDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHuyDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuyDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNgungDangKyDichVu,
            this.MaPhieuDangKy,
            this.TenNhanVien,
            this.NgayLap,
            this.LyDo,
            this.TrangThaiKiemDuyet});
            this.dgvHuyDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuyDangKy.Location = new System.Drawing.Point(3, 16);
            this.dgvHuyDangKy.Name = "dgvHuyDangKy";
            this.dgvHuyDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHuyDangKy.Size = new System.Drawing.Size(967, 309);
            this.dgvHuyDangKy.TabIndex = 0;
            this.dgvHuyDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHuyDangKy_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày lập phiếu:";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemNhanVien.Location = new System.Drawing.Point(350, 112);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(20, 20);
            this.btnThemNhanVien.TabIndex = 33;
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(198, 110);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(139, 21);
            this.cbNhanVien.TabIndex = 32;
            // 
            // cbMaPhieuDangKy
            // 
            this.cbMaPhieuDangKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieuDangKy.FormattingEnabled = true;
            this.cbMaPhieuDangKy.Location = new System.Drawing.Point(198, 74);
            this.cbMaPhieuDangKy.Name = "cbMaPhieuDangKy";
            this.cbMaPhieuDangKy.Size = new System.Drawing.Size(139, 21);
            this.cbMaPhieuDangKy.TabIndex = 34;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(198, 145);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(139, 20);
            this.dtpNgayLapPhieu.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Kiểm duyệt:";
            // 
            // rbDaKiemDuyet
            // 
            this.rbDaKiemDuyet.AutoSize = true;
            this.rbDaKiemDuyet.Location = new System.Drawing.Point(638, 150);
            this.rbDaKiemDuyet.Name = "rbDaKiemDuyet";
            this.rbDaKiemDuyet.Size = new System.Drawing.Size(93, 17);
            this.rbDaKiemDuyet.TabIndex = 38;
            this.rbDaKiemDuyet.Text = "Đã kiểm duyệt";
            this.rbDaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbChuaKiemDuyet
            // 
            this.rbChuaKiemDuyet.AutoSize = true;
            this.rbChuaKiemDuyet.Checked = true;
            this.rbChuaKiemDuyet.Location = new System.Drawing.Point(510, 150);
            this.rbChuaKiemDuyet.Name = "rbChuaKiemDuyet";
            this.rbChuaKiemDuyet.Size = new System.Drawing.Size(104, 17);
            this.rbChuaKiemDuyet.TabIndex = 37;
            this.rbChuaKiemDuyet.TabStop = true;
            this.rbChuaKiemDuyet.Text = "Chưa kiểm duyệt";
            this.rbChuaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // MaPhieuNgungDangKyDichVu
            // 
            this.MaPhieuNgungDangKyDichVu.DataPropertyName = "MaPhieuNgungDangKyDichVu";
            this.MaPhieuNgungDangKyDichVu.HeaderText = "Mã phiếu ngưng";
            this.MaPhieuNgungDangKyDichVu.Name = "MaPhieuNgungDangKyDichVu";
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
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 54;
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
            // FormHuyDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.gbDanhSachKH);
            this.Name = "FormHuyDangKy";
            this.Text = "FormHuyDangKy";
            this.Load += new System.EventHandler(this.FormHuyDangKy_Load);
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLyDoNgung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNgungDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvHuyDangKy;
        private System.Windows.Forms.ComboBox cbMaPhieuDangKy;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.RadioButton rbDaKiemDuyet;
        private System.Windows.Forms.RadioButton rbChuaKiemDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNgungDangKyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
    }
}