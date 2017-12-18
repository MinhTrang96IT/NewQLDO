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
    class PhongBanDAL : KetNoi
    {
        public DataTable LayDanhSachPhongBan()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhongBan_LayDanhSach";
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

        public bool ThemPhongBan(PhongBanDTO phongBanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhongBan_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", phongBanDTO.TenLPhongBan));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", phongBanDTO.MoTaPhongBan));
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

        public bool XoaPhongBan(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhongBan_Xoa";
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

        public bool SuaPhongBan(PhongBanDTO phongBanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhongBan_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", phongBanDTO.MaPhongBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", phongBanDTO.TenLPhongBan));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", phongBanDTO.MoTaPhongBan));
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

        public DataTable TimKiemPhongBanTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhongBan_TimKiemTheoTen";
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
