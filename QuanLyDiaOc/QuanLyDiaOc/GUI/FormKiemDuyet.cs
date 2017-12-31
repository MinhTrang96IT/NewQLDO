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
            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            dgvPhieuDangKy.Columns["TrangThaiKiemDuyet"].DisplayIndex = 7;
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

                    if (columnName.Equals("ChiTiet"))
                    {
                        MessageBox.Show("dsa");
                    }

                    if (columnName.Equals("XacNhan"))
                    {
                        MessageBox.Show("ddd");
                    }

                }
                catch { }
            }
        }
    }
}
