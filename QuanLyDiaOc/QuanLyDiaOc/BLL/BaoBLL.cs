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
    class BaoBLL
    {
        private BaoDAL baoDAL = new BaoDAL();
        public DataTable LayDanhSachBao()
        {
            return baoDAL.LayDanhSachBao();
        }

        public bool ThemBao(BaoDTO baoDTO)
        {
            return baoDAL.ThemBao(baoDTO);
        }

        public bool XoaBao(int ma)
        {
            return baoDAL.XoaBao(ma);
        }

        public bool SuaBao(BaoDTO baoDTO)
        {
            return baoDAL.SuaBao(baoDTO);
        }

        public DataTable TimKiemBaoTheoTen(string ten)
        {
            return baoDAL.TimKiemBaoTheoTen(ten);
        }
    }
}
