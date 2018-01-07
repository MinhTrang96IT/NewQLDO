namespace QuanLyDiaOc.GUI
{
    partial class FormBao
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenBao = new System.Windows.Forms.TextBox();
            this.txtMaBao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBao = new System.Windows.Forms.DataGridView();
            this.MaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDanhSachKH = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).BeginInit();
            this.gbDanhSachKH.SuspendLayout();
            this.gbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::QuanLyDiaOc.Properties.Resources.search;
            this.label9.Location = new System.Drawing.Point(631, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "   ";
            // 
            // txtTenBao
            // 
            this.txtTenBao.Location = new System.Drawing.Point(198, 108);
            this.txtTenBao.Name = "txtTenBao";
            this.txtTenBao.Size = new System.Drawing.Size(139, 20);
            this.txtTenBao.TabIndex = 8;
            // 
            // txtMaBao
            // 
            this.txtMaBao.Enabled = false;
            this.txtMaBao.Location = new System.Drawing.Point(198, 64);
            this.txtMaBao.Name = "txtMaBao";
            this.txtMaBao.Size = new System.Drawing.Size(139, 20);
            this.txtMaBao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên báo:";
            // 
            // dgvBao
            // 
            this.dgvBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBao,
            this.TenBao,
            this.MoTaBao});
            this.dgvBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBao.Location = new System.Drawing.Point(3, 16);
            this.dgvBao.Name = "dgvBao";
            this.dgvBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBao.Size = new System.Drawing.Size(967, 309);
            this.dgvBao.TabIndex = 0;
            this.dgvBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBao_CellClick);
            // 
            // MaBao
            // 
            this.MaBao.DataPropertyName = "MaBao";
            this.MaBao.HeaderText = "Mã báo";
            this.MaBao.Name = "MaBao";
            this.MaBao.Width = 68;
            // 
            // TenBao
            // 
            this.TenBao.DataPropertyName = "TenBao";
            this.TenBao.HeaderText = "Tên báo";
            this.TenBao.Name = "TenBao";
            this.TenBao.Width = 72;
            // 
            // MoTaBao
            // 
            this.MoTaBao.DataPropertyName = "MoTaBao";
            this.MoTaBao.HeaderText = "Mô tả";
            this.MoTaBao.Name = "MoTaBao";
            this.MoTaBao.Width = 59;
            // 
            // gbDanhSachKH
            // 
            this.gbDanhSachKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDanhSachKH.Controls.Add(this.dgvBao);
            this.gbDanhSachKH.Location = new System.Drawing.Point(105, 266);
            this.gbDanhSachKH.Name = "gbDanhSachKH";
            this.gbDanhSachKH.Size = new System.Drawing.Size(973, 328);
            this.gbDanhSachKH.TabIndex = 13;
            this.gbDanhSachKH.TabStop = false;
            this.gbDanhSachKH.Text = "Danh sách báo";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(650, 184);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(139, 20);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(168, 182);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 21;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(444, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(260, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(410, 54);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(379, 81);
            this.txtMoTa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã báo:";
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
            this.gbThongTinKH.Controls.Add(this.txtTenBao);
            this.gbThongTinKH.Controls.Add(this.txtMaBao);
            this.gbThongTinKH.Controls.Add(this.label3);
            this.gbThongTinKH.Controls.Add(this.label2);
            this.gbThongTinKH.Controls.Add(this.label1);
            this.gbThongTinKH.Location = new System.Drawing.Point(105, 8);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(973, 245);
            this.gbThongTinKH.TabIndex = 12;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông tin báo";
            // 
            // FormBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.gbDanhSachKH);
            this.Controls.Add(this.gbThongTinKH);
            this.Name = "FormBao";
            this.Text = "Form Báo";
            this.Load += new System.EventHandler(this.FormBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).EndInit();
            this.gbDanhSachKH.ResumeLayout(false);
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenBao;
        private System.Windows.Forms.TextBox txtMaBao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBao;
        private System.Windows.Forms.GroupBox gbDanhSachKH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaBao;
    }
}