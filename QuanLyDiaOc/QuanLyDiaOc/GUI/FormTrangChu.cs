using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiaOc.GUI
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();

            tabCtlChinh.ItemSize = new Size(150, 25);
        }

        public string TenNhanVien { get; set; }
        public string LoaiNhanVien { get; set; }

        int btnCloseSize = 16;
        int margin = 3;

        private void tabCtlChinh_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush txt;
            Rectangle tabRect = tabCtlChinh.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.White, tabRect);
                e.DrawFocusRectangle();
                txt = Brushes.Black;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Silver, tabRect);
                txt = Brushes.Gray;
            }
            RectangleF txtLayout = new RectangleF(tabRect.Left + margin, tabRect.Y, tabRect.Width - 2 * margin, tabRect.Height + 2 * margin);
            using(StringFormat strFormat = new StringFormat())
            {
                using (Font strFont = new Font("Segoe UI", 12, FontStyle.Regular))
                {
                    strFormat.Alignment = StringAlignment.Near;
                    strFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(tabCtlChinh.TabPages[e.Index].Text, strFont, txt, txtLayout, strFormat);
                }
                Rectangle rect = tabCtlChinh.GetTabRect(e.Index);
                e.Graphics.DrawImage(QuanLyDiaOc.Properties.Resources.cancel, txtLayout.Right - btnCloseSize - margin - 1, txtLayout.Top + margin + 1);
            }
        }

        private void tabCtlChinh_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabCtlChinh.TabPages.Count; i++)
            {
                Rectangle tabRect = tabCtlChinh.GetTabRect(i);
                RectangleF rect = new RectangleF(tabRect.Left + margin, tabRect.Y + margin, tabRect.Width - 2 * margin, tabRect.Height + 2 * margin);
                if (e.X >= rect.Right - btnCloseSize && e.X <= rect.Right && e.Y >= rect.Top && e.Y <= rect.Top + btnCloseSize)
                {
                    tabCtlChinh.TabPages.RemoveAt(tabCtlChinh.SelectedIndex);
                    return;
                }
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.TopLevel = false;
            formKhachHang.Visible = true;
            formKhachHang.FormBorderStyle = FormBorderStyle.None;
            formKhachHang.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Khách hàng");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formKhachHang);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            lbNguoiDung.Text = "Người dùng: " + TenNhanVien + " - " + LoaiNhanVien;
        }

        private void loạiĐịaỐcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiDiaOc formLoaiDiaOc = new FormLoaiDiaOc();
            formLoaiDiaOc.TopLevel = false;
            formLoaiDiaOc.Visible = true;
            formLoaiDiaOc.FormBorderStyle = FormBorderStyle.None;
            formLoaiDiaOc.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Loại địa ốc");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formLoaiDiaOc);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void loạiNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiNha formLoaiNha = new FormLoaiNha();
            formLoaiNha.TopLevel = false;
            formLoaiNha.Visible = true;
            formLoaiNha.FormBorderStyle = FormBorderStyle.None;
            formLoaiNha.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Loại nhà");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formLoaiNha);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhongBan formPhongBan = new FormPhongBan();
            formPhongBan.TopLevel = false;
            formPhongBan.Visible = true;
            formPhongBan.FormBorderStyle = FormBorderStyle.None;
            formPhongBan.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Phòng ban");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formPhongBan);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void loạiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiNhanVien formLoaiNhanVien = new FormLoaiNhanVien();
            formLoaiNhanVien.TopLevel = false;
            formLoaiNhanVien.Visible = true;
            formLoaiNhanVien.FormBorderStyle = FormBorderStyle.None;
            formLoaiNhanVien.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Loại nhân viên");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formLoaiNhanVien);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void quyềnHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuyenHan formQuyenHan = new FormQuyenHan();
            formQuyenHan.TopLevel = false;
            formQuyenHan.Visible = true;
            formQuyenHan.FormBorderStyle = FormBorderStyle.None;
            formQuyenHan.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Quyền hạn");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formQuyenHan);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void vịTríToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViTri formViTri = new FormViTri();
            formViTri.TopLevel = false;
            formViTri.Visible = true;
            formViTri.FormBorderStyle = FormBorderStyle.None;
            formViTri.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Vị trí");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formViTri);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void loạiQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiQuangCao formLoaiQuangCao = new FormLoaiQuangCao();
            formLoaiQuangCao.TopLevel = false;
            formLoaiQuangCao.Visible = true;
            formLoaiQuangCao.FormBorderStyle = FormBorderStyle.None;
            formLoaiQuangCao.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Loại quảng cáo");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formLoaiQuangCao);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.TopLevel = false;
            formNhanVien.Visible = true;
            formNhanVien.FormBorderStyle = FormBorderStyle.None;
            formNhanVien.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Nhân viên");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formNhanVien);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void địaỐcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDiaOc formDiaOc = new FormDiaOc();
            formDiaOc.TopLevel = false;
            formDiaOc.Visible = true;
            formDiaOc.FormBorderStyle = FormBorderStyle.None;
            formDiaOc.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Địa ốc");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formDiaOc);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuyDinh formQuyDinh = new FormQuyDinh();
            formQuyDinh.TopLevel = false;
            formQuyDinh.Visible = true;
            formQuyDinh.FormBorderStyle = FormBorderStyle.None;
            formQuyDinh.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Quy định");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formQuyDinh);
        }

        private void báoChíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBao formBao = new FormBao();
            formBao.TopLevel = false;
            formBao.Visible = true;
            formBao.FormBorderStyle = FormBorderStyle.None;
            formBao.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Báo chí");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formBao);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void ngưngĐăngKýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHuyDangKy formHuyDangKy = new FormHuyDangKy();
            formHuyDangKy.TopLevel = false;
            formHuyDangKy.Visible = true;
            formHuyDangKy.FormBorderStyle = FormBorderStyle.None;
            formHuyDangKy.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Ngưng đăng ký");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formHuyDangKy);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void giáTiềnQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaTienQC formGiaTienQC = new FormGiaTienQC();
            formGiaTienQC.TopLevel = false;
            formGiaTienQC.Visible = true;
            formGiaTienQC.FormBorderStyle = FormBorderStyle.None;
            formGiaTienQC.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Giá tiền QC");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formGiaTienQC);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void bàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaiViet formBaiViet = new FormBaiViet();
            formBaiViet.TopLevel = false;
            formBaiViet.Visible = true;
            formBaiViet.FormBorderStyle = FormBorderStyle.None;
            formBaiViet.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Bài viết");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formBaiViet);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChinhSuaThongTin diaglogChinhSuaThongTin = new FormChinhSuaThongTin();
            diaglogChinhSuaThongTin.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogChinhSuaThongTin.ShowDialog(this) == DialogResult.Yes) { }
        }

        private void phiếuĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy formPhieuDangKy = new FormPhieuDangKy();
            formPhieuDangKy.TopLevel = false;
            formPhieuDangKy.Visible = true;
            formPhieuDangKy.FormBorderStyle = FormBorderStyle.None;
            formPhieuDangKy.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Phiếu đăng ký");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formPhieuDangKy);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChiTietQuangCao formChiTietQuangCao = new FormChiTietQuangCao();
            formChiTietQuangCao.TopLevel = false;
            formChiTietQuangCao.Visible = true;
            formChiTietQuangCao.FormBorderStyle = FormBorderStyle.None;
            formChiTietQuangCao.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Đăng ký QC");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formChiTietQuangCao);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhanQuyen formPhanQuyen = new FormPhanQuyen();
            formPhanQuyen.TopLevel = false;
            formPhanQuyen.Visible = true;
            formPhanQuyen.FormBorderStyle = FormBorderStyle.None;
            formPhanQuyen.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Phiếu đăng ký");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formPhanQuyen);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }

        private void giaHạnĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuGiaHan formPhieuGiaHan = new FormPhieuGiaHan();
            formPhieuGiaHan.TopLevel = false;
            formPhieuGiaHan.Visible = true;
            formPhieuGiaHan.FormBorderStyle = FormBorderStyle.None;
            formPhieuGiaHan.Dock = DockStyle.Fill;
            tabCtlChinh.TabPages.Add("Phiếu gia hạn");
            tabCtlChinh.TabPages[tabCtlChinh.TabPages.Count - 1].Controls.Add(formPhieuGiaHan);
            tabCtlChinh.SelectedIndex = tabCtlChinh.TabPages.Count - 1;
        }
    }
}
