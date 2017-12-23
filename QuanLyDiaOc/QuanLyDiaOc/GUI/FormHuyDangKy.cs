using QuanLyDiaOc.BLL;
using QuanLyDiaOc.DTO;
using QuanLyDiaOc.GUI;
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
    public partial class FormHuyDangKy : Form
    {
        HuyDangKyBLL huyDangKyBLL;
        NhanVienBLL nhanVienBLL;
        string id;

        public FormHuyDangKy()
        {
            InitializeComponent(); 
            id = "";
            huyDangKyBLL = new HuyDangKyBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu hủy đăng ký");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    HuyDangKyDTO huyDangKyDTO = new HuyDangKyDTO(
                                   Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayLapPhieu.Text),
                                   txtLyDoNgung.Text.ToString(),
                                   trangThaiKiemDuyet);

                    try
                    {
                        if (huyDangKyBLL.ThemHuyDangKy(huyDangKyDTO))
                        {
                            MessageBox.Show("Thêm phiếu hủy đăng ký thành công");
                            dgvHuyDangKy.DataSource = huyDangKyBLL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Thêm phiếu hủy đăng ký thất bại");
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
                MessageBox.Show("Làm ơn chọn phiếu hủy đăng ký muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin phiếu hủy đăng ký số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (huyDangKyBLL.XoaHuyDangKy(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách phiếu hủy đăng ký thành công");
                        dgvHuyDangKy.DataSource = huyDangKyBLL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu hủy đăng ký thất bại");
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu hủy đăng ký");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    HuyDangKyDTO huyDangKyDTO = new HuyDangKyDTO(
                                   Int32.Parse(txtMaNgungDichVu.Text.ToString()),
                                   Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayLapPhieu.Text),
                                   txtLyDoNgung.Text.ToString(),
                                   trangThaiKiemDuyet);

                    try
                    {
                        if (huyDangKyBLL.SuaHuyDangKy(huyDangKyDTO))
                        {
                            MessageBox.Show("Sửa phiếu hủy đăng ký thành công");
                            dgvHuyDangKy.DataSource = huyDangKyBLL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa phiếu hủy đăng ký thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void FormHuyDangKy_Load(object sender, EventArgs e)
        {
            dgvHuyDangKy.DataSource = huyDangKyBLL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
            cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";

            cbMaPhieuDangKy.DataSource = huyDangKyBLL.LayDanhSachPhieuDangKy();
            cbMaPhieuDangKy.DisplayMember = "MaPhieuDangKy";
            cbMaPhieuDangKy.ValueMember = "MaPhieuDangKy";

            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaNgungDichVu.Text = txtLyDoNgung.Text = "";
            rbChuaKiemDuyet.Checked = true;
            rbDaKiemDuyet.Checked = false;
            cbMaPhieuDangKy.SelectedIndex = 0;
            txtLyDoNgung.Focus();
            cbNhanVien.SelectedIndex = 0;
            dtpNgayLapPhieu.Value = DateTime.Now;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtLyDoNgung.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(500, txtLyDoNgung.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 500 ký tự");
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
            dgvHuyDangKy.DataSource = huyDangKyBLL.TimKiemHuyDangKyTheoTen(txtTimKiem.Text);
        }

        private void dgvHuyDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvHuyDangKy.Rows[e.RowIndex];
                    txtMaNgungDichVu.Text = row.Cells["MaPhieuNgungDangKyDichVu"].Value.ToString();
                    id = row.Cells["MaPhieuNgungDangKyDichVu"].Value.ToString();
                    cbNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                    cbMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    txtLyDoNgung.Text = row.Cells["LyDo"].Value.ToString();
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value.ToString());
                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;

                }
                catch { }
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
    }
}
