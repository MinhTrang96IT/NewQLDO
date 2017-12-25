using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class NhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public int MaLoaiNhanVien { get; set; }
        public int MaPhongBan { get; set; }
        public string TenNhanVien { get; set; }
        public string CMND { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public NhanVienDTO(int maNhanVien, int maLoaiNhanVien, int maPhongBan, string tenNhanVien, string cMND, int gioiTinh, DateTime ngaySinh, string diaChi, string soDienThoai, string email, string tenDangNhap, string matKhau)
        {
            MaNhanVien = maNhanVien;
            MaLoaiNhanVien = maLoaiNhanVien;
            MaPhongBan = maPhongBan;
            TenNhanVien = tenNhanVien;
            CMND = cMND;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public NhanVienDTO(int maNhanVien, string tenNhanVien, string cMND, string diaChi, string soDienThoai, string email, string matKhau)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            CMND = cMND;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            MatKhau = matKhau;
        }

        public NhanVienDTO(int maLoaiNhanVien, int maPhongBan, string tenNhanVien, string cMND, int gioiTinh, DateTime ngaySinh, string diaChi, string soDienThoai, string email, string tenDangNhap, string matKhau)
        {
            MaLoaiNhanVien = maLoaiNhanVien;
            MaPhongBan = maPhongBan;
            TenNhanVien = tenNhanVien;
            CMND = cMND;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }
    }
}
