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
    class HinhAnhDAL : KetNoi
    {
        public DataTable LayDanhSachHinhAnh()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_HinhAnh_LayDanhSach";
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

        public bool ThemHinhAnh(HinhAnhDTO hinhAnhDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_HinhAnh_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mapdk", hinhAnhDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manv", hinhAnhDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayhca", hinhAnhDTO.NgayHenChupAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayca", hinhAnhDTO.NgayChupAnh));
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

        public bool XoaHinhAnh(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_HinhAnh_Xoa";
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

        public bool SuaHinhAnh(HinhAnhDTO hinhAnhDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_HinhAnh_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maha", hinhAnhDTO.MaHinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@mapdk", hinhAnhDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manv", hinhAnhDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayhca", hinhAnhDTO.NgayHenChupAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayca", hinhAnhDTO.NgayChupAnh));
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
