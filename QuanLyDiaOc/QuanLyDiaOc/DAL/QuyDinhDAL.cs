using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class QuyDinhDAL : KetNoi
    {
        public string LayLaiSuatTreHanThanhToan()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LayLaiSuatTreHanThanhToan";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["LaiSuatTreHanThanhToan"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LayPhanTramHoaDonGiaHan()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LayPhanTramHoaDonGiaHan";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["PhanTramHoaDonGiaHan"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LaySoNgayQuangCaoToiDa()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LaySoNgayQuangCaoToiDa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["SoNgayQuangCaoToiDa"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LaySoTuToiDa()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LaySoTuToiDa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["SoTuToiDa"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LayThoiGianChupAnhToiDa()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LayThoiGianChupAnhToiDa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["ThoiGianChupAnhToiDa"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public string LayPhanTramQuangCaoCoMau()
        {
            string s = null;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QuyDinh_LayPhanTramQuangCaoCoMau";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["PhanTramQuangCaoCoMau"].ToString();
                }
            }
            catch { }
            finally
            {
                CloseConnect();
            }
            return s;
        }

        public bool CapNhatPhieuThu(float laiSuat, float phanTramHoaDonGiaHan)
        {
            try
            {
                OpenConnect();
                String store = "sp_QuyDinh_SuaPhieuThu";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@laiSuat", laiSuat));
                sqlCommand.Parameters.Add(new SqlParameter("@phantramhoadongiahan", phanTramHoaDonGiaHan));
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

        public bool CapNhatQuangCao(int soNgayQuangCao, int soTuBaiViet, int thoiGianChupAnh, float phamTramQuangCao)
        {
            try
            {
                OpenConnect();
                String store = "sp_QuyDinh_SuaQuangCao";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@songayquangcao", soNgayQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@sotubaiviet", soTuBaiViet));
                sqlCommand.Parameters.Add(new SqlParameter("@thoigianchupanh", thoiGianChupAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@phantramquangcao", phamTramQuangCao));
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
