namespace QuanLyDiaOc.GUI
{
    partial class FormLoaiDiaOc
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
            this.dgvLoaiDiaOc = new System.Windows.Forms.DataGridView();
            this.MaLoaiDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiDiaOc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiDiaOc = new System.Windows.Forms.TextBox();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDiaOc)).BeginInit();
            this.gbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Controls.Add(this.dgvLoaiDiaOc);
            this.gbDanhSachKH.Location = new System.Drawing.Point(185, 269);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 3;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách loại địa ốc";
            // 
            // dgvLoaiDiaOc
            // 
            this.dgvLoaiDiaOc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoaiDiaOc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDiaOc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDiaOc,
            this.TenLoaiDiaOc,
            this.MoTa});
            this.dgvLoaiDiaOc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiDiaOc.Location = new System.Drawing.Point(3, 16);
            this.dgvLoaiDiaOc.Name = "dgvLoaiDiaOc";
            this.dgvLoaiDiaOc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDiaOc.Size = new System.Drawing.Size(967, 309);
            this.dgvLoaiDiaOc.TabIndex = 0;
            this.dgvLoaiDiaOc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDiaOc_CellClick);
            // 
            // MaLoaiDiaOc
            // 
            this.MaLoaiDiaOc.DataPropertyName = "MaLoaiDiaOc";
            this.MaLoaiDiaOc.HeaderText = "Mã loại địa ốc";
            this.MaLoaiDiaOc.Name = "MaLoaiDiaOc";
            this.MaLoaiDiaOc.Width = 80;
            // 
            // TenLoaiDiaOc
            // 
            this.TenLoaiDiaOc.DataPropertyName = "TenLoaiDiaOc";
            this.TenLoaiDiaOc.HeaderText = "Tên Loại Địa Ốc";
            this.TenLoaiDiaOc.Name = "TenLoaiDiaOc";
            this.TenLoaiDiaOc.Width = 88;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(674, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(693, 184);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(211, 182);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(487, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(393, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(303, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(453, 54);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtTenLoaiDiaOc
            // 
            this.txtTenLoaiDiaOc.Location = new System.Drawing.Point(241, 108);
            this.txtTenLoaiDiaOc.Name = "txtTenLoaiDiaOc";
            this.txtTenLoaiDiaOc.Size = new System.Drawing.Size(139, 20);
            this.txtTenLoaiDiaOc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại địa ốc:";
            // 
            // txtMaLoaiDiaOc
            // 
            this.txtMaLoaiDiaOc.Enabled = false;
            this.txtMaLoaiDiaOc.Location = new System.Drawing.Point(241, 64);
            this.txtMaLoaiDiaOc.Name = "txtMaLoaiDiaOc";
            this.txtMaLoaiDiaOc.Size = new System.Drawing.Size(139, 20);
            this.txtMaLoaiDiaOc.TabIndex = 7;
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
            this.gbThongTinKH.Controls.Add(this.txtTenLoaiDiaOc);
            this.gbThongTinKH.Controls.Add(this.txtMaLoaiDiaOc);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(185, 11);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 2;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin loại địa ốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại địa ốc:";
            // 
            // FormLoaiDiaOc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachKH);
            this.Controls.Add(this.gbThongTinKH);
            this.Name = "FormLoaiDiaOc";
            this.Text = "FormLoaiDiaOc";
            this.Load += new System.EventHandler(this.FormLoaiDiaOc_Load);
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDiaOc)).EndInit();
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvLoaiDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenLoaiDiaOc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiDiaOc;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}