
CREATE PROC sp_QuyenHan_LayDanhSach
AS
	SELECT * FROM QuyenHan
GO

CREATE PROC sp_QuyenHan_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO QuyenHan VALUES(@ten, @mota)
GO

CREATE PROC sp_QuyenHan_Xoa
@ma int

AS
	DELETE FROM QuyenHan WHERE MaQuyenHan=@ma
GO

CREATE PROC sp_QuyenHan_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE QuyenHan SET TenQuyenHan=@ten, MoTaQuyenHan=@mota WHERE MaQuyenHan=@ma
GO

CREATE PROC sp_QuyenHan_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM QuyenHan WHERE TenQuyenHan LIKE '%'+ @ten +'%'
GO