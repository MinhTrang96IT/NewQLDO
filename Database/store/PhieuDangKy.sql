
CREATE PROC sp_PhieuDangKy_LayDanhSach
AS
	SELECT * FROM PhieuDangKy
GO


CREATE PROC sp_PhieuDangKy_LayDanhSachPhieuDangKyCoTen
AS
	SELECT MaPhieuDangKy, TenKhachHang, MaDiaOc , TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc, SoLanGiaHan, TrangThaiKiemDuyet, TongTien, DaTra,ConNo, LyDoKhongDuyet  FROM PhieuDangKy, KhachHang, NhanVien WHERE PhieuDangKy.MaNhanVien = NhanVien.MaNhanVien AND PhieuDangKy.MaKhachHang = KhachHang.MaKhachHang
GO

CREATE PROC sp_PhieuDangKy_Them
	@makhachhang int,
	@madiaoc int,
	@manhanvien int,
	@ngaylap date,
	@ngaybatdau date,
	@ngayketthuc date,
	@solangiahan int,
	@trangthaikiemduyet int,
	@tongtien money,
	@datra money,
	@conno money,
	@lydokhongduyet nvarchar(200)
AS
	INSERT INTO PhieuDangKy VALUES(@makhachhang, @madiaoc, @manhanvien, @ngaylap, @ngaybatdau, @ngayketthuc, @solangiahan, @trangthaikiemduyet, @tongtien, @datra, @conno, @lydokhongduyet)
GO

CREATE PROC sp_PhieuDangKy_Xoa
@ma int

AS
	DELETE FROM PhieuDangKy WHERE MaPhieuDangKy=@ma
GO

CREATE PROC sp_PhieuDangKy_Sua
	@maphieudangky int,
	@makhachhang int,
	@madiaoc int,
	@manhanvien int,
	@ngaylap date,
	@ngaybatdau date,
	@ngayketthuc date,
	@solangiahan int,
	@trangthaikiemduyet int,
	@tongtien money,
	@datra money,
	@conno money,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuDangKy SET MaKhachHang=@makhachhang, MaDiaOc=@madiaoc, MaNhanVien=@manhanvien, NgayLap = @ngaylap, NgayBatDau = @ngaybatdau, NgayKetThuc = @ngayketthuc, SoLanGiaHan = @solangiahan, TrangThaiKiemDuyet = @trangthaikiemduyet, TongTien = @tongtien, DaTra = @datra, ConNo = @conno, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuDangKy = @maphieudangky
GO
