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
    class PhieuGiaHanDAL : KetNoi
    {
        public DataTable LayDanhSachPhieuGiaHan()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuGiaHan_LayDanhSach";
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

        public DataTable LayDanhSachPhieuGiaHanCoTen()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuGiaHan_LayDanhSachPhieuGiaHanCoTen";
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

        public DataTable LayDanhSachPhieuGiaHanTheoMaPDK(int maphieudangky)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_PhieuGiaHan_LayDanhSachPhieuGiaHanTheoMaPDK";
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

        public bool ThemPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuGiaHan_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", phieuGiaHanDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", phieuGiaHanDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", phieuGiaHanDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", phieuGiaHanDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", phieuGiaHanDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuGiaHanDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@tongtien", phieuGiaHanDTO.TongTien));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuGiaHanDTO.LyDoKhongDuyet));
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

        public bool XoaPhieuGiaHan(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuGiaHan_Xoa";
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

        public bool SuaPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuGiaHan_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieugiahan", phieuGiaHanDTO.MaPhieuGiaHan));
                sqlCommand.Parameters.Add(new SqlParameter("@maphieudangky", phieuGiaHanDTO.MaPhieuDangKy));
                sqlCommand.Parameters.Add(new SqlParameter("@manhanvien", phieuGiaHanDTO.MaNhanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaylap", phieuGiaHanDTO.NgayLap));
                sqlCommand.Parameters.Add(new SqlParameter("@ngaybatdau", phieuGiaHanDTO.NgayBatDau));
                sqlCommand.Parameters.Add(new SqlParameter("@ngayketthuc", phieuGiaHanDTO.NgayKetThuc));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuGiaHanDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@tongtien", phieuGiaHanDTO.TongTien));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuGiaHanDTO.LyDoKhongDuyet));

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

        public bool SuaKiemDuyetPhieuGiaHan(PhieuGiaHanDTO phieuGiaHanDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_PhieuGiaHan_SuaKiemDuyet";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@maphieugiahan", phieuGiaHanDTO.MaPhieuGiaHan));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", phieuGiaHanDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", phieuGiaHanDTO.LyDoKhongDuyet));

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
