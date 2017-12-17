using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class LoaiDiaOcDTO
    {
        public int MaLoaiDiaOc { get; set; }
        public string TenLoaiDiaOc { get; set; }
        public string MoTa { get; set; }
       

        public LoaiDiaOcDTO(int maLoaiDiaOc, string tenLoaiDiaOc, string moTa)
        {
            MaLoaiDiaOc = maLoaiDiaOc;
            TenLoaiDiaOc = tenLoaiDiaOc;
            MoTa = moTa;
        }

        public LoaiDiaOcDTO(string tenLoaiDiaOc, string moTa)
        {
            TenLoaiDiaOc = tenLoaiDiaOc;
            MoTa = moTa;
        }
    }
}
