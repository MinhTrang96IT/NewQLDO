
CREATE PROC sp_KhachHang_LayDanhSach
AS
	SELECT * FROM KhachHang
GO

CREATE PROC sp_KhachHang_Them
@ten nvarchar(100),
@cmnd nvarchar(15),
@gioitinh bit,
@namsinh smallint,
@diachi nvarchar(200),
@sdt varchar(20),
@email varchar(100)

AS
	INSERT INTO KhachHang VALUES(@ten, @cmnd, @gioitinh, @namsinh, @diachi, @sdt, @email)
GO

CREATE PROC sp_KhachHang_Xoa
@ma int

AS
	DELETE FROM KhachHang WHERE MaKhachHang=@ma
GO

CREATE PROC sp_KhachHang_Sua
@ma int,
@ten nvarchar(100),
@cmnd nvarchar(15),
@gioitinh bit,
@namsinh smallint,
@diachi nvarchar(200),
@sdt varchar(20),
@email varchar(100)

AS
	UPDATE KhachHang SET TenKhachHang=@ten, CMND=@cmnd, GioiTinh=@gioitinh, NamSinh=@namsinh, DiaChi=@diachi, SoDienthoai=@sdt, Email=@email WHERE MaKhachHang=@ma
GO

CREATE PROC sp_KhachHang_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM KhachHang WHERE TenKhachHang LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_KhachHang_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM KhachHang WHERE MaKhachHang=@ma
GO