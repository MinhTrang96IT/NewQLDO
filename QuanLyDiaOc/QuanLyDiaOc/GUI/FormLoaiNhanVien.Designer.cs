namespace QuanLyDiaOc.GUI
{
    partial class FormLoaiNhanVien
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
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dgvLoaiNhanVien = new System.Windows.Forms.DataGridView();
            this.MaLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaLoaiNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLoaiNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNhanVien)).BeginInit();
            this.gbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Controls.Add(this.dgvLoaiNhanVien);
            this.gbDanhSachKH.Location = new System.Drawing.Point(185, 269);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 7;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách loại nhân viên";
            // 
            // dgvLoaiNhanVien
            // 
            this.dgvLoaiNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoaiNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNhanVien,
            this.TenLoaiNhanVien,
            this.MoTaLoaiNhanVien});
            this.dgvLoaiNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgvLoaiNhanVien.Name = "dgvLoaiNhanVien";
            this.dgvLoaiNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNhanVien.Size = new System.Drawing.Size(967, 309);
            this.dgvLoaiNhanVien.TabIndex = 0;
            this.dgvLoaiNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiNhanVien_CellClick);
            // 
            // MaLoaiNhanVien
            // 
            this.MaLoaiNhanVien.DataPropertyName = "MaLoaiNhanVien";
            this.MaLoaiNhanVien.HeaderText = "Mã loại nhân viên";
            this.MaLoaiNhanVien.Name = "MaLoaiNhanVien";
            this.MaLoaiNhanVien.Width = 88;
            // 
            // TenLoaiNhanVien
            // 
            this.TenLoaiNhanVien.DataPropertyName = "TenLoaiNhanVien";
            this.TenLoaiNhanVien.HeaderText = "Tên Loại Nhân viên";
            this.TenLoaiNhanVien.Name = "TenLoaiNhanVien";
            this.TenLoaiNhanVien.Width = 97;
            // 
            // MoTaLoaiNhanVien
            // 
            this.MoTaLoaiNhanVien.DataPropertyName = "MoTaLoaiNhanVien";
            this.MoTaLoaiNhanVien.HeaderText = "Mô tả";
            this.MoTaLoaiNhanVien.Name = "MoTaLoaiNhanVien";
            this.MoTaLoaiNhanVien.Width = 47;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(204, 182);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(686, 184);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(480, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(386, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(296, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(446, 54);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtMaLoaiNhanVien
            // 
            this.txtMaLoaiNhanVien.Enabled = false;
            this.txtMaLoaiNhanVien.Location = new System.Drawing.Point(234, 64);
            this.txtMaLoaiNhanVien.Name = "txtMaLoaiNhanVien";
            this.txtMaLoaiNhanVien.Size = new System.Drawing.Size(139, 20);
            this.txtMaLoaiNhanVien.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại nhân viên:";
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Controls.Add(this.label9);
            this.gbThongTinKH.Controls.Add(this.txtTimKiem);
            this.gbThongTinKH.Controls.Add(this.btnTaoMoi);
            this.gbThongTinKH.Controls.Add(this.btnSua);
            this.gbThongTinKH.Controls.Add(this.btnXoa);
            this.gbThongTinKH.Controls.Add(this.btnThem);
            this.gbThongTinKH.Controls.Add(this.txtMoTa);
            this.gbThongTinKH.Controls.Add(this.txtTenLoaiNhanVien);
            this.gbThongTinKH.Controls.Add(this.txtMaLoaiNhanVien);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(185, 11);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 6;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin loại nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(667, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTenLoaiNhanVien
            // 
            this.txtTenLoaiNhanVien.Location = new System.Drawing.Point(234, 108);
            this.txtTenLoaiNhanVien.Name = "txtTenLoaiNhanVien";
            this.txtTenLoaiNhanVien.Size = new System.Drawing.Size(139, 20);
            this.txtTenLoaiNhanVien.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // FormLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachKH);
            this.Controls.Add(this.gbThongTinKH);
            this.Name = "FormLoaiNhanVien";
            this.Text = "FormLoaiNhanVien";
            this.Load += new System.EventHandler(this.FormLoaiNhanVien_Load);
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNhanVien)).EndInit();
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvLoaiNhanVien;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaLoaiNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.TextBox txtTenLoaiNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaLoaiNhanVien;
    }
}