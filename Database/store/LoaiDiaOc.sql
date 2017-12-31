
CREATE PROC sp_LoaiDiaOc_LayDanhSach
AS
	SELECT * FROM LoaiDiaOc
GO

CREATE PROC sp_LoaiDiaOc_Them
@ten nvarchar(100),
@mota nvarchar(500)
AS
	INSERT INTO LoaiDiaOc VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiDiaOc_Xoa
@ma int

AS
	DELETE FROM LoaiDiaOc WHERE MaLoaiDiaOc=@ma
GO

CREATE PROC sp_LoaiDiaOc_Sua
@ma int,
@ten nvarchar(100),
@mota nvarchar(500)

AS
	UPDATE LoaiDiaOc SET TenLoaiDiaOc=@ten, MoTa=@mota WHERE MaLoaiDiaOc=@ma
GO

CREATE PROC sp_LoaiDiaOc_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM LoaiDiaOc WHERE TenLoaiDiaOc LIKE '%'+ @ten +'%'
GO