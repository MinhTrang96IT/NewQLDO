using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;

namespace QuanLyDiaOc.BLL
{
    class GiayToBLL
    {
        private GiayToDAL giayToDAL = new GiayToDAL();

        public DataTable LayDanhSachGiayTo()
        {
            return giayToDAL.LayDanhSachGiayTo();
        }

        public DataTable LayDanhSachGiayToTheoMaDO(int maDO)
        {
            return giayToDAL.LayDanhSachGiayToTheoMaDO(maDO);
        }

        public bool ThemGiayTo(int maDo, byte[] ha, string ten)
        {
            return giayToDAL.ThemGiayTo(maDo, ha, ten);
        }

        public bool XoaGiayTo(int ma)
        {
            return giayToDAL.XoaGiayTo(ma);
        }

        public bool SuaGiayTo(int maGT, int maDO, byte[] ha, string ten)
        {
            return giayToDAL.SuaGiayTo(maGT, maDO, ha, ten);
        }
    }
}
