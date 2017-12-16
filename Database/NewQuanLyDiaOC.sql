create database QUANLYDIAOC
go
use QUANLYDIAOC
go

--------------------------------------------
-- Bảng khách hàng
create table KhachHang(
	MaKhachHang		int				identity(1,1),
	TenKhachHang	nvarchar(100)	not null,
	CMND			varchar(15)		not null,
	GioiTinh		bit				not null,
	NamSinh			smallint		not null,
	DiaChi			nvarchar(200)	not null,
	SoDienthoai		varchar(20)		not null,
	Email			varchar(100)	not null,
	
	primary key (MaKhachHang)
)

-- Bảng loại nhà
create table LoaiNha(
	MaLoaiNha		int				identity(1,1),
	TenLoaiNha	nvarchar(100)	not null,
	MoTa			nvarchar(500)	
	
	primary key (MaLoaiNha)
)

-------------------------------------------
-- Bảng loại địa ốc
create table LoaiDiaOc(
	MaLoaiDiaOc		int				identity(1,1),
	TenLoaiDiaOc	nvarchar(100)	not null,
	MoTa			nvarchar(500)	
	
	primary key (MaLoaiDiaOc)
)

--------------------------------------------
-- Bảng địa ốc
create table DiaOc(
	MaDiaOc				int				identity(1,1),		
	MaKhachHang			int				not null,
	MaLoaiDiaOc			int				not null,
	DiaChi				nvarchar(200)	not null,
	DienTichKhuonVien	numeric(18,2)	not null,
	DienTichSuDung		numeric(18,2)	not null,
	HuongNha			nvarchar(100)	not null,
	MaLoaiNha			int,
	ChieuDaiDat			int,
	ChieuRongNha		int,
	ChieuDaiNha			int,
	ChieuRongDat		int,
	SoTang				int,
	MoTaChiTiet			nvarchar(500)	not null,
	GiaBan				money			not null,
	TrangThaiKiemDuyet	bit				default 0,
	TrangThaiMuaBan		bit				default 0,
	
	primary key (MaDiaOc)
)

-------------------------------------------
-- Bảng giấy tờ
create table GiayTo(
	MaGiayTo			int				identity (1,1),			
	TrangThaiKiemDuyet	bit				default 0,
	MaDiaOc				int				not null,
	
	primary key (MaGiayTo)
)

-------------------------------------------
-- Bảng chi tiết giấy tờ
create table ChiTietGiayTo(
	MaChiTietGiayTo			int				identity (1,1),	
	MaGiayTo				int				not null,
	TenGiayTo				nvarchar(100)	not null,
	ScanGiayTo				image			not null,
	TrangThaiKiemDuyet		bit				default 0,
	
	primary key (MaChiTietGiayTo)
)

--------------------------------------------
-- Bảng phòng ban
create table PhongBan(
	MaPhongBan			int	 identity (1,1),
	TenLPhongBan		nvarchar(50)		not null,
	MoTaPhongBan		nvarchar(200)		not null,

	primary key (MaPhongBan)
)

--------------------------------------------
-- Bảng nhân viên
create table NhanVien(
	MaNhanVien			int					identity (1,1),			
	TenNhanVien			nvarchar(50)		not null,
	MaPhongBan			int					not null,
	CMND				varchar(15)			not null,
	NgaySinh			smalldatetime		not null,
	DiaChi				nvarchar(100)		not null,
	GioiTinh			bit					not null,
	Email				nvarchar(100)		not null,
	MaLoaiNhanVien		int					not null,
	TenDangNhap			varchar(30)			not null,
	MatKhau				varchar(15)			not null,

	primary key (MaNhanVien)
)

--------------------------------------------
-- Bảng loại nhân viên
create table LoaiNhanVien(
	MaLoaiNhanVien		int	 identity (1,1),
	TenLoaiNhanVien		nvarchar(50)		not null,
	MoTaLoaiNhanVien	nvarchar(200)		not null,

	primary key (MaLoaiNhanVien)
)

--------------------------------------------
-- Bảng quyền hạn
create table QuyenHan(
	MaQuyenHan			int	 identity (1,1),
	TenQuyenHan			nvarchar(50)		not null,
	MoQuyenHan			nvarchar(200)		not null,

	primary key (MaQuyenHan)
)

--------------------------------------------
-- Bảng phân quyền
create table PhanQuyen(
	MaPhanQuyen			int	 identity (1,1),
	MaQuyenHan			int					not null,
	MaLoaiNhanVien		int					not null,

	primary key (MaQuyenHan)
)

-- Bảng vị trí
create table ViTri(
	MaViTri				int	 identity (1,1),
	TenViTri			nvarchar(50)		not null,
	MoTaViTri			nvarchar(200)

	primary key (MaViTri)
)

--------------------------------------------
-- Bảng loại quảng cáo
create table LoaiQuangCao(
	MaLoaiQuangCao		int	 identity (1,1),
	TenLoaiQuangCao		nvarchar(50)		not null,
	MoTaLoaiQuangCao	nvarchar(200)		not null,

	primary key (MaLoaiQuangCao)
)


--------------------------------------------
-- Bảng giá tiền quảng cáo
create table GiaTienQuangCao(
	MaGiaTienQuangCao			int	 identity (1,1),
	MaLoaiQuangCao				int					not null,
	SoLuongPhatHanhToiThieu		int,
	SoLuongPhatHanhToiDa		int,
	MaViTri						int,
	MauSac						bit,
	KichCoToiThieu				int,
	KichCoToiDa					int,
	DonGia						money				not null,				

	primary key (MaGiaTienQuangCao)
)

--------------------------------------------
-- Bảng Phiếu đăng ký quảng cáo
create table PhieuDangKy(
	MaPhieuDangKy		int	 identity (1,1),
	MaKhachHang			int					not null,
	MaDiaOc				int					not null,
	MaNhanVien			int					not null,
	NgayLap				date				not null,
	NgayBatDau			date				not null,
	NgayKetThuc			date				not null,
	SoLanGiaHan			int					default 0,
	TrangThaiKiemDuyet	int					not null,
	TongTien			money				default 0,
	DaTra				money				default 0,
	ConNo				money				default 0,

	primary key (MaPhieuDangKy)
)

--------------------------------------------
-- Bảng Phiếu gia hạn
create table PhieuGiaHan(
	MaPhieuGiaHan		int	 identity (1,1),
	MaPhieuDangKy		int					not null,
	MaNhanVien			int					not null,
	NgayLap				date				not null,
	NgayBatDau			date				not null,
	NgayKetThuc			date				not null,
	TrangThaiKiemDuyet	int					not null,
	TongTien			money				default 0,
	DaTra				money				default 0,
	ConNo				money				default 0,
	
	primary key (MaPhieuGiaHan)
)

--------------------------------------------
-- Bảng Phiếu ngừng đăng ký dịch vụ
create table PhieuNgungDangKyDichVu(
	MaPhieuNgungDangKyDichVu		int	 identity (1,1),
	MaPhieuDangKy					int					not null,
	MaNhanVien						int					not null,
	NgayLap							date				not null,
	LyDo							nvarchar(500)		not null,
	TrangThaiKiemDuyet				int					not null,
	
	primary key (MaPhieuNgungDangKyDichVu)
)


--------------------------------------------
-- Bảng chi tiết quảng cáo
create table ChiTietQuangCao(
	MaChiTietQuangCao	int	 identity (1,1),
	MaPhieuDangKy		int					not null,
	MaLoaiQuangCao		int					not null,
	NgayBatDau			date				not null,
	NgayKetThuc			date				not null,
	SoLuongPhatHanh		int,
	MaViTri				int,
	KichThuoc			float,
	MauSac				bit,
	TrangThaiKiemDuyet	nvarchar(200)		not null,

	primary key (MaChiTietQuangCao)
)


-- Bảng hình ảnh
create table HinhAnh(
	MaHinhAnh			int				identity (1,1),
	MaPhieuDangKy		int				not null,
	MaNhanVien			int				not null,
	NgayHenChupAnh		date			not null,
	NgayChupAnh			date			not null,
	
	primary key (MaHinhAnh)
)

-------------------------------------------
-- Bảng chi tiết hình ảnh
create table ChiTietHinhAnh(
	MaChiTietHinhAnh		int				identity (1,1),	
	MaHinhAnh				int				not null,
	HinhAnh					image			not null,
	MoTaHinhAnh				nvarchar(100)	not null
	
	primary key (MaChiTietHinhAnh)
)

-- Bảng bài viết
create table BaiViet(
	MaBaiViet			int				identity (1,1),
	MaChiTietQuangCao	int				not null,
	MaNhanVien			int				not null,
	NoiDungBaiViet		nvarchar(1000)	not null,
	
	primary key (MaBaiViet)
)

--------------------------------------------
-- Quy định
create table QuyDinh(
	LaiSuatTreHanThanhToan		float,
	SoNgayQuangCaoToiDa			int,
	SoTuToiDa					int,
	ThoiGianChupAnhToiDa		int,
	PhanTramHoaDonGiaHan		float,
)	

-------------KHÓA NGOẠI-------------		
--Khóa ngoại bảng địa ốc				
alter table DiaOc add constraint FK_DiaOc_KhachHang_MaKhachHang foreign key(MaKhachHang) references KhachHang(MaKhachHang)
alter table DiaOc add constraint FK_DiaOc_LoaiDiaOc_MaLoaiDiaOc foreign key(MaLoaiDiaOc) references LoaiDiaOc(MaLoaiDiaOc)
alter table DiaOc add constraint FK_DiaOc_LoaiNha_MaLoaiNha foreign key(MaLoaiNha) references LoaiNha(MaLoaiNha)
--Khóa ngoại bảng giấy tờ			
alter table GiayTo add constraint FK_GiayTo_DiaOc_MaDiaOc foreign key(MaDiaOc) references DiaOc(MaDiaOc)
alter table ChiTietGiayTo add constraint FK_ChiTietGiayTo_GiayTo_MaGiayTo foreign key(MaGiayTo) references GiayTo(MaGiayTo)
--Khóa ngoại bảng nhân viên				
alter table NhanVien add constraint FK_NhanVien_PhongBan_MaPhongBan foreign key(MaPhongBan) references PhongBan(MaPhongBan)
alter table NhanVien add constraint FK_NhanVien_LoaiNhanVien_MaLoaiNhanVien foreign key(MaLoaiNhanVien) references LoaiNhanVien(MaLoaiNhanVien)
--Khóa ngoại bảng phân quyền			
alter table PhanQuyen add constraint FK_PhanQuyen_QuyenHan_MaQuyenHan foreign key(MaQuyenHan) references QuyenHan(MaQuyenHan)
alter table PhanQuyen add constraint FK_PhanQuyen_LoaiNhanVien_MaLoaiNhanVien foreign key(MaLoaiNhanVien) references LoaiNhanVien(MaLoaiNhanVien)
--Khóa ngoại bảng giá tiền quảng cáo		
alter table GiaTienQuangCao add constraint FK_GiaTienQuangCao_LoaiQuangCao_MaLoaiQuangCao foreign key(MaLoaiQuangCao) references LoaiQuangCao(MaLoaiQuangCao)
alter table GiaTienQuangCao add constraint FK_GiaTienQuangCao_ViTri_MaViTri foreign key(MaViTri) references ViTri(MaViTri)
--Khóa ngoại bảng phiếu đăng ký				
alter table PhieuDangKy add constraint FK_PhieuDangKy_KhachHang_MaKhachHang foreign key(MaKhachHang) references KhachHang(MaKhachHang)
alter table PhieuDangKy add constraint FK_PhieuDangKy_DiaOc_MaDiaOc foreign key(MaDiaOc) references DiaOc(MaDiaOc)
alter table PhieuDangKy add constraint FK_PhieuDangKy_NhanVien_MaNhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
--Khóa ngoại bảng phiếu gia hạn			
alter table PhieuGiaHan add constraint FK_PhieuGiaHan_PhieuDangKy_MaPhieuDangKy foreign key(MaPhieuDangKy) references PhieuDangKy(MaPhieuDangKy)
alter table PhieuGiaHan add constraint FK_PhieuGiaHan_NhanVien_MaNhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
--Khóa ngoại bảng phiếu ngưng đăng ký dịch vụ		
alter table PhieuNgungDangKyDichVu add constraint FK_PhieuNgungDangKyDichVu_PhieuDangKy_MaPhieuDangKy foreign key(MaPhieuDangKy) references PhieuDangKy(MaPhieuDangKy)
alter table PhieuNgungDangKyDichVu add constraint FK_PhieuNgungDangKyDichVu_NhanVien_MaNhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
--Khóa ngoại bảng chi tiết quảng cáo		
alter table ChiTietQuangCao add constraint FK_ChiTietQuangCao_PhieuDangKy_MaPhieuDangKy foreign key(MaPhieuDangKy) references PhieuDangKy(MaPhieuDangKy)
alter table ChiTietQuangCao add constraint FK_ChiTietQuangCao_PhieuDangKy_LoaiQuangCao_MaLoaiQuangCao foreign key(MaLoaiQuangCao) references LoaiQuangCao(MaLoaiQuangCao)
alter table ChiTietQuangCao add constraint FK_ChiTietQuangCao_ViTri_MaViTri foreign key(MaViTri) references ViTri(MaViTri)
--Khóa ngoại bảng hình ảnh	
alter table HinhAnh add constraint FK_HinhAnh_PhieuDangKy_MaPhieuDangKy foreign key(MaPhieuDangKy) references PhieuDangKy(MaPhieuDangKy)
alter table HinhAnh add constraint FK_HinhAnh_NhanVien_MaNhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
alter table ChiTietHinhAnh add constraint FK_ChiTietHinhAnh_HinhAnh_MaHinhAnh foreign key(MaHinhAnh) references HinhAnh(MaHinhAnh)
--Khóa ngoại bảng bài viết
alter table BaiViet add constraint FK_BaiViet_ChiTietQuangCao_MaChiTietQuangCao foreign key(MaChiTietQuangCao) references ChiTietQuangCao(MaChiTietQuangCao)
alter table BaiViet add constraint FK_BaiViet_NhanVien_MaNhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)


-------------------------------------------------------------------------
----------NHẬP THÔNG TIN----------------
--Disable all constraints
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"
set dateformat dmy

--Nhập thông tin bản thể loại
insert into TheLoai(TenTheLoai) values (N'Toán')

-------------------------------------
-- Enable all constraints
exec sp_MSforeachtable @command1="print '?'", @command2="ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"

