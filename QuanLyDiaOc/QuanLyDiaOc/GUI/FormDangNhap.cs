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
using System.Xml;
using QuanLyDiaOc.DAL;

namespace QuanLyDiaOc.GUI
{
    public partial class FormDangNhap : Form
    {
        public static int maNhanVienDangNhap = 0;
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
                if (nhanVienBLL.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text).Rows.Count > 0)
                {
                    maNhanVienDangNhap = nhanVienBLL.LayMaNhanVien(txtTaiKhoan.Text);
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
            else
            {
                MessageBox.Show(this, "Vui lòng kiểm tra lại cấu hình!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btnDangNhap_Click(null, null);
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.TabStop = false;
            btnCauHinh.TabStop = false;
            btnThoat.TabStop = false;
            btnCauHinh.TabStop = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            DialogCauHinh dialogCauHinh = new DialogCauHinh();
            dialogCauHinh.ShowDialog();
        }
    }
}
