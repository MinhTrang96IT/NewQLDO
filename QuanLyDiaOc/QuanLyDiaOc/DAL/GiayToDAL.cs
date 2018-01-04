using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class GiayToDAL : KetNoi
    {
        public DataTable LayDanhSachGiayTo()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiayTo_LayDanhSach";
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

        public DataTable LayDanhSachGiayToTheoMaDO(int maDO)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiayTo_LayDanhSachTheoMaDO";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", maDO));
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

        public bool ThemGiayTo(int maDo, byte[] ha, string ten)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiayTo_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", maDo));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", ha));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", ten));
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

        public bool XoaGiayTo(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiayTo_Xoa";
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

        public bool SuaGiayTo(int maGT, int maDO, byte[] ha, string ten)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiayTo_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@magt", maGT));
                sqlCommand.Parameters.Add(new SqlParameter("@mado", maDO));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", ha));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", ten));
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
