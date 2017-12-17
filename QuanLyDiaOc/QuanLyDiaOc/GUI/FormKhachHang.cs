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
using System.Text.RegularExpressions;

namespace QuanLyDiaOc.GUI
{
    public partial class FormKhachHang : Form
    {
        private KhachHangBLL khachHangBLL;
        private string id;
        public FormKhachHang()
        {
            InitializeComponent();
            khachHangBLL = new KhachHangBLL();
            id = "";
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LamMoiThongTin();
            dgvKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
        }

        private void LamMoiThongTin()
        {
            txtMaKH.Text = txtTenKH.Text = txtNamSinh.Text = txtCMND.Text = txtSoDienThoai.Text = txtEmail.Text = txtDiaChi.Text = txtTimKiem.Text = "";
            rbNam.Checked = true;
            txtTenKH.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenKH.Text.ToString() == "" || txtNamSinh.Text.ToString() == "" || txtDiaChi.Text.ToString() == "" || txtSoDienThoai.Text.ToString() == "" || txtEmail.Text.ToString() == "" || txtCMND.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            Regex regTen = new Regex(@"^([\w.'-_?@áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ ]+)$");
            if (!regTen.IsMatch(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(100, txtTenKH.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(200, txtDiaChi.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 ký tự!");
                return false;
            }
            Regex regSDT = new Regex(@"^(0|\+84)([\d]{9,10})$");
            if (!regSDT.IsMatch(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại phải 10 hoặc 11 số");
                return false;
            }
            Regex regEmail = new Regex(@"^[\w._%+-]+@([\w\.]+)$");
            if (!regEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng");
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];
                    txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                    id = row.Cells["MaKhachHang"].Value.ToString();
                    txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                    txtCMND.Text = row.Cells["CMND"].Value.ToString();
                    if (row.Cells["GioiTinh"].Value.ToString().Equals("True"))
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                    txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    txtSoDienThoai.Text = row.Cells["SoDienthoai"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin khách hàng");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int gioiTinh = 1;
                    if (rbNu.Checked)
                        gioiTinh = 0;

                    KhachHangDTO khachHangDTO = new KhachHangDTO(txtTenKH.Text, txtCMND.Text, gioiTinh, Int32.Parse(txtNamSinh.Text), txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text);

                    try
                    {
                        if (khachHangBLL.ThemKhachHang(khachHangDTO))
                        {
                            MessageBox.Show("Thêm khách hàng thành công");
                            dgvKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng thất bại");
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
                MessageBox.Show("Làm ơn chọn khách hàng muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (khachHangBLL.XoaKhachHang(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        dgvKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
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
                MessageBox.Show("Làm ơn chọn khách hàng muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin khách hàng");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        int gioiTinh = 1;
                        if (rbNu.Checked)
                            gioiTinh = 0;

                        KhachHangDTO khachHangDTO = new KhachHangDTO(Int32.Parse(txtMaKH.Text) ,txtTenKH.Text, txtCMND.Text, gioiTinh, Int32.Parse(txtNamSinh.Text), txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text);

                        try
                        {
                            if (khachHangBLL.SuaKhachHang(khachHangDTO))
                            {
                                MessageBox.Show("Sửa khách hàng thành công");
                                dgvKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa khách hàng thất bại");
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
            dgvKhachHang.DataSource = khachHangBLL.TimKiemKHTheoTen(txtTimKiem.Text);
        }
    }
}
