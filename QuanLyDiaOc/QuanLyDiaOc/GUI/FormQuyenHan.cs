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
    public partial class FormQuyenHan : Form
    {
        private QuyenHanBLL quyenHanBLL;
        private string id;

        public FormQuyenHan()
        {
            InitializeComponent();
            quyenHanBLL = new QuyenHanBLL();
            id = "";
        }

        private void dgvQuyenHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvQuyenHan.Rows[e.RowIndex];
                    txtMaQuyenHan.Text = row.Cells["MaQuyenHan"].Value.ToString();
                    id = row.Cells["MaQuyenHan"].Value.ToString();
                    txtTenQuyenHan.Text = row.Cells["TenQuyenHan"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTaQuyenHan"].Value.ToString();
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

        private void FormQuyenHan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa") && !Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - nhân viên quảng cáo"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            LamMoiThongTin();
            dgvQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
        }

        private void LamMoiThongTin()
        {
            txtMaQuyenHan.Text = txtTenQuyenHan.Text = txtMoTa.Text = "";
            txtTenQuyenHan.Focus();
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtTenQuyenHan.Text.ToString() == "" || txtMoTa.Text.ToString() == "")
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(50, txtTenQuyenHan.Text))
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
                MessageBox.Show("Làm ơn điền đầy đủ thông tin quyền hạn");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    QuyenHanDTO quyenHanDTO = new QuyenHanDTO(txtTenQuyenHan.Text, txtMoTa.Text);

                    try
                    {
                        if (quyenHanBLL.ThemQuyenHan(quyenHanDTO))
                        {
                            MessageBox.Show("Thêm quyền hạn thành công");
                            dgvQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
                        }
                        else
                        {
                            MessageBox.Show("Thêm quyền hạn thất bại");
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
                MessageBox.Show("Làm ơn chọn quyền hạn muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin quyền hạn số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (quyenHanBLL.XoaQuyenHan(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa quyền hạn thành công");
                        dgvQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa quyền hạn thất bại");
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
                MessageBox.Show("Làm ơn chọn quyền hạn muốn sửa");
            }
            else
            {
                if (KiemTraThongTinTrong())
                {
                    MessageBox.Show("Làm ơn điền đầy đủ thông tin quyền hạn");
                }
                else
                {
                    if (KiemTraThongTinHopLe())
                    {
                        QuyenHanDTO quyenHanDTO = new QuyenHanDTO(Int32.Parse(txtMaQuyenHan.Text), txtTenQuyenHan.Text, txtMoTa.Text);

                        try
                        {
                            if (quyenHanBLL.SuaQuyenHan(quyenHanDTO))
                            {
                                MessageBox.Show("Sửa quyền hạn thành công");
                                dgvQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
                                LamMoiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Sửa quyền hạn thất bại");
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
            dgvQuyenHan.DataSource = quyenHanBLL.TimKiemQuyenHanTheoTen(txtTimKiem.Text);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }
    }
}
