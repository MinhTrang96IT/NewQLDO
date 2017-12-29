using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DAL
{
    class ThongKeDAL :KetNoi
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
    }
}
