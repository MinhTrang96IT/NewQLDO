INSERT INTO NhanVien VALUES(N'Hoàng Kim Tuấn', 1, '251055042', '07/01/1996', N'Dĩ An, Bình Dương', 1, 'hoangkimtuan1996@gmail.com', 1, 'HoangKimTuan', '123456')
INSERT INTO LoaiNhanVien VALUES(N'Nhân viên quảng cáo', N'Thêm Xóa Sửa')

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

CREATE PROC sp_LoaiNhanVien_LayLoaiNhanVien
@ma int

AS
	SELECT TenLoaiNhanVien FROM LoaiNhanVien WHERE MaLoaiNhanVien=@ma
GO

CREATE PROC sp_NhanVien_LayMaLoaiNhanVien
@tk nvarchar(30)

AS
	SELECT MaLoaiNhanVien FROM NhanVien WHERE TenDangNhap=@tk
GO