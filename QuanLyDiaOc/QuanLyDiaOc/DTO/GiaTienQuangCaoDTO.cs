using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class GiaTienQuangCaoDTO
    {
        public int MaGiaTienQuangCao { get; set; }
        public int MaLoaiQuangCao { get; set; }
        public int MaViTri { get; set; }
        public int SoLuongPhatHanhToiThieu { get; set; }
        public int SoLuongPhatHanhToiDa { get; set; }
        public int KichCoToiThieu { get; set; }
        public int KichCoToiDa { get; set; }
        public double DonGia { get; set; }

        public GiaTienQuangCaoDTO(int maGiaTienQuangCao, int maLoaiQuangCao, int maViTri, int soLuongPhatHanhToiThieu, int soLuongPhatHanhToiDa, int kichCoToiThieu, int kichCoToiDa, double donGia)
        {
            MaGiaTienQuangCao = maGiaTienQuangCao;
            MaLoaiQuangCao = maLoaiQuangCao;
            MaViTri = maViTri;
            SoLuongPhatHanhToiThieu = soLuongPhatHanhToiThieu;
            SoLuongPhatHanhToiDa = soLuongPhatHanhToiDa;
            KichCoToiThieu = kichCoToiThieu;
            KichCoToiDa = kichCoToiDa;
            DonGia = donGia;
        }
       public  GiaTienQuangCaoDTO(int maLoaiQuangCao, int maViTri, int soLuongPhatHanhToiThieu, int soLuongPhatHanhToiDa, int kichCoToiThieu, int kichCoToiDa, double donGia)
        {
            MaLoaiQuangCao = maLoaiQuangCao;
            MaViTri = maViTri;
            SoLuongPhatHanhToiThieu = soLuongPhatHanhToiThieu;
            SoLuongPhatHanhToiDa = soLuongPhatHanhToiDa;
            KichCoToiThieu = kichCoToiThieu;
            KichCoToiDa = kichCoToiDa;
            DonGia = donGia;
        }
    }
}
