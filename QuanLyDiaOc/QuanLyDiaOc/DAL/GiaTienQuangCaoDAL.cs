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
    class GiaTienQuangCaoDAL :KetNoi
    {
        public DataTable LayDanhSachGiaTienQuangCao()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiaTienQuangCao_LayDanhSach";
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

        public DataTable LayDanhSachGiaTienQuangCaoTheoTenLoai()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiaTienQuangCao_LayDanhSachTheoTenLoai";
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

        public bool ThemGiaTienQuangCao(GiaTienQuangCaoDTO giaTienQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaTienQuangCao_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maloaiquangcao", giaTienQuangCaoDTO.MaLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mavitri", giaTienQuangCaoDTO.MaViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanhtoithieu", giaTienQuangCaoDTO.SoLuongPhatHanhToiThieu));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanhtoida", giaTienQuangCaoDTO.SoLuongPhatHanhToiDa));
                sqlCommand.Parameters.Add(new SqlParameter("@kichcotoithieu", giaTienQuangCaoDTO.KichCoToiThieu));
                sqlCommand.Parameters.Add(new SqlParameter("@kichcotoida", giaTienQuangCaoDTO.KichCoToiDa));
                sqlCommand.Parameters.Add(new SqlParameter("@dongia", giaTienQuangCaoDTO.DonGia));
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

        public bool XoaGiaTienQuangCao(int ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaTienQuangCao_Xoa";
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

        public bool SuaGiaTienQuangCao(GiaTienQuangCaoDTO giaTienQuangCaoDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaTienQuangCao_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@magiatienquangcao", giaTienQuangCaoDTO.MaGiaTienQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaiquangcao", giaTienQuangCaoDTO.MaLoaiQuangCao));
                sqlCommand.Parameters.Add(new SqlParameter("@mavitri", giaTienQuangCaoDTO.MaViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanhtoithieu", giaTienQuangCaoDTO.SoLuongPhatHanhToiThieu));
                sqlCommand.Parameters.Add(new SqlParameter("@soluongphathanhtoida", giaTienQuangCaoDTO.SoLuongPhatHanhToiDa));
                sqlCommand.Parameters.Add(new SqlParameter("@kichcotoithieu", giaTienQuangCaoDTO.KichCoToiThieu));
                sqlCommand.Parameters.Add(new SqlParameter("@kichcotoida", giaTienQuangCaoDTO.KichCoToiDa));
                sqlCommand.Parameters.Add(new SqlParameter("@dongia", giaTienQuangCaoDTO.DonGia));
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
                string store = "sp_GiaTienQuangCao_TimKiemTheoTen";
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
