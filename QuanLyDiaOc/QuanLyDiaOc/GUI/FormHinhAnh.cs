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
    public partial class FormHinhAnh : Form
    {
        private DiaOcBLL diaOcBLL;
        private int MaDiaOc = 0;
        private int MaPDKTuFormPDK = 0;
        private HinhAnhBLL hinhAnhBLL;
        private PhieuDangKyBLL phieuDangKyBLL;
        private NhanVienBLL nhanVienBLL;
        private string id;

        public FormHinhAnh(int maPhieuDangKy) : this()
        {
            MaPDKTuFormPDK = maPhieuDangKy;
        }

        public FormHinhAnh(bool checkDiaOc,int maDiaOc) : this()
        {
            MaDiaOc = maDiaOc;
        }
        public FormHinhAnh()
        {
            InitializeComponent();
            hinhAnhBLL = new HinhAnhBLL();
            phieuDangKyBLL = new PhieuDangKyBLL();
            nhanVienBLL = new NhanVienBLL();
            diaOcBLL = new DiaOcBLL();
            id = "";
        }

        private void FormHinhAnh_Load(object sender, EventArgs e)
        {
            if (MaPDKTuFormPDK == 0 && MaDiaOc == 0)
            {
                txtMaPhieuDangKy.Visible = false;
                dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
            } else if(MaDiaOc > 0 && MaPDKTuFormPDK == 0){
                txtMaPhieuDangKy.Visible = false;
                dgvHinhAnh.DataSource = diaOcBLL.LayDanhSachHinhAnh(MaDiaOc);
            }
            else if(MaDiaOc == 0 && MaPDKTuFormPDK > 0)
            {
                cbMaPDK.Visible = false;
                txtMaPhieuDangKy.Text = MaPDKTuFormPDK.ToString();
                btnThemPDK.Visible = false;
                dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachTheoMaPDK(MaPDKTuFormPDK);
            }
            if(MaDiaOc == 0)
            {
                cbMaPDK.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
            } else
            {
                cbMaPDK.DataSource = diaOcBLL.LayDanhSachHinhAnh(MaDiaOc);
            }
            cbMaPDK.DisplayMember = "MaPhieuDangKy";
            cbMaPDK.ValueMember = "MaPhieuDangKy";
            cbMaNV.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
        }

        private void btnThemPDK_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy diaglogPhieuDangKy = new FormPhieuDangKy();
            diaglogPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogPhieuDangKy.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbMaPDK.DataSource = phieuDangKyBLL.LayDanhSachPhieuDangKy();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormNhanVien diaglogNhanVien = new FormNhanVien();
            diaglogNhanVien.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogNhanVien.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbMaNV.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            }
        }

        private void LamMoiThongTin()
        {
            txtMaHA.Text = txtTimKiem.Text = "";
            cbMaNV.SelectedIndex = 0;
            cbMaPDK.SelectedIndex = 0;
            dtpNgayChup.Value = DateTime.Now;
            dtpNgayHC.Value = DateTime.Now;
            id = "";
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private bool KiemTraThongTinTrong()
        {
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            if(Convert.ToDateTime(dtpNgayChup.Text) < Convert.ToDateTime(dtpNgayHC.Text))
            {
                MessageBox.Show("Ngày chụp phải trùng hoặc sau ngày hẹn chụp");
                return false;
            }
            return true;
        }

        private void dgvHinhAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvHinhAnh.Rows[e.RowIndex];
                    txtMaHA.Text = row.Cells["MaHinhAnh"].Value.ToString();
                    id = row.Cells["MaHinhAnh"].Value.ToString();
                    cbMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                    cbMaPDK.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    dtpNgayChup.Value = Convert.ToDateTime(row.Cells["NgayChupAnh"].Value.ToString());
                    dtpNgayHC.Value = Convert.ToDateTime(row.Cells["NgayHenChupAnh"].Value.ToString());
                }
                catch { }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin hình ảnh");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    HinhAnhDTO hinhAnhDTO = new HinhAnhDTO(
                        Int32.Parse(cbMaPDK.SelectedValue.ToString()),
                        Int32.Parse(cbMaNV.SelectedValue.ToString()),
                        Convert.ToDateTime(dtpNgayHC.Text),
                        Convert.ToDateTime(dtpNgayChup.Text));
                    try
                    {
                        if (hinhAnhBLL.ThemHinhAnh(hinhAnhDTO))
                        {
                            MessageBox.Show("Thêm hình ảnh thành công");
                            if (MaPDKTuFormPDK == 0 && MaDiaOc == 0)
                            {
                                dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
                            }
                            else if(MaPDKTuFormPDK > 0 && MaDiaOc == 0)
                            {
                                dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachTheoMaPDK(MaPDKTuFormPDK);
                            } else if (MaPDKTuFormPDK == 0 && MaDiaOc > 0)
                            {
                                dgvHinhAnh.DataSource = diaOcBLL.LayDanhSachHinhAnh(MaDiaOc);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm hình ảnh thất bại");
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
                MessageBox.Show("Làm ơn chọn hình ảnh muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin hình ảnh số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (hinhAnhBLL.XoaHinhAnh(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách hình ảnh thành công");
                        if (MaPDKTuFormPDK == 0 && MaDiaOc == 0)
                        {
                            dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
                        }
                        else if (MaPDKTuFormPDK > 0 && MaDiaOc == 0)
                        {
                            dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachTheoMaPDK(MaPDKTuFormPDK);
                        }
                        else if (MaPDKTuFormPDK == 0 && MaDiaOc > 0)
                        {
                            dgvHinhAnh.DataSource = diaOcBLL.LayDanhSachHinhAnh(MaDiaOc);
                        }
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hình ảnh thất bại");
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
            if (id == "")
            {
                MessageBox.Show("Làm ơn chọn hình ảnh muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin hình ảnh");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        HinhAnhDTO hinhAnhDTO = new HinhAnhDTO(
                            Int32.Parse(txtMaHA.Text.ToString()),
                            Int32.Parse(cbMaPDK.SelectedValue.ToString()),
                            Int32.Parse(cbMaNV.SelectedValue.ToString()),
                            Convert.ToDateTime(dtpNgayHC.Text),
                            Convert.ToDateTime(dtpNgayChup.Text));

                        try
                        {
                            if (hinhAnhBLL.SuaHinhAnh(hinhAnhDTO))
                            {
                                MessageBox.Show("Sửa hình ảnh thành công");
                                if (MaPDKTuFormPDK == 0 && MaDiaOc == 0)
                                {
                                    dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
                                }
                                else if (MaPDKTuFormPDK > 0 && MaDiaOc == 0)
                                {
                                    dgvHinhAnh.DataSource = hinhAnhBLL.LayDanhSachTheoMaPDK(MaPDKTuFormPDK);
                                }
                                else if (MaPDKTuFormPDK == 0 && MaDiaOc > 0)
                                {
                                    dgvHinhAnh.DataSource = diaOcBLL.LayDanhSachHinhAnh(MaDiaOc);
                                }
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa hình ảnh thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //dgvHinhAnh.DataSource = hinhAnhBLL.TimKiemHATheoTen(txtTimKiem.Text);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Làm ơn chọn hình ảnh muốn xem chi tiết");
            }
            else
            { 
                FormChiTietHinhAnh diaglogChiTietHinhAnh = new FormChiTietHinhAnh(id);
                diaglogChiTietHinhAnh.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogChiTietHinhAnh.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                    cbMaNV.DataSource = nhanVienBLL.LayDanhSachNhanVien();
                }
            }
        }
    }
}
