namespace QuanLyDiaOc.GUI
{
    partial class FormHopDong
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
            this.XuatHopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetXuatHopDong = new QuanLyDiaOc.GUI.DataSetXuatHopDong();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.XuatHopDongTableAdapter = new QuanLyDiaOc.GUI.DataSetXuatHopDongTableAdapters.XuatHopDongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XuatHopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // XuatHopDongBindingSource
            // 
            this.XuatHopDongBindingSource.DataMember = "XuatHopDong";
            this.XuatHopDongBindingSource.DataSource = this.DataSetXuatHopDong;
            // 
            // DataSetXuatHopDong
            // 
            this.DataSetXuatHopDong.DataSetName = "DataSetXuatHopDong";
            this.DataSetXuatHopDong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetXuatHopDong";
            reportDataSource1.Value = this.XuatHopDongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyDiaOc.GUI.ReportXuatHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(673, 529);
            this.reportViewer1.TabIndex = 0;
            // 
            // XuatHopDongTableAdapter
            // 
            this.XuatHopDongTableAdapter.ClearBeforeFill = true;
            // 
            // FormHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 529);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHopDong";
            this.Text = "Hợp Đồng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XuatHopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetXuatHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource XuatHopDongBindingSource;
        private DataSetXuatHopDong DataSetXuatHopDong;
        private DataSetXuatHopDongTableAdapters.XuatHopDongTableAdapter XuatHopDongTableAdapter;
    }
}