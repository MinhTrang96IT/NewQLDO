----------------------- BÀI VIẾT ------------------------------------------
CREATE PROC sp_BaiViet_LayDanhSach
AS
	SELECT * FROM BaiViet
GO

CREATE PROC sp_BaiViet_LayDanhSachTheoTenNhanVien
AS
	SELECT MaBaiViet, MaChiTietQuangCao, TenNhanVien, NoiDungBaiViet, TrangThaiKiemDuyet, LyDoKhongDuyet FROM BaiViet, NhanVien WHERE BaiViet.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_ChiTietQuangCao_LayDanhSachBaiVietTheoMaChiTietQuangCao
@machitietquangcao int
AS
	SELECT MaBaiViet, MaChiTietQuangCao, TenNhanVien, NoiDungBaiViet, TrangThaiKiemDuyet, LyDoKhongDuyet FROM BaiViet, NhanVien WHERE BaiViet.MaNhanVien = NhanVien.MaNhanVien AND MaChiTietQuangCao = @machitietquangcao
GO

CREATE PROC sp_BaiViet_Them
	@machitietquangcao int,				
	@manhanvien int,
	@noidungbaiviet	nvarchar(4000),
	@trangthaikiemduyet	int,
	@lydokhongduyet nvarchar(200)		
AS
	INSERT INTO BaiViet VALUES( @machitietquangcao, @manhanvien, @noidungbaiviet, @trangthaikiemduyet, @lydokhongduyet)
GO

CREATE PROC sp_BaiViet_Xoa
@ma int

AS
	DELETE FROM BaiViet WHERE MaBaiViet=@ma
GO

CREATE PROC sp_BaiViet_Sua
	@mabaiviet int,				
	@machitietquangcao int,				
	@manhanvien int,
	@noidungbaiviet	nvarchar(4000),
	@trangthaikiemduyet	int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE BaiViet SET MaChiTietQuangCao=@machitietquangcao, MaNhanVien=@manhanvien, NoiDungBaiViet=@noidungbaiviet, TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaBaiViet=@mabaiviet
GO

CREATE PROC sp_BaiViet_SuaKiemDuyet
	@mabaiviet int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE BaiViet SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaBaiViet = @mabaiviet
GO

CREATE PROC sp_BaiViet_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM BaiViet WHERE MaBaiViet=@ma
GO

-------------------- Bằng cấp --------------------------------
CREATE PROC sp_BangCap_LayDanhSach
AS
	SELECT * FROM BangCap
GO

-------------------- Báo -------------------------------------

CREATE PROC sp_Bao_LayDanhSach
AS
	SELECT * FROM Bao
GO

CREATE PROC sp_Bao_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO Bao VALUES(@ten, @mota)
GO

CREATE PROC sp_Bao_Xoa
@ma int

AS
	DELETE FROM Bao WHERE MaBao=@ma
GO

CREATE PROC sp_Bao_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE Bao SET TenBao=@ten, MoTaBao=@mota WHERE MaBao=@ma
GO

CREATE PROC sp_Bao_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM Bao WHERE TenBao LIKE '%'+ @ten +'%'
GO

----------------------- Chi tiết hình ảnh -----------------------------
CREATE PROC sp_ChiTietHinhAnh_LayDanhSach
AS
	SELECT * FROM ChiTietHinhAnh
GO

CREATE PROC sp_ChiTietHinhAnh_LayDanhSachTheoMaHA
@maha int

AS
	SELECT * FROM ChiTietHinhAnh WHERE MaHinhAnh=@maha
GO

CREATE PROC sp_ChiTietHinhAnh_Them
@maha int,
@ha varbinary(max),
@mota nvarchar(100)

AS
	INSERT INTO ChiTietHinhAnh VALUES(@maha, Cast(@ha As varbinary(max)), @mota)
GO

CREATE PROC sp_ChiTietHinhAnh_Xoa
@ma int

AS
	DELETE FROM ChiTietHinhAnh WHERE MaChiTietHinhAnh=@ma
GO

CREATE PROC sp_ChiTietHinhAnh_Sua
@mact int,
@maha int,
@ha varbinary(max),
@mota nvarchar(100)

AS
	UPDATE ChiTietHinhAnh SET MaHinhAnh=@maha, HinhAnh=Cast(@ha As varbinary(max)), MoTaHinhAnh=@mota WHERE MaChiTietHinhAnh=@mact
GO

----------------------------- Chi tiết quảng cáo --------------------------------------

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

CREATE PROC sp_ChiTietQuangCao_LayDanhSachTheoMaChiTietQuangCao
@ma int
AS
	SELECT MaChiTietQuangCao, MaPhieuDangKy, TenLoaiQuangCao, TenViTri, TenBao, NgayBatDau, NgayKetThuc, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet, LyDoKhongDuyet FROM ChiTietQuangCao, LoaiQuangCao, ViTri, Bao WHERE ChiTietQuangCao.MaBao = Bao.MaBao AND ChiTietQuangCao.MaViTri = ViTri.MaViTri AND ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND  MaChiTietQuangCao = @ma
GO

----------------------------- Địa ốc ---------------------------------

CREATE PROC sp_DiaOc_LayDanhSach
AS
	SELECT * FROM DiaOc
GO

CREATE PROC sp_DiaOc_LayDanhSachTheoTenLoai
AS
	SELECT MaDiaOc, TenKhachHang, CMND, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang
GO

CREATE PROC sp_DiaOc_LayDanhSachDiaOcTheoMaKH
@makhachhang int
AS
	SELECT MaDiaOc, TenKhachHang, CMND, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND KhachHang.MaKhachHang = @makhachhang
GO

CREATE PROC sp_DiaOc_Them
	@makhachhang int,				
	@maloaidiaoc int,				
	@maloainha int,
	@diachi	nvarchar(200),
	@dientichkhuonvien	float,			
	@dientichsudung		float,		
	@huongnha nvarchar(100),	
	@chieudaidat float,
	@chieurongdat float,
	@chieudainha float,
	@chieurongnha float,
	@sotang	int,
	@motachitiet nvarchar(500),
	@giaban money,	
	@trangthaikiemduyet	bit,				
	@trangthaimuaban bit,
	@lydokhongduyet nvarchar(200)				
AS
	INSERT INTO DiaOc VALUES(@makhachhang, @maloaidiaoc, @maloainha, @diachi, @dientichkhuonvien, @dientichsudung, @huongnha, @chieudaidat, @chieurongdat, @chieudainha, @chieurongnha, @sotang, @motachitiet, @giaban, @trangthaikiemduyet, @trangthaimuaban, @lydokhongduyet)
GO

CREATE PROC sp_DiaOc_Xoa
@ma int

AS
	DELETE FROM DiaOc WHERE MaDiaOc=@ma
GO

CREATE PROC sp_DiaOc_Sua
	@madiaoc int,
	@makhachhang int,				
	@maloaidiaoc int,				
	@maloainha int,
	@diachi	nvarchar(200),
	@dientichkhuonvien	float,	
	@dientichsudung		float,		
	@huongnha nvarchar(100),	
	@chieudaidat float,
	@chieurongdat float,
	@chieudainha float,
	@chieurongnha float,
	@sotang	int,
	@motachitiet nvarchar(500),
	@giaban money,	
	@trangthaikiemduyet	bit,				
	@trangthaimuaban bit,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE DiaOc SET MaKhachHang=@makhachhang, MaLoaiDiaOc=@maloaidiaoc, MaLoaiNha=@maloainha, DienTichKhuonVien=@dientichkhuonvien, DienTichSuDung=@dientichsudung, DiaOc.DiaChi=@diachi, HuongNha=@huongnha, ChieuDaiDat=@chieudaidat, ChieuRongDat=@chieurongdat, ChieuDaiNha=@chieudainha, ChieuRongNha = @chieurongnha, SoTang = @sotang, MoTaChiTiet = @motachitiet, GiaBan = @giaban, TrangThaiKiemDuyet = @trangthaikiemduyet, TrangThaiMuaBan = @trangthaimuaban, LyDoKhongDuyet = @lydokhongduyet WHERE MaDiaOc=@madiaoc
GO

CREATE PROC sp_DiaOc_TimKiemTheoMa
@ma int
AS
	SELECT MaDiaOc, TenKhachHang,CMND, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND MaDiaOc = @ma
GO

CREATE PROC sp_DiaOc_LayDanhSachTheoMa
@ma int

AS
	SELECT MaDiaOc, TenKhachHang,CMND, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND MaDiaOc=@ma
GO

CREATE PROC sp_DiaOc_SuaKiemDuyet
	@madiaoc int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE DiaOc SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaDiaOc = @madiaoc
GO

CREATE PROC sp_DiaOc_LayDanhSachTheoMa2
@ma int

AS
	SELECT MaDiaOc, DiaOc.MaKhachHang, TenKhachHang, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND MaDiaOc=@ma
GO

CREATE PROC sp_DiaOc_LayMaPhieuDang

CREATE PROC sp_DiaOC_LayChiTietQuangCao
@madiaoc int
AS
	SELECT MaChiTietQuangCao, ChiTietQuangCao.MaPhieuDangKy, TenLoaiQuangCao, MaViTri, MaBao, ChiTietQuangCao.NgayBatDau, ChiTietQuangCao.NgayKetThuc, SoLuongPhatHanh, KichThuoc, ChiTietQuangCao.TrangThaiKiemDuyet
	 FROM ChiTietQuangCao, LoaiQuangCao, DiaOc, PhieuDangKy
	  WHERE ChiTietQuangCao.MaLoaiQuangCao = LoaiQuangCao.MaLoaiQuangCao AND DiaOc.MaDiaOc = @madiaoc AND DiaOc.MaDiaOc = PhieuDangKy.MaDiaOc AND PhieuDangKy.MaPhieuDangKy = ChiTietQuangCao.MaPhieuDangKy
	   AND ChiTietQuangCao.MaPhieuDangKy NOT IN (
	   select PhieuDangKy.MaPhieuDangKy 
	   from PhieuNgungDangKyDichVu, DiaOc, PhieuDangKy 
	   where DiaOc.MaDiaOc = @madiaoc and DiaOc.MaDiaOc = PhieuDangKy.MaDiaOc and PhieuDangKy.MaPhieuDangKy = PhieuNgungDangKyDichVu.MaPhieuDangKy)
Go

CREATE PROC sp_DiaOc_LayHinhAnh
@madiaoc int
AS
	Select * from HinhAnh where HinhAnh.MaPhieuDangKy IN (
		Select PhieuDangKy.MaPhieuDangKy from PhieuDangKy, DiaOc where 
	PhieuDangKy.MaDiaOc = DiaOc.MaDiaOc AND DiaOc.MaDiaOc = @madiaoc AND PhieuDangKy.MaPhieuDangKy NOT IN (
	select PhieuDangKy.MaPhieuDangKy 
	   from PhieuNgungDangKyDichVu, DiaOc, PhieuDangKy 
	   where DiaOc.MaDiaOc = @madiaoc and DiaOc.MaDiaOc = PhieuDangKy.MaDiaOc and PhieuDangKy.MaPhieuDangKy = PhieuNgungDangKyDichVu.MaPhieuDangKy)
	)
GO

------------------------ Giá tiền Quảng cáo ----------------------------------

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

------------------- Giấy tờ ----------------------------------------
CREATE PROC sp_GiayTo_LayDanhSach
AS
	SELECT * FROM GiayTo
GO

CREATE PROC sp_GiayTo_LayDanhSachTheoMaDO
@mado int

AS
	SELECT * FROM GiayTo WHERE MaDiaOc=@mado
GO

CREATE PROC sp_GiayTo_Them
@mado int,
@ha varbinary(max),
@ten nvarchar(100)

AS
	INSERT INTO GiayTo VALUES(@mado, @ten, Cast(@ha As varbinary(max)))
GO

CREATE PROC sp_GiayTo_Xoa
@ma int

AS
	DELETE FROM GiayTo WHERE MaGiayTo=@ma
GO

CREATE PROC sp_GiayTo_Sua
@magt int,
@mado int,
@ha varbinary(max),
@ten nvarchar(100)

AS
	UPDATE GiayTo SET MaDiaOc=@mado, ScanGiayTo=Cast(@ha As varbinary(max)), TenGiayTo=@ten WHERE MaGiayTo=@magt
GO

--------------- Hình Ảnh ------------------------------------
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

--------------- Khách hàng ----------------------------------------------

CREATE PROC sp_KhachHang_LayDanhSach
AS
	SELECT * FROM KhachHang
GO

CREATE PROC sp_KhachHang_Them
@ten nvarchar(100),
@cmnd nvarchar(15),
@gioitinh bit,
@namsinh smallint,
@diachi nvarchar(200),
@sdt varchar(20),
@email varchar(100)

AS
	INSERT INTO KhachHang VALUES(@ten, @cmnd, @gioitinh, @namsinh, @diachi, @sdt, @email)
GO

CREATE PROC sp_KhachHang_Xoa
@ma int

AS
	DELETE FROM KhachHang WHERE MaKhachHang=@ma
GO

CREATE PROC sp_KhachHang_Sua
@ma int,
@ten nvarchar(100),
@cmnd nvarchar(15),
@gioitinh bit,
@namsinh smallint,
@diachi nvarchar(200),
@sdt varchar(20),
@email varchar(100)

AS
	UPDATE KhachHang SET TenKhachHang=@ten, CMND=@cmnd, GioiTinh=@gioitinh, NamSinh=@namsinh, DiaChi=@diachi, SoDienthoai=@sdt, Email=@email WHERE MaKhachHang=@ma
GO

CREATE PROC sp_KhachHang_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM KhachHang WHERE TenKhachHang LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_KhachHang_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM KhachHang WHERE MaKhachHang=@ma
GO

--------------------- Loại địa ốc -----------------------

CREATE PROC sp_LoaiDiaOc_LayDanhSach
AS
	SELECT * FROM LoaiDiaOc
GO

CREATE PROC sp_LoaiDiaOc_Them
@ten nvarchar(100),
@mota nvarchar(500)
AS
	INSERT INTO LoaiDiaOc VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiDiaOc_Xoa
@ma int

AS
	DELETE FROM LoaiDiaOc WHERE MaLoaiDiaOc=@ma
GO

CREATE PROC sp_LoaiDiaOc_Sua
@ma int,
@ten nvarchar(100),
@mota nvarchar(500)

AS
	UPDATE LoaiDiaOc SET TenLoaiDiaOc=@ten, MoTa=@mota WHERE MaLoaiDiaOc=@ma
GO

CREATE PROC sp_LoaiDiaOc_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM LoaiDiaOc WHERE TenLoaiDiaOc LIKE '%'+ @ten +'%'
GO

--------------------- Loại nhà -------------------------

CREATE PROC sp_LoaiNha_LayDanhSach
AS
	SELECT * FROM LoaiNha
GO

CREATE PROC sp_LoaiNha_Them
@ten nvarchar(100),
@mota nvarchar(500)
AS
	INSERT INTO LoaiNha VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiNha_Xoa
@ma int

AS
	DELETE FROM LoaiNha WHERE MaLoaiNha=@ma
GO

CREATE PROC sp_LoaiNha_Sua
@ma int,
@ten nvarchar(100),
@mota nvarchar(500)

AS
	UPDATE LoaiNha SET TenLoaiNha=@ten, MoTa=@mota WHERE MaLoaiNha=@ma
GO

CREATE PROC sp_LoaiNha_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM LoaiNha WHERE TenLoaiNha LIKE '%'+ @ten +'%'
GO

------------------- Loại nhân viên ----------------------------

CREATE PROC sp_LoaiNhanVien_LayDanhSach
AS
	SELECT * FROM LoaiNhanVien
GO

CREATE PROC sp_LoaiNhanVien_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO LoaiNhanVien VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiNhanVien_Xoa
@ma int

AS
	DELETE FROM LoaiNhanVien WHERE MaLoaiNhanVien=@ma
GO

CREATE PROC sp_LoaiNhanVien_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE LoaiNhanVien SET TenLoaiNhanVien=@ten, MoTaLoaiNhanVien=@mota WHERE MaLoaiNhanVien=@ma
GO

CREATE PROC sp_LoaiNhanVien_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM LoaiNhanVien WHERE TenLoaiNhanVien LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_LoaiNhanVien_LayLoaiNhanVien
@ma int

AS
	SELECT TenLoaiNhanVien FROM LoaiNhanVien WHERE MaLoaiNhanVien=@ma
GO

--------------- Loại quảng cáo --------------------------

CREATE PROC sp_LoaiQuangCao_LayDanhSach
AS
	SELECT * FROM LoaiQuangCao
GO

CREATE PROC sp_LoaiQuangCao_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO LoaiQuangCao VALUES(@ten, @mota)
GO

CREATE PROC sp_LoaiQuangCao_Xoa
@ma int

AS
	DELETE FROM LoaiQuangCao WHERE MaLoaiQuangCao=@ma
GO

CREATE PROC sp_LoaiQuangCao_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE LoaiQuangCao SET TenLoaiQuangCao=@ten, MoTaLoaiQuangCao=@mota WHERE MaLoaiQuangCao=@ma
GO

CREATE PROC sp_LoaiQuangCao_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM LoaiQuangCao WHERE TenLoaiQuangCao LIKE '%'+ @ten +'%'
GO

--------------------- Nhân viên -----------------------------

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

----------------------- Phân quyền ---------------------
CREATE PROC sp_PhanQuyen_LayDanhSachTheoTenLoai
AS
	SELECT MaPhanQuyen, TenLoaiNhanVien, TenQuyenHan  FROM PhanQuyen, LoaiNhanVien, QuyenHan WHERE PhanQuyen.MaLoaiNhanVien = LoaiNhanVien.MaLoaiNhanVien AND PhanQuyen.MaQuyenHan = QuyenHan.MaQuyenHan
GO

CREATE PROC sp_PhanQuyen_Them
@loai int,
@qh int

AS
	INSERT INTO PhanQuyen VALUES(@qh, @loai)
GO

CREATE PROC sp_PhanQuyen_Xoa
@loai int

AS
	DELETE FROM PhanQuyen WHERE MaLoaiNhanVien=@loai
GO

CREATE PROC sp_PhanQuyen_LayDanhSachTenQuyenHanTheoLoaiNhanVien
@ten nvarchar(50)
AS
	SELECT TenQuyenHan FROM PhanQuyen, LoaiNhanVien, QuyenHan WHERE PhanQuyen.MaLoaiNhanVien = LoaiNhanVien.MaLoaiNhanVien AND PhanQuyen.MaQuyenHan = QuyenHan.MaQuyenHan AND TenLoaiNhanVien=@ten
GO

----------------------- Phiếu đăng ký ---------------------------

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

--------------------- Phiếu gia hạn ---------------------------

CREATE PROC sp_PhieuGiaHan_LayDanhSach
AS
	SELECT * FROM PhieuGiaHan
GO


CREATE PROC sp_PhieuGiaHan_LayDanhSachPhieuGiaHanCoTen
AS
	SELECT MaPhieuGiaHan, MaPhieuDangKy,  TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc,  TrangThaiKiemDuyet, TongTien, LyDoKhongDuyet  FROM PhieuGiaHan,  NhanVien WHERE PhieuGiaHan.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_PhieuGiaHan_LayDanhSachPhieuGiaHanTheoMaPDK
@maphieudangky int
AS
	SELECT MaPhieuGiaHan, MaPhieuDangKy,  TenNhanVien,NgayLap, NgayBatDau, NgayKetThuc,  TrangThaiKiemDuyet, TongTien, LyDoKhongDuyet  FROM PhieuGiaHan,  NhanVien WHERE PhieuGiaHan.MaNhanVien = NhanVien.MaNhanVien AND MaPhieuDangKy = @maphieudangky
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

CREATE PROC sp_PhieuGiaHan_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM PhieuGiaHan WHERE MaPhieuGiaHan=@ma
GO

-------------- Phiếu ngưng đăng ký dịch vụ -----------------------

CREATE PROC sp_HuyDangKy_LayDanhSach
AS
	SELECT * FROM PhieuNgungDangKyDichVu
GO

CREATE PROC sp_HuyDangKy_LayDanhSachPhieuDangKy
AS
	SELECT * FROM PhieuDangKy
GO

CREATE PROC sp_PhieuDangKy_LayDanhSachPhieuHuyDangKyCoTenNhanVien
AS
	SELECT MaPhieuNgungDangKyDichVu, MaPhieuDangKy, TenNhanVien , NgayLap,LyDo, TrangThaiKiemDuyet, LyDoKhongDuyet  FROM PhieuNgungDangKyDichVu, NhanVien WHERE PhieuNgungDangKyDichVu.MaNhanVien = NhanVien.MaNhanVien
GO

CREATE PROC sp_HuyDangKy_LayDanhSachHuyDangKyTheoMaPDK
@maphieudangky int
AS
	SELECT MaPhieuNgungDangKyDichVu, MaPhieuDangKy, TenNhanVien , NgayLap,LyDo, TrangThaiKiemDuyet, LyDoKhongDuyet  FROM PhieuNgungDangKyDichVu, NhanVien WHERE PhieuNgungDangKyDichVu.MaNhanVien = NhanVien.MaNhanVien AND MaPhieuDangKy = @maphieudangky
GO

CREATE PROC sp_HuyDangKy_Them
	@maphieudangky int,				
	@manhanvien int,				
	@ngaylap date,
	@lydo	nvarchar(500),	
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)	
AS
	INSERT INTO PhieuNgungDangKyDichVu VALUES(@maphieudangky, @manhanvien, @ngaylap, @lydo, @trangthaikiemduyet, @lydokhongduyet)
GO

CREATE PROC sp_HuyDangKy_Xoa
@ma int

AS
	DELETE FROM PhieuNgungDangKyDichVu WHERE MaPhieuNgungDangKyDichVu=@ma
GO

CREATE PROC sp_HuyDangKy_Sua
	@maphieungungdangkydichvu int,
	@maphieudangky int,				
	@manhanvien int,				
	@ngaylap date,
	@lydo	nvarchar(500),	
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuNgungDangKyDichVu SET MaPhieuDangKy=@maphieudangky, MaNhanVien=@manhanvien, NgayLap=@ngaylap, LyDo=@lydo, TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuNgungDangKyDichVu = @maphieungungdangkydichvu
GO

CREATE PROC sp_HuyDangKy_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT MaPhieuNgungDangKyDichVu, MaPhieuDangKy, TenNhanVien , NgayLap,LyDo, TrangThaiKiemDuyet, LyDoKhongDuyet  FROM PhieuNgungDangKyDichVu, NhanVien WHERE PhieuNgungDangKyDichVu.MaNhanVien = NhanVien.MaNhanVien AND TenNhanVien LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_PhieuNgungDangKyDichVu_SuaKiemDuyet
	@maphieungungdichvu int,
	@trangthaikiemduyet int,
	@lydokhongduyet nvarchar(200)
AS
	UPDATE PhieuNgungDangKyDichVu SET TrangThaiKiemDuyet=@trangthaikiemduyet, LyDoKhongDuyet = @lydokhongduyet WHERE MaPhieuNgungDangKyDichVu = @maphieungungdichvu
GO

CREATE PROC sp_PhieuNgungDangKyDichVu_LayDanhSachTheoMa
@ma int

AS
	SELECT * FROM PhieuNgungDangKyDichVu WHERE MaPhieuNgungDangKyDichVu=@ma
GO

---------------- Phòng ban -----------------------

CREATE PROC sp_PhongBan_LayDanhSach
AS
	SELECT * FROM PhongBan
GO

CREATE PROC sp_PhongBan_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO PhongBan VALUES(@ten, @mota)
GO

CREATE PROC sp_PhongBan_Xoa
@ma int

AS
	DELETE FROM PhongBan WHERE MaPhongBan=@ma
GO

CREATE PROC sp_PhongBan_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE PhongBan SET TenLPhongBan=@ten, MoTaPhongBan=@mota WHERE MaPhongBan=@ma
GO

CREATE PROC sp_PhongBan_TimKiemTheoTen
@ten nvarchar(100)

AS
	SELECT * FROM PhongBan WHERE TenLPhongBan LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_PhongBan_LayPhongBan
@ma int

AS
	SELECT TenLPhongBan FROM PhongBan WHERE MaPhongBan=@ma
GO

---------------- Quy định ----------------------------
CREATE PROC sp_QuyDinh_LayLaiSuatTreHanThanhToan
AS
	SELECT LaiSuatTreHanThanhToan FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_LayPhanTramHoaDonGiaHan
AS
	SELECT PhanTramHoaDonGiaHan FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_LaySoNgayQuangCaoToiDa
AS
	SELECT SoNgayQuangCaoToiDa FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_LaySoTuToiDa
AS
	SELECT SoTuToiDa FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_LayThoiGianChupAnhToiDa
AS
	SELECT ThoiGianChupAnhToiDa FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_LayPhanTramQuangCaoCoMau
AS
	SELECT PhanTramQuangCaoCoMau FROM QuyDinh
GO

CREATE PROC sp_QuyDinh_SuaPhieuThu
@laisuat float,
@phantramhoadongiahan float

AS
	UPDATE QuyDinh SET LaiSuatTreHanThanhToan=@laisuat, PhanTramHoaDonGiaHan=@phantramhoadongiahan
GO

CREATE PROC sp_QuyDinh_SuaQuangCao
@songayquangcao int,
@sotubaiviet int,
@thoigianchupanh int,
@phantramquangcao float

AS
	UPDATE QuyDinh SET SoNgayQuangCaoToiDa=@songayquangcao, SoTuToiDa=@songayquangcao, ThoiGianChupAnhToiDa=@thoigianchupanh, PhanTramQuangCaoCoMau=@phantramquangcao
GO

---------------------- Quyền hạn ------------------------

CREATE PROC sp_QuyenHan_LayDanhSach
AS
	SELECT * FROM QuyenHan
GO

CREATE PROC sp_QuyenHan_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO QuyenHan VALUES(@ten, @mota)
GO

CREATE PROC sp_QuyenHan_Xoa
@ma int

AS
	DELETE FROM QuyenHan WHERE MaQuyenHan=@ma
GO

CREATE PROC sp_QuyenHan_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE QuyenHan SET TenQuyenHan=@ten, MoTaQuyenHan=@mota WHERE MaQuyenHan=@ma
GO

CREATE PROC sp_QuyenHan_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM QuyenHan WHERE TenQuyenHan LIKE '%'+ @ten +'%'
GO

-------------- Thống kê ----------------------------
CREATE PROC sp_ThongKe_DoTuoiKhachHang
AS
	select NamSinh, Count(NamSinh) as SoLuong from KhachHang group by NamSinh
GO

CREATE PROC sp_ThongKe_LayDoanhThu
@THANG int,
@NAM int
AS
SELECT SUM(TongTien) FROM PhieuDangKy WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM
GO

CREATE PROC sp_ThongKe_SoLuongPhieuDangKyTheoLoaiQuangCao
@Nam int
AS
 SELECT TenLoaiQuangCao,ChiTietQuangCao.MaLoaiQuangCao, Count(ChiTietQuangCao.MaLoaiQuangCao) as SoLuong FROM PhieuDangKy, ChiTietQuangCao, LoaiQuangCao WHERE PhieuDangKy.MaPhieuDangKy = ChiTietQuangCao.MaPhieuDangKy AND YEAR(NgayLap) = @Nam and LoaiQuangCao.MaLoaiQuangCao = ChiTietQuangCao.MaLoaiQuangCao group by ChiTietQuangCao.MaLoaiQuangCao, LoaiQuangCao.TenLoaiQuangCao
GO

CREATE PROC sp_ThongKe_LayDoanhthuTheoLoaiQuangCao
@THANG int,
@NAM int,
@maloaiquangcao int
AS
SELECT MaLoaiQuangCao,SUM(TongTien) FROM PhieuDangKy, ChiTietQuangCao WHERE MONTH(NgayLap)=@THANG AND YEAR(NgayLap)=@NAM AND PhieuDangKy.MaPhieuDangKy = ChiTietQuangCao.MaPhieuDangKy AND ChiTietQuangCao.MaLoaiQuangCao = @maloaiquangcao group by ChiTietQuangCao.MaLoaiQuangCao
GO

------------------------ Vị trí ---------------------------------

CREATE PROC sp_ViTri_LayDanhSach
AS
	SELECT * FROM ViTri
GO

CREATE PROC sp_ViTri_Them
@ten nvarchar(50),
@mota nvarchar(200)
AS
	INSERT INTO ViTri VALUES(@ten, @mota)
GO

CREATE PROC sp_ViTri_Xoa
@ma int

AS
	DELETE FROM ViTri WHERE MaViTri=@ma
GO

CREATE PROC sp_ViTri_Sua
@ma int,
@ten nvarchar(50),
@mota nvarchar(200)

AS
	UPDATE ViTri SET TenViTri=@ten, MoTaViTri=@mota WHERE MaViTri=@ma
GO

CREATE PROC sp_ViTri_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT * FROM ViTri WHERE TenViTri LIKE '%'+ @ten +'%'
GO