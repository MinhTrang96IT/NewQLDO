using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiaOc.BLL;

namespace QuanLyDiaOc.GUI
{
    public partial class FormQuyDinh : Form
    {
        private QuyDinhBLL quyDinhBLL;
        public FormQuyDinh()
        {
            InitializeComponent();
            quyDinhBLL = new QuyDinhBLL();
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            try
            {
                if (quyDinhBLL.CapNhatPhieuThu((float)numUDLaiSuat.Value, (float)numUDPhanTramHoaDonGiaHan.Value))
                {
                    MessageBox.Show("Thay đổi phiếu thu thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi phiểu thu thất bại");
                }
            }
            catch
            {
            }
        }

        private void btnQuangCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (quyDinhBLL.CapNhatQuangCao((int)numUDSoNgayQuangCao.Value, (int)numUDSoTuBaiViet.Value, (int)numUDThoiGianChupAnh.Value, (float)numUDPhanTramQuangCao.Value))
                {
                    MessageBox.Show("Thay đổi quảng cáo thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi quảng cáo thất bại");
                }
            }
            catch
            {
            }
        }

        private void FormQuyDinh_Load(object sender, EventArgs e)
        {
            // Phiếu thu
            numUDLaiSuat.Value = Convert.ToDecimal(quyDinhBLL.LayLaiSuatTreHanThanhToan());
            numUDPhanTramHoaDonGiaHan.Value = Convert.ToDecimal(quyDinhBLL.LayPhanTramHoaDonGiaHan());

            // Quảng cáo
            numUDSoNgayQuangCao.Value = Convert.ToDecimal(quyDinhBLL.LaySoNgayQuangCaoToiDa());
            numUDSoTuBaiViet.Value = Convert.ToDecimal(quyDinhBLL.LaySoTuToiDa());
            numUDThoiGianChupAnh.Value = Convert.ToDecimal(quyDinhBLL.LayThoiGianChupAnhToiDa());
            numUDPhanTramQuangCao.Value = Convert.ToDecimal(quyDinhBLL.LayPhanTramQuangCaoCoMau());
        }
    }
}