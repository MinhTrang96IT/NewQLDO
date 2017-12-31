using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;
using System.Data;

namespace QuanLyDiaOc.BLL
{
    class BangCapBLL
    {
        private BangCapDAL bangCapDAL = new BangCapDAL();

        public DataTable LayDanhSachBangCap()
        {
            return bangCapDAL.LayDanhSachBangCap();
        }
    }
}
