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
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.GUI
{
    public partial class FormKiemDuyet : Form
    {
        private PhieuDangKyBLL phieuDangKyBLL;
        public FormKiemDuyet()
        {
            InitializeComponent();
            phieuDangKyBLL = new PhieuDangKyBLL();
        }

        private void tabctrKiemDuyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrKiemDuyet.SelectedIndex == 0)
            {
                dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            }
        }

        private void FormKiemDuyet_Load(object sender, EventArgs e)
        {
            LoadPhieuDangKy();
        }

        private void LoadPhieuDangKy()
        {
            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            dgvPhieuDangKy.Columns["TrangThaiKiemDuyet"].DisplayIndex = 7;
            dgvPhieuDangKy.Columns["LyDoKhongDuyet"].DisplayIndex = 8;
        }

        private void dgvPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhieuDangKy.Rows[e.RowIndex];
                    int columnIndex = dgvPhieuDangKy.CurrentCell.ColumnIndex;
                    string columnName = dgvPhieuDangKy.Columns[columnIndex].Name;
                    int maPhieuDK = Int32.Parse(row.Cells["MaPhieuDangKy"].Value.ToString());

                    if (columnName.Equals("ChiTiet"))
                    {
                        //FormPhieuDangKy diaglogPhieuDangKy = new FormPhieuDangKy(maPhieuDK);
                        //diaglogPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                        //if (diaglogPhieuDangKy.ShowDialog(this) == DialogResult.Yes) { }
                        //else
                        //{
                        //    LoadPhieuDangKy();
                        //}
                    }

                    if (columnName.Equals("XacNhan"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyet"].Value.ToString();
                        PhieuDangKyDTO phieuDangKyDTO = new PhieuDangKyDTO(maPhieuDK, trangThai, lyDo);
                        try
                        {
                            if (phieuDangKyBLL.SuaKiemDuyetPhieuDangKy(phieuDangKyDTO))
                            {
                                MessageBox.Show("Sửa trạng thái phiếu đăng ký thành công");
                                LoadPhieuDangKy();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái phiếu đăng ký thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }
    }
}
