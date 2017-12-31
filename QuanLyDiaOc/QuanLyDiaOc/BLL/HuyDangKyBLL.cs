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
    class HuyDangKyBLL
    {
        private HuyDangKyDAL huyDangKyDAL = new HuyDangKyDAL();

        public DataTable LayDanhSachHuyDangKy()
        {
            return huyDangKyDAL.LayDanhSachHuyDangKy();
        }

        public DataTable LayDanhSachPhieuDangKy()
        {
            return huyDangKyDAL.LayDanhSachPhieuDangKy();
        }

        public DataTable LayDanhSachPhieuHuyDangKyCoTenNhanVien()
        {
            return huyDangKyDAL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
        }

        public bool ThemHuyDangKy(HuyDangKyDTO huyDangKyDTO)
        {
            return huyDangKyDAL.ThemHuyDangKy(huyDangKyDTO);
        }

        public bool XoaHuyDangKy(int ma)
        {
            return huyDangKyDAL.XoaHuyDangKy(ma);
        }

        public bool SuaHuyDangKy(HuyDangKyDTO huyDangKyDTO)
        {
            return huyDangKyDAL.SuaHuyDangKy(huyDangKyDTO);
        }

        public DataTable TimKiemHuyDangKyTheoTen(string ten)
        {
            return huyDangKyDAL.TimKiemHuyDangKyTheoTen(ten);
        }

        public bool SuaKiemDuyetPhieunNgungDichVu(HuyDangKyDTO huyDangKyDTO)
        {
            return huyDangKyDAL.SuaKiemDuyetPhieunNgungDichVu(huyDangKyDTO);
        }
    }
}
