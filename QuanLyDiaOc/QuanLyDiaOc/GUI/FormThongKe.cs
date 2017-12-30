using QuanLyDiaOc.BLL;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyDiaOc.GUI
{
    public partial class FormThongKe : Form
    {
        ThongKeBLL thongKeBLL;

        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        object misValue = System.Reflection.Missing.Value;

        public FormThongKe()
        {
            InitializeComponent();
            thongKeBLL = new ThongKeBLL();
            String[] Nam = {"2017","2018","2019" };
            cbDoanhThu_Nam.DataSource = Nam;
            chartDoanhThuTheoThang.ChartAreas[0].AxisX.MajorGrid.Enabled = chartDoanhThuTheoThang.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartDoanhThuTheoThang.Titles.Add("Doanh thu theo tháng năm " + cbDoanhThu_Nam.Text + " (VND)");
        }

       
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            chartKhachHang.DataSource = thongKeBLL.LayThongKeKhachHangTheoNamSinh();
            chartKhachHang.ChartAreas["ChartKhachHang"].AxisX.Title = "Tuổi";
            chartKhachHang.ChartAreas["ChartKhachHang"].AxisY.Title = "Số lượng";

            chartKhachHang.Series["TuoiKhachHang"].XValueMember = "NamSinh";
            chartKhachHang.Series["TuoiKhachHang"].YValueMembers = "SoLuong";
        }


        private void btnXuatTheoThang_Click_1(object sender, EventArgs e)
        {
            SaveExcel(dataGridDoanhThu);
        }

        private void cbDoanhThu_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridDoanhThu.Rows.Add();
            int nam = int.Parse(cbDoanhThu_Nam.Text);
            chartDoanhThuTheoThang.Series.Clear();
            double TongTien = 0.0;
            Series series = new Series
            {
                Name = "series2",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            chartDoanhThuTheoThang.Series.Add(series);
            for (int i = 1; i <= 12; i++)
            {
                double tien = thongKeBLL.LayDoanhThuTheoThang(i, nam);
                TongTien += tien;
                series.Points.Add(tien);
                var p1 = series.Points[i - 1];
                p1.AxisLabel = "Tháng " + i;
                p1.LegendText = "Tháng " + i;
                if (tien > 0)
                {
                    p1.Label = string.Format("{0:#,###0}", tien);
                }
                dataGridDoanhThu.Columns[i].DefaultCellStyle.Format = "N2";
                dataGridDoanhThu.Rows[0].Cells[i].Value = tien;
            }
            dataGridDoanhThu.Columns[0].DefaultCellStyle.Format = "N2";
            dataGridDoanhThu.Rows[0].Cells[0].Value = TongTien;
        }

        private void SaveExcel(System.Windows.Forms.DataGridView grid)
        {
            try
            {
                System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
                saveDialog.InitialDirectory = @"D:\";
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 0;
                saveDialog.RestoreDirectory = true;
                saveDialog.Title = "Export Excel File To";
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    for (int i = 1; i < grid.Columns.Count + 1; i++)
                    {
                        xlWorkSheet.Cells[1, i] = grid.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i <= grid.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();

                        }
                    }
                    string path = saveDialog.FileName;
                    xlWorkBook.SaveCopyAs(path);
                    xlWorkBook.Saved = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    MessageBox.Show(this, "Đã xuất ra file excel", "Xuất excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show(this, "Không thể xuất ra file excel. Vui lòng thử lại.", "Xuất excel thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
