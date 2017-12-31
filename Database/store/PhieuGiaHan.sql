
CREATE PROC sp_PhieuGiaHan_LayDanhSach
AS
	SELECT * FROM PhieuGiaHan
GO


CREATE PROC sp_PhieuGiaHan_LayDanhSachPhieuGiaHanCoTen
AS
	SELECT MaPhieuGiaHan, MaPhieuDangKy,  TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc,  TrangThaiKiemDuyet, TongTien, LyDoKhongDuyet  FROM PhieuGiaHan,  NhanVien WHERE PhieuGiaHan.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_PhieuGiaHan_Them
	@maphieudangky int,
	@manhanvien int,
	@ngaylap date,
	@ngaybatdau date,
	@ngayketthuc date,
	@trangthaikiemduyet int,
	@tongtien money,
	@lydokhongduyet nvarchar(200)
AS
	INSERT INTO PhieuGiaHan VALUES(@maphieudangky, @manhanvien, @ngaylap, @ngaybatdau, @ngayketthuc,  @trangthaikiemduyet, @tongtien, @lydokhongduyet)
GO

CREATE PROC sp_PhieuGiaHan_Xoa
@ma int

AS
	DELETE FROM PhieuGiaHan WHERE MaPhieuGiaHan=@ma
GO

CREATE PROC sp_PhieuGiaHan_Sua
	@maphieugiahan int,
	@maphieudangky int,
	@manhanvien int,
	@ngaylap date,
	@ngaybatdau date,
	@ngayketthuc date,
	@trangthaikiemduyet int,
	@tongtien money,
	@lydokhongduyet nvarchar(200)	
AS
	UPDATE PhieuGiaHan SET MaPhieuDangKy=@maphieudangky, MaNhanVien=@manhanvien, NgayLap = @ngaylap, NgayBatDau = @ngaybatdau, NgayKetThuc = @ngayketthuc,  TrangThaiKiemDuyet = @trangthaikiemduyet, TongTien = @tongtien, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuGiaHan = @maphieugiahan
GO

CREATE PROC sp_PhieuGiaHan_SuaKiemDuyet
	@maphieugiahan int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuGiaHan SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuGiaHan = @maphieugiahan
GO