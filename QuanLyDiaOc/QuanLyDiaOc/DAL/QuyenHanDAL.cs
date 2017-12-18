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
    class QuyenHanDAL : KetNoi
    {
        public DataTable LayDanhSachQuyenHan()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyenHan_LayDanhSach";
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

        public bool ThemQuyenHan(QuyenHanDTO quyenHanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_QuyenHan_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", quyenHanDTO.TenQuyenHan));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", quyenHanDTO.MoTaQuyenHan));
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

        public bool XoaQuyenHan(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_QuyenHan_Xoa";
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

        public bool SuaQuyenHan(QuyenHanDTO quyenHanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_QuyenHan_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", quyenHanDTO.MaQuyenHan));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", quyenHanDTO.TenQuyenHan));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", quyenHanDTO.MoTaQuyenHan));
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

        public DataTable TimKiemQuyenHanTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyenHan_TimKiemTheoTen";
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
