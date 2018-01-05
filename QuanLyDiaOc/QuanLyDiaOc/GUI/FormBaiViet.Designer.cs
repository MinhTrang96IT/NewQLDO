namespace QuanLyDiaOc.GUI
{
    partial class FormBaiViet
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
            this.txtMaChiTietQuangCao = new System.Windows.Forms.TextBox();
            this.rbDaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.rbChuaKiemDuyet = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnThemChiTietQuangCao = new System.Windows.Forms.Button();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChiTietQuangCao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNoiDungBaiViet = new System.Windows.Forms.TextBox();
            this.txtMaBaiViet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dgvBaiViet = new System.Windows.Forms.DataGridView();
            this.MaBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiTietQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDungBaiViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiKiemDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LyDoKhongDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinKH.SuspendLayout();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiViet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Controls.Add(this.txtMaChiTietQuangCao);
            this.gbThongTinKH.Controls.Add(this.rbDaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.rbChuaKiemDuyet);
            this.gbThongTinKH.Controls.Add(this.label6);
            this.gbThongTinKH.Controls.Add(this.btnThemNhanVien);
            this.gbThongTinKH.Controls.Add(this.btnThemChiTietQuangCao);
            this.gbThongTinKH.Controls.Add(this.cbNhanVien);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.cbChiTietQuangCao);
            this.gbThongTinKH.Controls.Add(this.label4);
            this.gbThongTinKH.Controls.Add(this.btnTaoMoi);
            this.gbThongTinKH.Controls.Add(this.btnSua);
            this.gbThongTinKH.Controls.Add(this.btnXoa);
            this.gbThongTinKH.Controls.Add(this.btnThem);
            this.gbThongTinKH.Controls.Add(this.txtNoiDungBaiViet);
            this.gbThongTinKH.Controls.Add(this.txtMaBaiViet);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 14;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin bài viết";
            // 
            // txtMaChiTietQuangCao
            // 
            this.txtMaChiTietQuangCao.Location = new System.Drawing.Point(145, 83);
            this.txtMaChiTietQuangCao.Name = "txtMaChiTietQuangCao";
            this.txtMaChiTietQuangCao.ReadOnly = true;
            this.txtMaChiTietQuangCao.Size = new System.Drawing.Size(139, 20);
            this.txtMaChiTietQuangCao.TabIndex = 42;
            // 
            // rbDaKiemDuyet
            // 
            this.rbDaKiemDuyet.AutoSize = true;
            this.rbDaKiemDuyet.Location = new System.Drawing.Point(237, 152);
            this.rbDaKiemDuyet.Name = "rbDaKiemDuyet";
            this.rbDaKiemDuyet.Size = new System.Drawing.Size(93, 17);
            this.rbDaKiemDuyet.TabIndex = 41;
            this.rbDaKiemDuyet.Text = "Đã kiểm duyệt";
            this.rbDaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // rbChuaKiemDuyet
            // 
            this.rbChuaKiemDuyet.AutoSize = true;
            this.rbChuaKiemDuyet.Checked = true;
            this.rbChuaKiemDuyet.Location = new System.Drawing.Point(125, 152);
            this.rbChuaKiemDuyet.Name = "rbChuaKiemDuyet";
            this.rbChuaKiemDuyet.Size = new System.Drawing.Size(104, 17);
            this.rbChuaKiemDuyet.TabIndex = 40;
            this.rbChuaKiemDuyet.TabStop = true;
            this.rbChuaKiemDuyet.Text = "Chưa kiểm duyệt";
            this.rbChuaKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Trạng thái:";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemNhanVien.Location = new System.Drawing.Point(296, 114);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(20, 20);
            this.btnThemNhanVien.TabIndex = 34;
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnThemChiTietQuangCao
            // 
            this.btnThemChiTietQuangCao.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemChiTietQuangCao.Location = new System.Drawing.Point(296, 83);
            this.btnThemChiTietQuangCao.Name = "btnThemChiTietQuangCao";
            this.btnThemChiTietQuangCao.Size = new System.Drawing.Size(20, 20);
            this.btnThemChiTietQuangCao.TabIndex = 34;
            this.btnThemChiTietQuangCao.UseVisualStyleBackColor = true;
            this.btnThemChiTietQuangCao.Click += new System.EventHandler(this.btnThemChiTietQuangCao_Click);
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(145, 112);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(139, 21);
            this.cbNhanVien.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nhân viên:";
            // 
            // cbChiTietQuangCao
            // 
            this.cbChiTietQuangCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiTietQuangCao.FormattingEnabled = true;
            this.cbChiTietQuangCao.Location = new System.Drawing.Point(145, 81);
            this.cbChiTietQuangCao.Name = "cbChiTietQuangCao";
            this.cbChiTietQuangCao.Size = new System.Drawing.Size(139, 21);
            this.cbChiTietQuangCao.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã chi tiết quảng cáo:";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(21, 197);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(293, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(201, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(111, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNoiDungBaiViet
            // 
            this.txtNoiDungBaiViet.Location = new System.Drawing.Point(398, 19);
            this.txtNoiDungBaiViet.Multiline = true;
            this.txtNoiDungBaiViet.Name = "txtNoiDungBaiViet";
            this.txtNoiDungBaiViet.Size = new System.Drawing.Size(560, 208);
            this.txtNoiDungBaiViet.TabIndex = 13;
            // 
            // txtMaBaiViet
            // 
            this.txtMaBaiViet.Enabled = false;
            this.txtMaBaiViet.Location = new System.Drawing.Point(145, 47);
            this.txtMaBaiViet.Name = "txtMaBaiViet";
            this.txtMaBaiViet.Size = new System.Drawing.Size(139, 20);
            this.txtMaBaiViet.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội dung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bài viết:";
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Controls.Add(this.dgvBaiViet);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 15;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách bài viết";
            // 
            // dgvBaiViet
            // 
            this.dgvBaiViet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBaiViet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiViet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaiViet,
            this.MaChiTietQuangCao,
            this.TenNhanVien,
            this.NoiDungBaiViet,
            this.TrangThaiKiemDuyet,
            this.LyDoKhongDuyet});
            this.dgvBaiViet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaiViet.Location = new System.Drawing.Point(3, 16);
            this.dgvBaiViet.Name = "dgvBaiViet";
            this.dgvBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaiViet.Size = new System.Drawing.Size(967, 309);
            this.dgvBaiViet.TabIndex = 0;
            this.dgvBaiViet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaiViet_CellClick);
            // 
            // MaBaiViet
            // 
            this.MaBaiViet.DataPropertyName = "MaBaiViet";
            this.MaBaiViet.HeaderText = "Mã bài viết";
            this.MaBaiViet.Name = "MaBaiViet";
            this.MaBaiViet.Width = 78;
            // 
            // MaChiTietQuangCao
            // 
            this.MaChiTietQuangCao.DataPropertyName = "MaChiTietQuangCao";
            this.MaChiTietQuangCao.HeaderText = "Mã chi tiết quảng cáo";
            this.MaChiTietQuangCao.Name = "MaChiTietQuangCao";
            this.MaChiTietQuangCao.Width = 107;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 93;
            // 
            // NoiDungBaiViet
            // 
            this.NoiDungBaiViet.DataPropertyName = "NoiDungBaiViet";
            this.NoiDungBaiViet.HeaderText = "Nội dung bài viết";
            this.NoiDungBaiViet.Name = "NoiDungBaiViet";
            this.NoiDungBaiViet.Width = 87;
            // 
            // TrangThaiKiemDuyet
            // 
            this.TrangThaiKiemDuyet.DataPropertyName = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.HeaderText = "Trạng thái kiểm duyệt";
            this.TrangThaiKiemDuyet.Name = "TrangThaiKiemDuyet";
            this.TrangThaiKiemDuyet.Width = 80;
            // 
            // LyDoKhongDuyet
            // 
            this.LyDoKhongDuyet.DataPropertyName = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.HeaderText = "Lý do không duyệt";
            this.LyDoKhongDuyet.Name = "LyDoKhongDuyet";
            this.LyDoKhongDuyet.Width = 110;
            // 
            // FormBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.gbDanhSachKH);
            this.Name = "FormBaiViet";
            this.Text = "Form Bài Viết";
            this.Load += new System.EventHandler(this.FormBaiViet_Load);
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiViet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNoiDungBaiViet;
        private System.Windows.Forms.TextBox txtMaBaiViet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvBaiViet;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnThemChiTietQuangCao;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChiTietQuangCao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDaKiemDuyet;
        private System.Windows.Forms.RadioButton rbChuaKiemDuyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaiViet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDungBaiViet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiKiemDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKhongDuyet;
        private System.Windows.Forms.TextBox txtMaChiTietQuangCao;
    }
}