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
        public float DienTichKhuonVien { get; set; }
        public float DienTichSuDung { get; set; }
        public string HuongNha { get; set; }
        public float ChieuDaiDat { get; set; }
        public float ChieuRongDat { get; set; }
        public float ChieuDaiNha { get; set; }
        public float ChieuRongNha { get; set; }
        public int SoTang { get; set; }
        public string MoTaChiTiet { get; set; }
        public int GiaBan { get; set; }
        public int TrangThaiKiemDuyen { get; set; }
        public int TrangThaiMuaBan { get; set; }

        public DiaOcDTO(int maDiaOc, int maKhachHang, int maLoaiDiaOc, int maLoaiNha, string diaChi, float dienTichKhuonVien, float dienTichSuDung, string huongNha, float chieuDaiDat, float chieuRongDat, float chieuDaiNha, float chieuRongNha, int soTang, string moTaChiTiet, int giaBan, int trangThaiKiemDuyet, int trangThaiMuaBan)
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
            TrangThaiKiemDuyen = trangThaiKiemDuyet;
            TrangThaiMuaBan = trangThaiMuaBan;
        }

        public DiaOcDTO( int maKhachHang, int maLoaiDiaOc, int maLoaiNha, string diaChi, float dienTichKhuonVien, float dienTichSuDung, string huongNha, float chieuDaiDat, float chieuRongDat, float chieuDaiNha, float chieuRongNha, int soTang, string moTaChiTiet, int giaBan, int trangThaiKiemDuyet, int trangThaiMuaBan)
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
            TrangThaiKiemDuyen = trangThaiKiemDuyet;
            TrangThaiMuaBan = trangThaiMuaBan;
        }
    }
}
