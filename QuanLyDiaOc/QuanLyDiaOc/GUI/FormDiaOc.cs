using QuanLyDiaOc.BLL;
using QuanLyDiaOc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiaOc.GUI
{
    public partial class FormDiaOc : Form
    {
        DiaOcBLL diaOcBLL;
        KhachHangBLL khachHangBLL;
        LoaiDiaOcBLL loaiDiaOcBLL;
        LoaiNhaBLL loaiNhaBLL;
        string id;

        public FormDiaOc()
        {
            InitializeComponent();
            id = "";
            diaOcBLL = new DiaOcBLL();
            khachHangBLL = new KhachHangBLL();
            loaiDiaOcBLL = new LoaiDiaOcBLL();
            loaiNhaBLL = new LoaiNhaBLL();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin địa ốc");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    int trangThaiMuaBan = 0;
                    if (chkTrangThaiKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;
                    if (chkTrangThaiMuaBan.Checked)
                        trangThaiMuaBan = 1;

                    DiaOcDTO diaOcDTO = new DiaOcDTO(Int32.Parse(cbKhachHang.SelectedValue.ToString()), Int32.Parse(cbLoaiDiaOc.SelectedValue.ToString()), Int32.Parse(cbLoaiNha.SelectedValue.ToString()), txtDiaChi.Text, (float)Convert.ToDouble(txtDienTichKhuonVien.Text.ToString()), (float)Convert.ToDouble(txtDienTichSuDung.Text.ToString()), txtHuongNha.Text.ToString(), (float)Convert.ToDouble(txtChieuDaiDat.Text.ToString()), (float)Convert.ToDouble(txtChieuRongDat.Text.ToString()), (float)Convert.ToDouble(txtChieuDaiNha.Text.ToString()), (float)Convert.ToDouble(txtChieuRongNha.Text.ToString()), Int32.Parse(txtSoTang.Text.ToString()), txtMoTaChiTiet.Text.ToString(), Int32.Parse( txtGiaBan.Text.ToString()), trangThaiKiemDuyet, trangThaiMuaBan);

                    try
                    {
                        if (diaOcBLL.ThemDiaOc(diaOcDTO))
                        {
                            MessageBox.Show("Thêm địa ốc thành công");
                            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                        }
                        else
                        {
                            MessageBox.Show("Thêm địa ốc thất bại");
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
                MessageBox.Show("Làm ơn chọn địa ốc muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin địa ốc số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (diaOcBLL.XoaDiaOc(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách địa ốc thành công");
                        dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa địa ốc thất bại");
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

                    NhanVienDTO nhanVienDTO = new NhanVienDTO(Int32.Parse(txtMaNV.Text), Int32.Parse(cbLoaiNV.SelectedValue.ToString()), Int32.Parse(cbPhongBan.SelectedValue.ToString()), txtTenNV.Text, txtCMND.Text, gioiTinh, Convert.ToDateTime(dtpNgaySinh.Text), txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, txtTenDangNhap.Text, txtMatKhau.Text);

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

        private void FormDiaOc_Load(object sender, EventArgs e)
        {
            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
            cbKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
            cbKhachHang.DisplayMember = "TenKhachHang";
            cbKhachHang.ValueMember = "MaKhachHang";
            cbLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
            cbLoaiDiaOc.DisplayMember = "TenLoaiDiaOc";
            cbLoaiDiaOc.ValueMember = "MaLoaiDiaOc";
            cbLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
            cbLoaiNha.DisplayMember = "TenLoaiNha";
            cbLoaiNha.ValueMember = "MaLoaiNha";
            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaDiaOc.Text = cbKhachHang.Text = cbLoaiDiaOc.Text = cbLoaiNha.Text = txtDienTichKhuonVien.Text = txtDiaChi.Text = txtDienTichSuDung.Text = txtHuongNha.Text = txtGiaBan.Text = txtChieuDaiDat.Text = txtChieuRongDat.Text = txtChieuDaiNha.Text = txtChieuRongNha.Text = txtSoTang.Text = txtMoTaChiTiet.Text =  "";
            chkTrangThaiKiemDuyet.Checked = false;
            chkTrangThaiMuaBan.Checked = false;
            txtDienTichKhuonVien.Focus();
            cbKhachHang.SelectedIndex = 0;
            cbLoaiDiaOc.SelectedIndex = 0;
            cbLoaiNha.SelectedIndex = 0;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtDienTichKhuonVien.Text.ToString() == "" || txtDienTichSuDung.Text.ToString() == "" || txtDiaChi.Text.ToString() == "" || txtHuongNha.Text.ToString() == "" || txtGiaBan.Text.ToString() == "" || txtChieuDaiNha.Text.ToString() == "" || txtChieuRongNha.Text.ToString() == "" || txtChieuDaiDat.Text.ToString() == "" || txtChieuRongDat.Text.ToString() == "" || txtSoTang.Text.ToString() == "" || txtMoTaChiTiet.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
           
            if (!KiemTraSoKyTuNhapVao(200, txtDiaChi.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(100, txtHuongNha.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự!");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(500, txtMoTaChiTiet.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 500 ký tự!");
                return false;
            }
            Regex regSoThuc = new Regex(@"[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)");
            if (!regSoThuc.IsMatch(txtDienTichKhuonVien.Text))
            {
                MessageBox.Show("Diện tích khuôn viên phải là số thực");
                return false;
            }
            if (!regSoThuc.IsMatch(txtDienTichSuDung.Text))
            {
                MessageBox.Show("Diện tích sử dụng phải là số thực");
                return false;
            }
            if (!regSoThuc.IsMatch(txtChieuDaiDat.Text))
            {
                MessageBox.Show("Chiều dài đất phải là số thực");
                return false;
            }
            if (!regSoThuc.IsMatch(txtChieuRongDat.Text))
            {
                MessageBox.Show("Chiều rộng đất phải là số thực");
                return false;
            }
            if (!regSoThuc.IsMatch(txtChieuDaiNha.Text))
            {
                MessageBox.Show("Chiều dài nhà phải là số thực");
                return false;
            }
            if (!regSoThuc.IsMatch(txtChieuRongNha.Text))
            {
                MessageBox.Show("Chiều rộng nhà phải là số thực");
                return false;
            }
            Regex regexMoney = new Regex(@"^[0-9]+$");
            if (!regexMoney.IsMatch(txtGiaBan.Text))
            {
                MessageBox.Show("Giá bán thuộc Money format");
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang diaglogKhachHang = new FormKhachHang();
            diaglogKhachHang.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogKhachHang.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
            }
        }

        private void btnThemLoaiDiaOc_Click(object sender, EventArgs e)
        {
            FormLoaiDiaOc formLoaiDiaOc = new FormLoaiDiaOc();
            formLoaiDiaOc.StartPosition = FormStartPosition.CenterScreen;
            if (formLoaiDiaOc.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
            }
        }

        private void btnThemLoaiNha_Click(object sender, EventArgs e)
        {
            FormLoaiNha formLoaiNha = new FormLoaiNha();
            formLoaiNha.StartPosition = FormStartPosition.CenterScreen;
            if (formLoaiNha.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
            }
        }

        private void dgvDiaOc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
