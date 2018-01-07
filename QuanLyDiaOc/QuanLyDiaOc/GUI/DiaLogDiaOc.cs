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
    public partial class DiaLogDiaOc : Form
    {
        private KhachHangBLL khachHangBLL;
        private DiaOcBLL diaOcBLL;
        private DataRow rowKH, rowDO;

        public DiaLogDiaOc()
        {
            InitializeComponent();
            diaOcBLL = new DiaOcBLL();
            khachHangBLL = new KhachHangBLL();
        }

        public DiaLogDiaOc(int maDO) : this()
        {
            rowDO = diaOcBLL.LayDanhSachDiaOcTheoMa2(maDO).Rows[0];
            rowKH = khachHangBLL.LayDanhSachKhachHangTheoMa(Int32.Parse(rowDO["MaKhachHang"].ToString())).Rows[0];
        }

        private void LoadGBDiaOc()
        {
            lblMaDO.Text = rowDO["MaDiaOc"].ToString();
            lblMaKHDO.Text = rowDO["MaKhachHang"].ToString();
            lblTenLoaiDiaOc.Text = rowDO["TenLoaiDiaOc"].ToString();
            lblTenLoaiNha.Text = rowDO["TenLoaiNha"].ToString();
            lblDiaChiDO.Text = rowDO["DiaChi"].ToString();
            lblDTKV.Text = rowDO["DienTichKhuonVien"].ToString();
            lblDTSD.Text = rowDO["DienTichSuDung"].ToString();
            lblHuongNha.Text = rowDO["HuongNha"].ToString();
            lblChieuDaiNha.Text = rowDO["ChieuDaiDat"].ToString();
            lblChieuRongNha.Text = rowDO["ChieuRongDat"].ToString();
            lblChieuDaiDat.Text = rowDO["ChieuDaiNha"].ToString();
            lblChieuRongDat.Text = rowDO["ChieuRongNha"].ToString();
            lblSoTang.Text = rowDO["SoTang"].ToString();
            lblMoTaChiTiet.Text = rowDO["MoTaChiTiet"].ToString();
            lblGiaBan.Text = rowDO["GiaBan"].ToString();
            if (rowDO["TrangThaiKiemDuyet"].ToString().Equals("1"))
                lblTrangThaiKiemDuyet.Text = "Đã duyệt";
            else
                lblTrangThaiKiemDuyet.Text = "Chưa duyệt";
            if (rowDO["TrangThaiMuaBan"].ToString().Equals("True"))
                lblTrangThaiMuaBan.Text = "Đã mua";
            else
                lblTrangThaiMuaBan.Text = "Chưa mua";
            lblLyDoDO.Text = rowDO["LyDoKhongDuyet"].ToString();
        }

        private void LoadGBKhachHang()
        {
            lblMaKH.Text = rowKH["MaKhachHang"].ToString();
            lblTenKHang.Text = rowKH["TenKhachHang"].ToString();
            lblCMNDKH.Text = rowKH["CMND"].ToString();
            if (rowKH["GioiTinh"].ToString().Equals("True"))
                lblGTKH.Text = "Nam";
            else
                lblGTKH.Text = "Nữ";
            lblNamSinhKH.Text = rowKH["NamSinh"].ToString();
            lblDiaChiKH.Text = rowKH["DiaChi"].ToString();
            lblEmailKH.Text = rowKH["Email"].ToString();
            lblSDTKH.Text = rowKH["SoDienthoai"].ToString();
        }

        private void DiaLogDiaOc_Load(object sender, EventArgs e)
        {
            LoadGBDiaOc();
            LoadGBKhachHang();
        }
    }
}
