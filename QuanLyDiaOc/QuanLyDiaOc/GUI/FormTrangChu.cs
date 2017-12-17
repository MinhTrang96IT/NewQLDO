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

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        }
    }
}
