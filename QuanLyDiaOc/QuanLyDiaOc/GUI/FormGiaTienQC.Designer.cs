namespace QuanLyDiaOc.GUI
{
    partial class FormGiaTienQC
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
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtKichCoToiDa = new System.Windows.Forms.TextBox();
            this.txtKichCoToiThieu = new System.Windows.Forms.TextBox();
            this.txtSoLuongToiThieu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.gbDanhSanh = new System.Windows.Forms.GroupBox();
            this.dgvGiaTienQC = new System.Windows.Forms.DataGridView();
            this.MaGiaTienQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhatHanhToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhatHanhToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCoToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCoToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnThemViTri = new System.Windows.Forms.Button();
            this.btnThemLoaiQuangCao = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtSoLuongToiDa = new System.Windows.Forms.TextBox();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.cbLoaiQuangCao = new System.Windows.Forms.ComboBox();
            this.txtMaGiaTienQC = new System.Windows.Forms.TextBox();
            this.gbDanhSanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaTienQC)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(756, 37);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 21;
            // 
            // txtKichCoToiDa
            // 
            this.txtKichCoToiDa.Location = new System.Drawing.Point(755, 110);
            this.txtKichCoToiDa.Name = "txtKichCoToiDa";
            this.txtKichCoToiDa.Size = new System.Drawing.Size(121, 20);
            this.txtKichCoToiDa.TabIndex = 18;
            // 
            // txtKichCoToiThieu
            // 
            this.txtKichCoToiThieu.Location = new System.Drawing.Point(755, 75);
            this.txtKichCoToiThieu.Name = "txtKichCoToiThieu";
            this.txtKichCoToiThieu.Size = new System.Drawing.Size(121, 20);
            this.txtKichCoToiThieu.TabIndex = 18;
            // 
            // txtSoLuongToiThieu
            // 
            this.txtSoLuongToiThieu.Location = new System.Drawing.Point(491, 44);
            this.txtSoLuongToiThieu.Name = "txtSoLuongToiThieu";
            this.txtSoLuongToiThieu.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongToiThieu.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(699, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kích cỡ tối đa:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Số lượng phát hành tối thiểu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kích cỡ tối thiểu:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(358, 87);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(133, 13);
            this.d.TabIndex = 4;
            this.d.Text = "Số lượng phát hành tối đa:";
            // 
            // gbDanhSanh
            // 
            this.gbDanhSanh.Controls.Add(this.dgvGiaTienQC);
            this.gbDanhSanh.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSanh.Name = "gbDanhSanh";
            this.gbDanhSanh.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSanh.TabIndex = 5;
            this.gbDanhSanh.TabStop = false;
            this.gbDanhSanh.Text = "Danh sách giá tiền quảng cáo";
            // 
            // dgvGiaTienQC
            // 
            this.dgvGiaTienQC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiaTienQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaTienQC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaTienQuangCao,
            this.TenLoaiQuangCao,
            this.TenViTri,
            this.SoLuongPhatHanhToiThieu,
            this.SoLuongPhatHanhToiDa,
            this.KichCoToiThieu,
            this.KichCoToiDa,
            this.DonGia});
            this.dgvGiaTienQC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaTienQC.Location = new System.Drawing.Point(3, 16);
            this.dgvGiaTienQC.Name = "dgvGiaTienQC";
            this.dgvGiaTienQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaTienQC.Size = new System.Drawing.Size(967, 309);
            this.dgvGiaTienQC.TabIndex = 0;
            this.dgvGiaTienQC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaTienQC_CellClick);
            // 
            // MaGiaTienQuangCao
            // 
            this.MaGiaTienQuangCao.DataPropertyName = "MaGiaTienQuangCao";
            this.MaGiaTienQuangCao.HeaderText = "Mã giá tiền QC";
            this.MaGiaTienQuangCao.Name = "MaGiaTienQuangCao";
            this.MaGiaTienQuangCao.Width = 80;
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
            this.TenViTri.HeaderText = "Tên loại vị trí";
            this.TenViTri.Name = "TenViTri";
            this.TenViTri.Width = 78;
            // 
            // SoLuongPhatHanhToiThieu
            // 
            this.SoLuongPhatHanhToiThieu.DataPropertyName = "SoLuongPhatHanhToiThieu";
            this.SoLuongPhatHanhToiThieu.HeaderText = "Số lượng phát hành tối thiểu";
            this.SoLuongPhatHanhToiThieu.Name = "SoLuongPhatHanhToiThieu";
            this.SoLuongPhatHanhToiThieu.Width = 117;
            // 
            // SoLuongPhatHanhToiDa
            // 
            this.SoLuongPhatHanhToiDa.DataPropertyName = "SoLuongPhatHanhToiDa";
            this.SoLuongPhatHanhToiDa.HeaderText = "Số lượng phát hành tối đa";
            this.SoLuongPhatHanhToiDa.Name = "SoLuongPhatHanhToiDa";
            this.SoLuongPhatHanhToiDa.Width = 114;
            // 
            // KichCoToiThieu
            // 
            this.KichCoToiThieu.DataPropertyName = "KichCoToiThieu";
            this.KichCoToiThieu.HeaderText = "Kích cỡ tối thiểu";
            this.KichCoToiThieu.Name = "KichCoToiThieu";
            this.KichCoToiThieu.Width = 80;
            // 
            // KichCoToiDa
            // 
            this.KichCoToiDa.DataPropertyName = "KichCoToiDa";
            this.KichCoToiDa.HeaderText = "Kích cỡ tối đa";
            this.KichCoToiDa.Name = "KichCoToiDa";
            this.KichCoToiDa.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại quảng cáo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giá tiền QC:";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnThemViTri);
            this.gbThongTin.Controls.Add(this.btnThemLoaiQuangCao);
            this.gbThongTin.Controls.Add(this.label13);
            this.gbThongTin.Controls.Add(this.txtTimKiem);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.btnTaoMoi);
            this.gbThongTin.Controls.Add(this.txtDonGia);
            this.gbThongTin.Controls.Add(this.txtKichCoToiDa);
            this.gbThongTin.Controls.Add(this.txtKichCoToiThieu);
            this.gbThongTin.Controls.Add(this.txtSoLuongToiThieu);
            this.gbThongTin.Controls.Add(this.txtSoLuongToiDa);
            this.gbThongTin.Controls.Add(this.cbViTri);
            this.gbThongTin.Controls.Add(this.cbLoaiQuangCao);
            this.gbThongTin.Controls.Add(this.txtMaGiaTienQC);
            this.gbThongTin.Controls.Add(this.label16);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.label15);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.d);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Location = new System.Drawing.Point(105, 8);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(973, 245);
            this.gbThongTin.TabIndex = 4;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin giá tiền quảng cáo";
            // 
            // btnThemViTri
            // 
            this.btnThemViTri.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemViTri.Location = new System.Drawing.Point(281, 109);
            this.btnThemViTri.Name = "btnThemViTri";
            this.btnThemViTri.Size = new System.Drawing.Size(20, 20);
            this.btnThemViTri.TabIndex = 32;
            this.btnThemViTri.UseVisualStyleBackColor = true;
            this.btnThemViTri.Click += new System.EventHandler(this.btnThemViTri_Click);
            // 
            // btnThemLoaiQuangCao
            // 
            this.btnThemLoaiQuangCao.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemLoaiQuangCao.Location = new System.Drawing.Point(281, 72);
            this.btnThemLoaiQuangCao.Name = "btnThemLoaiQuangCao";
            this.btnThemLoaiQuangCao.Size = new System.Drawing.Size(20, 20);
            this.btnThemLoaiQuangCao.TabIndex = 31;
            this.btnThemLoaiQuangCao.UseVisualStyleBackColor = true;
            this.btnThemLoaiQuangCao.Click += new System.EventHandler(this.btnThemLoaiQuangCao_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label13.Location = new System.Drawing.Point(668, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(687, 207);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            // txtSoLuongToiDa
            // 
            this.txtSoLuongToiDa.Location = new System.Drawing.Point(492, 85);
            this.txtSoLuongToiDa.Name = "txtSoLuongToiDa";
            this.txtSoLuongToiDa.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongToiDa.TabIndex = 16;
            // 
            // cbViTri
            // 
            this.cbViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Location = new System.Drawing.Point(154, 108);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(121, 21);
            this.cbViTri.TabIndex = 15;
            // 
            // cbLoaiQuangCao
            // 
            this.cbLoaiQuangCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiQuangCao.FormattingEnabled = true;
            this.cbLoaiQuangCao.Location = new System.Drawing.Point(154, 72);
            this.cbLoaiQuangCao.Name = "cbLoaiQuangCao";
            this.cbLoaiQuangCao.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiQuangCao.TabIndex = 14;
            // 
            // txtMaGiaTienQC
            // 
            this.txtMaGiaTienQC.Enabled = false;
            this.txtMaGiaTienQC.Location = new System.Drawing.Point(154, 40);
            this.txtMaGiaTienQC.Name = "txtMaGiaTienQC";
            this.txtMaGiaTienQC.Size = new System.Drawing.Size(121, 20);
            this.txtMaGiaTienQC.TabIndex = 12;
            // 
            // FormGiaTienQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSanh);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormGiaTienQC";
            this.Text = "Form Giá Tiền Quảng Cáo";
            this.Load += new System.EventHandler(this.FormGiaTienQC_Load);
            this.gbDanhSanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaTienQC)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtKichCoToiDa;
        private System.Windows.Forms.TextBox txtKichCoToiThieu;
        private System.Windows.Forms.TextBox txtSoLuongToiThieu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.GroupBox gbDanhSanh;
        private System.Windows.Forms.DataGridView dgvGiaTienQC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnThemViTri;
        private System.Windows.Forms.Button btnThemLoaiQuangCao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtSoLuongToiDa;
        private System.Windows.Forms.ComboBox cbViTri;
        private System.Windows.Forms.ComboBox cbLoaiQuangCao;
        private System.Windows.Forms.TextBox txtMaGiaTienQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaTienQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhatHanhToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhatHanhToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCoToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCoToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}