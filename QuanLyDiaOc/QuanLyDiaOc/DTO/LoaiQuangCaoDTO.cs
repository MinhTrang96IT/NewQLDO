using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class LoaiQuangCaoDTO
    {
        public int MaLoaiQuangCao { get; set; }
        public string TenLoaiQuangCao { get; set; }
        public string MoTaLoaiQuangCao { get; set; }


        public LoaiQuangCaoDTO(int maLoaiQuangCao, string tenLoaiQuangCao, string moTa)
        {
            MaLoaiQuangCao = maLoaiQuangCao;
            TenLoaiQuangCao = tenLoaiQuangCao;
            MoTaLoaiQuangCao = moTa;
        }

        public LoaiQuangCaoDTO(string tenLoaiQuangCao, string moTa)
        {
            TenLoaiQuangCao = tenLoaiQuangCao;
            MoTaLoaiQuangCao = moTa;
        }
    }
}
