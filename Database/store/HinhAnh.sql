CREATE PROC sp_HinhAnh_LayDanhSach
AS
	SELECT * FROM HinhAnh
GO

CREATE PROC sp_HinhAnh_LayDanhSachTheoMaPDK
@maphieudangky int
AS	
	Select * from HinhAnh where MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_HinhAnh_Them
@mapdk int,
@manv int,
@ngayhca datetime,
@ngayca datetime

AS
	INSERT INTO HinhAnh VALUES(@mapdk, @mapdk, @ngayhca, @ngayca)
GO

CREATE PROC sp_HinhAnh_Xoa
@ma int

AS
	DELETE FROM HinhAnh WHERE MaHinhAnh=@ma
GO

CREATE PROC sp_HinhAnh_Sua
@maha int,
@mapdk int,
@manv int,
@ngayhca datetime,
@ngayca datetime

AS
	UPDATE HinhAnh SET MaPhieuDangKy=@mapdk, MaNhanVien=@manv, NgayHenChupAnh=@ngayhca, NgayChupAnh=@ngayca WHERE MaHinhAnh=@maha
GO