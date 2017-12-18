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
    class LoaiQuangCaoDAL : KetNoi
    {
        public DataTable LayDanhSachLoaiQuangCao()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiQuangCao_LayDanhSach";
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

        public bool ThemLoaiQuangCao(LoaiQuangCaoDTO loaiQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiQuangCao_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiQuangCaoDTO.TenLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiQuangCaoDTO.MoTaLoaiQuangCao));
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

        public bool XoaLoaiQuangCao(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiQuangCao_Xoa";
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

        public bool SuaLoaiQuangCao(LoaiQuangCaoDTO loaiQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiQuangCao_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", loaiQuangCaoDTO.MaLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiQuangCaoDTO.TenLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiQuangCaoDTO.MoTaLoaiQuangCao));
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

        public DataTable TimKiemLoaiQuangCaoTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiQuangCao_TimKiemTheoTen";
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
