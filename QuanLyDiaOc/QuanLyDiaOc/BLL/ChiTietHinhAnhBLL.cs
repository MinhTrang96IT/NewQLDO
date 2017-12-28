using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;

namespace QuanLyDiaOc.BLL
{
    class ChiTietHinhAnhBLL
    {
        private ChiTietHinhAnhDAL chiTietHinhAnhDAL = new ChiTietHinhAnhDAL();

        public DataTable LayDanhSachChiTietHinhAnh()
        {
            return chiTietHinhAnhDAL.LayDanhSachChiTietHinhAnh();
        }

        public DataTable LayDanhSachChiTietHinhAnhTheoMaHA(int maHA)
        {
            return chiTietHinhAnhDAL.LayDanhSachChiTietHinhAnhTheoMaHA(maHA);
        }

        public bool ThemChiTietHinhAnh(int maHa, byte[] ha, string moTa)
        {
            return chiTietHinhAnhDAL.ThemChiTietHinhAnh(maHa, ha, moTa);
        }

        public bool XoaChiTietHinhAnh(int ma)
        {
            return chiTietHinhAnhDAL.XoaChiTietHinhAnh(ma);
        }

        public bool SuaChiTietHinhAnh(int maCT, int maHa, byte[] ha, string moTa)
        {
            return chiTietHinhAnhDAL.SuaChiTietHinhAnh(maCT, maHa, ha, moTa);
        }
    }
}
