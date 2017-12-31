
CREATE PROC sp_Bao_LayDanhSach
AS
	SELECT * FROM Bao
GO

CREATE PROC sp_Bao_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO Bao VALUES(@ten, @mota)
GO

CREATE PROC sp_Bao_Xoa
@ma int

AS
	DELETE FROM Bao WHERE MaBao=@ma
GO

CREATE PROC sp_Bao_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE Bao SET TenBao=@ten, MoTaBao=@mota WHERE MaBao=@ma
GO

CREATE PROC sp_Bao_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM Bao WHERE TenBao LIKE '%'+ @ten +'%'
GO