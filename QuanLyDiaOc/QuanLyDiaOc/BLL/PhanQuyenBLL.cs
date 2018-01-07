using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;

namespace QuanLyDiaOc.BLL
{
    class PhanQuyenBLL
    {
        private PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();

        public DataTable LayDanhSachPhanQuyen()
        {
            return phanQuyenDAL.LayDanhSachPhanQuyen();
        }

        public DataTable LayDanhSachTenQuyenHanTheoLoaiNhanVien(string ten)
        {
            return phanQuyenDAL.LayDanhSachTenQuyenHanTheoLoaiNhanVien(ten);
        }

        public bool CapNhatPhanQuyen(int loai, List<int> list)
        {
            return phanQuyenDAL.CapNhatPhanQuyen(loai, list);
        }
    }
}
