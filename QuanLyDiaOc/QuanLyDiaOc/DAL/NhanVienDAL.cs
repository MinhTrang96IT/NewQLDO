using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDiaOc.DAL
{
    class NhanVienDAL : KetNoi
    {
        public DataTable KiemTraDangNhap(string tk, string mk)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_KiemTraDangNhap";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tk", tk));
                sqlCommand.Parameters.Add(new SqlParameter("@mk", mk));
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

        public string LayTenNhanVien(string tk)
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayTenNhanVien";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tk", tk));
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["TenNhanVien"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LayTenLoaiNhanVien(string ma)
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_LoaiNhanVien_LayLoaiNhanVien";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", Int32.Parse(ma)));
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["TenLoaiNhanVien"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LayMaLoaiNhanVien(string tk)
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayMaLoaiNhanVien";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tk", tk));
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["MaLoaiNhanVien"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }
    }
}
