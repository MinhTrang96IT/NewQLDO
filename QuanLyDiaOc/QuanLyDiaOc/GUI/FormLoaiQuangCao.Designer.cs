namespace QuanLyDiaOc.GUI
{
    partial class FormLoaiQuangCao
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
            this.dgvLoaiQuangCao = new System.Windows.Forms.DataGridView();
            this.MaLoaiQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaLoaiQuangCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtMaLoaiQuangCao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenLoaiQuangCao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiQuangCao)).BeginInit();
            this.gbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSachKH.Controls.Add(this.dgvLoaiQuangCao);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 11;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách loại quảng cáo";
            // 
            // dgvLoaiQuangCao
            // 
            this.dgvLoaiQuangCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoaiQuangCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiQuangCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiQuangCao,
            this.TenLoaiQuangCao,
            this.MoTaLoaiQuangCao});
            this.dgvLoaiQuangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiQuangCao.Location = new System.Drawing.Point(3, 16);
            this.dgvLoaiQuangCao.Name = "dgvLoaiQuangCao";
            this.dgvLoaiQuangCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiQuangCao.Size = new System.Drawing.Size(967, 309);
            this.dgvLoaiQuangCao.TabIndex = 0;
            this.dgvLoaiQuangCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiQuangCao_CellClick);
            // 
            // MaLoaiQuangCao
            // 
            this.MaLoaiQuangCao.DataPropertyName = "MaLoaiQuangCao";
            this.MaLoaiQuangCao.HeaderText = "Mã loại quảng cáo";
            this.MaLoaiQuangCao.Name = "MaLoaiQuangCao";
            this.MaLoaiQuangCao.Width = 94;
            // 
            // TenLoaiQuangCao
            // 
            this.TenLoaiQuangCao.DataPropertyName = "TenLoaiQuangCao";
            this.TenLoaiQuangCao.HeaderText = "Tên loại quảng cáo";
            this.TenLoaiQuangCao.Name = "TenLoaiQuangCao";
            this.TenLoaiQuangCao.Width = 97;
            // 
            // MoTaLoaiQuangCao
            // 
            this.MoTaLoaiQuangCao.DataPropertyName = "MoTaLoaiQuangCao";
            this.MoTaLoaiQuangCao.HeaderText = "Mô tả";
            this.MoTaLoaiQuangCao.Name = "MoTaLoaiQuangCao";
            this.MoTaLoaiQuangCao.Width = 47;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(494, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(700, 181);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(218, 179);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(310, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(460, 51);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtMaLoaiQuangCao
            // 
            this.txtMaLoaiQuangCao.Enabled = false;
            this.txtMaLoaiQuangCao.Location = new System.Drawing.Point(248, 61);
            this.txtMaLoaiQuangCao.Name = "txtMaLoaiQuangCao";
            this.txtMaLoaiQuangCao.Size = new System.Drawing.Size(139, 20);
            this.txtMaLoaiQuangCao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại quảng cáo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại quảng cáo:";
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
            this.gbThongTinKH.Controls.Add(this.txtTenLoaiQuangCao);
            this.gbThongTinKH.Controls.Add(this.txtMaLoaiQuangCao);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 10;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin loại quảng cáo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(681, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTenLoaiQuangCao
            // 
            this.txtTenLoaiQuangCao.Location = new System.Drawing.Point(248, 105);
            this.txtTenLoaiQuangCao.Name = "txtTenLoaiQuangCao";
            this.txtTenLoaiQuangCao.Size = new System.Drawing.Size(139, 20);
            this.txtTenLoaiQuangCao.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // FormLoaiQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachKH);
            this.Controls.Add(this.gbThongTinKH);
            this.Name = "FormLoaiQuangCao";
            this.Text = "Form Loại Quảng Cáo";
            this.Load += new System.EventHandler(this.FormLoaiQuangCao_Load);
            this.gbDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiQuangCao)).EndInit();
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.DataGridView dgvLoaiQuangCao;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtMaLoaiQuangCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.TextBox txtTenLoaiQuangCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiQuangCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaLoaiQuangCao;
    }
}