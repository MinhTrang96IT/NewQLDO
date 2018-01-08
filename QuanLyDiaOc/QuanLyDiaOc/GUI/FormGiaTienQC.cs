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
    public partial class FormGiaTienQC : Form
    {
        private GiaTienQuangCaoBLL giaTienQuangCaoBLL;
        private LoaiQuangCaoBLL loaiQuangCaoBLL;
        private ViTriBLL viTriBLL;
        private string id;
        private bool checkLoadDone = false;

        public FormGiaTienQC()
        {
            InitializeComponent();

            giaTienQuangCaoBLL = new GiaTienQuangCaoBLL();
            loaiQuangCaoBLL = new LoaiQuangCaoBLL();
            viTriBLL = new ViTriBLL();
            id = "";
        }

        private void AnButton()
        {
            btnTaoMoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FormGiaTienQC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa") && !Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Equals("Chỉnh sửa - nhân viên quảng cáo"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            dgvGiaTienQC.DataSource = giaTienQuangCaoBLL.LayDanhSachGiaTienQuangCaoTheoTenLoai();
            cbLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
            cbLoaiQuangCao.DisplayMember = "TenLoaiQuangCao";
            cbLoaiQuangCao.ValueMember = "MaLoaiQuangCao";
            cbViTri.DataSource = viTriBLL.LayDanhSachViTri();
            cbViTri.DisplayMember = "TenViTri";
            cbViTri.ValueMember = "MaViTri";
            LamMoiThongTin();
            checkLoadDone = true;
            if (cbLoaiQuangCao.Text == "Quảng cáo tờ bướm")
            {
                cbViTri.Enabled = btnThemViTri.Enabled = false;
                txtSoLuongToiDa.Enabled = txtSoLuongToiThieu.Enabled = txtKichCoToiThieu.Enabled = txtKichCoToiDa.Enabled = true;
            }
            else
            {
                cbViTri.Enabled = btnThemViTri.Enabled = true;
                txtKichCoToiDa.Text = txtKichCoToiThieu.Text = txtSoLuongToiDa.Text = txtSoLuongToiThieu.Text = "0";
                txtSoLuongToiDa.Enabled = txtSoLuongToiThieu.Enabled = txtKichCoToiThieu.Enabled = txtKichCoToiDa.Enabled = false;
            }
        }

        private void LamMoiThongTin()
        {
            txtMaGiaTienQC.Text = cbViTri.Text = cbLoaiQuangCao.Text = txtSoLuongToiThieu.Text = txtSoLuongToiDa.Text = txtKichCoToiDa.Text = txtKichCoToiThieu.Text = txtDonGia.Text = "";
            txtSoLuongToiThieu.Focus();
            cbLoaiQuangCao.SelectedIndex = 0;
            cbViTri.SelectedIndex = 0;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtDonGia.Text.ToString() == "" || txtKichCoToiThieu.Text.ToString() == "" || txtKichCoToiDa.Text.ToString() == "" || txtSoLuongToiDa.Text.ToString() == "" || txtSoLuongToiThieu.Text.ToString() == "" )
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {
            Regex regexSo = new Regex("^[0-9]+$");
            if (!regexSo.IsMatch(txtSoLuongToiThieu.Text))
            {
                MessageBox.Show("Số lượng tối thiểu chỉ được nhập số");
                return false;
            }
            if (!regexSo.IsMatch(txtSoLuongToiDa.Text))
            {
                MessageBox.Show("Số lượng tối đa chỉ được nhập số");
                return false;
            }
            if (!regexSo.IsMatch(txtKichCoToiDa.Text))
            {
                MessageBox.Show("Kích cỡ tối đa chỉ được nhập số");
                return false;
            }
            if (!regexSo.IsMatch(txtKichCoToiThieu.Text))
            {
                MessageBox.Show("Kích cỡ tối thiểu chỉ được nhập số");
                return false;
            }
            if(Int32.Parse(txtSoLuongToiDa.Text) <= Int32.Parse(txtSoLuongToiThieu.Text))
            {
                MessageBox.Show("Số lượng tối đa phải lớn hơn số lượng tối thiểu");
            }

            if (Double.Parse(txtKichCoToiDa.Text) <= Double.Parse(txtKichCoToiThieu.Text))
            {
                MessageBox.Show("Kích thước tối đa phải lớn hơn kích thước tối thiểu");
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

        private void dgvGiaTienQC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvGiaTienQC.Rows[e.RowIndex];
                    txtMaGiaTienQC.Text = row.Cells["MaGiaTienQuangCao"].Value.ToString();
                    id = row.Cells["MaGiaTienQuangCao"].Value.ToString();
                    cbLoaiQuangCao.Text = row.Cells["TenLoaiQuangCao"].Value.ToString();
                    cbViTri.Text = row.Cells["TenViTri"].Value.ToString();
                    txtKichCoToiThieu.Text = row.Cells["KichCoToiThieu"].Value.ToString();
                    txtKichCoToiDa.Text = row.Cells["KichCoToiDa"].Value.ToString();
                    txtSoLuongToiDa.Text = row.Cells["SoLuongPhatHanhToiDa"].Value.ToString();
                    txtSoLuongToiThieu.Text = row.Cells["SoLuongPhatHanhToiThieu"].Value.ToString();
                    txtDonGia.Text = String.Format("{0:#,###0}", double.Parse(row.Cells["DonGia"].Value.ToString()));
                }
                catch { }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin giá tiền quảng cáo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    GiaTienQuangCaoDTO giaTienQuangCaoDTO = new GiaTienQuangCaoDTO(
                        Int32.Parse(cbLoaiQuangCao.SelectedValue.ToString()),
                        Int32.Parse(cbViTri.SelectedValue.ToString()),
                        Int32.Parse(txtSoLuongToiThieu.Text.ToString()),
                        Int32.Parse(txtSoLuongToiDa.Text.ToString()),
                        Int32.Parse(txtKichCoToiThieu.Text.ToString()),
                        Int32.Parse(txtKichCoToiDa.Text.ToString()),
                        Double.Parse(txtDonGia.Text.ToString()));

                    try
                    {
                        if (giaTienQuangCaoBLL.ThemGiaTienQuangCao(giaTienQuangCaoDTO))
                        {
                            MessageBox.Show("Thêm giá tiền quảng cáo thành công");
                            dgvGiaTienQC.DataSource = giaTienQuangCaoBLL.LayDanhSachGiaTienQuangCaoTheoTenLoai();
                        }
                        else
                        {
                            MessageBox.Show("Thêm giá tiền quảng cáo thất bại");
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
                MessageBox.Show("Làm ơn chọn giá tiền quảng cáo muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin giá tiền quảng cáo số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (giaTienQuangCaoBLL.XoaGiaTienQuangCao(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách giá tiền quảng cáo thành công");
                        dgvGiaTienQC.DataSource = giaTienQuangCaoBLL.LayDanhSachGiaTienQuangCaoTheoTenLoai();
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giá tiền quảng cáo thất bại");
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
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin giá tiền quảng cáo");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {

                    GiaTienQuangCaoDTO giaTienQuangCaoDTO = new GiaTienQuangCaoDTO(
                        Int32.Parse(txtMaGiaTienQC.Text.ToString()),
                        Int32.Parse(cbLoaiQuangCao.SelectedValue.ToString()),
                        Int32.Parse(cbViTri.SelectedValue.ToString()),
                        Int32.Parse(txtSoLuongToiThieu.Text.ToString()),
                        Int32.Parse(txtSoLuongToiDa.Text.ToString()),
                        Int32.Parse(txtKichCoToiThieu.Text.ToString()),
                        Int32.Parse(txtKichCoToiDa.Text.ToString()),
                        Double.Parse(txtDonGia.Text.ToString()));
                    try
                    {
                        if (giaTienQuangCaoBLL.SuaGiaTienQuangCao(giaTienQuangCaoDTO))
                        {
                            MessageBox.Show("Sửa giá tiền quảng cáo thành công");
                            dgvGiaTienQC.DataSource = giaTienQuangCaoBLL.LayDanhSachGiaTienQuangCaoTheoTenLoai();
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa giá tiền quảng cáo thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvGiaTienQC.DataSource = giaTienQuangCaoBLL.TimKiemNVTheoTen(txtTimKiem.Text);
        }

        private void btnThemLoaiQuangCao_Click(object sender, EventArgs e)
        {
            FormLoaiQuangCao diaglogLoaiQuangCao = new FormLoaiQuangCao();
            diaglogLoaiQuangCao.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogLoaiQuangCao.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbLoaiQuangCao.DataSource = loaiQuangCaoBLL.LayDanhSachLoaiQuangCao();
            }
        }

        private void btnThemViTri_Click(object sender, EventArgs e)
        {
            FormViTri diaglogViTri = new FormViTri();
            diaglogViTri.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogViTri.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbViTri.DataSource = viTriBLL.LayDanhSachViTri();
            }
        }

        private void cbLoaiQuangCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkLoadDone)
            {
                if(cbLoaiQuangCao.Text == "Quảng cáo tờ bướm")
                {
                    cbViTri.Enabled = btnThemViTri.Enabled = false;
                    txtSoLuongToiDa.Enabled = txtSoLuongToiThieu.Enabled = txtKichCoToiThieu.Enabled = txtKichCoToiDa.Enabled = true;
                }
                else
                {
                    cbViTri.Enabled = btnThemViTri.Enabled = true;
                    txtKichCoToiDa.Text = txtKichCoToiThieu.Text = txtSoLuongToiDa.Text = txtSoLuongToiThieu.Text = "0";
                    txtSoLuongToiDa.Enabled = txtSoLuongToiThieu.Enabled = txtKichCoToiThieu.Enabled = txtKichCoToiDa.Enabled = false;
                }
            }
        }
    }
}
