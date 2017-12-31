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
    class PhieuDangKyBLL
    {
        private PhieuDangKyDAL phieuDangKyDAL = new PhieuDangKyDAL();

        public DataTable LayDanhSachPhieuDangKy()
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKy();
        }

        public DataTable LayDanhSachPhieuPhieuDangKyCoTen()
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKyCoTen();
        }

        public bool ThemPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.ThemPhieuDangKy(phieuDangKyDTO);
        }

        public bool XoaPhieuDangKy(int ma)
        {
            return phieuDangKyDAL.XoaPhieuDangKy(ma);
        }

        public bool SuaPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.SuaPhieuDangKy(phieuDangKyDTO);
        }

        public bool SuaKiemDuyetPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.SuaKiemDuyetPhieuDangKy(phieuDangKyDTO);
        }
    }
}
