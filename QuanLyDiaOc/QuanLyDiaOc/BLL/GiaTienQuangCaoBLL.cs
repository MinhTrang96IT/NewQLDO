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
    class GiaTienQuangCaoBLL
    {
        private GiaTienQuangCaoDAL GiaTienQuangCaoDAL = new GiaTienQuangCaoDAL();

        public DataTable LayDanhSachGiaTienQuangCao()
        {
            return GiaTienQuangCaoDAL.LayDanhSachGiaTienQuangCao();
        }

        public DataTable LayDanhSachGiaTienQuangCaoTheoTenLoai()
        {
            return GiaTienQuangCaoDAL.LayDanhSachGiaTienQuangCaoTheoTenLoai();
        }

        public bool ThemGiaTienQuangCao(GiaTienQuangCaoDTO giaTienQuangCaoDTO)
        {
            return GiaTienQuangCaoDAL.ThemGiaTienQuangCao(giaTienQuangCaoDTO);
        }

        public bool XoaGiaTienQuangCao(int ma)
        {
            return GiaTienQuangCaoDAL.XoaGiaTienQuangCao(ma);
        }

        public bool SuaGiaTienQuangCao(GiaTienQuangCaoDTO giaTienQuangCaoDTO)
        {
            return GiaTienQuangCaoDAL.SuaGiaTienQuangCao(giaTienQuangCaoDTO);
        }

        public DataTable TimKiemNVTheoTen(string ten)
        {
            return GiaTienQuangCaoDAL.TimKiemNVTheoTen(ten);
        }
    }
}
