namespace QuanLyDiaOc.GUI
{
    partial class FormHinhAnh
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
            this.gbHinhAnh = new System.Windows.Forms.GroupBox();
            this.txtMaPhieuDangKy = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThemPDK = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.dtpNgayChup = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHC = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaPDK = new System.Windows.Forms.ComboBox();
            this.txtMaHA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvHinhAnh = new System.Windows.Forms.DataGridView();
            this.MaHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHenChupAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChupAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHinhAnh.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHinhAnh
            // 
            this.gbHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbHinhAnh.Controls.Add(this.txtMaPhieuDangKy);
            this.gbHinhAnh.Controls.Add(this.btnThemNV);
            this.gbHinhAnh.Controls.Add(this.btnThemPDK);
            this.gbHinhAnh.Controls.Add(this.btnTaoMoi);
            this.gbHinhAnh.Controls.Add(this.btnSua);
            this.gbHinhAnh.Controls.Add(this.btnXoa);
            this.gbHinhAnh.Controls.Add(this.btnThem);
            this.gbHinhAnh.Controls.Add(this.label9);
            this.gbHinhAnh.Controls.Add(this.txtTimKiem);
            this.gbHinhAnh.Controls.Add(this.btnChiTiet);
            this.gbHinhAnh.Controls.Add(this.dtpNgayChup);
            this.gbHinhAnh.Controls.Add(this.dtpNgayHC);
            this.gbHinhAnh.Controls.Add(this.cbMaNV);
            this.gbHinhAnh.Controls.Add(this.cbMaPDK);
            this.gbHinhAnh.Controls.Add(this.txtMaHA);
            this.gbHinhAnh.Controls.Add(this.label5);
            this.gbHinhAnh.Controls.Add(this.label4);
            this.gbHinhAnh.Controls.Add(this.label3);
            this.gbHinhAnh.Controls.Add(this.label2);
            this.gbHinhAnh.Controls.Add(this.label1);
            this.gbHinhAnh.Location = new System.Drawing.Point(105, 8);
            this.gbHinhAnh.Name = "gbHinhAnh";
            this.gbHinhAnh.Size = new System.Drawing.Size(973, 245);
            this.gbHinhAnh.TabIndex = 0;
            this.gbHinhAnh.TabStop = false;
            this.gbHinhAnh.Text = "Thông tin hình ảnh";
            // 
            // txtMaPhieuDangKy
            // 
            this.txtMaPhieuDangKy.Location = new System.Drawing.Point(186, 93);
            this.txtMaPhieuDangKy.Name = "txtMaPhieuDangKy";
            this.txtMaPhieuDangKy.ReadOnly = true;
            this.txtMaPhieuDangKy.Size = new System.Drawing.Size(121, 20);
            this.txtMaPhieuDangKy.TabIndex = 47;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemNV.Location = new System.Drawing.Point(313, 130);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(20, 20);
            this.btnThemNV.TabIndex = 46;
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnThemPDK
            // 
            this.btnThemPDK.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemPDK.Location = new System.Drawing.Point(313, 94);
            this.btnThemPDK.Name = "btnThemPDK";
            this.btnThemPDK.Size = new System.Drawing.Size(20, 20);
            this.btnThemPDK.TabIndex = 45;
            this.btnThemPDK.UseVisualStyleBackColor = true;
            this.btnThemPDK.Click += new System.EventHandler(this.btnThemPDK_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(232, 191);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 44;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(504, 190);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(412, 190);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(322, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(729, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(748, 192);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 39;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(604, 91);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(120, 23);
            this.btnChiTiet.TabIndex = 11;
            this.btnChiTiet.Text = "Xem Chi tiết hình ảnh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // dtpNgayChup
            // 
            this.dtpNgayChup.Location = new System.Drawing.Point(437, 94);
            this.dtpNgayChup.Name = "dtpNgayChup";
            this.dtpNgayChup.Size = new System.Drawing.Size(129, 20);
            this.dtpNgayChup.TabIndex = 10;
            // 
            // dtpNgayHC
            // 
            this.dtpNgayHC.Location = new System.Drawing.Point(437, 55);
            this.dtpNgayHC.Name = "dtpNgayHC";
            this.dtpNgayHC.Size = new System.Drawing.Size(129, 20);
            this.dtpNgayHC.TabIndex = 9;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(186, 131);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(121, 21);
            this.cbMaNV.TabIndex = 8;
            // 
            // cbMaPDK
            // 
            this.cbMaPDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPDK.FormattingEnabled = true;
            this.cbMaPDK.Location = new System.Drawing.Point(186, 93);
            this.cbMaPDK.Name = "cbMaPDK";
            this.cbMaPDK.Size = new System.Drawing.Size(121, 21);
            this.cbMaPDK.TabIndex = 7;
            // 
            // txtMaHA
            // 
            this.txtMaHA.Enabled = false;
            this.txtMaHA.Location = new System.Drawing.Point(186, 55);
            this.txtMaHA.Name = "txtMaHA";
            this.txtMaHA.Size = new System.Drawing.Size(121, 20);
            this.txtMaHA.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày chụp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày hẹn chụp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hình ảnh:";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSach.Controls.Add(this.dgvHinhAnh);
            this.gbDanhSach.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSach.TabIndex = 1;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách hình ảnh";
            // 
            // dgvHinhAnh
            // 
            this.dgvHinhAnh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHinhAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHinhAnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHinhAnh,
            this.MaPhieuDangKy,
            this.MaNhanVien,
            this.NgayHenChupAnh,
            this.NgayChupAnh});
            this.dgvHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHinhAnh.Location = new System.Drawing.Point(3, 16);
            this.dgvHinhAnh.Name = "dgvHinhAnh";
            this.dgvHinhAnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHinhAnh.Size = new System.Drawing.Size(967, 309);
            this.dgvHinhAnh.TabIndex = 0;
            this.dgvHinhAnh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHinhAnh_CellClick);
            // 
            // MaHinhAnh
            // 
            this.MaHinhAnh.DataPropertyName = "MaHinhAnh";
            this.MaHinhAnh.HeaderText = "Mã hình ảnh";
            this.MaHinhAnh.Name = "MaHinhAnh";
            this.MaHinhAnh.Width = 91;
            // 
            // MaPhieuDangKy
            // 
            this.MaPhieuDangKy.DataPropertyName = "MaPhieuDangKy";
            this.MaPhieuDangKy.HeaderText = "Mã phiểu đăng ký";
            this.MaPhieuDangKy.Name = "MaPhieuDangKy";
            this.MaPhieuDangKy.Width = 98;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 89;
            // 
            // NgayHenChupAnh
            // 
            this.NgayHenChupAnh.DataPropertyName = "NgayHenChupAnh";
            this.NgayHenChupAnh.HeaderText = "Ngày hẹn chụp ảnh";
            this.NgayHenChupAnh.Name = "NgayHenChupAnh";
            this.NgayHenChupAnh.Width = 99;
            // 
            // NgayChupAnh
            // 
            this.NgayChupAnh.DataPropertyName = "NgayChupAnh";
            this.NgayChupAnh.HeaderText = "Ngày chụp ảnh";
            this.NgayChupAnh.Name = "NgayChupAnh";
            this.NgayChupAnh.Width = 80;
            // 
            // FormHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbHinhAnh);
            this.Name = "FormHinhAnh";
            this.Text = "Form Hình Ảnh";
            this.Load += new System.EventHandler(this.FormHinhAnh_Load);
            this.gbHinhAnh.ResumeLayout(false);
            this.gbHinhAnh.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHinhAnh;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.DateTimePicker dtpNgayChup;
        private System.Windows.Forms.DateTimePicker dtpNgayHC;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaPDK;
        private System.Windows.Forms.TextBox txtMaHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvHinhAnh;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThemPDK;
        private System.Windows.Forms.TextBox txtMaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHenChupAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChupAnh;
    }
}