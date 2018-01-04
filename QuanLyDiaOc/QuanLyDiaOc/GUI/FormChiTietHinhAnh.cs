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
using System.IO;

namespace QuanLyDiaOc.GUI
{
    public partial class FormChiTietHinhAnh : Form
    {
        private ChiTietHinhAnhBLL chiTietHinhAnhBLL;
        private HinhAnhBLL hinhAnhBLL;
        private bool kt;
        private string id;
        private byte[] arr;
        private ImageConverter converter;
        public FormChiTietHinhAnh()
        {
            InitializeComponent();
            chiTietHinhAnhBLL = new ChiTietHinhAnhBLL();
            hinhAnhBLL = new HinhAnhBLL();
            kt = false;
            id = "";
            converter = new ImageConverter();
        }

        public FormChiTietHinhAnh(string maHA) : this()
        {
            kt = true;
            dgvChiTietHinhAnh.DataSource = chiTietHinhAnhBLL.LayDanhSachChiTietHinhAnhTheoMaHA(Int32.Parse(maHA));
            cbMaHA.DropDownStyle = ComboBoxStyle.Simple;
            cbMaHA.Text = maHA;
            AnThongTin();
        }

        private void AnThongTin()
        {
            cbMaHA.Enabled = false;
            btnThemMaHA.Enabled = false;
        }

        private void FormChiTietHinhAnh_Load(object sender, EventArgs e)
        {
            if (!kt)
            {
                dgvChiTietHinhAnh.DataSource = chiTietHinhAnhBLL.LayDanhSachChiTietHinhAnh();
                cbMaHA.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
                cbMaHA.DisplayMember = "MaHinhAnh";
                cbMaHA.ValueMember = "MaHinhAnh";
            }
        }

        private void LamMoiThongTin()
        {
            txtMaChiTiet.Text = txtMoTa.Text = "";
            txtMoTa.Focus();
            cbMaHA.SelectedIndex = 0;
            pbHinhAnh.Image = null;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtMoTa.Text.ToString().Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            if (!KiemTraSoKyTuNhapVao(100, txtMoTa.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự!");
                return false;
            }
            Image img = pbHinhAnh.Image;
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            if (arr.Length == 0)
            {
                MessageBox.Show("Làm ơn chọn hình ảnh");
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

        private void dgvChiTietHinhAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvChiTietHinhAnh.Rows[e.RowIndex];
                    txtMaChiTiet.Text = row.Cells["MaChiTietHinhAnh"].Value.ToString();
                    id = row.Cells["MaChiTietHinhAnh"].Value.ToString();
                    cbMaHA.Text = row.Cells["MaHinhAnh"].Value.ToString();
                    pbHinhAnh.Image = (Bitmap)((new ImageConverter()).ConvertFrom(row.Cells["HinhAnh"].Value));
                    txtMoTa.Text = row.Cells["MoTaHinhAnh"].Value.ToString();
                }
                catch { }
            }
        }

        private void btnChonHA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbHinhAnh.Image = new Bitmap(dlg.FileName);
            }

            dlg.Dispose();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void ThemMaHA_Click(object sender, EventArgs e)
        {
            FormHinhAnh diaglogHinhAnh = new FormHinhAnh();
            diaglogHinhAnh.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogHinhAnh.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbMaHA.DataSource = hinhAnhBLL.LayDanhSachHinhAnh();
            }
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
                    try
                    {
                        if (chiTietHinhAnhBLL.ThemChiTietHinhAnh(Int32.Parse(cbMaHA.SelectedValue.ToString()), arr, txtMoTa.Text.ToString()))
                        {
                            MessageBox.Show("Thêm chi tiết hình ảnh thành công");
                            dgvChiTietHinhAnh.DataSource = chiTietHinhAnhBLL.LayDanhSachChiTietHinhAnh();
                        }
                        else
                        {
                            MessageBox.Show("Thêm chi tiết hình ảnh thất bại");
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
                MessageBox.Show("Làm ơn chọn chi tiết hình ảnh muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin chi tiết hình ảnh số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (chiTietHinhAnhBLL.XoaChiTietHinhAnh(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách chi tiết hình ảnh thành công");
                        dgvChiTietHinhAnh.DataSource = chiTietHinhAnhBLL.LayDanhSachChiTietHinhAnh();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết hình ảnh thất bại");
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
                MessageBox.Show("Làm ơn chọn chi tiết hình ảnh muốn sửa", "Thông báo");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin chi tiết quảng cáo");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        try
                        {
                            if (chiTietHinhAnhBLL.SuaChiTietHinhAnh(Int32.Parse(txtMaChiTiet.Text.ToString()), Int32.Parse(cbMaHA.SelectedValue.ToString()), arr, txtMoTa.Text.ToString()))
                            {
                                MessageBox.Show("Sửa chi tiết hình ảnh thành công");
                                dgvChiTietHinhAnh.DataSource = chiTietHinhAnhBLL.LayDanhSachChiTietHinhAnh();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa chi tiết hình ảnh thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }
    }
}