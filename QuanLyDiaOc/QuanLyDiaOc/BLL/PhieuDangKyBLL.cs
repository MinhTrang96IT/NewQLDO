using QuanLyDiaOc.DAL;
using QuanLyDiaOc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BLL
{
    class PhieuDangKyBLL
    {
        private PhieuDangKyDAL phieuDangKyDAL = new PhieuDangKyDAL();

        public DataTable LayDanhSachPhieuDangKy()
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKy();
        }

        public DataTable LayDanhSachPhieuPhieuDangKyCoTen()
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKyCoTen();
        }

        public DataTable LayDanhSachPhieuDangKyTheoMa(int ma)
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKyTheoMa(ma);
        }

        public DataTable LayDanhSachPhieuDangKyTheoMaDiaOc(int madiaoc)
        {
            return phieuDangKyDAL.LayDanhSachPhieuDangKyTheoMaDiaOc(madiaoc);
        }

        public bool ThemPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.ThemPhieuDangKy(phieuDangKyDTO);
        }

        public bool XoaPhieuDangKy(int ma)
        {
            return phieuDangKyDAL.XoaPhieuDangKy(ma);
        }

        public bool SuaPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.SuaPhieuDangKy(phieuDangKyDTO);
        }

        public bool SuaKiemDuyetPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            return phieuDangKyDAL.SuaKiemDuyetPhieuDangKy(phieuDangKyDTO);
        }

        public double TinhTongTien(List<int> listIdLoaiQuangCao, DataTable dtChiTiet, ChiTietQuangCaoBLL chiTietQuangCaoBLL)
        {
            double tongTien = 0.0;
            for (int i = 0; i < listIdLoaiQuangCao.Count; i++)
            {
                if (dtChiTiet.Rows[i]["TenLoaiQuangCao"].ToString() == "Quảng cáo tờ bướm")
                {
                    tongTien += Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_ToBuom(listIdLoaiQuangCao[i]).Rows[0]["DonGia"].ToString()) * Double.Parse(dtChiTiet.Rows[i]["SoLuongPhatHanh"].ToString());
                }
                else
                {
                    tongTien += Double.Parse(chiTietQuangCaoBLL.LayDonGiaTheoMa_LoaiKhac(listIdLoaiQuangCao[i]).Rows[0]["DonGia"].ToString());
                }
            }
            return tongTien;
        }
    }
}
