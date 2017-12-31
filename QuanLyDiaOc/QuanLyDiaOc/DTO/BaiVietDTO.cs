using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class BaiVietDTO
    {
        public int MaBaiViet { get; set; }
        public int MaChiTietQuangCao { get; set; }
        public int MaNhanVien { get; set; }
        public string NoiDungBaiViet { get; set; }
        public int TrangThaiKiemDuyet { get; set; }
        public string LyDoKhongDuyet { get; set; }

        public BaiVietDTO(int maBaiViet, int maChiTietQuangCao, int maNhanVien, string noiDungBaiViet, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaBaiViet = maBaiViet;
            MaChiTietQuangCao = maChiTietQuangCao;
            MaNhanVien = maNhanVien;
            NoiDungBaiViet = noiDungBaiViet;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public BaiVietDTO(int maChiTietQuangCao, int maNhanVien, string noiDungBaiViet, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaChiTietQuangCao = maChiTietQuangCao;
            MaNhanVien = maNhanVien;
            NoiDungBaiViet = noiDungBaiViet;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }
    }
}
