using QuanLyDiaOc.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiaOc.DTO;
namespace QuanLyDiaOc.GUI
{
    public partial class FormPhieuGiaHan : Form
    {
        private int MaPDKTuFormPDK = 0;
        PhieuGiaHanBLL phieuGiaHanBLL;
        PhieuDangKyBLL phieuDangKyBLL;
        NhanVienBLL nhanVienBLL;
        QuyDinhBLL quyDinhBLL;
        string id;
        bool checkFormLoad = true;

        public FormPhieuGiaHan(int maPhieuDangKy) : this()
        {
            MaPDKTuFormPDK = maPhieuDangKy;
        }
        public FormPhieuGiaHan()
        {
            InitializeComponent();
            id = "";
            phieuGiaHanBLL = new PhieuGiaHanBLL();
            phieuDangKyBLL = new PhieuDangKyBLL();
            nhanVienBLL = new NhanVienBLL();
            quyDinhBLL = new QuyDinhBLL();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu gia hạn");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
            if (rbDaKiemDuyet.Checked)
                trangThaiKiemDuyet = 1;

            PhieuGiaHanDTO phieuGiaHanDTO = new PhieuGiaHanDTO(
                           Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString()),
                           Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                           Convert.ToDateTime(dtpNgayLapPhieu.Text),
                           Convert.ToDateTime(dtpNgayBatDau.Text),
                           Convert.ToDateTime(dtpNgayKetThuc.Text),
                           trangThaiKiemDuyet,
                           Double.Parse(txtTongTien.Text.ToString())
                           , "");

            try
            {
                if (phieuGiaHanBLL.ThemPhieuGiaHan(phieuGiaHanDTO))
                {
                    MessageBox.Show("Thêm phiếu gia hạn thành công");
                            phieuGiaHanBLL.TangSoLanGiaHan(phieuGiaHanDTO.MaPhieuDangKy);
                    if (MaPDKTuFormPDK == 0)
                    {
                        dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuPhieuGiaHanCoTen();
                    }
                    else
                    {
                        dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuGiaHanTheoMaPDK(MaPDKTuFormPDK);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm phiếu gia hạn thất bại");
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
                MessageBox.Show("Làm ơn chọn phiếu gia hạn muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin phiếu gia hạn số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (phieuGiaHanBLL.XoaPhieuGiaHan(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách phiếu gia hạn thành công");
                        if (MaPDKTuFormPDK == 0)
                        {
                            dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuPhieuGiaHanCoTen();
                        }
                        else
                        {
                            dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuGiaHanTheoMaPDK(MaPDKTuFormPDK);
                        }
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu gia hạn thất bại");
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phiếu gia hạn");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;
                    if (txtMaPhieuGiaHan.Text != "")
                    {

                        PhieuGiaHanDTO phieuGiaHanDTO = new PhieuGiaHanDTO(
                                       Int32.Parse(txtMaPhieuGiaHan.Text.ToString()),
                                       Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString()),
                                       Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                       Convert.ToDateTime(dtpNgayLapPhieu.Text),
                                       Convert.ToDateTime(dtpNgayBatDau.Text),
                                       Convert.ToDateTime(dtpNgayKetThuc.Text),
                                       trangThaiKiemDuyet,
                                       Double.Parse(phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMa(Int32.Parse(cbMaPhieuDangKy.Text.ToString())).Rows[0]["TongTien"].ToString()) * Double.Parse(txtPhanTramGiaHan.Text.ToString())
                                       , "");

                        try
                        {
                            if (phieuGiaHanBLL.SuaPhieuGiaHan(phieuGiaHanDTO))
                            {
                                MessageBox.Show("Sửa phiếu gia hạn thành công");
                                if (MaPDKTuFormPDK == 0)
                                {
                                    dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuPhieuGiaHanCoTen();
                                }
                                else
                                {
                                    dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuGiaHanTheoMaPDK(MaPDKTuFormPDK);
                                }
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa phiếu gia hạn thất bại");
                            }
                        }
                        catch
                        {
                        }
                    } else
                    {
                        MessageBox.Show("Làm ơn chọn phiếu gia hạn muốn sửa thông tin!");
                    }

                }
            }
        }

        private void AnButton()
        {
            btnTaoMoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FormPhieuGiaHan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Xem thông tin"))
                    btnXuatHoaDon.Enabled = false;
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            if (MaPDKTuFormPDK == 0)
            {
                txtMaPhieuDangKy.Visible = false;
                dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuPhieuGiaHanCoTen();
            }
            else
            {
                cbMaPhieuDangKy.Visible = false;
                btnThemMaPhieuDangKy.Visible = false;
                txtMaPhieuDangKy.Text = MaPDKTuFormPDK.ToString();
                dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuGiaHanTheoMaPDK(MaPDKTuFormPDK);
            }
            cbMaPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
            cbMaPhieuDangKy.DisplayMember = "MaPhieuDangKy";
            cbMaPhieuDangKy.ValueMember = "MaPhieuDangKy";
            cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";
            txtPhanTramGiaHan.Text = quyDinhBLL.LayLaiSuatTreHanThanhToan();
            if (txtPhanTramGiaHan.Text == "")
                txtPhanTramGiaHan.Text = "0.1";
            double chiphi = Double.Parse(phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMa(Int32.Parse(cbMaPhieuDangKy.Text)).Rows[0]["TongTien"].ToString()) * Double.Parse(txtPhanTramGiaHan.Text.ToString());
            txtTongTien.Text = chiphi.ToString();
            LamMoiThongTin();
            checkFormLoad = false;
        }

        private void LamMoiThongTin()
        {
            txtMaPhieuGiaHan.Text = cbMaPhieuDangKy.Text = cbNhanVien.Text = "";
            rbChuaKiemDuyet.Checked = true;
            rbDaKiemDuyet.Checked = false;
            txtTongTien.Focus();
            cbMaPhieuDangKy.SelectedIndex = 0;
            cbNhanVien.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            dtpNgayLapPhieu.Value = DateTime.Now;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTongTien.Text.ToString() == "")
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
            if (Convert.ToDateTime(dtpNgayBatDau.Text) > Convert.ToDateTime(dtpNgayKetThuc.Text))
            {
                MessageBox.Show("Ngày bắt đầu phải trước hoặc trùng với ngày kết thúc");
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


        private void dgvPhieuGiaHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvPhieuGiaHan.Rows[e.RowIndex];
                    txtMaPhieuGiaHan.Text = row.Cells["MaPhieuGiaHan"].Value.ToString();
                    id = row.Cells["MaPhieuGiaHan"].Value.ToString();
                    cbMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    cbNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value.ToString());
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value.ToString());
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value.ToString());

                    double ChiPhi = 0.0;
                    ChiPhi = Double.Parse(phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMa(Int32.Parse(cbMaPhieuDangKy.Text.ToString())).Rows[0]["TongTien"].ToString()) * Double.Parse(txtPhanTramGiaHan.Text.ToString());

                    txtTongTien.Text = String.Format("{0:#,###0}", ChiPhi);
                }
                catch { }
            }
        }

        private void btnThemMaPhieuDangKy_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy diaglogPhieuDangKy = new FormPhieuDangKy();
            diaglogPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogPhieuDangKy.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbMaPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
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

        private void cbMaPhieuDangKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkFormLoad)
            {
                double ChiPhi = 0.0;
                ChiPhi = Double.Parse(phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMa(Int32.Parse(cbMaPhieuDangKy.Text.ToString())).Rows[0]["TongTien"].ToString()) * Double.Parse(txtPhanTramGiaHan.Text.ToString());

                txtTongTien.Text = String.Format("{0:#,###0}", ChiPhi);
            }
        }
    }
}
