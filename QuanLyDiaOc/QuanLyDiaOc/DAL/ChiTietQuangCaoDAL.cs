using QuanLyDiaOc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class ChiTietQuangCaoDAL : KetNoi
    {
        public DataTable LayDanhSachChiTietQuangCao()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietQuangCao_LayDanhSach";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public DataTable LayDanhSachChiTietQuangCaoTheoTenLoai()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietQuangCao_LayDanhSachTheoTenLoai";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public DataTable LayDanhSachChiTietQuangCaoTheoMaPhieuDangKy(int maphieudangky)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietQuangCao_LayDanhSachTheoMaPhieuDangKy";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", maphieudangky));
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public DataTable LayDonGiaTheoMa(int machitietquangcao)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietQuangCao_LayDonGiaTheoMa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@machitietquangcao", machitietquangcao));
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool ThemChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietQuangCao_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", chiTietQuangCaoDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaiquangcao", chiTietQuangCaoDTO.MaLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mavitri", chiTietQuangCaoDTO.MaViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mabao", chiTietQuangCaoDTO.MaBao));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", chiTietQuangCaoDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", chiTietQuangCaoDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanh", chiTietQuangCaoDTO.SoLuongPhatHanh));
                sqlCommand.Parameters.Add(new SqlParameter("@kichthuoc", chiTietQuangCaoDTO.KichThuoc));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", chiTietQuangCaoDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", chiTietQuangCaoDTO.LyDoKhongDuyet));
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool XoaChiTietQuangCao(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietQuangCao_Xoa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", ma));
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool SuaChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietQuangCao_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@machitietquangcao", chiTietQuangCaoDTO.MaChiTietQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", chiTietQuangCaoDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaiquangcao", chiTietQuangCaoDTO.MaLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mavitri", chiTietQuangCaoDTO.MaViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mabao", chiTietQuangCaoDTO.MaBao));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", chiTietQuangCaoDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", chiTietQuangCaoDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanh", chiTietQuangCaoDTO.SoLuongPhatHanh));
                sqlCommand.Parameters.Add(new SqlParameter("@kichthuoc", chiTietQuangCaoDTO.KichThuoc));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", chiTietQuangCaoDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", chiTietQuangCaoDTO.LyDoKhongDuyet));
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool SuaKiemDuyetChiTietQuangCao(ChiTietQuangCaoDTO chiTietQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietQuangCao_SuaKiemDuyet";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@machitietquangcao", chiTietQuangCaoDTO.MaChiTietQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", chiTietQuangCaoDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", chiTietQuangCaoDTO.LyDoKhongDuyet));

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
