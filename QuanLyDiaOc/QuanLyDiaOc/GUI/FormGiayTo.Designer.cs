namespace QuanLyDiaOc.GUI
{
    partial class FormGiayTo
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.cbMaDO = new System.Windows.Forms.ComboBox();
            this.btnChonHA = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnThemMaHA = new System.Windows.Forms.Button();
            this.txtTenGiayTo = new System.Windows.Forms.TextBox();
            this.txtMaGiayTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvGiayTo = new System.Windows.Forms.DataGridView();
            this.MaGiayTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanGiayTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaOc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiayTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiayTo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnTaoMoi);
            this.gbThongTin.Controls.Add(this.cbMaDO);
            this.gbThongTin.Controls.Add(this.btnChonHA);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.pbHinhAnh);
            this.gbThongTin.Controls.Add(this.btnThemMaHA);
            this.gbThongTin.Controls.Add(this.txtTenGiayTo);
            this.gbThongTin.Controls.Add(this.txtMaGiayTo);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Location = new System.Drawing.Point(105, 8);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(973, 245);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin giấy tờ";
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
            // cbMaDO
            // 
            this.cbMaDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDO.FormattingEnabled = true;
            this.cbMaDO.Location = new System.Drawing.Point(198, 95);
            this.cbMaDO.Name = "cbMaDO";
            this.cbMaDO.Size = new System.Drawing.Size(127, 21);
            this.cbMaDO.TabIndex = 40;
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
            this.btnThemMaHA.Location = new System.Drawing.Point(331, 96);
            this.btnThemMaHA.Name = "btnThemMaHA";
            this.btnThemMaHA.Size = new System.Drawing.Size(20, 20);
            this.btnThemMaHA.TabIndex = 36;
            this.btnThemMaHA.UseVisualStyleBackColor = true;
            // 
            // txtTenGiayTo
            // 
            this.txtTenGiayTo.Location = new System.Drawing.Point(198, 132);
            this.txtTenGiayTo.Name = "txtTenGiayTo";
            this.txtTenGiayTo.Size = new System.Drawing.Size(127, 20);
            this.txtTenGiayTo.TabIndex = 7;
            // 
            // txtMaGiayTo
            // 
            this.txtMaGiayTo.Enabled = false;
            this.txtMaGiayTo.Location = new System.Drawing.Point(198, 60);
            this.txtMaGiayTo.Name = "txtMaGiayTo";
            this.txtMaGiayTo.Size = new System.Drawing.Size(127, 20);
            this.txtMaGiayTo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên giấy tờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã địa ốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giấy tờ:";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSach.Controls.Add(this.dgvGiayTo);
            this.gbDanhSach.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSach.TabIndex = 2;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách giấy tờ";
            // 
            // dgvGiayTo
            // 
            this.dgvGiayTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiayTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiayTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiayTo,
            this.ScanGiayTo,
            this.MaDiaOc,
            this.TenGiayTo});
            this.dgvGiayTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiayTo.Location = new System.Drawing.Point(3, 16);
            this.dgvGiayTo.Name = "dgvGiayTo";
            this.dgvGiayTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiayTo.Size = new System.Drawing.Size(967, 309);
            this.dgvGiayTo.TabIndex = 0;
            this.dgvGiayTo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiayTo_CellClick);
            // 
            // MaGiayTo
            // 
            this.MaGiayTo.DataPropertyName = "MaGiayTo";
            this.MaGiayTo.HeaderText = "Mã giấy tờ";
            this.MaGiayTo.Name = "MaGiayTo";
            this.MaGiayTo.Width = 81;
            // 
            // ScanGiayTo
            // 
            this.ScanGiayTo.DataPropertyName = "ScanGiayTo";
            this.ScanGiayTo.HeaderText = "Giấy tờ";
            this.ScanGiayTo.Name = "ScanGiayTo";
            this.ScanGiayTo.Visible = false;
            this.ScanGiayTo.Width = 65;
            // 
            // MaDiaOc
            // 
            this.MaDiaOc.DataPropertyName = "MaDiaOc";
            this.MaDiaOc.HeaderText = "Mã địa ốc";
            this.MaDiaOc.Name = "MaDiaOc";
            this.MaDiaOc.Width = 80;
            // 
            // TenGiayTo
            // 
            this.TenGiayTo.DataPropertyName = "TenGiayTo";
            this.TenGiayTo.HeaderText = "Tên giấy tờ";
            this.TenGiayTo.Name = "TenGiayTo";
            this.TenGiayTo.Width = 85;
            // 
            // FormGiayTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormGiayTo";
            this.Text = "Form Giấy Tờ";
            this.Load += new System.EventHandler(this.FormGiayTo_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiayTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ComboBox cbMaDO;
        private System.Windows.Forms.Button btnChonHA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Button btnThemMaHA;
        private System.Windows.Forms.TextBox txtTenGiayTo;
        private System.Windows.Forms.TextBox txtMaGiayTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvGiayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanGiayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiayTo;
    }
}