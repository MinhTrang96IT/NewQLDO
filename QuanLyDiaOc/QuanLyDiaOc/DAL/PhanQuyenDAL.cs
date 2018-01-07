using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class PhanQuyenDAL : KetNoi
    {
        public DataTable LayDanhSachPhanQuyen()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhanQuyen_LayDanhSachTheoTenLoai";
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

        public DataTable LayDanhSachTenQuyenHanTheoLoaiNhanVien(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhanQuyen_LayDanhSachTenQuyenHanTheoLoaiNhanVien";
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

        public bool CapNhatPhanQuyen(int loai, List<int> list)
        {
            if (!XoaPhanQuyen(loai)) return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (!ThemPhanQuyen(list[i], loai)) return false;
            }
            return true;
        }

        public bool ThemPhanQuyen(int qh, int loai)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhanQuyen_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@qh", qh));
                sqlCommand.Parameters.Add(new SqlParameter("@loai", loai));
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

        public bool XoaPhanQuyen(int loai)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhanQuyen_Xoa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@loai", loai));
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
