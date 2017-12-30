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
    public partial class FormChinhSuaThongTin : Form
    {
        NhanVienBLL nhanVienBLl;
        DataTable dtNhanVienDangNhap;
        public FormChinhSuaThongTin()
        {
            InitializeComponent();
            nhanVienBLl = new NhanVienBLL();
            dtNhanVienDangNhap = new DataTable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //    txtHoTen.Focus();
                dtNhanVienDangNhap = nhanVienBLl.LayThongTinDangNhap(FormDangNhap.maNhanVienDangNhap);
                txtHoTen.Text = dtNhanVienDangNhap.Rows[0]["TenNhanVien"].ToString();
                txtCMND.Text = dtNhanVienDangNhap.Rows[0]["CMND"].ToString();
                txtDiaChi.Text = dtNhanVienDangNhap.Rows[0]["DiaChi"].ToString();
                txtSDT.Text = dtNhanVienDangNhap.Rows[0]["SoDienThoai"].ToString();
                txtEmail.Text = dtNhanVienDangNhap.Rows[0]["Email"].ToString();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng đăng nhập lại!");
            }
      
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(KiemTraThongTinHopLe())
            {
                NhanVienDTO nhanVienDTO = new NhanVienDTO(
                    FormDangNhap.maNhanVienDangNhap, 
                    txtHoTen.Text, 
                    txtCMND.Text, 
                    txtDiaChi.Text, 
                    txtSDT.Text,
                    txtEmail.Text,
                    txtMatKhauMoi.Text);

                try
                {
                    if (nhanVienBLl.SuaThongTinTheoMaNhanVien(nhanVienDTO))
                    {
                        MessageBox.Show("Sửa nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại");
                    }
                }
                catch
                {
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool KiemTraThongTinHopLe()
        {
            Regex regTen = new Regex(@"^([\w.'-_?@áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ ]+)$");
            if (!regTen.IsMatch(txtHoTen.Text))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(50, txtHoTen.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(15, txtCMND.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(100, txtDiaChi.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 200 ký tự!");
                return false;
            }
            Regex regSDT = new Regex(@"^(0|\+84)([\d]{9,10})$");
            if (!regSDT.IsMatch(txtSDT.Text))
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
            if (!KiemTraSoKyTuNhapVao(15, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(15, txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 15 ký tự!");
                return false;
            }
            if(txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp? Vui lòng thử lại!");
                return false;
            }
            return true;
        }
    }
}
