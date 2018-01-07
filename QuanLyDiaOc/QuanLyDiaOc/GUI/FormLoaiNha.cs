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
    public partial class FormLoaiNha : Form
    {
        private LoaiNhaBLL loaiNhaBLL;
        private string id;

        public FormLoaiNha()
        {
            InitializeComponent();
            loaiNhaBLL = new LoaiNhaBLL();
            id = "";
        }

        private void dgvLoaiNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvLoaiNha.Rows[e.RowIndex];
                    txtMaLoaiNha.Text = row.Cells["MaLoaiNha"].Value.ToString();
                    id = row.Cells["MaLoaiNha"].Value.ToString();
                    txtTenLoaiNha.Text = row.Cells["TenLoaiNha"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
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

        private void FormLoaiNha_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa") && !Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - nhân viên quảng cáo"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            LamMoiThongTin();
            dgvLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
        }

        private void LamMoiThongTin()
        {
            txtMaLoaiNha.Text = txtTenLoaiNha.Text = txtMoTa.Text = "";
            txtTenLoaiNha.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenLoaiNha.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(100, txtTenLoaiNha.Text))
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin loại nhà");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    LoaiNhaDTO loaiNhaDTO = new LoaiNhaDTO(txtTenLoaiNha.Text, txtMoTa.Text);

                    try
                    {
                        if (loaiNhaBLL.ThemLoaiNha(loaiNhaDTO))
                        {
                            MessageBox.Show("Thêm loại nhà thành công");
                            dgvLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại nhà thất bại");
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
                MessageBox.Show("Làm ơn chọn loại nhà muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin loại nhà số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (loaiNhaBLL.XoaLoaiNha(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa loại nhà thành công");
                        dgvLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại nhà thất bại");
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
                MessageBox.Show("Làm ơn chọn loại nhà muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin loại nhà");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        LoaiNhaDTO LoaiNhaDTO = new LoaiNhaDTO(Int32.Parse(txtMaLoaiNha.Text), txtTenLoaiNha.Text, txtMoTa.Text);

                        try
                        {
                            if (loaiNhaBLL.SuaLoaiNha(LoaiNhaDTO))
                            {
                                MessageBox.Show("Sửa loại nhà thành công");
                                dgvLoaiNha.DataSource = loaiNhaBLL.LayDanhSachLoaiNha();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa loại nhà thất bại");
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
            dgvLoaiNha.DataSource = loaiNhaBLL.TimKiemLoaiNhaTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
