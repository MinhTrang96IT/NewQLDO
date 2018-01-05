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
    public partial class FormLoaiQuangCao : Form
    {
        private LoaiQuangCaoBLL loaiQuangCaoBLL;
        private string id;

        public FormLoaiQuangCao()
        {
            InitializeComponent();
            loaiQuangCaoBLL = new LoaiQuangCaoBLL();
            id = "";
        }

        private void dgvLoaiQuangCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvLoaiQuangCao.Rows[e.RowIndex];
                    txtMaLoaiQuangCao.Text = row.Cells["MaLoaiQuangCao"].Value.ToString();
                    id = row.Cells["MaLoaiQuangCao"].Value.ToString();
                    txtTenLoaiQuangCao.Text = row.Cells["TenLoaiQuangCao"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaLoaiQuangCao"].Value.ToString();
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

        private void FormLoaiQuangCao_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa") && !Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - nhân viên quảng cáo"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            LamMoiThongTin();
            dgvLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
        }

        private void LamMoiThongTin()
        {
            txtMaLoaiQuangCao.Text = txtTenLoaiQuangCao.Text = txtMoTa.Text = "";
            txtTenLoaiQuangCao.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenLoaiQuangCao.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenLoaiQuangCao.Text))
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin loại quảng cáo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    LoaiQuangCaoDTO loaiQuangCaoDTO = new LoaiQuangCaoDTO(txtTenLoaiQuangCao.Text, txtMoTa.Text);

                    try
                    {
                        if (loaiQuangCaoBLL.ThemLoaiQuangCao(loaiQuangCaoDTO))
                        {
                            MessageBox.Show("Thêm loại quảng cáo thành công");
                            dgvLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại quảng cáo thất bại");
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
                MessageBox.Show("Làm ơn chọn loại quảng cáo muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin loại quảng cáo số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (loaiQuangCaoBLL.XoaLoaiQuangCao(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa loại quảng cáo thành công");
                        dgvLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại quảng cáo thất bại");
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
                MessageBox.Show("Làm ơn chọn loại quảng cáo muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin loại quảng cáo");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        LoaiQuangCaoDTO loaiQuangCaoDTO = new LoaiQuangCaoDTO(Int32.Parse(txtMaLoaiQuangCao.Text), txtTenLoaiQuangCao.Text, txtMoTa.Text);

                        try
                        {
                            if (loaiQuangCaoBLL.SuaLoaiQuangCao(loaiQuangCaoDTO))
                            {
                                MessageBox.Show("Sửa loại quảng cáo thành công");
                                dgvLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa loại quảng cáo thất bại");
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
            dgvLoaiQuangCao.DataSource = loaiQuangCaoBLL.TimKiemLoaiQuangCaoTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
