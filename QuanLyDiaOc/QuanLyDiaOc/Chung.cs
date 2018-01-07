using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.BLL;
using System.Data;

namespace QuanLyDiaOc
{
    class Chung
    {
        public static string loaiNhanVien;
        public static List<string> LayDSQuyenHan(string ten)
        {
            PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
            return phanQuyenBLL.LayDanhSachTenQuyenHanTheoLoaiNhanVien(ten).AsEnumerable()
                           .Select(r => r.Field<string>("TenQuyenHan"))
                           .ToList();
        }
    }
}
