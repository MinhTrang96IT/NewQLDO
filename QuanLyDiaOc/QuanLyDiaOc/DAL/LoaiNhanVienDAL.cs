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
    class LoaiNhanVienDAL : KetNoi
    {
        public DataTable LayDanhSachLoaiNhanVien()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiNhanVien_LayDanhSach";
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

        public bool ThemLoaiNhanVien(LoaiNhanVienDTO loaiNhanVienDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNhanVien_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiNhanVienDTO.TenLoaiNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiNhanVienDTO.MoTaLoaiNhanVien));
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

        public bool XoaLoaiNhanVien(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNhanVien_Xoa";
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

        public bool SuaLoaiNhanVien(LoaiNhanVienDTO loaiNhanVienDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNhanVien_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", loaiNhanVienDTO.MaLoaiNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiNhanVienDTO.TenLoaiNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiNhanVienDTO.MoTaLoaiNhanVien));
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

        public DataTable TimKiemLoaiNhanVienTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiNhanVien_TimKiemTheoTen";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", ten));
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
