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
    public partial class DialogChiTietQuangCao : Form
    {
        private ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        private DataRow rowCTQC;

        public DialogChiTietQuangCao()
        {
            InitializeComponent();
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
        }

        public DialogChiTietQuangCao(int maCTQC) : this()
        {
            rowCTQC = chiTietQuangCaoBLL.LayDanhSachCTQCTheoMa(maCTQC).Rows[0];
        }

        private void LoadGBChiTietQC()
        {
            lblMaChiTietQC.Text = rowCTQC["MaChiTietQuangCao"].ToString();
            lblMaPhieuDK.Text = rowCTQC["MaPhieuDangKy"].ToString();
            lblLoaiQuangCao.Text = rowCTQC["TenLoaiQuangCao"].ToString();
            lblViTri.Text = rowCTQC["TenViTri"].ToString();
            lblTenBao.Text = rowCTQC["TenBao"].ToString();
            lblNgayBD.Text = rowCTQC["NgayBatDau"].ToString().Split(' ')[0];
            lblNgayKT.Text = rowCTQC["NgayKetThuc"].ToString().Split(' ')[0];
            lblSoLuongPH.Text = rowCTQC["SoLuongPhatHanh"].ToString();
            lblKichThuoc.Text = rowCTQC["KichThuoc"].ToString();
            if (rowCTQC["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThai.Text = "Đã duyệt";
            else
                lblTrangThai.Text = "Chưa duyệt";
            lblLyDoCTQC.Text = rowCTQC["LyDoKhongDuyet"].ToString();
        }

        private void DialogChiTietQuangCao_Load(object sender, EventArgs e)
        {
            LoadGBChiTietQC();
        }

        private void btnPhieuDK_Click(object sender, EventArgs e)
        {
            FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(Int32.Parse(rowCTQC["MaPhieuDangKy"].ToString()));
            diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
            diaglogChiTietPhieuDangKy.ShowDialog(this);
        }
    }
}
