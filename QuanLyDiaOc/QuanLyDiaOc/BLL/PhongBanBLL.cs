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
    class PhongBanBLL
    {
        private PhongBanDAL phongBanDAL = new PhongBanDAL();
        public DataTable LayDanhSachPhongBan()
        {
            return phongBanDAL.LayDanhSachPhongBan();
        }

        public bool ThemPhongBan(PhongBanDTO phongBanDTO)
        {
            return phongBanDAL.ThemPhongBan(phongBanDTO);
        }

        public bool XoaPhongBan(int ma)
        {
            return phongBanDAL.XoaPhongBan(ma);
        }

        public bool SuaPhongBan(PhongBanDTO phongBanDTO)
        {
            return phongBanDAL.SuaPhongBan(phongBanDTO);
        }

        public DataTable TimKiemPhongBanTheoTen(string ten)
        {
            return phongBanDAL.TimKiemPhongBanTheoTen(ten);
        }

        public string LayTenPhongBan(string ma)
        {
            return phongBanDAL.LayTenPhongBan(ma);
        }
    }
}
