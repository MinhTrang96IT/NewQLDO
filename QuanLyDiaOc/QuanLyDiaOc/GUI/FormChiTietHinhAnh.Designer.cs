namespace QuanLyDiaOc.GUI
{
    partial class FormChiTietHinhAnh
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
            this.gbChiTietHinhAnh = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.cbMaHA = new System.Windows.Forms.ComboBox();
            this.btnChonHA = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnThemMaHA = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHinhAnh = new System.Windows.Forms.DataGridView();
            this.MaChiTietHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChiTietHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChiTietHinhAnh
            // 
            this.gbChiTietHinhAnh.Controls.Add(this.btnSua);
            this.gbChiTietHinhAnh.Controls.Add(this.btnXoa);
            this.gbChiTietHinhAnh.Controls.Add(this.btnTaoMoi);
            this.gbChiTietHinhAnh.Controls.Add(this.cbMaHA);
            this.gbChiTietHinhAnh.Controls.Add(this.btnChonHA);
            this.gbChiTietHinhAnh.Controls.Add(this.btnThem);
            this.gbChiTietHinhAnh.Controls.Add(this.pbHinhAnh);
            this.gbChiTietHinhAnh.Controls.Add(this.btnThemMaHA);
            this.gbChiTietHinhAnh.Controls.Add(this.txtMoTa);
            this.gbChiTietHinhAnh.Controls.Add(this.txtMaChiTiet);
            this.gbChiTietHinhAnh.Controls.Add(this.label4);
            this.gbChiTietHinhAnh.Controls.Add(this.label2);
            this.gbChiTietHinhAnh.Controls.Add(this.label1);
            this.gbChiTietHinhAnh.Location = new System.Drawing.Point(105, 12);
            this.gbChiTietHinhAnh.Name = "gbChiTietHinhAnh";
            this.gbChiTietHinhAnh.Size = new System.Drawing.Size(973, 245);
            this.gbChiTietHinhAnh.TabIndex = 0;
            this.gbChiTietHinhAnh.TabStop = false;
            this.gbChiTietHinhAnh.Text = "Thông tin chi tiết hình ảnh";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(324, 204);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(243, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(81, 204);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 41;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // cbMaHA
            // 
            this.cbMaHA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHA.FormattingEnabled = true;
            this.cbMaHA.Location = new System.Drawing.Point(198, 81);
            this.cbMaHA.Name = "cbMaHA";
            this.cbMaHA.Size = new System.Drawing.Size(127, 21);
            this.cbMaHA.TabIndex = 40;
            // 
            // btnChonHA
            // 
            this.btnChonHA.Location = new System.Drawing.Point(388, 116);
            this.btnChonHA.Name = "btnChonHA";
            this.btnChonHA.Size = new System.Drawing.Size(89, 23);
            this.btnChonHA.TabIndex = 39;
            this.btnChonHA.Text = "Chọn hình ảnh";
            this.btnChonHA.UseVisualStyleBackColor = true;
            this.btnChonHA.Click += new System.EventHandler(this.btnChonHA_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(162, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Location = new System.Drawing.Point(483, 30);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(452, 197);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 37;
            this.pbHinhAnh.TabStop = false;
            // 
            // btnThemMaHA
            // 
            this.btnThemMaHA.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemMaHA.Location = new System.Drawing.Point(331, 82);
            this.btnThemMaHA.Name = "btnThemMaHA";
            this.btnThemMaHA.Size = new System.Drawing.Size(20, 20);
            this.btnThemMaHA.TabIndex = 36;
            this.btnThemMaHA.UseVisualStyleBackColor = true;
            this.btnThemMaHA.Click += new System.EventHandler(this.ThemMaHA_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(198, 118);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(127, 50);
            this.txtMoTa.TabIndex = 7;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Enabled = false;
            this.txtMaChiTiet.Location = new System.Drawing.Point(198, 46);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(127, 20);
            this.txtMaChiTiet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả hình ảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hình ảnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi tiết hình ảnh:";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.dgvChiTietHinhAnh);
            this.gbDanhSach.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSach.TabIndex = 1;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách chi tiết hình ảnh";
            // 
            // dgvChiTietHinhAnh
            // 
            this.dgvChiTietHinhAnh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvChiTietHinhAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHinhAnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietHinhAnh,
            this.HinhAnh,
            this.MaHinhAnh,
            this.MoTaHinhAnh});
            this.dgvChiTietHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHinhAnh.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietHinhAnh.Name = "dgvChiTietHinhAnh";
            this.dgvChiTietHinhAnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHinhAnh.Size = new System.Drawing.Size(967, 309);
            this.dgvChiTietHinhAnh.TabIndex = 0;
            this.dgvChiTietHinhAnh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHinhAnh_CellClick);
            // 
            // MaChiTietHinhAnh
            // 
            this.MaChiTietHinhAnh.DataPropertyName = "MaChiTietHinhAnh";
            this.MaChiTietHinhAnh.HeaderText = "Mã chi tiết hình ảnh";
            this.MaChiTietHinhAnh.Name = "MaChiTietHinhAnh";
            this.MaChiTietHinhAnh.Width = 98;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = false;
            // 
            // MaHinhAnh
            // 
            this.MaHinhAnh.DataPropertyName = "MaHinhAnh";
            this.MaHinhAnh.HeaderText = "Mã hình ảnh";
            this.MaHinhAnh.Name = "MaHinhAnh";
            this.MaHinhAnh.Width = 84;
            // 
            // MoTaHinhAnh
            // 
            this.MoTaHinhAnh.DataPropertyName = "MoTaHinhAnh";
            this.MoTaHinhAnh.HeaderText = "Mô tả hình ảnh";
            this.MoTaHinhAnh.Name = "MoTaHinhAnh";
            this.MoTaHinhAnh.Width = 78;
            // 
            // FormChiTietHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbChiTietHinhAnh);
            this.Name = "FormChiTietHinhAnh";
            this.Text = "FormChiTietHinhAnh";
            this.Load += new System.EventHandler(this.FormChiTietHinhAnh_Load);
            this.gbChiTietHinhAnh.ResumeLayout(false);
            this.gbChiTietHinhAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChiTietHinhAnh;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietHinhAnh;
        private System.Windows.Forms.Button btnThemMaHA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaHinhAnh;
        private System.Windows.Forms.Button btnChonHA;
        private System.Windows.Forms.ComboBox cbMaHA;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
    }
}