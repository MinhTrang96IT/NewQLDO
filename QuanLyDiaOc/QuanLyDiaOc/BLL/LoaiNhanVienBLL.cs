using QuanLyDiaOc.DAL;
using QuanLyDiaOc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BLL
{
    class LoaiNhanVienBLL
    {
        private LoaiNhanVienDAL loaiNhanVienDAL = new LoaiNhanVienDAL();
        public DataTable LayDanhSachLoaiNhanVien()
        {
            return loaiNhanVienDAL.LayDanhSachLoaiNhanVien();
        }

        public bool ThemLoaiNhanVien(LoaiNhanVienDTO loaiNhanVienDTO)
        {
            return loaiNhanVienDAL.ThemLoaiNhanVien(loaiNhanVienDTO);
        }

        public bool XoaLoaiNhanVien(int ma)
        {
            return loaiNhanVienDAL.XoaLoaiNhanVien(ma);
        }

        public bool SuaLoaiNhanVien(LoaiNhanVienDTO loaiNhanVienDTO)
        {
            return loaiNhanVienDAL.SuaLoaiNhanVien(loaiNhanVienDTO);
        }

        public DataTable TimKiemLoaiNhanVienTheoTen(string ten)
        {
            return loaiNhanVienDAL.TimKiemLoaiNhanVienTheoTen(ten);
        }
    }
}
