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
    class PhieuDangKyDAL : KetNoi
    {
        public DataTable LayDanhSachPhieuDangKy()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuDangKy_LayDanhSach";
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

        public DataTable LayDanhSachPhieuDangKyCoTen()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuDangKy_LayDanhSachPhieuDangKyCoTen";
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

        public DataTable LayDanhSachPhieuDangKyTheoMa(int ma)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuDangKy_LayDanhSachTheoMa";
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

        public bool ThemPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuDangKy_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makhachhang", phieuDangKyDTO.MaKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@madiaoc", phieuDangKyDTO.MaDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", phieuDangKyDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", phieuDangKyDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", phieuDangKyDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", phieuDangKyDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@solangiahan", phieuDangKyDTO.SoLanGiaHan));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@tongtien", phieuDangKyDTO.TongTien));
                sqlCommand.Parameters.Add(new SqlParameter("@datra", phieuDangKyDTO.DaTra));
                sqlCommand.Parameters.Add(new SqlParameter("@conno", phieuDangKyDTO.ConNo));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuDangKyDTO.LyDoKhongDuyet));
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

        public bool XoaPhieuDangKy(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuDangKy_Xoa";
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

        public bool SuaPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuDangKy_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", phieuDangKyDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@makhachhang", phieuDangKyDTO.MaKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@madiaoc", phieuDangKyDTO.MaDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", phieuDangKyDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", phieuDangKyDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", phieuDangKyDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", phieuDangKyDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@solangiahan", phieuDangKyDTO.SoLanGiaHan));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@tongtien", phieuDangKyDTO.TongTien));
                sqlCommand.Parameters.Add(new SqlParameter("@datra", phieuDangKyDTO.DaTra));
                sqlCommand.Parameters.Add(new SqlParameter("@conno", phieuDangKyDTO.ConNo));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuDangKyDTO.LyDoKhongDuyet));

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

        public bool SuaKiemDuyetPhieuDangKy(PhieuDangKyDTO phieuDangKyDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuDangKy_SuaKiemDuyet";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", phieuDangKyDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuDangKyDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuDangKyDTO.LyDoKhongDuyet));

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
