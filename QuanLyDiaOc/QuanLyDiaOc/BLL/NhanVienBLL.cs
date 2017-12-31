using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DAL;
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.BLL
{
    class NhanVienBLL
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable KiemTraDangNhap(string tk, string mk)
        {
            return nhanVienDAL.KiemTraDangNhap(tk, mk);
        }

        public string LayTenNhanVien(string tk)
        {
            return nhanVienDAL.LayTenNhanVien(tk);
        }

        public int LayMaNhanVien(string tk)
        {
            return nhanVienDAL.LayMaNhanVien(tk);
        }

        public string LayTenLoaiNhanVien(string ma)
        {
            return nhanVienDAL.LayTenLoaiNhanVien(ma);
        }

        public string LayMaLoaiNhanVien(string tk)
        {
            return nhanVienDAL.LayMaLoaiNhanVien(tk);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return nhanVienDAL.LayDanhSachNhanVien();
        }

        public DataTable LayDanhSachNhanVienTheoTenLoai()
        {
            return nhanVienDAL.LayDanhSachNhanVienTheoTenLoai();
        }

        public DataTable LayDanhSachNhanVienTheoMa(int ma)
        {
            return nhanVienDAL.LayDanhSachNhanVienTheoMa(ma);
        }

        public bool ThemNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanVienDAL.ThemNhanVien(nhanVienDTO);
        }

        public bool SuaThongTinTheoMaNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanVienDAL.SuaThongTinTheoMaNhanVien(nhanVienDTO);
        }
        public bool XoaNhanVien(int ma)
        {
            return nhanVienDAL.XoaNhanVien(ma);
        }

        public bool SuaNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanVienDAL.SuaNhanVien(nhanVienDTO);
        }

        public DataTable TimKiemNVTheoTen(string ten)
        {
            return nhanVienDAL.TimKiemNVTheoTen(ten);
        }

        public DataTable LayThongTinDangNhap(int maNhanVien)
        {
            return nhanVienDAL.LayThongTinDangNhap(maNhanVien);
        }
    }
}
