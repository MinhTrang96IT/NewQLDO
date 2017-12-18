using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class QuyenHanDTO
    {
        public int MaQuyenHan { get; set; }
        public string TenQuyenHan { get; set; }
        public string MoTaQuyenHan { get; set; }


        public QuyenHanDTO(int maQuyenHan, string tenQuyenHan, string moTa)
        {
            MaQuyenHan = maQuyenHan;
            TenQuyenHan = tenQuyenHan;
            MoTaQuyenHan = moTa;
        }

        public QuyenHanDTO(string tenQuyenHan, string moTa)
        {
            TenQuyenHan = tenQuyenHan;
            MoTaQuyenHan = moTa;
        }
    }
}
