﻿using QuanLyDiaOc.BLL;
using System;
using QuanLyDiaOc.DTO;
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
    public partial class FormBaiViet : Form
    {
        private int MaChiTietQuangCaoPoup = 0;
        BaiVietBLL baiVietBLL;
        NhanVienBLL nhanVienBLL;
       ChiTietQuangCaoBLL chiTietQuangCaoBLL;
        string id;

        public FormBaiViet()
        {
            InitializeComponent();
            id = "";
            baiVietBLL = new BaiVietBLL();
            nhanVienBLL = new NhanVienBLL();
            chiTietQuangCaoBLL = new ChiTietQuangCaoBLL();
        }

        public FormBaiViet(int maChiTietQuangCao) : this()
        {
            MaChiTietQuangCaoPoup = maChiTietQuangCao;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LamMoiThongTin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin bài viết");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    BaiVietDTO baiVietDTO = new BaiVietDTO(
                                   Int32.Parse(cbChiTietQuangCao.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   txtNoiDungBaiViet.Text.ToString(),
                                   trangThaiKiemDuyet,"");

                    try
                    {
                        if (baiVietBLL.ThemBaiViet(baiVietDTO))
                        {
                            MessageBox.Show("Thêm bài viết thành công");
                            if(MaChiTietQuangCaoPoup == 0)
                            {
                                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoTenNhanVien();
                            } else
                            {
                                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoMaChiTietQuangCao(MaChiTietQuangCaoPoup);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm bài viết thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Làm ơn chọn bài viết muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thông tin bài viết số " + id, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (baiVietBLL.XoaBaiViet(Int32.Parse(id)))
                    {
                        MessageBox.Show("Xóa khách bài viết thành công");
                        if (MaChiTietQuangCaoPoup == 0)
                        {
                            dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoTenNhanVien();
                        }
                        else
                        {
                            dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoMaChiTietQuangCao(MaChiTietQuangCaoPoup);
                        }
                        LamMoiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bài viết thất bại");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTrong())
            {
                MessageBox.Show("Làm ơn điền đầy đủ thông tin bài viết");
            }
            else
            {
                if (KiemTraThongTinHopLe())
                {
                    int trangThaiKiemDuyet = 0;
                    if (rbDaKiemDuyet.Checked)
                        trangThaiKiemDuyet = 1;

                    BaiVietDTO baiVietDTO = new BaiVietDTO(
                                   Int32.Parse(txtMaBaiViet.Text.ToString()),
                                   Int32.Parse(cbChiTietQuangCao.SelectedValue.ToString()),
                                   Int32.Parse(cbNhanVien.SelectedValue.ToString()),
                                   txtNoiDungBaiViet.Text.ToString(),
                                   trangThaiKiemDuyet, "");

                    try
                    {
                        if (baiVietBLL.SuaBaiViet(baiVietDTO))
                        {
                            MessageBox.Show("Sửa bài viết thành công");
                            if (MaChiTietQuangCaoPoup == 0)
                            {
                                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoTenNhanVien();
                            }
                            else
                            {
                                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoMaChiTietQuangCao(MaChiTietQuangCaoPoup);
                            }
                            LamMoiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Sửa bài viết thất bại");
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void AnButton()
        {
            btnTaoMoi.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FormBaiViet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count; i++)
            {
                if (Chung.LayDSQuyenHan(Chung.loaiNhanVien)[i].Contains("Chỉnh sửa"))
                    break;
                if (i == Chung.LayDSQuyenHan(Chung.loaiNhanVien).Count - 1)
                    AnButton();
            }
            if (MaChiTietQuangCaoPoup == 0)
            {
                txtMaChiTietQuangCao.Visible = false;
                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoTenNhanVien();
            } else
            {
                cbChiTietQuangCao.Visible = false;
                btnThemChiTietQuangCao.Visible = false;
                txtMaChiTietQuangCao.Text = MaChiTietQuangCaoPoup.ToString();
                dgvBaiViet.DataSource = baiVietBLL.LayDanhSachBaiVietTheoMaChiTietQuangCao(MaChiTietQuangCaoPoup);
            }
            cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "MaNhanVien";
            cbChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCao();
            cbChiTietQuangCao.DisplayMember = "MaChiTietQuangCao";
            cbChiTietQuangCao.ValueMember = "MaChiTietQuangCao"; 
            LamMoiThongTin();
        }

        private void LamMoiThongTin()
        {
            txtMaBaiViet.Text = cbChiTietQuangCao.Text = cbNhanVien.Text = txtNoiDungBaiViet.Text = "";
            rbChuaKiemDuyet.Checked = true;
            rbDaKiemDuyet.Checked = false;
            txtNoiDungBaiViet.Focus();
            cbNhanVien.SelectedIndex = 0;
        //    cbChiTietQuangCao.SelectedIndex = 0;
            id = "";
        }

        private bool KiemTraThongTinTrong()
        {
            if (txtNoiDungBaiViet.Text.ToString() == "" )
            {
                return true;
            }
            return false;
        }

        private bool KiemTraThongTinHopLe()
        {

            if (!KiemTraSoKyTuNhapVao(4000, txtNoiDungBaiViet.Text))
            {
                MessageBox.Show("Chỉ được nhập tối đa 4000 ký tự");
                return false;
            }
            return true;
        }

        private bool KiemTraSoKyTuNhapVao(int max, string str)
        {
            if (str.Length <= max)
                return true;
            return false;
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != 127)
            {
                MessageBox.Show("Chỉ nhập số tại đây");
                e.Handled = true;
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien diaglogNhanVien = new FormNhanVien();
            diaglogNhanVien.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogNhanVien.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbNhanVien.DataSource = nhanVienBLL.LayDanhSachNhanVien();
            }
        }

        private void btnThemChiTietQuangCao_Click(object sender, EventArgs e)
        {
            FormChiTietQuangCao diaglogChiTietQuangCao = new FormChiTietQuangCao();
            diaglogChiTietQuangCao.StartPosition = FormStartPosition.CenterScreen;
            if (diaglogChiTietQuangCao.ShowDialog(this) == DialogResult.Yes) { }
            else
            {
                cbChiTietQuangCao.DataSource = chiTietQuangCaoBLL.LayDanhSachChiTietQuangCao();
            } 
        }

        private void dgvBaiViet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvBaiViet.Rows[e.RowIndex];
                    txtMaBaiViet.Text = row.Cells["MaBaiViet"].Value.ToString();
                    id = row.Cells["MaBaiViet"].Value.ToString();
                    cbNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                 //   cbChiTietQuangCao.Text = row.Cells["ChiTietQuangCao"].Value.ToString();
                    txtNoiDungBaiViet.Text = row.Cells["NoiDungBaiViet"].Value.ToString();

                    if (row.Cells["TrangThaiKiemDuyet"].Value.ToString().Equals("1"))
                        rbDaKiemDuyet.Checked = true;
                    else
                        rbChuaKiemDuyet.Checked = true;

                }
                catch { }
            }
        }
    }
}
