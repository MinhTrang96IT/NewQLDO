using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class LoaiNhanVienDTO
    {
        public int MaLoaiNhanVien { get; set; }
        public string TenLoaiNhanVien { get; set; }
        public string MoTaLoaiNhanVien { get; set; }


        public LoaiNhanVienDTO(int maLoaiNhanVien, string tenLoaiNhanVien, string moTa)
        {
            MaLoaiNhanVien = maLoaiNhanVien;
            TenLoaiNhanVien = tenLoaiNhanVien;
            MoTaLoaiNhanVien = moTa;
        }

        public LoaiNhanVienDTO(string tenLoaiNhanVien, string moTa)
        {
            TenLoaiNhanVien = tenLoaiNhanVien;
            MoTaLoaiNhanVien = moTa;
        }
    }
}
