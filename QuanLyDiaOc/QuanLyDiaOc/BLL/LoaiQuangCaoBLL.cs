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
    class LoaiQuangCaoBLL
    {
        private LoaiQuangCaoDAL loaiQuangCaoDAL = new LoaiQuangCaoDAL();
        public DataTable LayDanhSachLoaiQuangCao()
        {
            return loaiQuangCaoDAL.LayDanhSachLoaiQuangCao();
        }

        public bool ThemLoaiQuangCao(LoaiQuangCaoDTO loaiQuangCaoDTO)
        {
            return loaiQuangCaoDAL.ThemLoaiQuangCao(loaiQuangCaoDTO);
        }

        public bool XoaLoaiQuangCao(int ma)
        {
            return loaiQuangCaoDAL.XoaLoaiQuangCao(ma);
        }

        public bool SuaLoaiQuangCao(LoaiQuangCaoDTO loaiQuangCaoDTO)
        {
            return loaiQuangCaoDAL.SuaLoaiQuangCao(loaiQuangCaoDTO);
        }

        public DataTable TimKiemLoaiQuangCaoTheoTen(string ten)
        {
            return loaiQuangCaoDAL.TimKiemLoaiQuangCaoTheoTen(ten);
        }
    }
}
