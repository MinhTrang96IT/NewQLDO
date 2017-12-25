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
    public partial class FormChiTietQuangCao : Form
    {
        private int MaPhieuDangKy;

        public FormChiTietQuangCao()
        {
            InitializeComponent();
        }
        public FormChiTietQuangCao(int maPhieuDangKy) : this()
        {
            MaPhieuDangKy = maPhieuDangKy;
            MessageBox.Show("" + MaPhieuDangKy);
        }
    }
}
