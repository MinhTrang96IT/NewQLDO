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
    public partial class FormPhanQuyen : Form
    {
        private QuyenHanBLL quyenHanBLL;
        private LoaiNhanVienBLL loaiNhanVienBLL;
        private PhanQuyenBLL phanQuyenBLL;
        private List<int> listId;
        private List<int> listCheck;

        public FormPhanQuyen()
        {
            InitializeComponent();

            quyenHanBLL = new QuyenHanBLL();
            loaiNhanVienBLL = new LoaiNhanVienBLL();
            phanQuyenBLL = new PhanQuyenBLL();
            listCheck = new List<int>();
            listId = quyenHanBLL.LayDanhSachQuyenHan().AsEnumerable()
                           .Select(r => r.Field<int>("MaQuyenHan"))
                           .ToList();
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            clbQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
            clbQuyenHan.DisplayMember = "TenQuyenHan";
            clbQuyenHan.ValueMember = "MaQuyenHan";
            cbLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
            cbLoaiNhanVien.DisplayMember = "TenLoaiNhanVien";
            cbLoaiNhanVien.ValueMember = "MaLoaiNhanVien";
            dgvPhanQuyen.DataSource = phanQuyenBLL.LayDanhSachPhanQuyen();
        }

        private void btnThemLoaiNhanVien_Click(object sender, EventArgs e)
        {
            FormLoaiNhanVien diaglogLoaiNhanVien = new FormLoaiNhanVien();
            diaglogLoaiNhanVien.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogLoaiNhanVien.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbLoaiNhanVien.DataSource = loaiNhanVienBLL.LayDanhSachLoaiNhanVien();
            }
        }

        private void btnThemQuyenHan_Click(object sender, EventArgs e)
        {
            FormQuyenHan diaglogQuyenHan = new FormQuyenHan();
            diaglogQuyenHan.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogQuyenHan.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                clbQuyenHan.DataSource = quyenHanBLL.LayDanhSachQuyenHan();
                clbQuyenHan.DisplayMember = "TenQuyenHan";
                clbQuyenHan.ValueMember = "MaQuyenHan";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (phanQuyenBLL.CapNhatPhanQuyen(Int32.Parse(cbLoaiNhanVien.SelectedValue.ToString()), listCheck))
                dgvPhanQuyen.DataSource = phanQuyenBLL.LayDanhSachPhanQuyen();
            else
                MessageBox.Show("Cập nhật phân quyền thất bại");
        }

        private void clbQuyenHan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue.ToString().Equals("Checked"))
            {
                listCheck.Add(listId[e.Index]);
            }
            else
            {
                listCheck.Remove(listId[e.Index]);
            }
        }
    }
}
