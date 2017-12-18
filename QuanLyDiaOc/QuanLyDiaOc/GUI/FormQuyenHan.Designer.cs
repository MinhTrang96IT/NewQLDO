namespace QuanLyDiaOc.GUI
{
    partial class FormQuyenHan
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
            this.btnSua = new System.Windows.Forms.Button();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenQuyenHan = new System.Windows.Forms.TextBox();
            this.txtMaQuyenHan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuyenHan = new System.Windows.Forms.DataGridView();
            this.MaQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.gbThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenHan)).BeginInit();
            this.gbDanhSachKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(463, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.gbThongTinKH.Controls.Add(this.txtTenQuyenHan);
            this.gbThongTinKH.Controls.Add(this.txtMaQuyenHan);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(185, 11);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 8;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin quyền hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(650, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(669, 184);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(187, 182);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(369, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(279, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(429, 54);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtTenQuyenHan
            // 
            this.txtTenQuyenHan.Location = new System.Drawing.Point(217, 108);
            this.txtTenQuyenHan.Name = "txtTenQuyenHan";
            this.txtTenQuyenHan.Size = new System.Drawing.Size(139, 20);
            this.txtTenQuyenHan.TabIndex = 8;
            // 
            // txtMaQuyenHan
            // 
            this.txtMaQuyenHan.Enabled = false;
            this.txtMaQuyenHan.Location = new System.Drawing.Point(217, 64);
            this.txtMaQuyenHan.Name = "txtMaQuyenHan";
            this.txtMaQuyenHan.Size = new System.Drawing.Size(139, 20);
            this.txtMaQuyenHan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên quyền hạn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quyền hạn:";
            // 
            // dgvQuyenHan
            // 
            this.dgvQuyenHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuyenHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyenHan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuyenHan,
            this.TenQuyenHan,
            this.MoTaQuyenHan});
            this.dgvQuyenHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuyenHan.Location = new System.Drawing.Point(3, 16);
            this.dgvQuyenHan.Name = "dgvQuyenHan";
            this.dgvQuyenHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuyenHan.Size = new System.Drawing.Size(967, 309);
            this.dgvQuyenHan.TabIndex = 0;
            this.dgvQuyenHan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyenHan_CellClick);
            // 
            // MaQuyenHan
            // 
            this.MaQuyenHan.DataPropertyName = "MaQuyenHan";
            this.MaQuyenHan.HeaderText = "Mã quyền hạn";
            this.MaQuyenHan.Name = "MaQuyenHan";
            this.MaQuyenHan.Width = 92;
            // 
            // TenQuyenHan
            // 
            this.TenQuyenHan.DataPropertyName = "TenQuyenHan";
            this.TenQuyenHan.HeaderText = "Tên quyền hạn";
            this.TenQuyenHan.Name = "TenQuyenHan";
            this.TenQuyenHan.Width = 96;
            // 
            // MoTaQuyenHan
            // 
            this.MoTaQuyenHan.DataPropertyName = "MoTaQuyenHan";
            this.MoTaQuyenHan.HeaderText = "Mô tả";
            this.MoTaQuyenHan.Name = "MoTaQuyenHan";
            this.MoTaQuyenHan.Width = 47;
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Controls.Add(this.dgvQuyenHan);
            this.gbDanhSachKH.Location = new System.Drawing.Point(185, 269);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 9;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách quyền hạn";
            // 
            // FormQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.gbDanhSachKH);
            this.Name = "FormQuyenHan";
            this.Text = "FormQuyenHan";
            this.Load += new System.EventHandler(this.FormQuyenHan_Load);
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenHan)).EndInit();
            this.gbDanhSachKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenQuyenHan;
        private System.Windows.Forms.TextBox txtMaQuyenHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuyenHan;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyenHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyenHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaQuyenHan;
    }
}