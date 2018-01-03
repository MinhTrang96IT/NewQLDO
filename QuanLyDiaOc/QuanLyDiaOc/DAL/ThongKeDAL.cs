using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class ThongKeDAL : KetNoi
    {
        public DataTable ThongKeKhachHangTheoNamSinh()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ThongKe_DoTuoiKhachHang";
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

        public DataTable ThongKeLoaiQuangCaoTheoNam(int nam)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_ThongKe_SoLuongPhieuDangKyTheoLoaiQuangCao";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@Nam", nam));
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

        public double LayDoanhThuTheoThang(int thang, int nam)
        {
            try
            {
                OpenConnect();
                const string store = "sp_ThongKe_LayDoanhThu";
                sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
                sqlCommand.Parameters.Add(new SqlParameter("@THANG", thang));
                sqlCommand.Parameters.Add(new SqlParameter("@NAM", nam));
                var reader = sqlCommand.ExecuteReader();

                double tien = 0.0;
                while (reader.Read())
                {
                    tien = double.Parse(reader[0].ToString());
                }
                CloseConnect();
                return tien;
            }
            catch
            {
                return 0;
            }
            finally
            {
                CloseConnect();
            }
        }

        public double LayDoanhThuTheoLoaiQuangCao(int thang, int nam, int maloaiquangcao)
        {
            try
            {
                OpenConnect();
                const string store = "sp_ThongKe_LayDoanhthuTheoLoaiQuangCao";
                sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
                sqlCommand.Parameters.Add(new SqlParameter("@THANG", thang));
                sqlCommand.Parameters.Add(new SqlParameter("@NAM", nam));
                sqlCommand.Parameters.Add(new SqlParameter("@maloaiquangcao", maloaiquangcao));
                var reader = sqlCommand.ExecuteReader();

                double tien = 0.0;
                while (reader.Read())
                {
                    tien = double.Parse(reader[1].ToString());
                }
                CloseConnect();
                return tien;
            }
            catch
            {
                return 0;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
