using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyDiaOc.DTO;

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

        public int LayMaNhanVien(string tk)
        {
            int s = 0;
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayMaNhanVien";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tk", tk));
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = Int32.Parse( reader["MaNhanVien"].ToString());
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

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayDanhSach";
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

        public DataTable LayDanhSachNhanVienTheoTenLoai()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayDanhSachTheoTenLoai";
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

        public bool ThemNhanVien(NhanVienDTO nhanVienDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_NhanVien_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maLoaiNV", nhanVienDTO.MaLoaiNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@maPB", nhanVienDTO.MaPhongBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", nhanVienDTO.TenNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@cmnd", nhanVienDTO.CMND));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", nhanVienDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", nhanVienDTO.NgaySinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", nhanVienDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", nhanVienDTO.SoDienThoai));
                sqlCommand.Parameters.Add(new SqlParameter("@email", nhanVienDTO.Email));
                sqlCommand.Parameters.Add(new SqlParameter("@tk", nhanVienDTO.TenDangNhap));
                sqlCommand.Parameters.Add(new SqlParameter("@mk", nhanVienDTO.MatKhau));
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

        public bool XoaNhanVien(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_NhanVien_Xoa";
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

        public bool SuaNhanVien(NhanVienDTO nhanVienDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_NhanVien_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maNV", nhanVienDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@maLoaiNV", nhanVienDTO.MaLoaiNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@maPB", nhanVienDTO.MaPhongBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", nhanVienDTO.TenNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@cmnd", nhanVienDTO.CMND));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", nhanVienDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaysinh", nhanVienDTO.NgaySinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", nhanVienDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", nhanVienDTO.SoDienThoai));
                sqlCommand.Parameters.Add(new SqlParameter("@email", nhanVienDTO.Email));
                sqlCommand.Parameters.Add(new SqlParameter("@tk", nhanVienDTO.TenDangNhap));
                sqlCommand.Parameters.Add(new SqlParameter("@mk", nhanVienDTO.MatKhau));
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

        public DataTable TimKiemNVTheoTen(string ten)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_TimKiemTheoTen";
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

        public bool SuaThongTinTheoMaNhanVien(NhanVienDTO nhanVienDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_NhanVien_SuaThongTinTheoMaNhanVien";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", nhanVienDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@tennhanvien", nhanVienDTO.TenNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@cmnd", nhanVienDTO.CMND));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", nhanVienDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sodienthoai", nhanVienDTO.SoDienThoai));
                sqlCommand.Parameters.Add(new SqlParameter("@email", nhanVienDTO.Email));
                sqlCommand.Parameters.Add(new SqlParameter("@matkhau", nhanVienDTO.MatKhau));
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

        public DataTable LayThongTinDangNhap(int maNhanVien)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NhanVien_LayThongTinDangNhap";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", maNhanVien));
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
