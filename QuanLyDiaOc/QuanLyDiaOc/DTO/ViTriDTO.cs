using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class ViTriDTO
    {
        public int MaViTri { get; set; }
        public string TenViTri { get; set; }
        public string MoTaViTri { get; set; }


        public ViTriDTO(int maViTri, string tenViTri, string moTa)
        {
            MaViTri = maViTri;
            TenViTri = tenViTri;
            MoTaViTri = moTa;
        }

        public ViTriDTO(string tenViTri, string moTa)
        {
            TenViTri = tenViTri;
            MoTaViTri = moTa;
        }
    }
}
