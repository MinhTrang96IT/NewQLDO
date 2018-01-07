namespace QuanLyDiaOc.GUI
{
    partial class FormHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.XuatHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetXuatHopDong = new QuanLyDiaOc.GUI.DataSetXuatHopDong();
            this.layDanhSachTheoMaPhieuDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XuatHoaDonTableAdapter = new QuanLyDiaOc.GUI.DataSetXuatHopDongTableAdapters.XuatHoaDonTableAdapter();
            this.danhSachTheoMaPhieuDangKyTableAdapter = new QuanLyDiaOc.GUI.DataSetXuatHopDongTableAdapters.DanhSachTheoMaPhieuDangKyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachTheoMaPhieuDangKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // XuatHoaDonBindingSource
            // 
            this.XuatHoaDonBindingSource.DataMember = "XuatHoaDon";
            this.XuatHoaDonBindingSource.DataSource = this.DataSetXuatHopDong;
            // 
            // DataSetXuatHopDong
            // 
            this.DataSetXuatHopDong.DataSetName = "DataSetXuatHopDong";
            this.DataSetXuatHopDong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layDanhSachTheoMaPhieuDangKyBindingSource
            // 
            this.layDanhSachTheoMaPhieuDangKyBindingSource.DataMember = "LayDanhSachTheoMaPhieuDangKy";
            this.layDanhSachTheoMaPhieuDangKyBindingSource.DataSource = this.DataSetXuatHopDong;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSetHoaDon";
            reportDataSource1.Value = this.XuatHoaDonBindingSource;
            reportDataSource2.Name = "DataSetHoaDon_ChiTietQuangCao";
            reportDataSource2.Value = this.layDanhSachTheoMaPhieuDangKyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiaOc.GUI.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(818, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // XuatHoaDonTableAdapter
            // 
            this.XuatHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // danhSachTheoMaPhieuDangKyTableAdapter
            // 
            this.danhSachTheoMaPhieuDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormHoaDon";
            this.Text = "Xuất hóa đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuatHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layDanhSachTheoMaPhieuDangKyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource XuatHoaDonBindingSource;
        private DataSetXuatHopDong DataSetXuatHopDong;
        private DataSetXuatHopDongTableAdapters.XuatHoaDonTableAdapter XuatHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource layDanhSachTheoMaPhieuDangKyBindingSource;
        private DataSetXuatHopDongTableAdapters.DanhSachTheoMaPhieuDangKyTableAdapter danhSachTheoMaPhieuDangKyTableAdapter;
    }
}