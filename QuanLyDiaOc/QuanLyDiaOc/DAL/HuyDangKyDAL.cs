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
    class HuyDangKyDAL : KetNoi
    {
        public DataTable LayDanhSachHuyDangKy()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_HuyDangKy_LayDanhSach";
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

        public DataTable LayDanhSachPhieuDangKy()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_HuyDangKy_LayDanhSachPhieuDangKy";
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

        public DataTable LayDanhSachPhieuHuyDangKyCoTenNhanVien()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuDangKy_LayDanhSachPhieuHuyDangKyCoTenNhanVien";
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

        public DataTable LayDanhSachHuyDangKyTheoMa(int ma)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuNgungDangKyDichVu_LayDanhSachTheoMa";
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

        public bool ThemHuyDangKy(HuyDangKyDTO huyDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_HuyDangKy_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", huyDangKyDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", huyDangKyDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", huyDangKyDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@lydo", huyDangKyDTO.LyDo));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", huyDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", huyDangKyDTO.LyDoKhongDuyet));
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

        public bool XoaHuyDangKy(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_HuyDangKy_Xoa";
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

        public bool SuaHuyDangKy(HuyDangKyDTO huyDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_HuyDangKy_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieungungdangkydichvu", huyDangKyDTO.MaPhieuNgungDangKyDichVu));
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", huyDangKyDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", huyDangKyDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", huyDangKyDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@lydo", huyDangKyDTO.LyDo));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", huyDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", huyDangKyDTO.LyDoKhongDuyet));

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

        public DataTable TimKiemHuyDangKyTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_HuyDangKy_TimKiemTheoTen";
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

        public bool SuaKiemDuyetPhieunNgungDichVu(HuyDangKyDTO huyDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuNgungDangKyDichVu_SuaKiemDuyet";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieungungdichvu", huyDangKyDTO.MaPhieuNgungDangKyDichVu));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", huyDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", huyDangKyDTO.LyDoKhongDuyet));

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

        public DataTable LayDanhSachHuyDangKyTheoMaPDK(int maphieudangky)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_HuyDangKy_LayDanhSachHuyDangKyTheoMaPDK";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", maphieudangky));
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
