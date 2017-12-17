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
    class LoaiNhaDAL : KetNoi
    {
        public DataTable LayDanhSachLoaiNha()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiNha_LayDanhSach";
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

        public bool ThemLoaiNha(LoaiNhaDTO loaiNhaDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNha_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiNhaDTO.TenLoaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiNhaDTO.MoTa));
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

        public bool XoaLoaiNha(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNha_Xoa";
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

        public bool SuaLoaiNha(LoaiNhaDTO loaiNhaDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiNha_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", loaiNhaDTO.MaLoaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiNhaDTO.TenLoaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiNhaDTO.MoTa));
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

        public DataTable TimKiemLoaiNhaTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiNha_TimKiemTheoTen";
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
