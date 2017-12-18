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
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.GUI
{
    public partial class FormNhanVien : Form
    {
        private NhanVienBLL nhanVienBLL;
        private string id;

        public FormNhanVien()
        {
            InitializeComponent();

            nhanVienBLL = new NhanVienBLL();
            id = "";
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LamMoiThongTin();
            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
        }

        private void LamMoiThongTin()
        {
            txtMaNV.Text = cbLoaiNV.Text = cbPhongBan.Text = txtTenNV.Text = txtCMND.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = txtTenDangNhap.Text = txtMatKhau.Text = txtTimKiem.Text = "";
            rbNam.Checked = true;
            txtTenNV.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtMaNV.Text.ToString() == "" || txtTenNV.Text.ToString() == "" || txtCMND.Text.ToString() == "" || txtDiaChi.Text.ToString() == "" || txtEmail.Text.ToString() == "" || txtSoDienThoai.Text.ToString() == "" || txtTenDangNhap.Text.ToString() == "" || txtMatKhau.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
