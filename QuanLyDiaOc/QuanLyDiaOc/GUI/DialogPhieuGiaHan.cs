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
    public partial class DialogPhieuGiaHan : Form
    {
        private PhieuGiaHanBLL phieuGiaHanBLL;
        private NhanVienBLL nhanVienBLL;
        private DataRow rowPGH, rowNV;

        public DialogPhieuGiaHan()
        {
            InitializeComponent();
            phieuGiaHanBLL = new PhieuGiaHanBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        public DialogPhieuGiaHan(int maPGH) : this()
        {
            rowPGH = phieuGiaHanBLL.LayDanhSachPhieuGiaHanTheoMa(maPGH).Rows[0];
            rowNV = nhanVienBLL.LayDanhSachNhanVienTheoMa(Int32.Parse(rowPGH["MaNhanVien"].ToString())).Rows[0];
        }

        private void LoadGBPhieuGH()
        {
            lblMaNDV.Text = rowPGH["MaPhieuGiaHan"].ToString();
            lblMaCTQC.Text = rowPGH["MaPhieuDangKy"].ToString();
            lblMaNVBV.Text = rowPGH["MaNhanVien"].ToString();
            lblNgayLap.Text = rowPGH["NgayLap"].ToString().Split(' ')[0];
            lblNgayBD.Text = rowPGH["NgayBatDau"].ToString().Split(' ')[0];
            lblNgayKT.Text = rowPGH["NgayKetThuc"].ToString().Split(' ')[0];
            lblTongTien.Text = rowPGH["TongTien"].ToString() + " m2";
            if (rowPGH["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThai.Text = "Đã duyệt";
            else
                lblTrangThai.Text = "Chưa duyệt";
            lblLyDo.Text = rowPGH["LyDoKhongDuyet"].ToString();
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
            FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(Int32.Parse(rowPGH["MaPhieuDangKy"].ToString()));
            diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            diaglogChiTietPhieuDangKy.ShowDialog(this);
        }

        private void DialogPhieuGiaHan_Load(object sender, EventArgs e)
        {
            LoadGBNhanVien();
            LoadGBPhieuGH();
        }
    }
}
