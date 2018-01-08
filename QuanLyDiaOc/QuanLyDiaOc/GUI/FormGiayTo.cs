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

namespace QuanLyDiaOc.GUI
{
    public partial class FormGiayTo : Form
    {
        private GiayToBLL giayToBLL;
        private DiaOcBLL diaOcBLL;
        private bool kt;
        private string id;
        private byte[] arr;
        private ImageConverter converter;

        public FormGiayTo()
        {
            InitializeComponent();
            giayToBLL = new GiayToBLL();
            diaOcBLL = new DiaOcBLL();
            kt = false;
            id = "";
            converter = new ImageConverter();
        }

        public FormGiayTo(string maDO) : this()
        {
            kt = true;
            dgvGiayTo.DataSource = giayToBLL.LayDanhSachGiayToTheoMaDO(Int32.Parse(maDO));
            cbMaDO.DisplayMember = "MaDiaOc";
            cbMaDO.ValueMember = "MaDiaOc";
            cbMaDO.DropDownStyle = ComboBoxStyle.Simple;
            cbMaDO.Text = maDO;
            AnThongTin();
        }

        private void AnThongTin()
        {
            cbMaDO.Enabled = false;
            btnThemMaHA.Enabled = false;
        }

        private void LamMoiThongTin()
        {
            txtMaGiayTo.Text = txtTenGiayTo.Text = "";
            txtTenGiayTo.Focus();
            //cbMaDO.SelectedIndex = 0;
            pbHinhAnh.Image = null;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenGiayTo.Text.ToString().Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            if (!KiemTraSoKyTuNhapVao(100, txtTenGiayTo.Text))
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin giấy tờ");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    try
                    {
                        if (giayToBLL.ThemGiayTo(Int32.Parse(cbMaDO.Text.ToString()), arr, txtTenGiayTo.Text.ToString()))
                        {
                            MessageBox.Show("Thêm giấy tờ thành công");
                            dgvGiayTo.DataSource = giayToBLL.LayDanhSachGiayTo();
                        }
                        else
                        {
                            MessageBox.Show("Thêm giấy tờ thất bại");
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
                MessageBox.Show("Làm ơn chọn giấy tờ muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin giấy tờ số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (giayToBLL.XoaGiayTo(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách giấy tờ thành công");
                        dgvGiayTo.DataSource = giayToBLL.LayDanhSachGiayTo();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóagiấy tờ thất bại");
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
                MessageBox.Show("Làm ơn chọn giấy tờ muốn sửa", "Thông báo");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin giấy tờ");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        try
                        {
                            if (giayToBLL.SuaGiayTo(Int32.Parse(txtMaGiayTo.Text.ToString()), Int32.Parse(cbMaDO.Text.ToString()), arr, txtTenGiayTo.Text.ToString()))
                            {
                                MessageBox.Show("Sửa giấy tờ thành công");
                                dgvGiayTo.DataSource = giayToBLL.LayDanhSachGiayTo();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa giấy tờ thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }
                }
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

        private void dgvGiayTo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvGiayTo.Rows[e.RowIndex];
                    txtMaGiayTo.Text = row.Cells["MaGiayTo"].Value.ToString();
                    id = row.Cells["MaGiayTo"].Value.ToString();
                    cbMaDO.Text = row.Cells["MaDiaOc"].Value.ToString();
                    pbHinhAnh.Image = (Bitmap)((new ImageConverter()).ConvertFrom(row.Cells["ScanGiayTo"].Value));
                    txtTenGiayTo.Text = row.Cells["TenGiayTo"].Value.ToString();
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

        private void FormGiayTo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            if (!kt)
            {
                dgvGiayTo.DataSource = giayToBLL.LayDanhSachGiayTo();
                cbMaDO.DataSource = diaOcBLL.LayDanhSachDiaOc();
                cbMaDO.DisplayMember = "MaDiaOc";
                cbMaDO.ValueMember = "MaDiaOc";
            }
        }
    }
}
