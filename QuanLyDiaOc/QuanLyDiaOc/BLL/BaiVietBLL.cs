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
    class BaiVietBLL
    {
        private BaiVietDAL baiVietDAL = new BaiVietDAL();

        public DataTable LayDanhSachBaiViet()
        {
            return baiVietDAL.LayDanhSachBaiViet();
        }

        public DataTable LayDanhSachBaiVietTheoMa(int ma)
        {
            return baiVietDAL.LayDanhSachBaiVietTheoMa(ma);
        }

        public DataTable LayDanhSachBaiVietTheoTenNhanVien()
        {
            return baiVietDAL.LayDanhSachBaiVietTheoTenNhanVien();
        }

        public bool ThemBaiViet(BaiVietDTO baiVietDTO)
        {
            return baiVietDAL.ThemBaiViet(baiVietDTO);
        }

        public bool XoaBaiViet(int ma)
        {
            return baiVietDAL.XoaBaiViet(ma);
        }

        public bool SuaBaiViet(BaiVietDTO baiVietDTO)
        {
            return baiVietDAL.SuaBaiViet(baiVietDTO);
        }

        public bool SuaKiemDuyetBaiViet(BaiVietDTO baiVietDTO)
        {
            return baiVietDAL.SuaKiemDuyetBaiViet(baiVietDTO);
        }

        public DataTable LayDanhSachBaiVietTheoMaChiTietQuangCao(int machitietquangcao)
        {
            return baiVietDAL.LayDanhSachBaiVietTheoMaChiTietQuangCao(machitietquangcao);
        }
    }
}
