using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class DiaOcDTO
    {
        public int MaDiaOc { get; set; }
        public int MaKhachHang { get; set; }
        public int MaLoaiDiaOc { get; set; }
        public int MaLoaiNha { get; set; }
        public string DiaChi { get; set; }
        public double DienTichKhuonVien { get; set; }
        public double DienTichSuDung { get; set; }
        public string HuongNha { get; set; }
        public double ChieuDaiDat { get; set; }
        public double ChieuRongDat { get; set; }
        public double ChieuDaiNha { get; set; }
        public double ChieuRongNha { get; set; }
        public int SoTang { get; set; }
        public string MoTaChiTiet { get; set; }
        public double GiaBan { get; set; }
        public int TrangThaiKiemDuyet { get; set; }
        public int TrangThaiMuaBan { get; set; }

        public DiaOcDTO(int maDiaOc, int maKhachHang, int maLoaiDiaOc, int maLoaiNha, string diaChi, double dienTichKhuonVien, double dienTichSuDung, string huongNha, double chieuDaiDat, double chieuRongDat, double chieuDaiNha, double chieuRongNha, int soTang, string moTaChiTiet, double giaBan, int trangThaiKiemDuyet, int trangThaiMuaBan)
        {
            MaDiaOc = maDiaOc;
            MaKhachHang = maKhachHang;
            MaLoaiDiaOc = maLoaiDiaOc;
            MaLoaiNha = maLoaiNha;
            DiaChi = diaChi;
            DienTichKhuonVien = dienTichKhuonVien;
            DienTichSuDung = dienTichSuDung;
            HuongNha = huongNha;
            ChieuDaiDat = chieuDaiDat;
            ChieuRongDat = chieuRongDat;
            ChieuDaiNha = chieuDaiNha;
            ChieuRongNha = chieuRongNha;
            SoTang = soTang;
            MoTaChiTiet = moTaChiTiet;
            GiaBan = giaBan;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TrangThaiMuaBan = trangThaiMuaBan;
        }

        public DiaOcDTO( int maKhachHang, int maLoaiDiaOc, int maLoaiNha, string diaChi, double dienTichKhuonVien, double dienTichSuDung, string huongNha, double chieuDaiDat, double chieuRongDat, double chieuDaiNha, double chieuRongNha, int soTang, string moTaChiTiet, double giaBan, int trangThaiKiemDuyet, int trangThaiMuaBan)
        {
            MaKhachHang = maKhachHang;
            MaLoaiDiaOc = maLoaiDiaOc;
            MaLoaiNha = maLoaiNha;
            DiaChi = diaChi;
            DienTichKhuonVien = dienTichKhuonVien;
            DienTichSuDung = dienTichSuDung;
            HuongNha = huongNha;
            ChieuDaiDat = chieuDaiDat;
            ChieuRongDat = chieuRongDat;
            ChieuDaiNha = chieuDaiNha;
            ChieuRongNha = chieuRongNha;
            SoTang = soTang;
            MoTaChiTiet = moTaChiTiet;
            GiaBan = giaBan;
            TrangThaiKiemDuyet = trangThaiKiemDuyet;
            TrangThaiMuaBan = trangThaiMuaBan;
        }
    }
}
