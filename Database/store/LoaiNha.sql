INSERT INTO LoaiNha VALUES(N'Nhà đẹp đây', N'Nhà của tớ đẹp lắm á, 1 túp lều tranh 2 trái tim vàng')

CREATE PROC sp_LoaiNha_LayDanhSach
AS
	SELECT * FROM LoaiNha
GO

CREATE PROC sp_LoaiNha_Them
@ten nvarchar(100),
@mota nvarchar(500)
AS
	INSERT INTO LoaiNha VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiNha_Xoa
@ma int

AS
	DELETE FROM LoaiNha WHERE MaLoaiNha=@ma
GO

CREATE PROC sp_LoaiNha_Sua
@ma int,
@ten nvarchar(100),
@mota nvarchar(500)

AS
	UPDATE LoaiNha SET TenLoaiNha=@ten, MoTa=@mota WHERE MaLoaiNha=@ma
GO

CREATE PROC sp_LoaiNha_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM LoaiNha WHERE TenLoaiNha LIKE '%'+ @ten +'%'
GO