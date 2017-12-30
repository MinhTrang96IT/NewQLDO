using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DTO
{
    class HinhAnhDTO
    {
        public int MaHinhAnh { get; set; }
        public int MaPhieuDangKy { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayHenChupAnh { get; set; }
        public DateTime NgayChupAnh { get; set; }

        public HinhAnhDTO(int maHinhAnh, int maPhieuDangKy, int maNhanVien, DateTime ngayHenChupAnh, DateTime ngayChupAnh)
        {
            MaHinhAnh = maHinhAnh;
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayHenChupAnh = ngayHenChupAnh;
            NgayChupAnh = ngayChupAnh;
        }

        public HinhAnhDTO(int maPhieuDangKy, int maNhanVien, DateTime ngayHenChupAnh, DateTime ngayChupAnh)
        {
            MaPhieuDangKy = maPhieuDangKy;
            MaNhanVien = maNhanVien;
            NgayHenChupAnh = ngayHenChupAnh;
            NgayChupAnh = ngayChupAnh;
        }
    }
}
