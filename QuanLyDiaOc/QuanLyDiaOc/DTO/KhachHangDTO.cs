using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class KhachHangDTO
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string CMND { get; set; }
        public int GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public KhachHangDTO(int maKhachHang, string tenKhachHang, string cMND, int gioiTinh, int namSinh, string diaChi, string soDienThoai, string email)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            CMND = cMND;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }

        public KhachHangDTO(string tenKhachHang, string cMND, int gioiTinh, int namSinh, string diaChi, string soDienThoai, string email)
        {
            TenKhachHang = tenKhachHang;
            CMND = cMND;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }
    }
}
