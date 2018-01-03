
CREATE PROC sp_ChiTietQuangCao_LayDanhSach
AS
	SELECT * FROM ChiTietQuangCao
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoTenLoai
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, MaViTri, MaBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet FROM ChiTietQuangCao, LoaiQuangCao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao
GO

CREATE PROC sp_ChiTietQuangCao_ThemLoaiToBuom
	@maphieudangky int,
	@maloaiquangcao int,				
	@soluongphathanh int,
	@kichthuoc float,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)	
AS
	INSERT INTO ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet,LyDoKhongDuyet) VALUES(@maphieudangky, @maloaiquangcao, @soluongphathanh, @kichthuoc, @trangthaikiemduyet, @lydokhongduyet)
GO

CREATE PROC sp_ChiTietQuangCao_ThemLoaiKhac
	@maphieudangky int,
	@maloaiquangcao int,				
	@mavitri int,
	@mabao int,		
	@ngaybatdau date,
	@ngayketthuc date,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)	
AS
	INSERT INTO ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri,MaBao, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet,LyDoKhongDuyet) VALUES(@maphieudangky, @maloaiquangcao, @mavitri, @mabao, @ngaybatdau, @ngayketthuc, @trangthaikiemduyet, @lydokhongduyet)
GO

CREATE PROC sp_ChiTietQuangCao_Xoa
@ma int

AS
	DELETE FROM ChiTietQuangCao WHERE MaChiTietQuangCao=@ma
GO

CREATE PROC sp_ChiTietQuangCao_SuaToBuom
	@machitietquangcao int,				
	@maphieudangky int,
	@maloaiquangcao int,				
	@soluongphathanh int,
	@kichthuoc float,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE ChiTietQuangCao SET MaPhieuDangKy = @maphieudangky, MaLoaiQuangCao=@maloaiquangcao, SoLuongPhatHanh=@soluongphathanh, KichThuoc=@kichthuoc, TrangThaiKiemDuyet = @trangthaikiemduyet , LyDoKhongDuyet = @lydokhongduyet, NgayBatDau = null, NgayKetThuc = null, MaViTri = null, MaBao = null WHERE MaChiTietQuangCao=@machitietquangcao
GO

CREATE PROC sp_ChiTietQuangCao_SuaLoaiKhac
	@machitietquangcao int,				
	@maphieudangky int,
	@maloaiquangcao int,				
	@mavitri int,
	@mabao int,		
	@ngaybatdau date,
	@ngayketthuc date,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE ChiTietQuangCao SET MaPhieuDangKy = @maphieudangky, MaLoaiQuangCao=@maloaiquangcao, MaViTri=@mavitri, MaBao=@mabao, NgayBatDau=@ngaybatdau, NgayKetThuc=@ngayketthuc, TrangThaiKiemDuyet = @trangthaikiemduyet , LyDoKhongDuyet = @lydokhongduyet , SoLuongPhatHanh = null, KichThuoc = null WHERE MaChiTietQuangCao=@machitietquangcao
GO


CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoMaPhieuDangKy
@maphieudangky int
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, MaViTri, MaBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet, LyDoKhongDuyet FROM ChiTietQuangCao, LoaiQuangCao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND  ChiTietQuangCao.MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_ChiTietQuangCao_LayDonGiaTheoMa_ToBuom
@machitietquangcao int
AS
	SELECT DonGia From ChiTietQuangCao, GiaTienQuangCao WHERE ChiTietQuangCao.MaChiTietQuangCao = @machitietquangcao AND (ChiTietQuangCao.SoLuongPhatHanh between GiaTienQuangCao.SoLuongPhatHanhToiThieu and GiaTienQuangCao.SoLuongPhatHanhToiDa) AND (ChiTietQuangCao.KichThuoc between GiaTienQuangCao.KichCoToiThieu and GiaTienQuangCao.KichCoToiDa)
GO

CREATE PROC sp_ChiTietQuangCao_LayDonGiaTheoMa_LoaiKhac
@machitietquangcao int
AS
	SELECT DonGia From ChiTietQuangCao, GiaTienQuangCao WHERE ChiTietQuangCao.MaChiTietQuangCao = @machitietquangcao AND ChiTietQuangCao.MaLoaiQuangCao = GiaTienQuangCao.MaLoaiQuangCao AND ChiTietQuangCao.MaViTri = GiaTienQuangCao.MaViTri
GO


CREATE PROC sp_ChiTietQuangCao_SuaKiemDuyet
	@machitietquangcao int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE ChiTietQuangCao SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaChiTietQuangCao = @machitietquangcao
GO