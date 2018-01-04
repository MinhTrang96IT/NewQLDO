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
using QuanLyDiaOc.DTO;

namespace QuanLyDiaOc.GUI
{
    public partial class FormKiemDuyet : Form
    {
        private PhieuDangKyBLL phieuDangKyBLL;
        private PhieuGiaHanBLL phieuGiaHanBLL;
        private HuyDangKyBLL huyDangKyBLL;
        private ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        private BaiVietBLL baiVietBLL;
        private DiaOcBLL diaOcBLL;

        public FormKiemDuyet()
        {
            InitializeComponent();
            phieuDangKyBLL = new PhieuDangKyBLL();
            phieuGiaHanBLL = new PhieuGiaHanBLL();
            huyDangKyBLL = new HuyDangKyBLL();
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
            baiVietBLL = new BaiVietBLL();
            diaOcBLL = new DiaOcBLL();
        }

        private void tabctrKiemDuyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrKiemDuyet.SelectedIndex == 0)
            {
                LoadPhieuDangKy();
            }

            if (tabctrKiemDuyet.SelectedIndex == 1)
            {
                LoadPhieuGiaHan();
            }

            if (tabctrKiemDuyet.SelectedIndex == 2)
            {
                LoadPhieuNgungDV();
            }

            if (tabctrKiemDuyet.SelectedIndex == 3)
            {
                LoadChiTietQuangCao();
            }

            if (tabctrKiemDuyet.SelectedIndex == 4)
            {
                LoadBaiViet();
            }

            if (tabctrKiemDuyet.SelectedIndex == 5)
            {
                LoadDiaOc();
            }
        }

        private void FormKiemDuyet_Load(object sender, EventArgs e)
        {
            LoadPhieuDangKy();
        }

        private void LoadPhieuDangKy()
        {
            dgvPhieuDangKy.DataSource = phieuDangKyBLL.LayDanhSachPhieuPhieuDangKyCoTen();
            dgvPhieuDangKy.Columns["TrangThaiKiemDuyet"].DisplayIndex = 7;
            dgvPhieuDangKy.Columns["LyDoKhongDuyet"].DisplayIndex = 8;
        }

        private void LoadPhieuGiaHan()
        {
            dgvPhieuGiaHan.DataSource = phieuGiaHanBLL.LayDanhSachPhieuPhieuGiaHanCoTen();
            dgvPhieuGiaHan.Columns["TrangThaiKiemDuyetGH"].DisplayIndex = 6;
            dgvPhieuGiaHan.Columns["LyDoKhongDuyetGH"].DisplayIndex = 7;
        }

        private void LoadPhieuNgungDV()
        {
            dgvNgungDichVu.DataSource = huyDangKyBLL.LayDanhSachPhieuHuyDangKyCoTenNhanVien();
            dgvNgungDichVu.Columns["TrangThaiKiemDuyetNDV"].DisplayIndex = 6;
            dgvNgungDichVu.Columns["LyDoKhongDuyetNDV"].DisplayIndex = 7;
        }

        private void LoadChiTietQuangCao()
        {
            dgvChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCao();
        }

        private void LoadBaiViet()
        {
            dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoTenNhanVien();
        }

        private void LoadDiaOc()
        {
            dgvDiaOc.DataSource = diaOcBLL.LayDanhSachDiaOc();
            dgvDiaOc.Columns["TrangThaiKiemDuyetDO"].DisplayIndex = 17;
            dgvDiaOc.Columns["LyDoKhongDuyetDO"].DisplayIndex = 18;
        }

        private void dgvPhieuDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhieuDangKy.Rows[e.RowIndex];
                    int columnIndex = dgvPhieuDangKy.CurrentCell.ColumnIndex;
                    string columnName = dgvPhieuDangKy.Columns[columnIndex].Name;
                    int maPhieuDK = Int32.Parse(row.Cells["MaPhieuDangKy"].Value.ToString());

                    if (columnName.Equals("ChiTiet"))
                    {
                        FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(maPhieuDK);
                        diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                        diaglogChiTietPhieuDangKy.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhan"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyet"].Value.ToString();
                        PhieuDangKyDTO phieuDangKyDTO = new PhieuDangKyDTO(maPhieuDK, trangThai, lyDo);
                        try
                        {
                            if (phieuDangKyBLL.SuaKiemDuyetPhieuDangKy(phieuDangKyDTO))
                            {
                                MessageBox.Show("Sửa trạng thái phiếu đăng ký thành công");
                                LoadPhieuDangKy();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái phiếu đăng ký thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }

        private void dgvPhieuGiaHan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhieuGiaHan.Rows[e.RowIndex];
                    int columnIndex = dgvPhieuGiaHan.CurrentCell.ColumnIndex;
                    string columnName = dgvPhieuGiaHan.Columns[columnIndex].Name;
                    int maPhieuGH = Int32.Parse(row.Cells["MaPhieuGiaHan"].Value.ToString());

                    if (columnName.Equals("ChiTietGH"))
                    {
                        //FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(maPhieuGH);
                        //diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                        //diaglogChiTietPhieuDangKy.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhanGh"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyetGH"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyetGH"].Value.ToString();
                        PhieuGiaHanDTO phieuGiaHanDTO = new PhieuGiaHanDTO(maPhieuGH, trangThai, lyDo);
                        try
                        {
                            if (phieuGiaHanBLL.SuaKiemDuyetPhieuGiaHan(phieuGiaHanDTO))
                            {
                                MessageBox.Show("Sửa trạng thái phiếu gia hạn thành công");
                                LoadPhieuGiaHan();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái phiếu gia hạn thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }

        private void dgvNgungDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvNgungDichVu.Rows[e.RowIndex];
                    int columnIndex = dgvNgungDichVu.CurrentCell.ColumnIndex;
                    string columnName = dgvNgungDichVu.Columns[columnIndex].Name;
                    int maPhieuNDV = Int32.Parse(row.Cells["MaPhieuNgungDangKyDichVu"].Value.ToString());

                    if (columnName.Equals("ChiTietNDV"))
                    {
                        //FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(maPhieuGH);
                        //diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                        //diaglogChiTietPhieuDangKy.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhanNDV"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyetNDV"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyetNDV"].Value.ToString();
                        HuyDangKyDTO huyDangKyDTO = new HuyDangKyDTO(maPhieuNDV, trangThai, lyDo);
                        try
                        {
                            if (huyDangKyBLL.SuaKiemDuyetPhieunNgungDichVu(huyDangKyDTO))
                            {
                                MessageBox.Show("Sửa trạng thái phiếu ngưng dịch vụ thành công");
                                LoadPhieuNgungDV();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái phiếu ngưng dịch vụ thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }

        private void dgvChiTietQuangCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvChiTietQuangCao.Rows[e.RowIndex];
                    int columnIndex = dgvChiTietQuangCao.CurrentCell.ColumnIndex;
                    string columnName = dgvChiTietQuangCao.Columns[columnIndex].Name;
                    int maPhieuCT = Int32.Parse(row.Cells["MaChiTietQuangCao"].Value.ToString());

                    if (columnName.Equals("ChiTietCT"))
                    {
                        //FormChiTietPhieuDangKy diaglogChiTietPhieuDangKy = new FormChiTietPhieuDangKy(maPhieuGH);
                        //diaglogChiTietPhieuDangKy.StartPosition = FormStartPosition.CenterScreen;
                        //diaglogChiTietPhieuDangKy.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhanCT"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyetCT"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyetCT"].Value.ToString();
                        ChiTietQuangCaoDTO chiTietQuangCaoDTO = new ChiTietQuangCaoDTO(maPhieuCT, trangThai, lyDo);
                        try
                        {
                            if (chiTietQuangCaoBLL.SuaKiemDuyetChiTietQuangCao(chiTietQuangCaoDTO))
                            {
                                MessageBox.Show("Sửa trạng thái chi tiết quảng cáo thành công");
                                LoadChiTietQuangCao();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái chi tiết quảng cáo thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }

        private void dgvBaiViet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvBaiViet.Rows[e.RowIndex];
                    int columnIndex = dgvBaiViet.CurrentCell.ColumnIndex;
                    string columnName = dgvBaiViet.Columns[columnIndex].Name;
                    int maBV = Int32.Parse(row.Cells["MaBaiViet"].Value.ToString());

                    if (columnName.Equals("ChiTietBV"))
                    {
                        DialogBaiViet dialogBaiViet = new DialogBaiViet(maBV);
                        dialogBaiViet.StartPosition = FormStartPosition.CenterScreen;
                        dialogBaiViet.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhanBV"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyetBV"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyetBV"].Value.ToString();
                        BaiVietDTO baiVietDTO = new BaiVietDTO(maBV, trangThai, lyDo);
                        try
                        {
                            if (baiVietBLL.SuaKiemDuyetBaiViet(baiVietDTO))
                            {
                                MessageBox.Show("Sửa trạng thái bài viết thành công");
                                LoadBaiViet();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái bài viết thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }

        private void dgvDiaOc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDiaOc.Rows[e.RowIndex];
                    int columnIndex = dgvDiaOc.CurrentCell.ColumnIndex;
                    string columnName = dgvDiaOc.Columns[columnIndex].Name;
                    int maPhieuDO = Int32.Parse(row.Cells["MaDiaOcDO"].Value.ToString());

                    if (columnName.Equals("ChiTietDO"))
                    {
                        DiaLogDiaOc diaLogDiaOc = new DiaLogDiaOc(maPhieuDO);
                        diaLogDiaOc.StartPosition = FormStartPosition.CenterScreen;
                        diaLogDiaOc.ShowDialog(this);
                    }

                    if (columnName.Equals("XacNhanDO"))
                    {
                        int trangThai = 0;
                        if (row.Cells["TrangThaiKiemDuyetDO"].Value.ToString().Equals("1"))
                            trangThai = 1;
                        string lyDo = "";
                        if (trangThai == 0)
                            lyDo = row.Cells["LyDoKhongDuyetDO"].Value.ToString();
                        DiaOcDTO diaOcDTO = new DiaOcDTO(maPhieuDO, trangThai, lyDo);
                        try
                        {
                            if (diaOcBLL.SuaKiemDuyetDiaOc(diaOcDTO))
                            {
                                MessageBox.Show("Sửa trạng thái địa ốc thành công");
                                LoadDiaOc();
                            }
                            else
                            {
                                MessageBox.Show("Sửa trạng thái địa ốc thất bại");
                            }
                        }
                        catch
                        {
                        }
                    }

                }
                catch { }
            }
        }
    }
}
