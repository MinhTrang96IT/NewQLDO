using QuanLyDiaOc.BLL;
using System;
using QuanLyDiaOc.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyDiaOc.GUI
{
    public partial class FormPhieuDangKy : Form
    {
        PhieuDangKyBLL phieuDangKyBLL;
        KhachHangBLL khachHangBLL;
        NhanVienBLL nhanVienBLL;
        DiaOcBLL diaOcBLL;
        ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        string id;

        public FormPhieuDangKy()
        {
            InitializeComponent();
            id = "";
            phieuDangKyBLL = new PhieuDangKyBLL();
            khachHangBLL = new KhachHangBLL();
            nhanVienBLL = new NhanVienBLL();
            diaOcBLL = new DiaOcBLL();
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu đăng ký");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    PhieuDangKyDTO phieuDangKyDTO = new PhieuDangKyDTO(
                                   Int32.Parse(cbKhachHang.SelectedValue.ToString()),
                                   Int32.Parse(cbDiaOc.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayLapPhieu.Text),
                                   Convert.ToDateTime(dtpNgayBatDau.Text),
                                   Convert.ToDateTime(dtpNgayKetThuc.Text),
                                   Int32.Parse(txtSoLanGiaHan.Text.ToString()),
                                   trangThaiKiemDuyet,
                                   Double.Parse(txtTongTien.Text.ToString())
                                   ,"");

                    try
                    {
                        if (phieuDangKyBLL.ThemPhieuDangKy(phieuDangKyDTO))
                        {
                            MessageBox.Show("Thêm phiếu đăng ký thành công");
                            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                        }
                        else
                        {
                            MessageBox.Show("Thêm phiếu đăng ký thất bại");
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
                MessageBox.Show("Làm ơn chọn phiếu đăng ký muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin phiếu đăng ký số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (phieuDangKyBLL.XoaPhieuDangKy(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách phiếu đăng ký thành công");
                        dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu đăng ký thất bại");
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu đăng ký");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    PhieuDangKyDTO phieuDangKyDTO = new PhieuDangKyDTO(
                                   Int32.Parse(txtMaPhieuDangKy.Text.ToString()),
                                   Int32.Parse(cbKhachHang.SelectedValue.ToString()),
                                   Int32.Parse(cbDiaOc.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayLapPhieu.Text),
                                   Convert.ToDateTime(dtpNgayBatDau.Text),
                                   Convert.ToDateTime(dtpNgayKetThuc.Text),
                                   Int32.Parse(txtSoLanGiaHan.Text.ToString()),
                                   trangThaiKiemDuyet,
                                   Double.Parse(txtTongTien.Text.ToString())
                                   ,"");

                    try
                    {
                        if (phieuDangKyBLL.SuaPhieuDangKy(phieuDangKyDTO))
                        {
                            MessageBox.Show("Sửa phiếu đăng ký thành công");
                            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa phiếu đăng ký thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void FormPhieuDangKy_Load(object sender, EventArgs e)
        {
            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            cbKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
            cbKhachHang.DisplayMember = "TenKhachHang";
            cbKhachHang.ValueMember = "MaKhachHang";
            cbDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOc();
            cbDiaOc.DisplayMember = "MaDiaOc";
            cbDiaOc.ValueMember = "MaDiaOc";
            cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";

            if(txtMaPhieuDangKy.Text != "" && txtMaPhieuDangKy.Text != null)
            {
                cbDanhSachQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                cbDanhSachQuangCao.DisplayMember = "MaChiTietQuangCao";
                cbDanhSachQuangCao.ValueMember = "MaChiTietQuangCao";
            }
            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaPhieuDangKy.Text = cbKhachHang.Text = cbDanhSachQuangCao.Text = cbDiaOc.Text = cbNhanVien.Text = txtSoLanGiaHan.Text = txtTongTien.Text = cbDanhSachQuangCao.Text =  "";
            rbChuaKiemDuyet.Checked = true;
            rbDaKiemDuyet.Checked = false;
            txtTongTien.Focus();
            cbKhachHang.SelectedIndex = 0;
            cbDiaOc.SelectedIndex = 0;
            cbKhachHang.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            dtpNgayLapPhieu.Value = DateTime.Now;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if ( txtSoLanGiaHan.Text.ToString() == "" || txtTongTien.Text.ToString() == "" )
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            //Regex regexSo = new Regex("^[0-9]+$");
            //if (!regexSo.IsMatch(txtTongTien.Text))
            //{
            //    MessageBox.Show("Tổng tiền chỉ được nhập số");
            //    return false;
            //}
            //if (!regexSo.IsMatch(txtDaTra.Text))
            //{
            //    MessageBox.Show("Tổng tiền chỉ được nhập số");
            //    return false;
            //}
            //if (!regexSo.IsMatch(txtSoLanGiaHan.Text))
            //{
            //    MessageBox.Show("Tổng tiền chỉ được nhập số");
            //    return false;
            //}
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


        private void dgvPhieuDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvPhieuDangKy.Rows[e.RowIndex];
                    txtMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    id = row.Cells["MaPhieuDangKy"].Value.ToString();
                    cbKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                    cbDiaOc.Text = row.Cells["MaDiaOc"].Value.ToString();
                    cbNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                    txtSoLanGiaHan.Text = row.Cells["SoLanGiaHan"].Value.ToString();
                    cbDanhSachQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                    cbDanhSachQuangCao.DisplayMember = "MaChiTietQuangCao";
                    cbDanhSachQuangCao.ValueMember = "MaChiTietQuangCao";
                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value.ToString());
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value.ToString());
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value.ToString());
                    txtTongTien.Text = String.Format("{0:#,###0}", double.Parse(row.Cells["TongTien"].Value.ToString()));
                }
                catch { }
            }
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

        private void btnThemDiaOc_Click(object sender, EventArgs e)
        {
            FormDiaOc diaglogDiaOc = new FormDiaOc();
            diaglogDiaOc.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogDiaOc.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOc();
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien diaglogNhanVien = new FormNhanVien();
            diaglogNhanVien.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogNhanVien.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            }
        }

        private void btnChiTietQuangCao_Click(object sender, EventArgs e)
        {
            if(id != "")
            {
                FormChiTietQuangCao diaglogChiTietQuangCao = new FormChiTietQuangCao(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                diaglogChiTietQuangCao.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogChiTietQuangCao.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                    cbDanhSachQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu đăng ký muốn xem chi tiết quảng cáo!");
            }
        }
    }
}
