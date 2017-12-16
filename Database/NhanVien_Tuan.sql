INSERT INTO NhanVien VALUES(N'Hoàng Kim Tuấn', 1, '251055042', '07/01/1996', N'Dĩ An, Bình Dương', 1, 'hoangkimtuan1996@gmail.com', 1, 'HoangKimTuan', '123456')

CREATE PROC sp_NguoiDung_KiemTraDangNhap
@tk nvarchar(30),
@mk nvarchar(15)

AS
	SELECT MaNhanVien FROM NhanVien WHERE TenDangNhap=@tk AND MatKhau=@mk
GO