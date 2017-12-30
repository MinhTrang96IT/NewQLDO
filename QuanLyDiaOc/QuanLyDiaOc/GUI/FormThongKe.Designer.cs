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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.cbDoanhThu_Nam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridDoanhThu = new System.Windows.Forms.DataGridView();
            this.Canam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatTheoThang = new System.Windows.Forms.Button();
            this.chartDoanhThuTheoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabThongKe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHang)).BeginInit();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabDoanhThu);
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
            // chartKhachHang
            // 
            chartArea2.Name = "ChartKhachHang";
            this.chartKhachHang.ChartAreas.Add(chartArea2);
            this.chartKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartKhachHang.Legends.Add(legend2);
            this.chartKhachHang.Location = new System.Drawing.Point(3, 3);
            this.chartKhachHang.Name = "chartKhachHang";
            series1.ChartArea = "ChartKhachHang";
            series1.Legend = "Legend1";
            series1.Name = "TuoiKhachHang";
            this.chartKhachHang.Series.Add(series1);
            this.chartKhachHang.Size = new System.Drawing.Size(1168, 571);
            this.chartKhachHang.TabIndex = 0;
            this.chartKhachHang.Text = "A";
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
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dataGridDoanhThu);
            this.tabDoanhThu.Controls.Add(this.btnXuatTheoThang);
            this.tabDoanhThu.Controls.Add(this.chartDoanhThuTheoThang);
            this.tabDoanhThu.Controls.Add(this.cbDoanhThu_Nam);
            this.tabDoanhThu.Controls.Add(this.label3);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Size = new System.Drawing.Size(1174, 577);
            this.tabDoanhThu.TabIndex = 2;
            this.tabDoanhThu.Text = "Doanh thu theo tháng";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // cbDoanhThu_Nam
            // 
            this.cbDoanhThu_Nam.FormattingEnabled = true;
            this.cbDoanhThu_Nam.Location = new System.Drawing.Point(231, 21);
            this.cbDoanhThu_Nam.Name = "cbDoanhThu_Nam";
            this.cbDoanhThu_Nam.Size = new System.Drawing.Size(121, 21);
            this.cbDoanhThu_Nam.TabIndex = 31;
            this.cbDoanhThu_Nam.SelectedIndexChanged += new System.EventHandler(this.cbDoanhThu_Nam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Năm";
            // 
            // dataGridDoanhThu
            // 
            this.dataGridDoanhThu.AllowUserToAddRows = false;
            this.dataGridDoanhThu.AllowUserToDeleteRows = false;
            this.dataGridDoanhThu.AllowUserToResizeRows = false;
            this.dataGridDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDoanhThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Canam,
            this.Thang1,
            this.Thang2,
            this.Thang3,
            this.Thang4,
            this.Thang5,
            this.Thang6,
            this.Thang7,
            this.Thang8,
            this.Thang9,
            this.Thang10,
            this.Thang11,
            this.Thang12});
            this.dataGridDoanhThu.EnableHeadersVisualStyles = false;
            this.dataGridDoanhThu.Location = new System.Drawing.Point(114, 443);
            this.dataGridDoanhThu.Name = "dataGridDoanhThu";
            this.dataGridDoanhThu.ReadOnly = true;
            this.dataGridDoanhThu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDoanhThu.RowHeadersVisible = false;
            this.dataGridDoanhThu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDoanhThu.Size = new System.Drawing.Size(1050, 90);
            this.dataGridDoanhThu.TabIndex = 42;
            // 
            // Canam
            // 
            this.Canam.HeaderText = "Cả năm (VNĐ)";
            this.Canam.Name = "Canam";
            this.Canam.ReadOnly = true;
            // 
            // Thang1
            // 
            this.Thang1.HeaderText = "Tháng 1";
            this.Thang1.Name = "Thang1";
            this.Thang1.ReadOnly = true;
            // 
            // Thang2
            // 
            this.Thang2.HeaderText = "Tháng 2";
            this.Thang2.Name = "Thang2";
            this.Thang2.ReadOnly = true;
            // 
            // Thang3
            // 
            this.Thang3.HeaderText = "Tháng 3";
            this.Thang3.Name = "Thang3";
            this.Thang3.ReadOnly = true;
            // 
            // Thang4
            // 
            this.Thang4.HeaderText = "Tháng 4";
            this.Thang4.Name = "Thang4";
            this.Thang4.ReadOnly = true;
            // 
            // Thang5
            // 
            this.Thang5.HeaderText = "Tháng 5";
            this.Thang5.Name = "Thang5";
            this.Thang5.ReadOnly = true;
            // 
            // Thang6
            // 
            this.Thang6.HeaderText = "Tháng 6";
            this.Thang6.Name = "Thang6";
            this.Thang6.ReadOnly = true;
            // 
            // Thang7
            // 
            this.Thang7.HeaderText = "Tháng 7";
            this.Thang7.Name = "Thang7";
            this.Thang7.ReadOnly = true;
            // 
            // Thang8
            // 
            this.Thang8.HeaderText = "Tháng 8";
            this.Thang8.Name = "Thang8";
            this.Thang8.ReadOnly = true;
            // 
            // Thang9
            // 
            this.Thang9.HeaderText = "Tháng 9";
            this.Thang9.Name = "Thang9";
            this.Thang9.ReadOnly = true;
            // 
            // Thang10
            // 
            this.Thang10.HeaderText = "Tháng 10";
            this.Thang10.Name = "Thang10";
            this.Thang10.ReadOnly = true;
            // 
            // Thang11
            // 
            this.Thang11.HeaderText = "Tháng 11";
            this.Thang11.Name = "Thang11";
            this.Thang11.ReadOnly = true;
            // 
            // Thang12
            // 
            this.Thang12.HeaderText = "Tháng 12";
            this.Thang12.Name = "Thang12";
            this.Thang12.ReadOnly = true;
            // 
            // btnXuatTheoThang
            // 
            this.btnXuatTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatTheoThang.Location = new System.Drawing.Point(586, 541);
            this.btnXuatTheoThang.Name = "btnXuatTheoThang";
            this.btnXuatTheoThang.Size = new System.Drawing.Size(168, 28);
            this.btnXuatTheoThang.TabIndex = 41;
            this.btnXuatTheoThang.Text = "Xuất ra Excel";
            this.btnXuatTheoThang.UseVisualStyleBackColor = true;
            this.btnXuatTheoThang.Click += new System.EventHandler(this.btnXuatTheoThang_Click_1);
            // 
            // chartDoanhThuTheoThang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThuTheoThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThuTheoThang.Legends.Add(legend1);
            this.chartDoanhThuTheoThang.Location = new System.Drawing.Point(114, 48);
            this.chartDoanhThuTheoThang.Name = "chartDoanhThuTheoThang";
            this.chartDoanhThuTheoThang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartDoanhThuTheoThang.Size = new System.Drawing.Size(1050, 370);
            this.chartDoanhThuTheoThang.TabIndex = 40;
            this.chartDoanhThuTheoThang.Text = "Doanh thu";
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
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhachHang;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.DataGridView dataGridDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang12;
        private System.Windows.Forms.Button btnXuatTheoThang;
        private System.Windows.Forms.ComboBox cbDoanhThu_Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuTheoThang;
    }
}