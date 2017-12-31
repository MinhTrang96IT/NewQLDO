
CREATE PROC sp_BaiViet_LayDanhSach
AS
	SELECT * FROM BaiViet
GO

CREATE PROC sp_BaiViet_LayDanhSachTheoTenNhanVien
AS
	SELECT MaBaiViet, MaChiTietQuangCao, TenNhanVien, NoiDungBaiViet, TrangThaiKiemDuyet, LyDoKhongDuyet FROM BaiViet, NhanVien WHERE BaiViet.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_BaiViet_Them
	@machitietquangcao int,				
	@manhanvien int,
	@noidungbaiviet	nvarchar(4000),
	@trangthaikiemduyet	int,
	@lydokhongduyet nvarchar(200)		
AS
	INSERT INTO BaiViet VALUES( @machitietquangcao, @manhanvien, @noidungbaiviet, @trangthaikiemduyet, @lydokhongduyet)
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
	@trangthaikiemduyet	int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE BaiViet SET MaChiTietQuangCao=@machitietquangcao, MaNhanVien=@manhanvien, NoiDungBaiViet=@noidungbaiviet, TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaBaiViet=@mabaiviet
GO
