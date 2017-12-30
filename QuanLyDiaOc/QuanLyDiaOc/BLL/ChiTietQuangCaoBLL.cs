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
    class ChiTietQuangCaoBLL
    {
        private ChiTietQuangCaoDAL chiTietQuangCaoDAL = new ChiTietQuangCaoDAL();

        public DataTable LayDanhSachChiTietQuangCao()
        {
            return chiTietQuangCaoDAL.LayDanhSachChiTietQuangCao();
        }

        public DataTable LayDanhSachChiTietQuangCaoTheoTenLoai()
        {
            return chiTietQuangCaoDAL.LayDanhSachChiTietQuangCaoTheoTenLoai();
        }

        public DataTable LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(int maphieudangky)
        {
            return chiTietQuangCaoDAL.LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy( maphieudangky);
        }

        public DataTable LayDonGiaTheoMa(int machitietquangcao)
        {
            return chiTietQuangCaoDAL.LayDonGiaTheoMa(machitietquangcao);
        }

        public bool ThemChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.ThemChiTietQuangCao(chiTietQuangCaoDTO);
        }

        public bool XoaChiTietQuangCao(int ma)
        {
            return chiTietQuangCaoDAL.XoaChiTietQuangCao(ma);
        }

        public bool SuaChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.SuaChiTietQuangCao(chiTietQuangCaoDTO);
        }
    }
}
