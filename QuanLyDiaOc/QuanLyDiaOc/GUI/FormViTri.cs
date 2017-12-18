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
    public partial class FormViTri : Form
    {
        private ViTriBLL viTriBLL;
        private string id;

        public FormViTri()
        {
            InitializeComponent();
            viTriBLL = new ViTriBLL();
            id = "";
        }

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvViTri.Rows[e.RowIndex];
                    txtMaViTri.Text = row.Cells["MaViTri"].Value.ToString();
                    id = row.Cells["MaViTri"].Value.ToString();
                    txtTenViTri.Text = row.Cells["TenViTri"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaViTri"].Value.ToString();
                }
                catch { }
            }
        }

        private void FormViTri_Load(object sender, EventArgs e)
        {
            LamMoiThongTin();
            dgvViTri.DataSource = viTriBLL.LayDanhSachViTri();
        }

        private void LamMoiThongTin()
        {
            txtMaViTri.Text = txtTenViTri.Text = txtMoTa.Text = "";
            txtTenViTri.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenViTri.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenViTri.Text))
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin vị trí");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    ViTriDTO viTriDTO = new ViTriDTO(txtTenViTri.Text, txtMoTa.Text);

                    try
                    {
                        if (viTriBLL.ThemViTri(viTriDTO))
                        {
                            MessageBox.Show("Thêm vị trí thành công");
                            dgvViTri.DataSource = viTriBLL.LayDanhSachViTri();
                        }
                        else
                        {
                            MessageBox.Show("Thêm vị trí thất bại");
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
                MessageBox.Show("Làm ơn chọn vị trí muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin vị trí số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (viTriBLL.XoaViTri(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa vị trí thành công");
                        dgvViTri.DataSource = viTriBLL.LayDanhSachViTri();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vị trí thất bại");
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
                MessageBox.Show("Làm ơn chọn vị trí muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin vị trí");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        ViTriDTO viTriDTO = new ViTriDTO(Int32.Parse(txtMaViTri.Text), txtTenViTri.Text, txtMoTa.Text);

                        try
                        {
                            if (viTriBLL.SuaViTri(viTriDTO))
                            {
                                MessageBox.Show("Sửa vị trí thành công");
                                dgvViTri.DataSource = viTriBLL.LayDanhSachViTri();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa vị trí thất bại");
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
            dgvViTri.DataSource = viTriBLL.TimKiemViTriTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
