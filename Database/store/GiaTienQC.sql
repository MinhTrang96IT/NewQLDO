
CREATE PROC sp_GiaTienQuangCao_LayDanhSach
AS
	SELECT * FROM GiaTienQuangCao
GO

CREATE PROC sp_GiaTienQuangCao_LayDanhSachTheoTenLoai
AS
	SELECT MaGiaTienQuangCao, TenLoaiQuangCao, TenViTri, SoLuongPhatHanhToiThieu, SoLuongPhatHanhToiDa, KichCoToiThieu, KichCoToiDa, DonGia FROM GiaTienQuangCao, LoaiQuangCao, ViTri WHERE GiaTienQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND GiaTienQuangCao.MaViTri = ViTri.MaViTri
GO

CREATE PROC sp_GiaTienQuangCao_Them
	@maloaiquangcao int,				
	@mavitri int,				
	@soluongphathanhtoithieu	int,
	@soluongphathanhtoida	int,			
	@kichcotoithieu		int,		
	@kichcotoida int,	
	@dongia money
AS
	INSERT INTO GiaTienQuangCao VALUES(@maloaiquangcao, @mavitri, @soluongphathanhtoithieu, @soluongphathanhtoida, @kichcotoithieu, @kichcotoida, @dongia)
GO

CREATE PROC sp_GiaTienQuangCao_Xoa
@ma int

AS
	DELETE FROM GiaTienQuangCao WHERE MaGiaTienQuangCao=@ma
GO

CREATE PROC sp_GiaTienQuangCao_Sua
	@magiatienquangcao int,				
	@maloaiquangcao int,				
	@mavitri int,				
	@soluongphathanhtoithieu	int,
	@soluongphathanhtoida	int,			
	@kichcotoithieu		int,		
	@kichcotoida int,	
	@dongia money
AS
	UPDATE GiaTienQuangCao SET MaLoaiQuangCao=@maloaiquangcao, MaViTri=@mavitri, SoLuongPhatHanhToiThieu=@soluongphathanhtoithieu, SoLuongPhatHanhToiDa=@soluongphathanhtoida, KichCoToiThieu=@kichcotoithieu, KichCoToiDa=@kichcotoida, DonGia=@dongia WHERE MaGiaTienQuangCao=@magiatienquangcao
GO

CREATE PROC sp_GiaTienQuangCao_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT MaGiaTienQuangCao, TenLoaiQuangCao, TenViTri, SoLuongPhatHanhToiThieu, SoLuongPhatHanhToiDa, KichCoToiThieu, KichCoToiDa, DonGia FROM GiaTienQuangCao, LoaiQuangCao, ViTri WHERE GiaTienQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND GiaTienQuangCao.MaViTri = ViTri.MaViTri AND TenLoaiQuangCao LIKE '%'+ @ten +'%'
GO