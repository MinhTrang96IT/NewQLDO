namespace QuanLyDiaOc.GUI
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabThongKe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabPage1);
            this.tabThongKe.Controls.Add(this.tabPage2);
            this.tabThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongKe.Location = new System.Drawing.Point(0, 0);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(1182, 603);
            this.tabThongKe.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartKhachHang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Độ tuổi Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Địa ốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartKhachHang
            // 
            chartArea1.Name = "ChartKhachHang";
            this.chartKhachHang.ChartAreas.Add(chartArea1);
            this.chartKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartKhachHang.Legends.Add(legend1);
            this.chartKhachHang.Location = new System.Drawing.Point(3, 3);
            this.chartKhachHang.Name = "chartKhachHang";
            series1.ChartArea = "ChartKhachHang";
            series1.Legend = "Legend1";
            series1.Name = "SeriesKhachHang";
            this.chartKhachHang.Series.Add(series1);
            this.chartKhachHang.Size = new System.Drawing.Size(1168, 571);
            this.chartKhachHang.TabIndex = 0;
            this.chartKhachHang.Text = "A";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tabThongKe);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.tabThongKe.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhachHang;
    }
}