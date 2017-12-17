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
    class LoaiDiaOcDAL : KetNoi
    {
        public DataTable LayDanhSachLoaiDiaOc()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiDiaOc_LayDanhSach";
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

        public bool ThemLoaiDiaOc(LoaiDiaOcDTO loaiDiaOcDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiDiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiDiaOcDTO.TenLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiDiaOcDTO.MoTa));
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

        public bool XoaLoaiDiaOc(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiDiaOc_Xoa";
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

        public bool SuaLoaiDiaOc(LoaiDiaOcDTO loaiDiaOcDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_LoaiDiaOc_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", loaiDiaOcDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", loaiDiaOcDTO.TenLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", loaiDiaOcDTO.MoTa));
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

        public DataTable TimKiemLoaiDiaOcTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiDiaOc_TimKiemTheoTen";
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
