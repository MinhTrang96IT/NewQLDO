using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiaOc.BLL;

namespace QuanLyDiaOc.GUI
{
    public partial class FormDangNhap : Form
    {
        private NhanVienBLL nhanVienBLL;
        public FormDangNhap()
        {
            InitializeComponent();
            nhanVienBLL = new NhanVienBLL();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (nhanVienBLL.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) != null)
            {
                FormTrangChu formTrangChu = new FormTrangChu();
                formTrangChu.TenNhanVien = nhanVienBLL.LayTenNhanVien(txtTaiKhoan.Text);
                formTrangChu.LoaiNhanVien = nhanVienBLL.LayTenLoaiNhanVien(nhanVienBLL.LayMaLoaiNhanVien(txtTaiKhoan.Text));
                formTrangChu.Show();
                this.Hide();
            }
            else if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show(this, "Phải nhập đủ tên đăng nhập và mật khẩu!!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
