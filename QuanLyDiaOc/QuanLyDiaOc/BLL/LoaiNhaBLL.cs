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
    class LoaiNhaBLL
    {
        private LoaiNhaDAL loaiNhaDAL = new LoaiNhaDAL();
        public DataTable LayDanhSachLoaiNha()
        {
            return loaiNhaDAL.LayDanhSachLoaiNha();
        }

        public bool ThemLoaiNha(LoaiNhaDTO loaiNhaDTO)
        {
            return loaiNhaDAL.ThemLoaiNha(loaiNhaDTO);
        }

        public bool XoaLoaiNha(int ma)
        {
            return loaiNhaDAL.XoaLoaiNha(ma);
        }

        public bool SuaLoaiNha(LoaiNhaDTO loaiNhaDTO)
        {
            return loaiNhaDAL.SuaLoaiNha(loaiNhaDTO);
        }

        public DataTable TimKiemLoaiNhaTheoTen(string ten)
        {
            return loaiNhaDAL.TimKiemLoaiNhaTheoTen(ten);
        }
    }
}
