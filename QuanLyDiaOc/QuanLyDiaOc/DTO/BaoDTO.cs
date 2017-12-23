using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class BaoDTO
    {
        public int MaBao { get; set; }
        public string TenBao { get; set; }
        public string MoTaBao { get; set; }


        public BaoDTO(int maBao, string tenBao, string moTa)
        {
            MaBao = maBao;
            TenBao = tenBao;
            MoTaBao = moTa;
        }

        public BaoDTO(string tenBao, string moTa)
        {
            TenBao = tenBao;
            MoTaBao = moTa;
        }
    }
}
