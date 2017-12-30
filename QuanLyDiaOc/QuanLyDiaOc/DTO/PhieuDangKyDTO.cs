using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class PhieuDangKyDTO
    {
        public int MaPhieuDangKy { get; set; }
        public int MaKhachHang { get; set; }
        public int MaDiaOc { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoLanGiaHan { get; set; }
        public int TrangThaiKiemDuyet { get; set; }
        public double TongTien { get; set; }
        public double DaTra { get; set; }
        public double ConNo { get; set; }

        public PhieuDangKyDTO(int maPhieuDangKy, int maKhachHang, int maDiaOc, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int soLanGiaHan, int trangThaiKiemDuyet, double tongTien, double daTra, double conNo)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaKhachHang = maKhachHang;
            MaDiaOc = maDiaOc;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLanGiaHan = soLanGiaHan;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TongTien = tongTien;
            DaTra = daTra;
            ConNo = conNo;
        }

        public PhieuDangKyDTO( int maKhachHang, int maDiaOc, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int soLanGiaHan, int trangThaiKiemDuyet, double tongTien, double daTra, double conNo)
        {
            MaKhachHang = maKhachHang;
            MaDiaOc = maDiaOc;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            SoLanGiaHan = soLanGiaHan;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TongTien = tongTien;
            DaTra = daTra;
            ConNo = conNo;
        }

    }
}
