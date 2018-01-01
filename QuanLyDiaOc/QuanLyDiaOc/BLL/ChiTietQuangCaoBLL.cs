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

        public bool ThemChiTietQuangCaoToBuom(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.ThemChiTietQuangCaoToBuom(chiTietQuangCaoDTO);
        }

        public bool ThemChiTietQuangCaoLoaiKhac(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.ThemChiTietQuangCaoLoaiKhac(chiTietQuangCaoDTO);
        }

        public bool XoaChiTietQuangCao(int ma)
        {
            return chiTietQuangCaoDAL.XoaChiTietQuangCao(ma);
        }

        public bool SuaChiTietQuangCaoToBuom(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.SuaChiTietQuangCaoToBuom(chiTietQuangCaoDTO);
        }

        public bool SuaChiTietQuangCaoLoaiKhac(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.SuaChiTietQuangCaoLoaiKhac(chiTietQuangCaoDTO);
        }

        public bool SuaKiemDuyetChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            return chiTietQuangCaoDAL.SuaKiemDuyetChiTietQuangCao(chiTietQuangCaoDTO);
        }
    }
}
