using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class LoaiNhaDTO
    {
        public int MaLoaiNha { get; set; }
        public string TenLoaiNha { get; set; }
        public string MoTa { get; set; }


        public LoaiNhaDTO(int maLoaiNha, string tenLoaiNha, string moTa)
        {
            MaLoaiNha = maLoaiNha;
            TenLoaiNha = tenLoaiNha;
            MoTa = moTa;
        }

        public LoaiNhaDTO(string tenLoaiNha, string moTa)
        {
            TenLoaiNha = tenLoaiNha;
            MoTa = moTa;
        }
    }
}
