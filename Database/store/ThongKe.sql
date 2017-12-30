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
