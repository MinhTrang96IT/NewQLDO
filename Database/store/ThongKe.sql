CREATE PROC sp_ThongKe_DoTuoiKhachHang
AS
	select NamSinh, Count(NamSinh) as SoLuong from KhachHang group by NamSinh
GO

CREATE PROC sp_ThongKe_LayDoanhThu
@THANG int,
@NAM int
AS
SELECT SUM(TongTien) FROM PhieuDangKy WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM
GO

CREATE PROC sp_ThongKe_SoLuongPhieuDangKyTheoLoaiQuangCao
@Nam int
AS
 SELECT TenLoaiQuangCao,ChiTietQuangCao.MaLoaiQuangCao, Count(ChiTietQuangCao.MaLoaiQuangCao) as SoLuong FROM PhieuDangKy, ChiTietQuangCao, LoaiQuangCao WHERE PhieuDangKy.MaPhieuDangKy = ChiTietQuangCao.MaPhieuDangKy AND YEAR(NgayLap) = @Nam and LoaiQuangCao.MaLoaiQuangCao = ChiTietQuangCao.MaLoaiQuangCao group by ChiTietQuangCao.MaLoaiQuangCao, LoaiQuangCao.TenLoaiQuangCao
GO

CREATE PROC sp_ThongKe_LayDoanhthuTheoLoaiQuangCao
@THANG int,
@NAM int,
@maloaiquangcao int
AS
SELECT MaLoaiQuangCao,SUM(TongTien) FROM PhieuDangKy, ChiTietQuangCao WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM AND PhieuDangKy.MaPhieuDangKy = ChiTietQuangCao.MaPhieuDangKy AND ChiTietQuangCao.MaLoaiQuangCao = @maloaiquangcao group by ChiTietQuangCao.MaLoaiQuangCao
GO
