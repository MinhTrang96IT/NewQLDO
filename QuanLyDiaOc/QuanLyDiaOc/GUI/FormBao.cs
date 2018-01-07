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
    public partial class FormBao : Form
    {
        private BaoBLL baoBLL;
        private string id;

        public FormBao()
        {
            InitializeComponent();
            baoBLL = new BaoBLL();
            id = "";
        }

        private void dgvBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvBao.Rows[e.RowIndex];
                    txtMaBao.Text = row.Cells["MaBao"].Value.ToString();
                    id = row.Cells["MaBao"].Value.ToString();
                    txtTenBao.Text = row.Cells["TenBao"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaBao"].Value.ToString();
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

        private void FormBao_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa") && !Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - nhân viên quảng cáo"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            LamMoiThongTin();
            dgvBao.DataSource = baoBLL.LayDanhSachBao();
        }

        private void LamMoiThongTin()
        {
            txtMaBao.Text = txtTenBao.Text = txtMoTa.Text = "";
            txtTenBao.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenBao.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenBao.Text))
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin báo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    BaoDTO baoDTO = new BaoDTO(txtTenBao.Text, txtMoTa.Text);

                    try
                    {
                        if (baoBLL.ThemBao(baoDTO))
                        {
                            MessageBox.Show("Thêm báo thành công");
                            dgvBao.DataSource = baoBLL.LayDanhSachBao();
                        }
                        else
                        {
                            MessageBox.Show("Thêm báo thất bại");
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
                MessageBox.Show("Làm ơn chọn báo muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin báo số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (baoBLL.XoaBao(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa báo thành công");
                        dgvBao.DataSource = baoBLL.LayDanhSachBao();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa báo thất bại");
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
                MessageBox.Show("Làm ơn chọn báo muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin báo");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        BaoDTO baoDTO = new BaoDTO(Int32.Parse(txtMaBao.Text), txtTenBao.Text, txtMoTa.Text);

                        try
                        {
                            if (baoBLL.SuaBao(baoDTO))
                            {
                                MessageBox.Show("Sửa báo thành công");
                                dgvBao.DataSource = baoBLL.LayDanhSachBao();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa báo thất bại");
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
            dgvBao.DataSource = baoBLL.TimKiemBaoTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
