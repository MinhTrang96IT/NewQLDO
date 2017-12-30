using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class ChiTietHinhAnhDAL : KetNoi
    {
        public DataTable LayDanhSachChiTietHinhAnh()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietHinhAnh_LayDanhSach";
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

        public DataTable LayDanhSachChiTietHinhAnhTheoMaHA(int maHA)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ChiTietHinhAnh_LayDanhSachTheoMaHA";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maha", maHA));
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

        public bool ThemChiTietHinhAnh(int maHa, byte[] ha, string moTa)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietHinhAnh_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maha", maHa));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", ha));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", moTa));
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

        public bool XoaChiTietHinhAnh(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietHinhAnh_Xoa";
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

        public bool SuaChiTietHinhAnh(int maCT, int maHa, byte[] ha, string moTa)
        {
            try
            {
                OpenConnect();
                string store = "sp_ChiTietHinhAnh_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mact", maCT));
                sqlCommand.Parameters.Add(new SqlParameter("@maha", maHa));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", ha));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", moTa));
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
