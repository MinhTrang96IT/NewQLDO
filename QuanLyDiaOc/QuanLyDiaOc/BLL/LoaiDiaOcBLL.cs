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
    class LoaiDiaOcBLL
    {
        private LoaiDiaOcDAL LoaiDiaOcDAL = new LoaiDiaOcDAL();
        public DataTable LayDanhSachLoaiDiaOc()
        {
            return LoaiDiaOcDAL.LayDanhSachLoaiDiaOc();
        }

        public bool ThemLoaiDiaOc(LoaiDiaOcDTO loaiDiaOcDTO)
        {
            return LoaiDiaOcDAL.ThemLoaiDiaOc(loaiDiaOcDTO);
        }

        public bool XoaLoaiDiaOc(int ma)
        {
            return LoaiDiaOcDAL.XoaLoaiDiaOc(ma);
        }

        public bool SuaLoaiDiaOc(LoaiDiaOcDTO loaiDiaOcDTO)
        {
            return LoaiDiaOcDAL.SuaLoaiDiaOc(loaiDiaOcDTO);
        }

        public DataTable TimKiemLoaiDiaOcTheoTen(string ten)
        {
            return LoaiDiaOcDAL.TimKiemLoaiDiaOcTheoTen(ten);
        }
    }
}
