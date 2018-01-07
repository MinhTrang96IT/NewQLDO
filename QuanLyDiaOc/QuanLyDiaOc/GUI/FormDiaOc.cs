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
        private int MaKhachHangPoup = 0;
        DiaOcBLL diaOcBLL;
        KhachHangBLL khachHangBLL;
        LoaiDiaOcBLL loaiDiaOcBLL;
        LoaiNhaBLL loaiNhaBLL;
        string id;
        private bool checkLoadDone = false;
        public FormDiaOc()
        {
            InitializeComponent();
            id = "";
            diaOcBLL = new DiaOcBLL();
            khachHangBLL = new KhachHangBLL();
            loaiDiaOcBLL = new LoaiDiaOcBLL();
            loaiNhaBLL = new LoaiNhaBLL();
        }

        public FormDiaOc(int maKhachHang) : this()
        {
            MaKhachHangPoup = maKhachHang;
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

                    DiaOcDTO diaOcDTO = new DiaOcDTO(
                                   Int32.Parse(cbKhachHang.SelectedValue.ToString()),
                                   Int32.Parse(cbLoaiDiaOc.SelectedValue.ToString()),
                                   Int32.Parse(cbLoaiNha.SelectedValue.ToString()),
                                   txtDiaChi.Text.ToString(),
                                   Double.Parse(txtDienTichKhuonVien.Text.ToString()),
                                   Double.Parse(txtDienTichSuDung.Text.ToString()),
                                   txtHuongNha.Text.ToString(),
                                   Double.Parse(txtChieuDaiDat.Text.ToString()),
                                   Double.Parse(txtChieuRongDat.Text.ToString()),
                                   Double.Parse(txtChieuDaiNha.Text.ToString()),
                                   Double.Parse(txtChieuRongNha.Text.ToString()),
                                   Int32.Parse(txtSoTang.Text.ToString()),
                                   txtMoTaChiTiet.Text.ToString(),
                                   Double.Parse(txtGiaBan.Text.ToString()),
                                   trangThaiKiemDuyet, trangThaiMuaBan,"");

                    try
                    {
                        if (diaOcBLL.ThemDiaOc(diaOcDTO))
                        {
                            MessageBox.Show("Thêm địa ốc thành công");
                            if(MaKhachHangPoup == 0)
                            {
                                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                            } else
                            {
                                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoMaKH(MaKhachHangPoup);
                            }
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
                        if (MaKhachHangPoup == 0)
                        {
                            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                        }
                        else
                        {
                            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoMaKH(MaKhachHangPoup);
                        }
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

                    DiaOcDTO diaOcDTO = new DiaOcDTO(
                        Int32.Parse(txtMaDiaOc.Text.ToString()),
                        Int32.Parse(cbKhachHang.SelectedValue.ToString()), 
                        Int32.Parse(cbLoaiDiaOc.SelectedValue.ToString()), 
                        Int32.Parse(cbLoaiNha.SelectedValue.ToString()), 
                        txtDiaChi.Text.ToString(), 
                        Double.Parse(txtDienTichKhuonVien.Text.ToString()),
                        Double.Parse(txtDienTichSuDung.Text.ToString()), 
                        txtHuongNha.Text.ToString(),
                        Double.Parse(txtChieuDaiDat.Text.ToString()),
                        Double.Parse(txtChieuRongDat.Text.ToString()),
                        Double.Parse(txtChieuDaiNha.Text.ToString()),
                        Double.Parse(txtChieuRongNha.Text.ToString()), 
                        Int32.Parse(txtSoTang.Text.ToString()), 
                        txtMoTaChiTiet.Text.ToString(), 
                        Double.Parse(txtGiaBan.Text.ToString()), 
                        trangThaiKiemDuyet, trangThaiMuaBan,"");

                    try
                    {
                        if (diaOcBLL.SuaDiaOc(diaOcDTO))
                        {
                            MessageBox.Show("Sửa địa ốc thành công");
                            if (MaKhachHangPoup == 0)
                            {
                                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                            }
                            else
                            {
                                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoMaKH(MaKhachHangPoup);
                            }
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa địa ốc thất bại");
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

        private void FormDiaOc_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            if (MaKhachHangPoup == 0)
            {
                txtMaKhachHang.Visible = false;
                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
            }
            else
            {
                cbKhachHang.Visible = false;
                btnThemKhachHang.Visible = false;
                txtMaKhachHang.Text = MaKhachHangPoup.ToString();
                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoMaKH(MaKhachHangPoup);
            }

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
            checkLoadDone = true;
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
            //Regex regexMoney = new Regex(@"^[0-9]+$");
            //if (!regexMoney.IsMatch(txtGiaBan.Text))
            //{
            //    MessageBox.Show("Giá bán thuộc Money format");
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Regex regexSo = new Regex("^[0-9]+$");
            if (!regexSo.IsMatch(txtTimKiem.Text))
            {
                MessageBox.Show("Phải nhập số mã địa ốc vào đây");
                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
            } else
            {
                DataTable dtTimKiem = diaOcBLL.TimKiemDiaOcTheoMa(Int32.Parse(txtTimKiem.Text));
                if (dtTimKiem.Rows.Count > 0)
                {
                    dgvDiaOc.DataSource = diaOcBLL.TimKiemDiaOcTheoMa(Int32.Parse(txtTimKiem.Text));
                }
                else
                {
                    dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
                }
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
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvDiaOc.Rows[e.RowIndex];
                    txtMaDiaOc.Text = row.Cells["MaDiaOc"].Value.ToString();
                    id = row.Cells["MaDiaOc"].Value.ToString();
                    cbKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                    cbLoaiDiaOc.Text = row.Cells["TenLoaiDiaOc"].Value.ToString();
                    cbLoaiNha.Text = row.Cells["TenLoaiNha"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtDienTichKhuonVien.Text = row.Cells["DienTichKhuonVien"].Value.ToString();
                    txtDienTichSuDung.Text = row.Cells["DienTichSuDung"].Value.ToString();
                    txtCMND.Text = row.Cells["CMND"].Value.ToString();
                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("True"))
                        chkTrangThaiKiemDuyet.Checked = true;
                    else
                        chkTrangThaiKiemDuyet.Checked = false;

                    if (row.Cells["TrangThaiMuaBan"].Value.ToString().Equals("True"))
                        chkTrangThaiMuaBan.Checked = true;
                    else
                        chkTrangThaiMuaBan.Checked = false;

                    txtHuongNha.Text = row.Cells["HuongNha"].Value.ToString();
                    txtChieuDaiDat.Text = row.Cells["ChieuDaiDat"].Value.ToString();
                    txtChieuRongDat.Text = row.Cells["ChieuRongDat"].Value.ToString();
                    txtChieuDaiNha.Text = row.Cells["ChieuDaiNha"].Value.ToString();
                    txtChieuRongNha.Text = row.Cells["ChieuRongNha"].Value.ToString();
                    txtSoTang.Text = row.Cells["SoTang"].Value.ToString();
                    txtMoTaChiTiet.Text = row.Cells["MoTaChiTiet"].Value.ToString();
                    txtGiaBan.Text = String.Format("{0:#,###0}", double.Parse(row.Cells["GiaBan"].Value.ToString()));
                }
                catch { }
            }
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoadDone)
            {
                txtCMND.Text = khachHangBLL.LayDanhSachKhachHangTheoMa(Int32.Parse(cbKhachHang.SelectedValue.ToString())).Rows[0]["CMND"].ToString();
            }
        }

        private void btnQuanLyPhieuDangKy_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                FormPhieuDangKy diaglogPhieuDangKy = new FormPhieuDangKy(Int32.Parse(txtMaDiaOc.Text.ToString()));
                diaglogPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogPhieuDangKy.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                    //       txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa ốc muốn quản lý phiếu đăng ký!");
            }
        }

        private void btnGiayTo_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                FormGiayTo dialogGiayTo = new FormGiayTo(txtMaDiaOc.Text.ToString());
                dialogGiayTo.StartPosition = FormStartPosition.CenterScreen;
                if (dialogGiayTo.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                    //       txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn địa ốc muốn xem giấy tờ!");
            }
        }
    }
}
