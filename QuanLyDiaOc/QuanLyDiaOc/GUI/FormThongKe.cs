using QuanLyDiaOc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiaOc.GUI
{
    public partial class FormThongKe : Form
    {
        ThongKeBLL thongKeBLL;
        public FormThongKe()
        {
            InitializeComponent();
            thongKeBLL = new ThongKeBLL();
        }

       
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            chartKhachHang.DataSource = thongKeBLL.LayThongKeKhachHangTheoNamSinh();
            chartKhachHang.ChartAreas["ChartKhachHang"].AxisX.Title = "Tuổi";
            chartKhachHang.ChartAreas["ChartKhachHang"].AxisY.Title = "Số lượng";

            chartKhachHang.Series["SeriesKhachHang"].XValueMember = "NamSinh";
            chartKhachHang.Series["SeriesKhachHang"].YValueMembers = "SoLuong";
        }
    }
}
