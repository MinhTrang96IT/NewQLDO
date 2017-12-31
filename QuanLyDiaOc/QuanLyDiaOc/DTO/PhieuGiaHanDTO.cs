using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class PhieuGiaHanDTO
    {
        public int MaPhieuGiaHan { get; set; }
        public int MaPhieuDangKy { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TrangThaiKiemDuyet { get; set; }
        public double TongTien { get; set; }
        public string LyDoKhongDuyet { get; set; }

        public PhieuGiaHanDTO(int maPhieuGiaHan, int maPhieuDangKy, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int trangThaiKiemDuyet, double tongTien, string lyDoKhongDuyet)
        {
            MaPhieuGiaHan = maPhieuGiaHan;
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TongTien = tongTien;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public PhieuGiaHanDTO(int maPhieuDangKy, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int trangThaiKiemDuyet, double tongTien, string lyDoKhongDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TongTien = tongTien;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public PhieuGiaHanDTO(int maPhieuGiaHan, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaPhieuGiaHan = maPhieuGiaHan;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }
    }
}
