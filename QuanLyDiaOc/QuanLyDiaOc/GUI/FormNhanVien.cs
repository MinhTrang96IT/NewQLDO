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
        private LoaiNhanVienBLL loaiNhanVienBLL;
        private PhongBanBLL phongBanBLL;
        private string id;

        public FormNhanVien()
        {
            InitializeComponent();

            nhanVienBLL = new NhanVienBLL();
            loaiNhanVienBLL = new LoaiNhanVienBLL();
            phongBanBLL = new PhongBanBLL();
            id = "";
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbLoaiNV.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
            cbLoaiNV.DisplayMember = "TenLoaiNhanVien";
            cbLoaiNV.ValueMember = "MaLoaiNhanVien";
            cbPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
            cbPhongBan.DisplayMember = "TenLPhongBan";
            cbPhongBan.ValueMember = "MaPhongBan";
            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaNV.Text = cbLoaiNV.Text = cbPhongBan.Text = txtTenNV.Text = txtCMND.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = txtTenDangNhap.Text = txtMatKhau.Text = txtTimKiem.Text = "";
            rbNam.Checked = true;
            txtTenNV.Focus();
            cbLoaiNV.SelectedIndex = 0;
            cbPhongBan.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                    txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                    id = row.Cells["MaNhanVien"].Value.ToString();
                    cbLoaiNV.Text = nhanVienBLL.LayTenLoaiNhanVien(row.Cells["MaLoaiNhanVien"].Value.ToString());
                    cbLoaiNV.Text = phongBanBLL.LayTenPhongBan(row.Cells["MaPhongBan"].Value.ToString());
                    txtTenNV.Text = row.Cells["TenNhanVien"].Value.ToString();
                    txtCMND.Text = row.Cells["CMND"].Value.ToString();
                    if (row.Cells["GioiTinh"].Value.ToString().Equals("True"))
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtSoDienThoai.Text = row.Cells["SoDienthoai"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                    txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                }
                catch { }
            }
        }
    }
}
