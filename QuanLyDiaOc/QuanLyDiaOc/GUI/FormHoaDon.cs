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
    public partial class FormHoaDon : Form
    {
        private int maPhieuDangKy = 2;
        public FormHoaDon()
        {
            InitializeComponent();
        }
        public FormHoaDon(int MaPhieuDangKy) : this()
        {
            maPhieuDangKy = MaPhieuDangKy;
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetXuatHopDong.XuatHoaDon' table. You can move, or remove it, as needed.
            this.XuatHoaDonTableAdapter.Fill(this.DataSetXuatHopDong.XuatHoaDon,maPhieuDangKy);
            this.danhSachTheoMaPhieuDangKyTableAdapter.Fill(this.DataSetXuatHopDong.LayDanhSachTheoMaPhieuDangKy,maPhieuDangKy);

            this.reportViewer1.RefreshReport();
        }
    }
}
