
CREATE PROC sp_BaiViet_LayDanhSach
AS
	SELECT * FROM BaiViet
GO

CREATE PROC sp_BaiViet_LayDanhSachTheoTenNhanVien
AS
	SELECT MaBaiViet, MaChiTietQuangCao, TenNhanVien, NoiDungBaiViet, TrangThaiKiemDuyet FROM BaiViet, NhanVien WHERE BaiViet.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_BaiViet_Them
	@machitietquangcao int,				
	@manhanvien int,
	@noidungbaiviet	nvarchar(4000),
	@trangthaikiemduyet	int		
AS
	INSERT INTO BaiViet VALUES( @machitietquangcao, @manhanvien, @noidungbaiviet, @trangthaikiemduyet)
GO

CREATE PROC sp_BaiViet_Xoa
@ma int

AS
	DELETE FROM BaiViet WHERE MaBaiViet=@ma
GO

CREATE PROC sp_BaiViet_Sua
	@mabaiviet int,				
	@machitietquangcao int,				
	@manhanvien int,
	@noidungbaiviet	nvarchar(4000),
	@trangthaikiemduyet	int	
AS
	UPDATE BaiViet SET MaChiTietQuangCao=@machitietquangcao, MaNhanVien=@manhanvien, NoiDungBaiViet=@noidungbaiviet, TrangThaiKiemDuyet=@trangthaikiemduyet WHERE MaBaiViet=@mabaiviet
GO
