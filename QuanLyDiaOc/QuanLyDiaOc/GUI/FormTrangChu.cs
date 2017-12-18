﻿using System;
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
    }
}
