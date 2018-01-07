using QuanLyDiaOc.BLL;
using QuanLyDiaOc.DTO;
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
    public partial class FormLoaiNhanVien : Form
    {
        private LoaiNhanVienBLL loaiNhanVienBLL;
        private string id;

        public FormLoaiNhanVien()
        {
            InitializeComponent();
            loaiNhanVienBLL = new LoaiNhanVienBLL();
            id = "";
        }

        private void dgvLoaiNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvLoaiNhanVien.Rows[e.RowIndex];
                    txtMaLoaiNhanVien.Text = row.Cells["MaLoaiNhanVien"].Value.ToString();
                    id = row.Cells["MaLoaiNhanVien"].Value.ToString();
                    txtTenLoaiNhanVien.Text = row.Cells["TenLoaiNhanVien"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaLoaiNhanVien"].Value.ToString();
                }
                catch { }
            }
        }

        private void AnButton()
        {
            btnTaoMoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FormLoaiNhanVien_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - giám đốc"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            LamMoiThongTin();
            dgvLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
        }

        private void LamMoiThongTin()
        {
            txtMaLoaiNhanVien.Text = txtTenLoaiNhanVien.Text = txtMoTa.Text = "";
            txtTenLoaiNhanVien.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenLoaiNhanVien.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenLoaiNhanVien.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 50 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(200, txtMoTa.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 ký tự!");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin loại nhân viên");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    LoaiNhanVienDTO loaiNhanVienDTO = new LoaiNhanVienDTO(txtTenLoaiNhanVien.Text, txtMoTa.Text);

                    try
                    {
                        if (loaiNhanVienBLL.ThemLoaiNhanVien(loaiNhanVienDTO))
                        {
                            MessageBox.Show("Thêm loại nhân viên thành công");
                            dgvLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại nhân viên thất bại");
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
                MessageBox.Show("Làm ơn chọn loại nhân viên muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin loại nhân viên số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (loaiNhanVienBLL.XoaLoaiNhanVien(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa loại nhân viên thành công");
                        dgvLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại nhân viên thất bại");
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
                MessageBox.Show("Làm ơn chọn loại nhân viên muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin loại nhân viên");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        LoaiNhanVienDTO loaiNhanVienDTO = new LoaiNhanVienDTO(Int32.Parse(txtMaLoaiNhanVien.Text), txtTenLoaiNhanVien.Text, txtMoTa.Text);

                        try
                        {
                            if (loaiNhanVienBLL.SuaLoaiNhanVien(loaiNhanVienDTO))
                            {
                                MessageBox.Show("Sửa loại nhân viên thành công");
                                dgvLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa loại nhân viên thất bại");
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
            dgvLoaiNhanVien.DataSource = loaiNhanVienBLL.TimKiemLoaiNhanVienTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
