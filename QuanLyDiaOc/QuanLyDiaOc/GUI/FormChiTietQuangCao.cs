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
using System.Text.RegularExpressions;

namespace QuanLyDiaOc.GUI
{
    public partial class FormChiTietQuangCao : Form
    {
        private int MaPDKTuFormPDK = 0;
        ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        PhieuDangKyBLL phieuDangKyBLL;
        LoaiQuangCaoBLL loaiQuangCaoBLL;
        ViTriBLL viTriBLL;
        BaoBLL baoBLL;
        string id;
        public FormChiTietQuangCao(int maPhieuDangKy) : this()
        {
            MaPDKTuFormPDK = maPhieuDangKy;
        }

        private void FormChiTietQuangCao_Load(object sender, EventArgs e)
        {
            if (MaPDKTuFormPDK == 0)
            {
                txtMaPhieuDangKy.Visible = false;
                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoTenLoai();
            }
            else
            {
                cbMaPhieuDangKy.Visible = false;
                btnThemPhieuDangKy.Visible = false;
                txtMaPhieuDangKy.Text = MaPDKTuFormPDK.ToString();
                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(MaPDKTuFormPDK);

            }

            cbMaPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
            cbMaPhieuDangKy.DisplayMember = "MaPhieuDangKy";
            cbMaPhieuDangKy.ValueMember = "MaPhieuDangKy";
            cbLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
            cbLoaiQuangCao.DisplayMember = "TenLoaiQuangCao";
            cbLoaiQuangCao.ValueMember = "MaLoaiQuangCao";
            cbViTri.DataSource = viTriBLL.LayDanhSachViTri();
            cbViTri.DisplayMember = "TenViTri";
            cbViTri.ValueMember = "MaViTri";
            cbBao.DataSource = baoBLL.LayDanhSachBao();
            cbBao.DisplayMember = "TenBao";
            cbBao.ValueMember = "MaBao";
            LamMoiThongTin();
        }
        

        public FormChiTietQuangCao()
        {
            InitializeComponent();
            id = "";
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
            phieuDangKyBLL = new PhieuDangKyBLL();
            loaiQuangCaoBLL = new LoaiQuangCaoBLL();
            viTriBLL = new ViTriBLL();
            baoBLL = new BaoBLL();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin chi tiết quảng cáo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;
                    int maPhieuDangKy;
                    if(MaPDKTuFormPDK == 0)
                    {
                        maPhieuDangKy = Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString());
                    } else
                    {
                        maPhieuDangKy = MaPDKTuFormPDK;
                    }
                    ChiTietQuangCaoDTO chiTietQuangCaoDTO = new ChiTietQuangCaoDTO(
                                   maPhieuDangKy,
                                   Int32.Parse(cbLoaiQuangCao.SelectedValue.ToString()),
                                   Int32.Parse(cbViTri.SelectedValue.ToString()),
                                   Int32.Parse(cbBao.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayBatDau.Text),
                                   Convert.ToDateTime(dtpNgayKetThuc.Text),
                                   Int32.Parse(txtSoLuong.Text.ToString()),
                                   Double.Parse(txtKichThuoc.Text.ToString()),
                                   trangThaiKiemDuyet);

                    try
                    {
                        if (chiTietQuangCaoBLL.ThemChiTietQuangCao(chiTietQuangCaoDTO))
                        {
                            MessageBox.Show("Thêm chi tiết quảng cáo thành công");
                            if(MaPDKTuFormPDK == 0)
                            {
                                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoTenLoai();
                            } else
                            {
                                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(MaPDKTuFormPDK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm chi tiết quảng cáo thất bại");
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
                MessageBox.Show("Làm ơn chọn chi tiết quảng cáo muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin chi tiết quảng cáo số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (chiTietQuangCaoBLL.XoaChiTietQuangCao(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách chi tiết quảng cáo thành công");
                        if (MaPDKTuFormPDK == 0)
                        {
                            dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoTenLoai();
                        }
                        else
                        {
                            dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(MaPDKTuFormPDK);
                        }
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết quảng cáo thất bại");
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin chi tiết quảng cáo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;
                    int maPhieuDangKy;
                    if (MaPDKTuFormPDK == 0)
                    {
                        maPhieuDangKy = Int32.Parse(cbMaPhieuDangKy.SelectedValue.ToString());
                    }
                    else
                    {
                        maPhieuDangKy = MaPDKTuFormPDK;
                    }
                    ChiTietQuangCaoDTO chiTietQuangCaoDTO = new ChiTietQuangCaoDTO(
                                   Int32.Parse(txtMaChiTietQuangCao.Text.ToString()),
                                   maPhieuDangKy,
                                   Int32.Parse(cbLoaiQuangCao.SelectedValue.ToString()),
                                   Int32.Parse(cbViTri.SelectedValue.ToString()),
                                   Int32.Parse(cbBao.SelectedValue.ToString()),
                                   Convert.ToDateTime(dtpNgayBatDau.Text),
                                   Convert.ToDateTime(dtpNgayKetThuc.Text),
                                   Int32.Parse(txtSoLuong.Text.ToString()),
                                   Double.Parse(txtKichThuoc.Text.ToString()),
                                   trangThaiKiemDuyet);

                    try
                    {
                        if (chiTietQuangCaoBLL.SuaChiTietQuangCao(chiTietQuangCaoDTO))
                        {
                            MessageBox.Show("Sửa chi tiết quảng cáo thành công");
                            if (MaPDKTuFormPDK == 0)
                            {
                                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoTenLoai();
                            }
                            else
                            {
                                dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(MaPDKTuFormPDK);
                            }
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa chi tiết quảng cáo thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void LamMoiThongTin()
        {
            txtMaChiTietQuangCao.Text = cbBao.Text = cbLoaiQuangCao.Text = cbMaPhieuDangKy.Text = cbViTri.Text = txtKichThuoc.Text = txtSoLuong.Text = "";
            rbChuaKiemDuyet.Checked = true;
            rbDaKiemDuyet.Checked = false;
            txtSoLuong.Focus();
            cbMaPhieuDangKy.SelectedIndex = 0;
            cbLoaiQuangCao.SelectedIndex = 0;
            cbBao.SelectedIndex = 0;
            cbViTri.SelectedIndex = 0;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtSoLuong.Text.ToString() == "" || txtKichThuoc.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            Regex regexSo = new Regex("^[0-9]+$");
            if (!regexSo.IsMatch(txtSoLuong.Text))
            {
                MessageBox.Show("Tổng tiền chỉ được nhập số");
                return false;
            }
            Regex regSoThuc = new Regex(@"[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)");
            if (!regSoThuc.IsMatch(txtKichThuoc.Text))
            {
                MessageBox.Show("Kích thước phải là số thực");
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

        private void btnThemPhieuDangKy_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy diaglogPhieuDangKy = new FormPhieuDangKy();
            diaglogPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogPhieuDangKy.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbMaPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
            }
        }

        private void btnThemLoaiQuangCao_Click(object sender, EventArgs e)
        {
            FormLoaiQuangCao diaglogLoaiQuangCao = new FormLoaiQuangCao();
            diaglogLoaiQuangCao.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogLoaiQuangCao.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
            }
        }

        private void btnThemBao_Click(object sender, EventArgs e)
        {
            FormBao diaglogBao = new FormBao();
            diaglogBao.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogBao.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbBao.DataSource = baoBLL.LayDanhSachBao();
            }
        }

        private void btnThemViTri_Click(object sender, EventArgs e)
        {
            FormViTri diaglogViTri= new FormViTri();
            diaglogViTri.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogViTri.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbViTri.DataSource = viTriBLL.LayDanhSachViTri();
            }
        }

        private void dgvChiTietQuangCao_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvChiTietQuangCao.Rows[e.RowIndex];
                    txtMaChiTietQuangCao.Text = row.Cells["MaChiTietQuangCao"].Value.ToString();
                    id = row.Cells["MaChiTietQuangCao"].Value.ToString();
                    cbMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    cbLoaiQuangCao.Text = row.Cells["TenLoaiQuangCao"].Value.ToString();
                    cbViTri.Text = row.Cells["TenViTri"].Value.ToString();
                    cbBao.Text = row.Cells["TenBao"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SoLuongPhatHanh"].Value.ToString();
                    
                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;

                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value.ToString());
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value.ToString());
                    txtKichThuoc.Text = row.Cells["KichThuoc"].Value.ToString();

                    double ChiPhi = Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa(Int32.Parse(id)).Rows[0]["DonGia"].ToString()) * Double.Parse(txtSoLuong.Text);
                    txtChiPhi.Text = String.Format("{0:#,###0}", ChiPhi.ToString() + " VNĐ");
                }
                catch { }
            }
        }
    }
}
