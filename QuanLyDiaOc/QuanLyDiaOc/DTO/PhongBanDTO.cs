using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class PhongBanDTO
    {
        public int MaPhongBan { get; set; }
        public string TenLPhongBan { get; set; }
        public string MoTaPhongBan { get; set; }


        public PhongBanDTO(int maPhongBan, string tenPhongBan, string moTa)
        {
            MaPhongBan = maPhongBan;
            TenLPhongBan = tenPhongBan;
            MoTaPhongBan = moTa;
        }

        public PhongBanDTO(string tenPhongBan, string moTa)
        {
            TenLPhongBan = tenPhongBan;
            MoTaPhongBan = moTa;
        }
    }
}
