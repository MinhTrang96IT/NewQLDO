using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DAL;

namespace QuanLyDiaOc.BLL
{
    class QuyDinhBLL
    {
        private QuyDinhDAL quyDinhDAL = new QuyDinhDAL();
        public string LayLaiSuatTreHanThanhToan()
        {
            return quyDinhDAL.LayLaiSuatTreHanThanhToan();
        }

        public string LayPhanTramHoaDonGiaHan()
        {
            return quyDinhDAL.LayPhanTramHoaDonGiaHan();
        }

        public string LaySoNgayQuangCaoToiDa()
        {
            return quyDinhDAL.LaySoNgayQuangCaoToiDa();
        }

        public string LaySoTuToiDa()
        {
            return quyDinhDAL.LaySoTuToiDa();
        }

        public string LayThoiGianChupAnhToiDa()
        {
            return quyDinhDAL.LayThoiGianChupAnhToiDa();
        }

        public string LayPhanTramQuangCaoCoMau()
        {
            return quyDinhDAL.LayPhanTramQuangCaoCoMau();
        }

        public bool CapNhatPhieuThu(float laiSuat, float phanTramHoaDonGiaHan)
        {
            return quyDinhDAL.CapNhatPhieuThu(laiSuat, phanTramHoaDonGiaHan);
        }

        public bool CapNhatQuangCao(int soNgayQuangCao, int soTuBaiViet, int thoiGianChupAnh, float phamTramQuangCao)
        {
            return quyDinhDAL.CapNhatQuangCao(soNgayQuangCao, soTuBaiViet, thoiGianChupAnh, phamTramQuangCao);
        }
    }
}
