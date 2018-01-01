using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class ChiTietQuangCaoDTO
    {
        public int MaChiTietQuangCao { get; set; }
        public int MaPhieuDangKy { get; set; }
        public int MaLoaiQuangCao { get; set; }
        public int MaViTri { get; set; }
        public int MaBao { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoLuongPhatHanh { get; set; }
        public double KichThuoc { get; set; }
        public int TrangThaiKiemDuyet { get; set; }
        public string LyDoKhongDuyet { get; set; }


        public ChiTietQuangCaoDTO(int maChiTietQuangCao, int maPhieuDangKy , int maLoaiQuangCao, int maViTri, int maBao, DateTime ngayBatDau, DateTime ngayKetThuc, int soLuongPhatHanh, double kichThuoc, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaChiTietQuangCao = maChiTietQuangCao;
            MaPhieuDangKy = maPhieuDangKy;
            MaLoaiQuangCao = maLoaiQuangCao;
            MaViTri = maViTri;
            MaBao = maBao;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLuongPhatHanh = soLuongPhatHanh;
            KichThuoc = kichThuoc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public ChiTietQuangCaoDTO(int maPhieuDangKy, int maLoaiQuangCao, int maViTri, int maBao, DateTime ngayBatDau, DateTime ngayKetThuc, int soLuongPhatHanh, double kichThuoc, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaLoaiQuangCao = maLoaiQuangCao;
            MaViTri = maViTri;
            MaBao = maBao;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLuongPhatHanh = soLuongPhatHanh;
            KichThuoc = kichThuoc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public ChiTietQuangCaoDTO(int maChiTietQuangCao, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaChiTietQuangCao = maChiTietQuangCao;
               TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }
        
        public ChiTietQuangCaoDTO(int maPhieuDangKy, int maLoaiQuangCao, int maViTri, int maBao, DateTime ngayBatDau, DateTime ngayKetThuc, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaLoaiQuangCao = maLoaiQuangCao;
            MaViTri = maViTri;
            MaBao = maBao;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public ChiTietQuangCaoDTO(int maPhieuDangKy, int maLoaiQuangCao, int soLuongPhatHanh, double kichThuoc, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaLoaiQuangCao = maLoaiQuangCao;
            SoLuongPhatHanh = soLuongPhatHanh;
            KichThuoc = kichThuoc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }
    }
}
