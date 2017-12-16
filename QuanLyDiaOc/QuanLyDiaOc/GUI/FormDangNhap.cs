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
using QuanLyDiaOc.GUI;

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
                this.Hide();
                FormTrangChu formTrangChu = new FormTrangChu();
                //formTrangChu.user = user;
                //formHome.type = loginBLL.GetType(user);
                formTrangChu.Show();
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
