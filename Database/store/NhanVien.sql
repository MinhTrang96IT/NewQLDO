INSERT INTO NhanVien VALUES(1, 1, N'Hoàng Kim Tuấn', '251055042', 1, '07/01/1996', N'Dĩ An, Bình Dương', '0969987548', 'hoangkimtuan1996@gmail.com', 'HoangKimTuan', '123456')

CREATE PROC sp_NhanVien_KiemTraDangNhap
@tk nvarchar(30),
@mk nvarchar(15)

AS
	SELECT MaNhanVien FROM NhanVien WHERE TenDangNhap=@tk AND MatKhau=@mk
GO

CREATE PROC sp_NhanVien_LayTenNhanVien
@tk nvarchar(30)

AS
	SELECT TenNhanVien FROM NhanVien WHERE TenDangNhap=@tk
GO

CREATE PROC sp_NhanVien_LayMaLoaiNhanVien
@tk nvarchar(30)

AS
	SELECT MaLoaiNhanVien FROM NhanVien WHERE TenDangNhap=@tk
GO

CREATE PROC sp_NhanVien_LayDanhSach
AS
	SELECT * FROM NhanVien
GO