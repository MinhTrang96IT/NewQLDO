using QuanLyDiaOc.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BLL
{
    class ThongKeBLL
    {
        private ThongKeDAL thongKeDAL = new ThongKeDAL();
        public DataTable LayThongKeKhachHangTheoNamSinh()
        {
            return thongKeDAL.ThongKeKhachHangTheoNamSinh();
        }

        public double LayDoanhThuTheoThang(int thang, int nam)
        {
            try
            {
                return thongKeDAL.LayDoanhThuTheoThang(thang, nam);
            }
            catch
            {
                return 0.0;
            }
        }
    }
}
