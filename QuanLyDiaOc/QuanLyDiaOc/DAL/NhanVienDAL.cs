using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
                string store = "sp_NguoiDung_KiemTraDangNhap";
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
    }
}
