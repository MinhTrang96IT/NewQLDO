﻿
CREATE PROC sp_HuyDangKy_LayDanhSach
AS
	SELECT * FROM PhieuNgungDangKyDichVu
GO

CREATE PROC sp_HuyDangKy_LayDanhSachPhieuDangKy
AS
	SELECT * FROM PhieuDangKy
GO

CREATE PROC sp_PhieuDangKy_LayDanhSachPhieuHuyDangKyCoTenNhanVien
AS
	SELECT MaPhieuNgungDangKyDichVu, MaPhieuDangKy, TenNhanVien , NgayLap,LyDo, TrangThaiKiemDuyet  FROM PhieuNgungDangKyDichVu, NhanVien WHERE PhieuNgungDangKyDichVu.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_HuyDangKy_Them
	@maphieudangky int,				
	@manhanvien int,				
	@ngaylap date,
	@lydo	nvarchar(500),	
	@trangthaikiemduyet int	
AS
	INSERT INTO PhieuNgungDangKyDichVu VALUES(@maphieudangky, @manhanvien, @ngaylap, @lydo, @trangthaikiemduyet)
GO

CREATE PROC sp_HuyDangKy_Xoa
@ma int

AS
	DELETE FROM PhieuNgungDangKyDichVu WHERE MaPhieuNgungDangKyDichVu=@ma
GO

CREATE PROC sp_HuyDangKy_Sua
	@maphieungungdangkydichvu int,
	@maphieudangky int,				
	@manhanvien int,				
	@ngaylap date,
	@lydo	nvarchar(500),	
	@trangthaikiemduyet int	
AS
	UPDATE PhieuNgungDangKyDichVu SET MaPhieuDangKy=@maphieudangky, MaNhanVien=@manhanvien, NgayLap=@ngaylap, LyDo=@lydo, TrangThaiKiemDuyet=@trangthaikiemduyet WHERE MaPhieuNgungDangKyDichVu = @maphieungungdangkydichvu
GO

CREATE PROC sp_HuyDangKy_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT MaPhieuNgungDangKyDichVu, MaPhieuDangKy, TenNhanVien , NgayLap,LyDo, TrangThaiKiemDuyet  FROM PhieuNgungDangKyDichVu, NhanVien WHERE PhieuNgungDangKyDichVu.MaNhanVien = NhanVien.MaNhanVien AND TenNhanVien LIKE '%'+ @ten +'%'
GO