
CREATE PROC sp_ChiTietQuangCao_LayDanhSach
AS
	SELECT * FROM ChiTietQuangCao
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoTenLoai
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, TenViTri, TenBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet FROM ChiTietQuangCao, LoaiQuangCao, ViTri, Bao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND ChiTietQuangCao.MaViTri = ViTri.MaViTri AND ChiTietQuangCao.MaBao = Bao.MaBao
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
	@trangthaikiemduyet int		
AS
	INSERT INTO ChiTietQuangCao VALUES(@maphieudangky, @maloaiquangcao, @mavitri, @mabao, @ngaybatdau, @ngayketthuc, @soluongphathanh, @kichthuoc, @trangthaikiemduyet)
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
	@trangthaikiemduyet int		
AS
	UPDATE ChiTietQuangCao SET MaPhieuDangKy = @maphieudangky, MaLoaiQuangCao=@maloaiquangcao, MaViTri=@mavitri, MaBao=@mabao, NgayBatDau=@ngaybatdau, NgayKetThuc=@ngayketthuc, SoLuongPhatHanh=@soluongphathanh, KichThuoc=@kichthuoc, TrangThaiKiemDuyet = @trangthaikiemduyet WHERE MaChiTietQuangCao=@machitietquangcao
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoMaPhieuDangKy
@maphieudangky int
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, TenViTri, TenBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet FROM ChiTietQuangCao, LoaiQuangCao, ViTri, Bao WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND ChiTietQuangCao.MaViTri = ViTri.MaViTri AND ChiTietQuangCao.MaBao = Bao.MaBao AND ChiTietQuangCao.MaPhieuDangKy = @maphieudangky
GO
