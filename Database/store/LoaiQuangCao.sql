
CREATE PROC sp_LoaiQuangCao_LayDanhSach
AS
	SELECT * FROM LoaiQuangCao
GO

CREATE PROC sp_LoaiQuangCao_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO LoaiQuangCao VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiQuangCao_Xoa
@ma int

AS
	DELETE FROM LoaiQuangCao WHERE MaLoaiQuangCao=@ma
GO

CREATE PROC sp_LoaiQuangCao_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE LoaiQuangCao SET TenLoaiQuangCao=@ten, MoTaLoaiQuangCao=@mota WHERE MaLoaiQuangCao=@ma
GO

CREATE PROC sp_LoaiQuangCao_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM LoaiQuangCao WHERE TenLoaiQuangCao LIKE '%'+ @ten +'%'
GO