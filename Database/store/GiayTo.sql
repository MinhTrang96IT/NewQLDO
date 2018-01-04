CREATE PROC sp_GiayTo_LayDanhSach
AS
	SELECT * FROM GiayTo
GO

CREATE PROC sp_GiayTo_LayDanhSachTheoMaDO
@mado int

AS
	SELECT * FROM GiayTo WHERE MaDiaOc=@mado
GO

CREATE PROC sp_GiayTo_Them
@mado int,
@ha varbinary(max),
@ten nvarchar(100)

AS
	INSERT INTO GiayTo VALUES(@mado, @ten, Cast(@ha As varbinary(max)))
GO

CREATE PROC sp_GiayTo_Xoa
@ma int

AS
	DELETE FROM GiayTo WHERE MaGiayTo=@ma
GO

CREATE PROC sp_GiayTo_Sua
@magt int,
@mado int,
@ha varbinary(max),
@ten nvarchar(100)

AS
	UPDATE GiayTo SET MaDiaOc=@mado, ScanGiayTo=Cast(@ha As varbinary(max)), TenGiayTo=@ten WHERE MaGiayTo=@magt
GO