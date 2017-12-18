INSERT INTO LoaiNhanVien VALUES(N'Nhân viên văn phòng', N'Ngồi chơi hoy')

CREATE PROC sp_LoaiNhanVien_LayDanhSach
AS
	SELECT * FROM LoaiNhanVien
GO

CREATE PROC sp_LoaiNhanVien_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO LoaiNhanVien VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiNhanVien_Xoa
@ma int

AS
	DELETE FROM LoaiNhanVien WHERE MaLoaiNhanVien=@ma
GO

CREATE PROC sp_LoaiNhanVien_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE LoaiNhanVien SET TenLoaiNhanVien=@ten, MoTaLoaiNhanVien=@mota WHERE MaLoaiNhanVien=@ma
GO

CREATE PROC sp_LoaiNhanVien_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM LoaiNhanVien WHERE TenLoaiNhanVien LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_LoaiNhanVien_LayLoaiNhanVien
@ma int

AS
	SELECT TenLoaiNhanVien FROM LoaiNhanVien WHERE MaLoaiNhanVien=@ma
GO