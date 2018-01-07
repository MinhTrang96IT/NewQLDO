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
    public partial class DialogBaiViet : Form
    {
        private BaiVietBLL baiVietBLL;
        private NhanVienBLL nhanVienBLL;
        private DataRow rowBV, rowNV;

        public DialogBaiViet()
        {
            InitializeComponent();
            baiVietBLL = new BaiVietBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        public DialogBaiViet(int maBV) : this()
        {
            rowBV = baiVietBLL.LayDanhSachBaiVietTheoMa(maBV).Rows[0];
            rowNV = nhanVienBLL.LayDanhSachNhanVienTheoMa(Int32.Parse(rowBV["MaNhanVien"].ToString())).Rows[0];
        }

        private void LoadGBBaiViet()
        {
            lblMaBV.Text = rowBV["MaBaiViet"].ToString();
            lblMaCTQC.Text = rowBV["MaChiTietQuangCao"].ToString();
            lblMaNVBV.Text = rowBV["MaNhanVien"].ToString();
            lblNoiDung.Text = rowBV["NoiDungBaiViet"].ToString();
            if (rowBV["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThai.Text = "Đã duyệt";
            else
                lblTrangThai.Text = "Chưa duyệt";
            lblLyDo.Text = rowBV["LyDoKhongDuyet"].ToString();
        }

        private void LoadGBNhanVien()
        {
            lblMaNV.Text = rowNV["MaNhanVien"].ToString();
            lblTenLoaiNV.Text = rowNV["TenLoaiNhanVien"].ToString();
            lblTenLoaiPB.Text = rowNV["TenLPhongBan"].ToString();
            lblTenNV.Text = rowNV["TenNhanVien"].ToString();
            lblTenBC.Text = rowNV["TenBangCap"].ToString();
            lblCMNDNV.Text = rowNV["CMND"].ToString();
            if (rowNV["GioiTinh"].ToString().Equals("True"))
                lblGioiTinhNV.Text = "Nam";
            else
                lblGioiTinhNV.Text = "Nữ";
            lblNgaySinhNV.Text = rowNV["NgaySinh"].ToString();
            lblDiaChiNV.Text = rowNV["DiaChi"].ToString();
            lblEmailNV.Text = rowNV["Email"].ToString();
            lblSDTNV.Text = rowNV["SoDienThoai"].ToString();
            lblTenDN.Text = rowNV["TenDangNhap"].ToString();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DialogChiTietQuangCao dialogChiTietQuangCao = new DialogChiTietQuangCao(Int32.Parse(rowBV["MaChiTietQuangCao"].ToString()));
            dialogChiTietQuangCao.StartPosition = FormStartPosition.CenterScreen;
            dialogChiTietQuangCao.ShowDialog(this);
        }

        private void DialogBaiViet_Load(object sender, EventArgs e)
        {
            LoadGBNhanVien();
            LoadGBBaiViet();
        }
    }
}
