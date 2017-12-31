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
    class DiaOcDAL : KetNoi
    {
        public DataTable LayDanhSachDiaOc()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DiaOc_LayDanhSach";
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

        public DataTable LayDanhSachDiaOcTheoTenLoai()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DiaOc_LayDanhSachTheoTenLoai";
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

        public bool ThemDiaOc(DiaOcDTO diaOcDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makhachhang", diaOcDTO.MaKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaidiaoc", diaOcDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@maloainha", diaOcDTO.MaLoaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", diaOcDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dientichkhuonvien", diaOcDTO.DienTichKhuonVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dientichsudung", diaOcDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@huongnha", diaOcDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@chieudaidat", diaOcDTO.ChieuDaiDat));
                sqlCommand.Parameters.Add(new SqlParameter("@chieurongdat", diaOcDTO.ChieuRongDat));
                sqlCommand.Parameters.Add(new SqlParameter("@chieudainha", diaOcDTO.ChieuDaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@chieurongnha", diaOcDTO.ChieuRongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@sotang", diaOcDTO.SoTang));
                sqlCommand.Parameters.Add(new SqlParameter("@motachitiet", diaOcDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", diaOcDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", diaOcDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaimuaban", diaOcDTO.TrangThaiMuaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", diaOcDTO.LyDoKhongDuyet));
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

        public bool XoaDiaOc(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Xoa";
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

        public bool SuaDiaOc(DiaOcDTO diaOcDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@madiaoc", diaOcDTO.MaDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@makhachhang", diaOcDTO.MaKhachHang));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaidiaoc", diaOcDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@maloainha", diaOcDTO.MaLoaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", diaOcDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dientichkhuonvien", diaOcDTO.DienTichKhuonVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dientichsudung", diaOcDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@huongnha", diaOcDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@chieudaidat", diaOcDTO.ChieuDaiDat));
                sqlCommand.Parameters.Add(new SqlParameter("@chieurongdat", diaOcDTO.ChieuRongDat));
                sqlCommand.Parameters.Add(new SqlParameter("@chieudainha", diaOcDTO.ChieuDaiNha));
                sqlCommand.Parameters.Add(new SqlParameter("@chieurongnha", diaOcDTO.ChieuRongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@sotang", diaOcDTO.SoTang));
                sqlCommand.Parameters.Add(new SqlParameter("@motachitiet", diaOcDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", diaOcDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaikiemduyet", diaOcDTO.TrangThaiKiemDuyet));
                sqlCommand.Parameters.Add(new SqlParameter("@trangthaimuaban", diaOcDTO.TrangThaiMuaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@lydokhongduyet", diaOcDTO.LyDoKhongDuyet));
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
                string store = "sp_DiaOc_TimKiemTheoTen";
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
