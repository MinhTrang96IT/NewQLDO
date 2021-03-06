﻿using System;
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
        public string LyDoKhongDuyet { get; set; }

        public PhieuDangKyDTO(int maPhieuDangKy, int maKhachHang, int maDiaOc, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int soLanGiaHan, int trangThaiKiemDuyet, double tongTien, string lyDoKhongDuyet)
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
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public PhieuDangKyDTO( int maKhachHang, int maDiaOc, int maNhanVien, DateTime ngayLap, DateTime ngayBatDau, DateTime ngayKetThuc, int soLanGiaHan, int trangThaiKiemDuyet, double tongTien, string lyDoKhongDuyet)
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
            LyDoKhongDuyet = lyDoKhongDuyet;
        }

        public PhieuDangKyDTO(int maPhieuDangKy, int trangThaiKiemDuyet, string lyDoKhongDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            LyDoKhongDuyet = lyDoKhongDuyet;
        }
    }
}
