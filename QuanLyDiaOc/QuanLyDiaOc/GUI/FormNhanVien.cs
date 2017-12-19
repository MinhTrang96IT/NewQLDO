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
using System.Text.RegularExpressions;

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
            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVienTheoTenLoai();
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
            if (txtTenNV.Text.ToString() == "" || txtCMND.Text.ToString() == "" || txtDiaChi.Text.ToString() == "" || txtEmail.Text.ToString() == "" || txtSoDienThoai.Text.ToString() == "" || txtTenDangNhap.Text.ToString() == "" || txtMatKhau.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            Regex regTen = new Regex(@"^([\w.'-_?@áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ ]+)$");
            if (!regTen.IsMatch(txtTenNV.Text))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(50, txtTenNV.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(15, txtCMND.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(100, txtDiaChi.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 ký tự!");
                return false;
            }
            Regex regSDT = new Regex(@"^(0|\+84)([\d]{9,10})$");
            if (!regSDT.IsMatch(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải 10 hoặc 11 số");
                return false;
            }
            Regex regEmail = new Regex(@"^[\w._%+-]+@([\w\.]+)$");
            if (!regEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(30, txtTenDangNhap.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(15, txtMatKhau.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }

            return true;
        }

        private bool KiemTraSoKyTuNhapVao(int max, string str)
        {
            if (str.Length <= max)
                return true;
            return false;
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
            {
                MessageBox.Show("Chỉ nhập số tại đây");
                e.Handled = true;
            }
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
                    cbLoaiNV.Text = row.Cells["TenLoaiNhanVien"].Value.ToString();
                    cbPhongBan.Text = row.Cells["TenLPhongBan"].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin nhân viên");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int gioiTinh = 1;
                    if (rbNu.Checked)
                        gioiTinh = 0;

                    NhanVienDTO nhanVienDTO = new NhanVienDTO(Int32.Parse(cbLoaiNV.SelectedValue.ToString()), Int32.Parse(cbPhongBan.SelectedValue.ToString()), txtTenNV.Text, txtCMND.Text, gioiTinh, Convert.ToDateTime(dtpNgaySinh.Text), txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, txtTenDangNhap.Text, txtMatKhau.Text);

                    try
                    {
                        if (nhanVienBLL.ThemNhanVien(nhanVienDTO))
                        {
                            MessageBox.Show("Thêm nhân viên thành công");
                            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVienTheoTenLoai();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Làm ơn chọn nhân viên muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin nhân viên số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nhanVienBLL.XoaNhanVien(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách nhân viên thành công");
                        dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVienTheoTenLoai();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin nhân viên");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int gioiTinh = 1;
                    if (rbNu.Checked)
                        gioiTinh = 0;

                    NhanVienDTO nhanVienDTO = new NhanVienDTO(Int32.Parse(txtMaNV.Text) ,Int32.Parse(cbLoaiNV.SelectedValue.ToString()), Int32.Parse(cbPhongBan.SelectedValue.ToString()), txtTenNV.Text, txtCMND.Text, gioiTinh, Convert.ToDateTime(dtpNgaySinh.Text), txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, txtTenDangNhap.Text, txtMatKhau.Text);

                    try
                    {
                        if (nhanVienBLL.SuaNhanVien(nhanVienDTO))
                        {
                            MessageBox.Show("Sửa nhân viên thành công");
                            dgvNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVienTheoTenLoai();
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBLL.TimKiemNVTheoTen(txtTimKiem.Text);
        }

        private void btnThemLoaiNV_Click(object sender, EventArgs e)
        {
            FormLoaiNhanVien diaglogLoaiNhanVien = new FormLoaiNhanVien();
            diaglogLoaiNhanVien.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogLoaiNhanVien.ShowDialog(this) == DialogResult.Yes) {}
            else
            {
                cbLoaiNV.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
            }
        }

        private void btnThemLoaiPB_Click(object sender, EventArgs e)
        {
            FormPhongBan diaglogPhongBan = new FormPhongBan();
            diaglogPhongBan.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogPhongBan.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
            }
        }
    }
}
