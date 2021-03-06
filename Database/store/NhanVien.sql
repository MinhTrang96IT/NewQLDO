﻿
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

CREATE PROC sp_NhanVien_LayMaNhanVien
@tk nvarchar(30)

AS
	SELECT MaNhanVien FROM NhanVien WHERE TenDangNhap=@tk
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

CREATE PROC sp_NhanVien_LayDanhSachTheoTenLoai
AS
	SELECT MaNhanVien, TenLoaiNhanVien, TenLPhongBan, TenNhanVien, TenBangCap, CMND, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email, TenDangNhap, MatKhau FROM NhanVien, LoaiNhanVien, PhongBan, BangCap WHERE NhanVien.MaLoaiNhanVien = LoaiNhanVien.MaLoaiNhanVien AND NhanVien.MaPhongBan = PhongBan.MaPhongBan AND NhanVien.MaBangCap = BangCap.MaBangCap
GO

CREATE PROC sp_NhanVien_KiemTra
@ten nvarchar(30)

AS
	SELECT * FROM NhanVien WHERE TenDangNhap=@ten
GO

CREATE PROC sp_NhanVien_Them
@maLoaiNV int,
@maPB int,
@mabc int,
@ten nvarchar(50),
@cmnd nvarchar(15),
@gioitinh bit,
@ngaysinh datetime,
@diachi nvarchar(100),
@sdt varchar(20),
@email varchar(100),
@tk varchar(30),
@mk varchar(15)

AS
	INSERT INTO NhanVien VALUES(@maLoaiNV, @maPB, @ten, @cmnd, @gioitinh, @ngaysinh, @diachi, @sdt, @email, @tk, @mk, @mabc)
GO

CREATE PROC sp_NhanVien_Xoa
@ma int

AS
	DELETE FROM NhanVien WHERE MaNhanVien=@ma
GO

CREATE PROC sp_NhanVien_Sua
@maNV int,
@maLoaiNV int,
@maPB int,
@mabc int,
@ten nvarchar(50),
@cmnd nvarchar(15),
@gioitinh bit,
@ngaysinh datetime,
@diachi nvarchar(100),
@sdt varchar(20),
@email varchar(100),
@tk varchar(30),
@mk varchar(15)

AS
	UPDATE NhanVien SET MaLoaiNhanVien=@maLoaiNV, MaPhongBan=@maPB, TenNhanVien=@ten, CMND=@cmnd, GioiTinh=@gioitinh, NgaySinh=@ngaysinh, DiaChi=@diachi, SoDienThoai=@sdt, Email=@email, TenDangNhap=@tk, MatKhau=@mk, MaBangCap=@mabc WHERE MaNhanVien=@maNV
GO

CREATE PROC sp_NhanVien_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM NhanVien WHERE TenNhanVien LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_NhanVien_SuaThongTinTheoMaNhanVien
@manhanvien int,
@tennhanvien nvarchar(50),
@cmnd nvarchar(15),
@diachi nvarchar(100),
@sodienthoai varchar(20),
@email varchar(100),
@matkhau varchar(15)

AS
	UPDATE NhanVien SET TenNhanVien=@tennhanvien, CMND=@cmnd, DiaChi=@diachi, SoDienThoai=@sodienthoai, Email=@email, MatKhau=@matkhau WHERE MaNhanVien=@manhanvien
GO

CREATE PROC sp_NhanVien_LayThongTinDangNhap
@manhanvien int
AS
	SELECT * FROM NhanVien where MaNhanVien = @manhanvien
GO

CREATE PROC sp_NhanVien_LayDanhSachTheoMa
@ma int

AS
	SELECT MaNhanVien, TenLoaiNhanVien, TenLPhongBan, TenNhanVien, TenBangCap, CMND, GioiTinh, NgaySinh, DiaChi, SoDienThoai, Email, TenDangNhap, MatKhau FROM NhanVien, LoaiNhanVien, PhongBan, BangCap WHERE NhanVien.MaLoaiNhanVien = LoaiNhanVien.MaLoaiNhanVien AND NhanVien.MaPhongBan = PhongBan.MaPhongBan AND NhanVien.MaBangCap = BangCap.MaBangCap AND MaNhanVien=@ma
GO