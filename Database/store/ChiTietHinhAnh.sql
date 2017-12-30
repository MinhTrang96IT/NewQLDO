CREATE PROC sp_ChiTietHinhAnh_LayDanhSach
AS
	SELECT * FROM ChiTietHinhAnh
GO

CREATE PROC sp_ChiTietHinhAnh_LayDanhSachTheoMaHA
@maha int

AS
	SELECT * FROM ChiTietHinhAnh WHERE MaHinhAnh=@maha
GO

CREATE PROC sp_ChiTietHinhAnh_Them
@maha int,
@ha varbinary(max),
@mota nvarchar(100)

AS
	INSERT INTO ChiTietHinhAnh VALUES(@maha, Cast(@ha As varbinary(max)), @mota)
GO

CREATE PROC sp_ChiTietHinhAnh_Xoa
@ma int

AS
	DELETE FROM ChiTietHinhAnh WHERE MaChiTietHinhAnh=@ma
GO

CREATE PROC sp_ChiTietHinhAnh_Sua
@mact int,
@maha int,
@ha varbinary(max),
@mota nvarchar(100)

AS
	UPDATE ChiTietHinhAnh SET MaHinhAnh=@maha, HinhAnh=Cast(@ha As varbinary(max)), MoTaHinhAnh=@mota WHERE MaChiTietHinhAnh=@mact
GO