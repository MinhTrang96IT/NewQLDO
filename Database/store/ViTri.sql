INSERT INTO ViTri VALUES(N'vị trí 1', N'mô tả vị trí 1')

CREATE PROC sp_ViTri_LayDanhSach
AS
	SELECT * FROM ViTri
GO

CREATE PROC sp_ViTri_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO ViTri VALUES(@ten, @mota)
GO

CREATE PROC sp_ViTri_Xoa
@ma int

AS
	DELETE FROM ViTri WHERE MaViTri=@ma
GO

CREATE PROC sp_ViTri_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE ViTri SET TenViTri=@ten, MoTaViTri=@mota WHERE MaViTri=@ma
GO

CREATE PROC sp_ViTri_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM ViTri WHERE TenViTri LIKE '%'+ @ten +'%'
GO