CREATE PROC sp_ThongKe_DoTuoiKhachHang
AS
	select NamSinh, Count(NamSinh) as SoLuong from KhachHang group by NamSinh
GO