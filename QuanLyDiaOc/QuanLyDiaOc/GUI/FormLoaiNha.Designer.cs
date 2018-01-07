namespace QuanLyDiaOc.GUI
{
    partial class FormLoaiNha
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
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiNha = new System.Windows.Forms.TextBox();
            this.txtMaLoaiNha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiNha = new System.Windows.Forms.DataGridView();
            this.MaLoaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.gbThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNha)).BeginInit();
            this.gbDanhSachKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(192, 183);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbThongTinKH.Controls.Add(this.label9);
            this.gbThongTinKH.Controls.Add(this.txtTimKiem);
            this.gbThongTinKH.Controls.Add(this.btnTaoMoi);
            this.gbThongTinKH.Controls.Add(this.btnSua);
            this.gbThongTinKH.Controls.Add(this.btnXoa);
            this.gbThongTinKH.Controls.Add(this.btnThem);
            this.gbThongTinKH.Controls.Add(this.txtMoTa);
            this.gbThongTinKH.Controls.Add(this.txtTenLoaiNha);
            this.gbThongTinKH.Controls.Add(this.txtMaLoaiNha);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 4;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin loại nhà";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(655, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(674, 185);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(468, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(374, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(284, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(434, 55);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtTenLoaiNha
            // 
            this.txtTenLoaiNha.Location = new System.Drawing.Point(222, 109);
            this.txtTenLoaiNha.Name = "txtTenLoaiNha";
            this.txtTenLoaiNha.Size = new System.Drawing.Size(139, 20);
            this.txtTenLoaiNha.TabIndex = 8;
            // 
            // txtMaLoaiNha
            // 
            this.txtMaLoaiNha.Enabled = false;
            this.txtMaLoaiNha.Location = new System.Drawing.Point(222, 65);
            this.txtMaLoaiNha.Name = "txtMaLoaiNha";
            this.txtMaLoaiNha.Size = new System.Drawing.Size(139, 20);
            this.txtMaLoaiNha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại nhà:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại nhà:";
            // 
            // dgvLoaiNha
            // 
            this.dgvLoaiNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoaiNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNha,
            this.TenLoaiNha,
            this.MoTa});
            this.dgvLoaiNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiNha.Location = new System.Drawing.Point(3, 16);
            this.dgvLoaiNha.Name = "dgvLoaiNha";
            this.dgvLoaiNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNha.Size = new System.Drawing.Size(967, 309);
            this.dgvLoaiNha.TabIndex = 0;
            this.dgvLoaiNha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiNha_CellClick);
            // 
            // MaLoaiNha
            // 
            this.MaLoaiNha.DataPropertyName = "MaLoaiNha";
            this.MaLoaiNha.HeaderText = "Mã loại nhà";
            this.MaLoaiNha.Name = "MaLoaiNha";
            this.MaLoaiNha.Width = 87;
            // 
            // TenLoaiNha
            // 
            this.TenLoaiNha.DataPropertyName = "TenLoaiNha";
            this.TenLoaiNha.HeaderText = "Tên Loại Nhà";
            this.TenLoaiNha.Name = "TenLoaiNha";
            this.TenLoaiNha.Width = 97;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 59;
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSachKH.Controls.Add(this.dgvLoaiNha);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 5;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách loại nhà";
            // 
            // FormLoaiNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.gbDanhSachKH);
            this.Name = "FormLoaiNha";
            this.Text = "Form Loại Nhà";
            this.Load += new System.EventHandler(this.FormLoaiNha_Load);
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNha)).EndInit();
            this.gbDanhSachKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenLoaiNha;
        private System.Windows.Forms.TextBox txtMaLoaiNha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiNha;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}