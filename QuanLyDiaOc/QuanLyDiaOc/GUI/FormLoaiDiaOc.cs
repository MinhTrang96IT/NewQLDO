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
    public partial class FormLoaiDiaOc : Form
    {
        private LoaiDiaOcBLL loaiDiaOcBLL;
        private string id;

        public FormLoaiDiaOc()
        {
            InitializeComponent();
            loaiDiaOcBLL = new LoaiDiaOcBLL();
            id = "";
        }

        private void dgvLoaiDiaOc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvLoaiDiaOc.Rows[e.RowIndex];
                    txtMaLoaiDiaOc.Text = row.Cells["MaLoaiDiaOc"].Value.ToString();
                    id = row.Cells["MaLoaiDiaOc"].Value.ToString();
                    txtTenLoaiDiaOc.Text = row.Cells["TenLoaiDiaOc"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                }
                catch { }
            }
        }

        private void FormLoaiDiaOc_Load(object sender, EventArgs e)
        {
            LamMoiThongTin();
            dgvLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
        }

        private void LamMoiThongTin()
        {
            txtMaLoaiDiaOc.Text = txtTenLoaiDiaOc.Text = txtMoTa.Text ="";
            txtTenLoaiDiaOc.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenLoaiDiaOc.Text.ToString() == "" || txtMoTa.Text.ToString() == "" )
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            
            if (!KiemTraSoKyTuNhapVao(100, txtTenLoaiDiaOc.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 100 ký tự");
                return false;
            }
            if (!KiemTraSoKyTuNhapVao(500, txtMoTa.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 500 ký tự!");
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin loại địa ốc");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    LoaiDiaOcDTO loaiDiaOcDTO = new LoaiDiaOcDTO(txtTenLoaiDiaOc.Text, txtMoTa.Text);

                    try
                    {
                        if (loaiDiaOcBLL.ThemLoaiDiaOc(loaiDiaOcDTO))
                        {
                            MessageBox.Show("Thêm loại địa ốc thành công");
                            dgvLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại địa ốc thất bại");
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
                MessageBox.Show("Làm ơn chọn loại địa ốc muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin loại địa ốc số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (loaiDiaOcBLL.XoaLoaiDiaOc(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa loại địa ốc thành công");
                        dgvLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại địa ốc thất bại");
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
                MessageBox.Show("Làm ơn chọn loại địa ốc muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin loại địa ốc");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        LoaiDiaOcDTO loaiDiaOcDTO = new LoaiDiaOcDTO(Int32.Parse(txtMaLoaiDiaOc.Text), txtTenLoaiDiaOc.Text, txtMoTa.Text);

                        try
                        {
                            if (loaiDiaOcBLL.SuaLoaiDiaOc(loaiDiaOcDTO))
                            {
                                MessageBox.Show("Sửa loại địa ốc thành công");
                                dgvLoaiDiaOc.DataSource = loaiDiaOcBLL.LayDanhSachLoaiDiaOc();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa loại địa ốc thất bại");
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
            dgvLoaiDiaOc.DataSource = loaiDiaOcBLL.TimKiemLoaiDiaOcTheoTen(txtTimKiem.Text);
        }
    }
}
