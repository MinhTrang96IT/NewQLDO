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
    public partial class DialogHuyDangKy : Form
    {
        private HuyDangKyBLL huyDangKyBLL;
        private NhanVienBLL nhanVienBLL;
        private DataRow rowNDV, rowNV;

        public DialogHuyDangKy()
        {
            InitializeComponent();
            huyDangKyBLL = new HuyDangKyBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        public DialogHuyDangKy(int maNDV) : this()
        {
            rowNDV = huyDangKyBLL.LayDanhSachHuyDangKyTheoMa(maNDV).Rows[0];
            rowNV = nhanVienBLL.LayDanhSachNhanVienTheoMa(Int32.Parse(rowNDV["MaNhanVien"].ToString())).Rows[0];
        }
        private void LoadGBHuyDangKy()
        {
            lblMaNDV.Text = rowNDV["MaPhieuNgungDangKyDichVu"].ToString();
            lblMaCTQC.Text = rowNDV["MaPhieuDangKy"].ToString();
            lblMaNVBV.Text = rowNDV["MaNhanVien"].ToString();
            lblNgayLap.Text = rowNDV["NgayLap"].ToString().Split(' ')[0];
            lblLyDoNDV.Text = rowNDV["LyDo"].ToString();
            if (rowNDV["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThai.Text = "Đã duyệt";
            else
                lblTrangThai.Text = "Chưa duyệt";
            lblLyDo.Text = rowNDV["LyDoKhongDuyet"].ToString();
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

        private void btnPhieuDK_Click(object sender, EventArgs e)
        {
            FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(Int32.Parse(rowNDV["MaPhieuDangKy"].ToString()));
            diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            diaglogChiTietPhieuDangKy.ShowDialog(this);
        }

        private void DialogHuyDangKy_Load(object sender, EventArgs e)
        {
            LoadGBNhanVien();
            LoadGBHuyDangKy();
        }
    }
}
