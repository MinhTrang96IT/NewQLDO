INSERT INTO PhongBan VALUES(N'Phòng hành chính', N'phòng này để xử lý giấy tờ')

CREATE PROC sp_PhongBan_LayDanhSach
AS
	SELECT * FROM PhongBan
GO

CREATE PROC sp_PhongBan_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO PhongBan VALUES(@ten, @mota)
GO

CREATE PROC sp_PhongBan_Xoa
@ma int

AS
	DELETE FROM PhongBan WHERE MaPhongBan=@ma
GO

CREATE PROC sp_PhongBan_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE PhongBan SET TenLPhongBan=@ten, MoTaPhongBan=@mota WHERE MaPhongBan=@ma
GO

CREATE PROC sp_PhongBan_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM PhongBan WHERE TenLPhongBan LIKE '%'+ @ten +'%'
GO