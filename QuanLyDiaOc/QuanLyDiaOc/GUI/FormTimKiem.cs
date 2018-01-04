using QuanLyDiaOc.BLL;
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
    public partial class FormTimKiem : Form
    {
        DiaOcBLL diaOcBLL;
        ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        public FormTimKiem()
        {
            InitializeComponent();
            diaOcBLL = new DiaOcBLL();
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dgvDiaOc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDiaOc.Rows[e.RowIndex];
                    int columnIndex = dgvDiaOc.CurrentCell.ColumnIndex;
                    string columnName = dgvDiaOc.Columns[columnIndex].Name;
                    int maDiaOc = Int32.Parse(row.Cells["MaDiaOc"].Value.ToString());

                    if (columnName.Equals("XemGiayTo"))
                    {
                        MessageBox.Show("ád");
                    }

                    lbChiTietQUangCao.Text = "Thông tin quảng cáo của Địa ốc số " + maDiaOc;
                    dgvChiTietQuangCao.DataSource = diaOcBLL.LayDanhSachChiTietQuangCao(maDiaOc);
                    if(diaOcBLL.LayDanhSachChiTietQuangCao(maDiaOc).Rows.Count > 0)
                    {
                        DataGridViewRow rowChiTietQUangCao = this.dgvChiTietQuangCao.Rows[0];
                        txtMaChiTietQuangCao.Text = rowChiTietQUangCao.Cells["MaChiTietQuangCao"].Value.ToString();
                        txtMaPhieuDangKy.Text = rowChiTietQUangCao.Cells["MaPhieuDangKy"].Value.ToString();
                        txtTenLoaiQuangCao.Text = rowChiTietQUangCao.Cells["TenLoaiQuangCao"].Value.ToString();
                        txtTenVitri.Text = rowChiTietQUangCao.Cells["MaViTri"].Value.ToString();
                        txtTenBao.Text = rowChiTietQUangCao.Cells["MaBao"].Value.ToString();
                        txtSoLuong.Text = rowChiTietQUangCao.Cells["SoLuongPhatHanh"].Value.ToString();

                        if (rowChiTietQUangCao.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                            rbDaKiemDuyet.Checked = true;
                        else
                            rbChuaKiemDuyet.Checked = true;
                        if (rowChiTietQUangCao.Cells["NgayBatDau"].Value.ToString() != "")
                            dtpNgayBatDau.Value = Convert.ToDateTime(rowChiTietQUangCao.Cells["NgayBatDau"].Value.ToString());
                        if (rowChiTietQUangCao.Cells["NgayKetThuc"].Value.ToString() != "")
                            dtpNgayKetThuc.Value = Convert.ToDateTime(rowChiTietQUangCao.Cells["NgayKetThuc"].Value.ToString());
                        txtKichThuoc.Text = rowChiTietQUangCao.Cells["KichThuoc"].Value.ToString();
                        if (txtTenLoaiQuangCao.Text.ToString() == "Quảng cáo tờ bướm")
                        {
                            double ChiPhi = Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_ToBuom(Int32.Parse(txtMaChiTietQuangCao.Text)).Rows[0]["DonGia"].ToString()) * Double.Parse(txtSoLuong.Text);
                            txtChiPhi.Text = String.Format("{0:#,###0}", ChiPhi.ToString() + " VNĐ" + " (" + txtSoLuong.Text + " tờ)");
                        }
                        else
                        {
                            double ChiPhi = Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_LoaiKhac(Int32.Parse(txtMaChiTietQuangCao.Text)).Rows[0]["DonGia"].ToString());
                            txtChiPhi.Text = String.Format("{0:#,###0}", ChiPhi.ToString() + " VNĐ");
                        }
                    } else
                    {
                        txtChiPhi.Text = txtKichThuoc.Text = txtMaChiTietQuangCao.Text = txtMaPhieuDangKy.Text = txtSoLuong.Text = txtTenBao.Text = txtTenLoaiQuangCao.Text = txtTenVitri.Text = "";
                    }
                   
                }

                catch
                {
                }
            }

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Regex regexSo = new Regex("^[0-9]+$");
            if (!regexSo.IsMatch(txtTimKiem.Text))
            {
                MessageBox.Show("Phải nhập số mã địa ốc vào đây");
                dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
            }
            else
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOcTheoTenLoai();
        }

        private void dgvChiTietQuangCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvChiTietQuangCao.Rows[e.RowIndex];
                    txtMaChiTietQuangCao.Text = row.Cells["MaChiTietQuangCao"].Value.ToString();
                    txtMaPhieuDangKy.Text = row.Cells["MaPhieuDangKy"].Value.ToString();
                    txtTenLoaiQuangCao.Text = row.Cells["TenLoaiQuangCao"].Value.ToString();
                    txtTenVitri.Text = row.Cells["MaViTri"].Value.ToString();
                    txtTenBao.Text = row.Cells["MaBao"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SoLuongPhatHanh"].Value.ToString();

                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;
                    if (row.Cells["NgayBatDau"].Value.ToString() != "")
                        dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value.ToString());
                    if (row.Cells["NgayKetThuc"].Value.ToString() != "")
                        dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value.ToString());
                    txtKichThuoc.Text = row.Cells["KichThuoc"].Value.ToString();
                    if (txtTenLoaiQuangCao.Text.ToString() == "Quảng cáo tờ bướm")
                    {
                        double ChiPhi = Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_ToBuom(Int32.Parse(txtMaChiTietQuangCao.Text)).Rows[0]["DonGia"].ToString()) * Double.Parse(txtSoLuong.Text);
                        txtChiPhi.Text = String.Format("{0:#,###0}", ChiPhi.ToString() + " VNĐ" + " (" + txtSoLuong.Text + " tờ)");
                    }
                    else
                    {
                        double ChiPhi = Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_LoaiKhac(Int32.Parse(txtMaChiTietQuangCao.Text)).Rows[0]["DonGia"].ToString());
                        txtChiPhi.Text = String.Format("{0:#,###0}", ChiPhi.ToString() + " VNĐ");
                    }
                }
                catch { }
            }
        }

        private void btnBaiViet_Click(object sender, EventArgs e)
        {
            if (txtMaChiTietQuangCao.Text != "")
            {
                FormBaiViet diaglogBaiViet = new FormBaiViet(Int32.Parse(txtMaChiTietQuangCao.Text.ToString()));
                diaglogBaiViet.StartPosition = FormStartPosition.CenterScreen;
                if (diaglogBaiViet.ShowDialog(this) == DialogResult.Yes) { }
                else
                {
                    //txtSoLuongQuangCao.Text = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(Int32.Parse(txtMaPhieuDangKy.Text)).Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Chi tiết quảng cáo muốn xem bài viết!");
            }
        }
    }
}
