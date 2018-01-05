namespace QuanLyDiaOc.GUI
{
    partial class FormPhanQuyen
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
            this.gbPhanQuyen = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemQuyenHan = new System.Windows.Forms.Button();
            this.btnThemLoaiNhanVien = new System.Windows.Forms.Button();
            this.clbQuyenHan = new System.Windows.Forms.CheckedListBox();
            this.cbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSachPhanQuyen = new System.Windows.Forms.GroupBox();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.MaPhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhanQuyen.SuspendLayout();
            this.gbDanhSachPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhanQuyen
            // 
            this.gbPhanQuyen.Controls.Add(this.btnCapNhat);
            this.gbPhanQuyen.Controls.Add(this.label9);
            this.gbPhanQuyen.Controls.Add(this.txtTimKiem);
            this.gbPhanQuyen.Controls.Add(this.btnThemQuyenHan);
            this.gbPhanQuyen.Controls.Add(this.btnThemLoaiNhanVien);
            this.gbPhanQuyen.Controls.Add(this.clbQuyenHan);
            this.gbPhanQuyen.Controls.Add(this.cbLoaiNhanVien);
            this.gbPhanQuyen.Controls.Add(this.label2);
            this.gbPhanQuyen.Controls.Add(this.label1);
            this.gbPhanQuyen.Location = new System.Drawing.Point(105, 8);
            this.gbPhanQuyen.Name = "gbPhanQuyen";
            this.gbPhanQuyen.Size = new System.Drawing.Size(973, 245);
            this.gbPhanQuyen.TabIndex = 0;
            this.gbPhanQuyen.TabStop = false;
            this.gbPhanQuyen.Text = "Thông tin phân quyền";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(479, 189);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 41;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(738, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(757, 203);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 37;
            // 
            // btnThemQuyenHan
            // 
            this.btnThemQuyenHan.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemQuyenHan.Location = new System.Drawing.Point(697, 112);
            this.btnThemQuyenHan.Name = "btnThemQuyenHan";
            this.btnThemQuyenHan.Size = new System.Drawing.Size(20, 20);
            this.btnThemQuyenHan.TabIndex = 36;
            this.btnThemQuyenHan.UseVisualStyleBackColor = true;
            this.btnThemQuyenHan.Click += new System.EventHandler(this.btnThemQuyenHan_Click);
            // 
            // btnThemLoaiNhanVien
            // 
            this.btnThemLoaiNhanVien.Image = global::QuanLyDiaOc.Properties.Resources.add;
            this.btnThemLoaiNhanVien.Location = new System.Drawing.Point(362, 113);
            this.btnThemLoaiNhanVien.Name = "btnThemLoaiNhanVien";
            this.btnThemLoaiNhanVien.Size = new System.Drawing.Size(20, 20);
            this.btnThemLoaiNhanVien.TabIndex = 35;
            this.btnThemLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btnThemLoaiNhanVien.Click += new System.EventHandler(this.btnThemLoaiNhanVien_Click);
            // 
            // clbQuyenHan
            // 
            this.clbQuyenHan.FormattingEnabled = true;
            this.clbQuyenHan.Location = new System.Drawing.Point(479, 66);
            this.clbQuyenHan.Name = "clbQuyenHan";
            this.clbQuyenHan.Size = new System.Drawing.Size(212, 109);
            this.clbQuyenHan.TabIndex = 3;
            this.clbQuyenHan.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbQuyenHan_ItemCheck);
            // 
            // cbLoaiNhanVien
            // 
            this.cbLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiNhanVien.FormattingEnabled = true;
            this.cbLoaiNhanVien.Location = new System.Drawing.Point(235, 112);
            this.cbLoaiNhanVien.Name = "cbLoaiNhanVien";
            this.cbLoaiNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền hạn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại nhân viên:";
            // 
            // gbDanhSachPhanQuyen
            // 
            this.gbDanhSachPhanQuyen.Controls.Add(this.dgvPhanQuyen);
            this.gbDanhSachPhanQuyen.Location = new System.Drawing.Point(105, 259);
            this.gbDanhSachPhanQuyen.Name = "gbDanhSachPhanQuyen";
            this.gbDanhSachPhanQuyen.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachPhanQuyen.TabIndex = 1;
            this.gbDanhSachPhanQuyen.TabStop = false;
            this.gbDanhSachPhanQuyen.Text = "Danh sách phân quyền";
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhanQuyen,
            this.TenLoaiNhanVien,
            this.TenQuyenHan});
            this.dgvPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanQuyen.Location = new System.Drawing.Point(3, 16);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(967, 309);
            this.dgvPhanQuyen.TabIndex = 0;
            // 
            // MaPhanQuyen
            // 
            this.MaPhanQuyen.DataPropertyName = "MaPhanQuyen";
            this.MaPhanQuyen.HeaderText = "Mã phân quyền";
            this.MaPhanQuyen.Name = "MaPhanQuyen";
            this.MaPhanQuyen.Visible = false;
            this.MaPhanQuyen.Width = 106;
            // 
            // TenLoaiNhanVien
            // 
            this.TenLoaiNhanVien.DataPropertyName = "TenLoaiNhanVien";
            this.TenLoaiNhanVien.HeaderText = "Loại nhân viên";
            this.TenLoaiNhanVien.Name = "TenLoaiNhanVien";
            this.TenLoaiNhanVien.Width = 94;
            // 
            // TenQuyenHan
            // 
            this.TenQuyenHan.DataPropertyName = "TenQuyenHan";
            this.TenQuyenHan.HeaderText = "Tên quyền hạn";
            this.TenQuyenHan.Name = "TenQuyenHan";
            this.TenQuyenHan.Width = 96;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachPhanQuyen);
            this.Controls.Add(this.gbPhanQuyen);
            this.Name = "FormPhanQuyen";
            this.Text = "FormPhanQuyen";
            this.Load += new System.EventHandler(this.FormPhanQuyen_Load);
            this.gbPhanQuyen.ResumeLayout(false);
            this.gbPhanQuyen.PerformLayout();
            this.gbDanhSachPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPhanQuyen;
        private System.Windows.Forms.CheckedListBox clbQuyenHan;
        private System.Windows.Forms.ComboBox cbLoaiNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemQuyenHan;
        private System.Windows.Forms.Button btnThemLoaiNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox gbDanhSachPhanQuyen;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyenHan;
    }
}