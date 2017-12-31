﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class HuyDangKyDTO
    {
        public int MaPhieuNgungDangKyDichVu { get;set; }
        public int MaPhieuDangKy { get;set; }
        public int MaNhanVien { get;set; }
        public DateTime NgayLap { get; set; }
        public string LyDo { get; set; }
        public int TrangThaiKiemDuyet { get; set; }

        public HuyDangKyDTO(int maPhieuNgungDangKyDichVu, int maPhieuDangKy, int maNhanVien,DateTime ngayLap, string lyDo, int trangThaiKiemDuyet)
        {
            MaPhieuNgungDangKyDichVu = maPhieuNgungDangKyDichVu;
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            LyDo = lyDo;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
        }

        public HuyDangKyDTO(int maPhieuDangKy, int maNhanVien, DateTime ngayLap, string lyDo, int trangThaiKiemDuyet)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayLap = ngayLap;
            LyDo = lyDo;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
        }
    }
}