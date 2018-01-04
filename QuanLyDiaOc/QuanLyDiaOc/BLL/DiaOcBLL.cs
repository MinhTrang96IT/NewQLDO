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
    class DiaOcBLL
    {
        private DiaOcDAL diaOcDAL = new DiaOcDAL();

        public DataTable LayDanhSachDiaOc()
        {
            return diaOcDAL.LayDanhSachDiaOc();
        }

        public DataTable LayDanhSachDiaOcTheoTenLoai()
        {
            return diaOcDAL.LayDanhSachDiaOcTheoTenLoai();
        }

        public DataTable LayDanhSachDiaOcTheoMa(int ma)
        {
            return diaOcDAL.LayDanhSachDiaOcTheoMa(ma);
        }

        public DataTable LayDanhSachDiaOcTheoMa2(int ma)
        {
            return diaOcDAL.LayDanhSachDiaOcTheoMa2(ma);
        }

        public bool ThemDiaOc(DiaOcDTO diaOcDTO)
        {
            return diaOcDAL.ThemDiaOc(diaOcDTO);
        }

        public bool XoaDiaOc(int ma)
        {
            return diaOcDAL.XoaDiaOc(ma);
        }

        public bool SuaDiaOc(DiaOcDTO diaOcDTO)
        {
            return diaOcDAL.SuaDiaOc(diaOcDTO);
        }

        public DataTable TimKiemNVTheoTen(string ten)
        {
            return diaOcDAL.TimKiemNVTheoTen(ten);
        }

        public bool SuaKiemDuyetDiaOc(DiaOcDTO diaOcDTO)
        {
            return diaOcDAL.SuaKiemDuyetDiaOc(diaOcDTO);
        }
    }
}
