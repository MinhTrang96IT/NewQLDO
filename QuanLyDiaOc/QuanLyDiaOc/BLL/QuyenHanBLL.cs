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
    class QuyenHanBLL
    {
        private QuyenHanDAL quyenHanDAL = new QuyenHanDAL();
        public DataTable LayDanhSachQuyenHan()
        {
            return quyenHanDAL.LayDanhSachQuyenHan();
        }

        public bool ThemQuyenHan(QuyenHanDTO quyenHanDTO)
        {
            return quyenHanDAL.ThemQuyenHan(quyenHanDTO);
        }

        public bool XoaQuyenHan(int ma)
        {
            return quyenHanDAL.XoaQuyenHan(ma);
        }

        public bool SuaQuyenHan(QuyenHanDTO quyenHanDTO)
        {
            return quyenHanDAL.SuaQuyenHan(quyenHanDTO);
        }

        public DataTable TimKiemQuyenHanTheoTen(string ten)
        {
            return quyenHanDAL.TimKiemQuyenHanTheoTen(ten);
        }
    }
}
