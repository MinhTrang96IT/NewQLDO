using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.BLL
{
    class HinhAnhBLL
    {
        private HinhAnhDAL hinhAnhDAL = new HinhAnhDAL();

        public DataTable LayDanhSachHinhAnh()
        {
            return hinhAnhDAL.LayDanhSachHinhAnh();
        }

        public bool ThemHinhAnh(HinhAnhDTO hinhAnhDTO)
        {
            return hinhAnhDAL.ThemHinhAnh(hinhAnhDTO);
        }

        public bool XoaHinhAnh(int ma)
        {
            return hinhAnhDAL.XoaHinhAnh(ma);
        }

        public bool SuaHinhAnh(HinhAnhDTO hinhAnhDTO)
        {
            return hinhAnhDAL.SuaHinhAnh(hinhAnhDTO);
        }

        public DataTable LayDanhSachTheoMaPDK(int maphieudangky)
        {
            return hinhAnhDAL.LayDanhSachTheoMaPDK(maphieudangky);
        }
    }
}
