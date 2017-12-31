using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.BLL
{
    class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();
        public DataTable LayDanhSachKhachHang()
        {
            return khachHangDAL.LayDanhSachKhachHang();
        }

        public DataTable LayDanhSachKhachHangTheoMa(int ma)
        {
            return khachHangDAL.LayDanhSachKhachHangTheoMa(ma);
        }

        public bool ThemKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.ThemKhachHang(khachHangDTO);
        }

        public bool XoaKhachHang(int ma)
        {
            return khachHangDAL.XoaKhachHang(ma);
        }

        public bool SuaKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.SuaKhachHang(khachHangDTO);
        }

        public DataTable TimKiemKHTheoTen(string ten)
        {
            return khachHangDAL.TimKiemKHTheoTen(ten);
        }
    }
}
