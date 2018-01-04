
CREATE PROC sp_DiaOc_LayDanhSach
AS
	SELECT * FROM DiaOc
GO

CREATE PROC sp_DiaOc_LayDanhSachTheoTenLoai
AS
	SELECT MaDiaOc, TenKhachHang, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang
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

CREATE PROC sp_DiaOc_TimKiemTheoTen
@ten nvarchar(50)

AS
	SELECT MaDiaOc, TenKhachHang, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND TenKhachHang LIKE '%'+ @ten +'%'
GO

CREATE PROC sp_DiaOc_LayDanhSachTheoMa
@ma int

AS
	SELECT MaDiaOc, TenKhachHang, TenLoaiDiaOc, TenLoaiNha, DiaOc.DiaChi, DienTichKhuonVien, DienTichSuDung, HuongNha, ChieuDaiDat, ChieuRongDat, ChieuDaiNha, ChieuRongNha, SoTang, MoTaChiTiet, GiaBan, TrangThaiKiemDuyet, TrangThaiMuaBan, LyDoKhongDuyet FROM DiaOc, KhachHang, LoaiNha, LoaiDiaOc WHERE DiaOc.MaLoaiDiaOc = LoaiDiaOc.MaLoaiDiaOc AND DiaOc.MaLoaiNha = LoaiNha.MaLoaiNha AND DiaOc.MaKhachHang = KhachHang.MaKhachHang AND MaDiaOc=@ma
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