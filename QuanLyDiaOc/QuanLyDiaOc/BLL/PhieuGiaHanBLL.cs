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
    class PhieuGiaHanBLL
    {
        private PhieuGiaHanDAL phieuGiaHanDAL = new PhieuGiaHanDAL();

        public DataTable LayDanhSachPhieuGiaHan()
        {
            return phieuGiaHanDAL.LayDanhSachPhieuGiaHan();
        }

        public DataTable LayDanhSachPhieuPhieuGiaHanCoTen()
        {
            return phieuGiaHanDAL.LayDanhSachPhieuGiaHanCoTen();
        }

        public bool ThemPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            return phieuGiaHanDAL.ThemPhieuGiaHan(phieuGiaHanDTO);
        }

        public bool XoaPhieuGiaHan(int ma)
        {
            return phieuGiaHanDAL.XoaPhieuGiaHan(ma);
        }

        public bool SuaPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            return phieuGiaHanDAL.SuaPhieuGiaHan(phieuGiaHanDTO);
        }

        public bool SuaKiemDuyetPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            return phieuGiaHanDAL.SuaKiemDuyetPhieuGiaHan(phieuGiaHanDTO);
        }
    }
}
