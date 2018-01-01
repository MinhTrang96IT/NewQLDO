
CREATE PROC sp_ChiTietQuangCao_LayDanhSach
AS
	SELECT * FROM ChiTietQuangCao
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoTenLoai
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, MaViTri, MaBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet FROM ChiTietQuangCao, LoaiQuangCao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao
GO

CREATE PROC sp_ChiTietQuangCao_Them
	@maphieudangky int,
	@maloaiquangcao int,				
	@mavitri int,
	@mabao int,		
	@ngaybatdau date,
	@ngayketthuc date,
	@soluongphathanh int,
	@kichthuoc float,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)	
AS
	INSERT INTO ChiTietQuangCao VALUES(@maphieudangky, @maloaiquangcao, @mavitri, @mabao, @ngaybatdau, @ngayketthuc, @soluongphathanh, @kichthuoc, @trangthaikiemduyet, @lydokhongduyet)
GO

CREATE PROC sp_ChiTietQuangCao_Xoa
@ma int

AS
	DELETE FROM ChiTietQuangCao WHERE MaChiTietQuangCao=@ma
GO

CREATE PROC sp_ChiTietQuangCao_Sua
	@machitietquangcao int,				
	@maphieudangky int,
	@maloaiquangcao int,				
	@mavitri int,
	@mabao int,		
	@ngaybatdau date,
	@ngayketthuc date,
	@soluongphathanh int,
	@kichthuoc float,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE ChiTietQuangCao SET MaPhieuDangKy = @maphieudangky, MaLoaiQuangCao=@maloaiquangcao, MaViTri=@mavitri, MaBao=@mabao, NgayBatDau=@ngaybatdau, NgayKetThuc=@ngayketthuc, SoLuongPhatHanh=@soluongphathanh, KichThuoc=@kichthuoc, TrangThaiKiemDuyet = @trangthaikiemduyet , LyDoKhongDuyet = @lydokhongduyet WHERE MaChiTietQuangCao=@machitietquangcao
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoMaPhieuDangKy
@maphieudangky int
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, MaViTri, MaBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet, LyDoKhongDuyet FROM ChiTietQuangCao, LoaiQuangCao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND  ChiTietQuangCao.MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_ChiTietQuangCao_LayDonGiaTheoMa
@machitietquangcao int
AS
	SELECT DonGia From ChiTietQuangCao, GiaTienQuangCao WHERE ChiTietQuangCao.MaChiTietQuangCao = @machitietquangcao AND ChiTietQuangCao.MaLoaiQuangCao = GiaTienQuangCao.MaLoaiQuangCao AND ChiTietQuangCao.MaViTri = GiaTienQuangCao.MaViTri AND (ChiTietQuangCao.SoLuongPhatHanh between GiaTienQuangCao.SoLuongPhatHanhToiThieu and GiaTienQuangCao.SoLuongPhatHanhToiDa) AND (ChiTietQuangCao.KichThuoc between GiaTienQuangCao.KichCoToiThieu and GiaTienQuangCao.KichCoToiDa)
GO

CREATE PROC sp_ChiTietQuangCao_SuaKiemDuyet
	@machitietquangcao int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE ChiTietQuangCao SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaChiTietQuangCao = @machitietquangcao
GO