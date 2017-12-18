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
    public partial class FormPhongBan : Form
    {
        private PhongBanBLL phongBanBLL;
        private string id;

        public FormPhongBan()
        {
            InitializeComponent();
            phongBanBLL = new PhongBanBLL();
            id = "";
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvPhongBan.Rows[e.RowIndex];
                    txtMaPhongBan.Text = row.Cells["MaPhongBan"].Value.ToString();
                    id = row.Cells["MaPhongBan"].Value.ToString();
                    txtTenPhongBan.Text = row.Cells["TenLPhongBan"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaPhongBan"].Value.ToString();
                }
                catch { }
            }
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            LamMoiThongTin();
            dgvPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
        }

        private void LamMoiThongTin()
        {
            txtMaPhongBan.Text = txtTenPhongBan.Text = txtMoTa.Text = "";
            txtTenPhongBan.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenPhongBan.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenPhongBan.Text))
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin phòng ban");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    PhongBanDTO phongBanDTO = new PhongBanDTO(txtTenPhongBan.Text, txtMoTa.Text);

                    try
                    {
                        if (phongBanBLL.ThemPhongBan(phongBanDTO))
                        {
                            MessageBox.Show("Thêm phòng ban thành công");
                            dgvPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
                        }
                        else
                        {
                            MessageBox.Show("Thêm phòng ban thất bại");
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
                MessageBox.Show("Làm ơn chọn phòng ban muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin phòng ban số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (phongBanBLL.XoaPhongBan(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa phòng ban thành công");
                        dgvPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng ban thất bại");
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
                MessageBox.Show("Làm ơn chọn phòng ban muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin phòng ban");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        PhongBanDTO phongBanDTO = new PhongBanDTO(Int32.Parse(txtMaPhongBan.Text), txtTenPhongBan.Text, txtMoTa.Text);

                        try
                        {
                            if (phongBanBLL.SuaPhongBan(phongBanDTO))
                            {
                                MessageBox.Show("Sửa phòng ban thành công");
                                dgvPhongBan.DataSource = phongBanBLL.LayDanhSachPhongBan();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa phòng ban thất bại");
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
            dgvPhongBan.DataSource = phongBanBLL.TimKiemPhongBanTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
