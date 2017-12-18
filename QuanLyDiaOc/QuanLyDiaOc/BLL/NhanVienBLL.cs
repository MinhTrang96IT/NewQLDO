using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DAL;

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
    }
}
