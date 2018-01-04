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
    class BaiVietDAL : KetNoi
    {
        public DataTable LayDanhSachBaiViet()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_BaiViet_LayDanhSach";
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

        public DataTable LayDanhSachBaiVietTheoTenNhanVien()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_BaiViet_LayDanhSachTheoTenNhanVien";
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

        public DataTable LayDanhSachBaiViwtTheoMa(int ma)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_BaiViet_LayDanhSachTheoMa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", ma));
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

        public bool ThemBaiViet(BaiVietDTO baiVietDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_BaiViet_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@machitietquangcao", baiVietDTO.MaChiTietQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", baiVietDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@noidungbaiviet", baiVietDTO.NoiDungBaiViet));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", baiVietDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", baiVietDTO.LyDoKhongDuyet));
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

        public bool XoaBaiViet(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_BaiViet_Xoa";
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

        public bool SuaBaiViet(BaiVietDTO baiVietDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_BaiViet_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mabaiviet", baiVietDTO.MaBaiViet));
                sqlCommand.Parameters.Add(new SqlParameter("@machitietquangcao", baiVietDTO.MaChiTietQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", baiVietDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@noidungbaiviet", baiVietDTO.NoiDungBaiViet));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", baiVietDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", baiVietDTO.LyDoKhongDuyet));
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

        public bool SuaKiemDuyetBaiViet(BaiVietDTO baiVietDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_BaiViet_SuaKiemDuyet";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@mabaiviet", baiVietDTO.MaBaiViet));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", baiVietDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", baiVietDTO.LyDoKhongDuyet));

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

        public DataTable LayDanhSachBaiVietTheoMaChiTietQuangCao(int machitietquangcao)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietQuangCao_LayDanhSachBaiVietTheoMaChiTietQuangCao";
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
    }
}
