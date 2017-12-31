using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.DAL
{
    class KhachHangDAL : KetNoi
    {
        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_LayDanhSach";
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

        public DataTable LayDanhSachKhachHangTheoMa(int ma)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_LayDanhSachTheoMa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", ma));
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

        public bool ThemKhachHang(KhachHangDTO khachHangDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", khachHangDTO.TenKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@cmnd", khachHangDTO.CMND));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", khachHangDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@namsinh", khachHangDTO.NamSinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", khachHangDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", khachHangDTO.SoDienThoai));
                sqlCommand.Parameters.Add(new SqlParameter("@email", khachHangDTO.Email));
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

        public bool XoaKhachHang(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Xoa";
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

        public bool SuaKhachHang(KhachHangDTO khachHangDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", khachHangDTO.MaKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", khachHangDTO.TenKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@cmnd", khachHangDTO.CMND));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", khachHangDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@namsinh", khachHangDTO.NamSinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", khachHangDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", khachHangDTO.SoDienThoai));
                sqlCommand.Parameters.Add(new SqlParameter("@email", khachHangDTO.Email));
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

        public DataTable TimKiemKHTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_TimKiemTheoTen";
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
