
CREATE PROC sp_PhieuDangKy_LayDanhSach
AS
	SELECT * FROM PhieuDangKy
GO


CREATE PROC sp_PhieuDangKy_LayDanhSachPhieuDangKyCoTen
AS
	SELECT MaPhieuDangKy, TenKhachHang, MaDiaOc , TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc, SoLanGiaHan, TrangThaiKiemDuyet, TongTien, LyDoKhongDuyet  FROM PhieuDangKy, KhachHang, NhanVien WHERE PhieuDangKy.MaNhanVien = NhanVien.MaNhanVien AND PhieuDangKy.MaKhachHang = KhachHang.MaKhachHang
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
	@lydokhongduyet nvarchar(200)
AS
	INSERT INTO PhieuDangKy VALUES(@makhachhang, @madiaoc, @manhanvien, @ngaylap, @ngaybatdau, @ngayketthuc, @solangiahan, @trangthaikiemduyet, @tongtien,@lydokhongduyet)
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
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuDangKy SET MaKhachHang=@makhachhang, MaDiaOc=@madiaoc, MaNhanVien=@manhanvien, NgayLap = @ngaylap, NgayBatDau = @ngaybatdau, NgayKetThuc = @ngayketthuc, SoLanGiaHan = @solangiahan, TrangThaiKiemDuyet = @trangthaikiemduyet, TongTien = @tongtien, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_PhieuDangKy_SuaKiemDuyet
	@maphieudangky int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuDangKy SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_PhieuDangKy_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM PhieuDangKy WHERE MaPhieuDangKy=@ma
GO

CREATE PROC sp_PhieuDangKy_LayDanhSachTheoMaDiaOc
@madiaoc int
AS
	SELECT MaPhieuDangKy, TenKhachHang, MaDiaOc , TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc, SoLanGiaHan, TrangThaiKiemDuyet, TongTien, LyDoKhongDuyet  FROM PhieuDangKy, KhachHang, NhanVien WHERE PhieuDangKy.MaNhanVien = NhanVien.MaNhanVien AND PhieuDangKy.MaKhachHang = KhachHang.MaKhachHang AND MaDiaOc = @madiaoc
Go

CREATE PROC sp_PhieuDangKy_XuatHopDong
@maphieudangky int
AS
	SELECT 
	TenKhachHang, NamSinh, CMND, KhachHang.DiaChi,PhieuDangKy.NgayLap, PhieuDangKy.TongTien,DiaOc.MaDiaOc,CMND, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan
	From KhachHang, PhieuDangKy, DiaOc, LoaiDiaOc, LoaiNha
	where PhieuDangKy.MaPhieuDangKy = @maphieudangky and
	diaoc.MaDiaOc = PhieuDangKy.MaDiaOc and 
	KhachHang.MaKhachHang = PhieuDangKy.MaKhachHang and
	LoaiDiaOc.MaLoaiDiaOc = DiaOc.MaLoaiDiaOc and LoaiNha.MaLoaiNha = DiaOc.MaLoaiNha
Go

CREATE PROC sp_PhieuDangKy_XuatHoaDon
@maphieudangky int
AS
	select PhieuDangKy.NgayLap, PhieuDangKy.MaPhieuDangKy, TenKhachHang, KhachHang.DiaChi, KhachHang.SoDienthoai, KhachHang.Email, PhieuDangKy.TongTien, NhanVien.TenNhanVien 
	from PhieuDangKy, NhanVien, KhachHang
	where PhieuDangKy.MaPhieuDangKy = @maphieudangky AND PhieuDangKy.MaKhachHang = KhachHang.MaKhachHang AND PhieuDangKy.MaNhanVien = NhanVien.MaNhanVien
Go