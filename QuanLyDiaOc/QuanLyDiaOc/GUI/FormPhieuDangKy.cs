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
        private int  MaDiaOcPoup = 0;
        PhieuDangKyBLL phieuDangKyBLL;
        KhachHangBLL khachHangBLL;
        NhanVienBLL nhanVienBLL;
        DiaOcBLL diaOcBLL;
        ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        string id;
        private List<int> listIdLoaiQuangCao;

        public FormPhieuDangKy(int maDiaOc) : this()
        {
            MaDiaOcPoup = maDiaOc;
        }

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
                            if (MaDiaOcPoup == 0)
                            {
                                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                            }
                            else
                            {
                                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMaDiaOc(MaDiaOcPoup);
                            }
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
                        if (MaDiaOcPoup == 0)
                        {
                            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                        }
                        else
                        {
                            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMaDiaOc(MaDiaOcPoup);
                        }
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
                            if (MaDiaOcPoup == 0)
                            {
                                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
                            }
                            else
                            {
                                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMaDiaOc(MaDiaOcPoup);
                            }
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

        private void AnButton()
        {
            btnTaoMoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FormPhieuDangKy_Load(object sender, EventArgs e)
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
            if (MaDiaOcPoup == 0)
            {
                txtMaDiaOc.Visible = false;
                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            }
            else
            {
                cbKhachHang.Visible = false;
                btnThemDiaOc.Visible = false;
                txtMaDiaOc.Text = MaDiaOcPoup.ToString();
                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMaDiaOc(MaDiaOcPoup);
            }
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
                txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
            }
    
            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaPhieuDangKy.Text = cbKhachHang.Text  = cbDiaOc.Text = cbNhanVien.Text = txtSoLanGiaHan.Text = txtTongTien.Text = "";
            rbChuaKiemDuyet.Checked = true;
            txtSoLuongQuangCao.Text = "0";
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
                    txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();

                    DataTable dtChiTiet = new DataTable();
                    dtChiTiet = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                    listIdLoaiQuangCao = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString())).AsEnumerable()
                           .Select(r => r.Field<int>("MaChiTietQuangCao"))
                           .ToList();
                    double TongTien = 0.0;
                    for(int i = 0; i< listIdLoaiQuangCao.Count;i++)
                    {
                        if (dtChiTiet.Rows[i]["TenLoaiQuangCao"].ToString() == "Quảng cáo tờ bướm")
                        {
                             TongTien += Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_ToBuom(listIdLoaiQuangCao[i]).Rows[0]["DonGia"].ToString()) * Double.Parse(dtChiTiet.Rows[i]["SoLuongPhatHanh"].ToString());
                        }
                        else
                        {
                             TongTien += Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_LoaiKhac(listIdLoaiQuangCao[i]).Rows[0]["DonGia"].ToString());
                        }
                    }

                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value.ToString());
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value.ToString());
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value.ToString());
                    txtTongTien.Text = String.Format("{0:#,###0}", TongTien);
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
                    txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu đăng ký muốn xem chi tiết quảng cáo!");
            }
        }

        private void btnGiaHanDichVu_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                FormPhieuGiaHan diaglogPhieuGiaHan = new FormPhieuGiaHan(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                diaglogPhieuGiaHan.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogPhieuGiaHan.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                //    txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu đăng ký muốn xem gia hạn");
            }
        }

        private void btnHuyDichVu_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                FormHuyDangKy diaglogHuyDangKy = new FormHuyDangKy(Int32.Parse(txtMaPhieuDangKy.Text.ToString()));
                diaglogHuyDangKy.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogHuyDangKy.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                  //  txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu đăng ký muốn Hủy đăng kí");
            }
        }
    }
}
