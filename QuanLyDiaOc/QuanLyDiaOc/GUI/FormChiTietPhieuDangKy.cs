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
    public partial class FormChiTietPhieuDangKy : Form
    {
        private PhieuDangKyBLL phieuDangKyBLL;
        private KhachHangBLL khachHangBLL;
        private DiaOcBLL diaOcBLL;
        private NhanVienBLL nhanVienBLL;
        private DataRow rowPDK, rowKH, rowNV, rowDO;
        public FormChiTietPhieuDangKy()
        {
            InitializeComponent();
            phieuDangKyBLL = new PhieuDangKyBLL();
            khachHangBLL = new KhachHangBLL();
            diaOcBLL = new DiaOcBLL();
            nhanVienBLL = new NhanVienBLL();
        }

        public FormChiTietPhieuDangKy(int maPDK) : this()
        {
            rowPDK = phieuDangKyBLL.LayDanhSachPhieuDangKyTheoMa(maPDK).Rows[0];
            rowKH = khachHangBLL.LayDanhSachKhachHangTheoMa(Int32.Parse(rowPDK["MaKhachHang"].ToString())).Rows[0];
            rowDO = diaOcBLL.LayDanhSachDiaOcTheoMa(Int32.Parse(rowPDK["MaDiaOc"].ToString())).Rows[0];
            rowNV = nhanVienBLL.LayDanhSachNhanVienTheoMa(Int32.Parse(rowPDK["MaNhanVien"].ToString())).Rows[0];
        }

        private void LoadGBPhieuDangKy()
        {
            lblMa.Text = rowPDK["MaPhieuDangKy"].ToString();
            lblNgayLap.Text = rowPDK["NgayLap"].ToString().Split(' ')[0];
            lblNgayBD.Text = rowPDK["NgayBatDau"].ToString().Split(' ')[0];
            lblNgayKT.Text = rowPDK["NgayKetThuc"].ToString().Split(' ')[0];
            lblSoLan.Text = rowPDK["SoLanGiaHan"].ToString();
            if (rowPDK["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThai.Text = "Đã duyệt";
            else
                lblTrangThai.Text = "Chưa duyệt";
            lblLyDo.Text = rowPDK["LyDoKhongDuyet"].ToString();
            lblTongTien.Text = rowPDK["TongTien"].ToString();
        }

        private void LoadGBDiaOc()
        {
            lblMaDO.Text = rowDO["MaDiaOc"].ToString();
            lblTenKH.Text = rowDO["TenKhachHang"].ToString();
            lblTenLoaiDiaOc.Text = rowDO["TenLoaiDiaOc"].ToString();
            lblTenLoaiNha.Text = rowDO["TenLoaiNha"].ToString();
            lblDiaChiDO.Text = rowDO["DiaChi"].ToString();
            lblDTKV.Text = rowDO["DienTichKhuonVien"].ToString();
            lblDTSD.Text = rowDO["DienTichSuDung"].ToString();
            lblHuongNha.Text = rowDO["HuongNha"].ToString();
            lblChieuDaiNha.Text = rowDO["ChieuDaiDat"].ToString();
            lblChieuRongNha.Text = rowDO["ChieuRongDat"].ToString();
            lblChieuDaiDat.Text = rowDO["ChieuDaiNha"].ToString();
            lblChieuRongDat.Text = rowDO["ChieuRongNha"].ToString();
            lblSoTang.Text = rowDO["SoTang"].ToString();
            lblMoTaChiTiet.Text = rowDO["MoTaChiTiet"].ToString(); 
            lblGiaBan.Text = rowDO["GiaBan"].ToString();
            if (rowDO["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThaiKiemDuyet.Text = "Đã duyệt";
            else
                lblTrangThaiKiemDuyet.Text = "Chưa duyệt";
            if (rowDO["TrangThaiMuaBan"].ToString().Equals("True"))
                lblTrangThaiMuaBan.Text = "Đã mua";
            else
                lblTrangThaiMuaBan.Text = "Chưa mua";
            lblLyDoDO.Text = rowDO["LyDoKhongDuyet"].ToString();
        }

        private void LoadGBKhachHang()
        {
            lblMaKH.Text = rowKH["MaKhachHang"].ToString();
            lblTenKHang.Text = rowKH["TenKhachHang"].ToString();
            lblCMNDKH.Text = rowKH["CMND"].ToString();
            if (rowKH["GioiTinh"].ToString().Equals("True"))
                lblGTKH.Text = "Nam";
            else
                lblGTKH.Text = "Nữ";
            lblNamSinhKH.Text = rowKH["NamSinh"].ToString();
            lblDiaChiKH.Text = rowKH["DiaChi"].ToString();
            lblEmailKH.Text = rowKH["Email"].ToString();
            lblSDTKH.Text = rowKH["SoDienthoai"].ToString();
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

        private void FormChiTietPhieuDangKy_Load(object sender, EventArgs e)
        {
            LoadGBPhieuDangKy();
            LoadGBDiaOc();
            LoadGBKhachHang();
            LoadGBNhanVien();
        }
    }
}
