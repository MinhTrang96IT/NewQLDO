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
    public partial class FormHopDong : Form
    {
        private int maPhieuDangKy = 2;
        public FormHopDong()
        {
            InitializeComponent();
        }
        public FormHopDong(int MaPhieuDangKy) : this()
        {
            maPhieuDangKy = MaPhieuDangKy;
        }
        private void FormHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetXuatHopDong.XuatHopDong' table. You can move, or remove it, as needed.
            this.XuatHopDongTableAdapter.Fill(this.DataSetXuatHopDong.XuatHopDong,maPhieuDangKy);

            this.reportViewer1.RefreshReport();
        }
    }
}
