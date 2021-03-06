
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
	TenLoaiNha		nvarchar(100)	not null,
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
	MaLoaiNha			int,
	DiaChi				nvarchar(200)	not null,
	DienTichKhuonVien	float			not null,
	DienTichSuDung		float			not null,
	HuongNha			nvarchar(100)	not null,
	ChieuDaiDat			float,
	ChieuRongDat		float,
	ChieuDaiNha			float,
	ChieuRongNha		float,
	SoTang				int,
	MoTaChiTiet			nvarchar(500)	not null,
	GiaBan				money			not null,
	TrangThaiKiemDuyet	int				default 0,
	TrangThaiMuaBan		bit				default 0,
	LyDoKhongDuyet		nvarchar(200)		null,

	primary key (MaDiaOc)
)


-------------------------------------------
-- Bảng chi tiết giấy tờ
create table GiayTo(
	MaGiayTo			int				identity (1,1),			
	MaDiaOc				int				not null,
	TenGiayTo			nvarchar(100)	not null,
	ScanGiayTo			varbinary(max),
	
	primary key (MaGiayTo)
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
	MaLoaiNhanVien		int					not null,
	MaPhongBan			int					not null,
	TenNhanVien			nvarchar(50)		not null,
	CMND				varchar(15)			not null,
	GioiTinh			bit					not null,
	NgaySinh			datetime			not null,
	DiaChi				nvarchar(100)		not null,
	SoDienThoai			varchar(15)			not null,
	Email				nvarchar(100)		not null,
	TenDangNhap			varchar(30)			not null,
	MatKhau				varchar(15)			not null,
	MaBangCap			int					not null,

	primary key (MaNhanVien)
)

--------------------------------------------
--Bảng bằng cấp
create table BangCap(
	MaBangCap			int					identity (1,1),
	TenBangCap			nvarchar(100)		not null,

	primary key (MaBangCap)
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
	MoTaQuyenHan			nvarchar(200)		not null,

	primary key (MaQuyenHan)
)

--------------------------------------------
-- Bảng phân quyền
create table PhanQuyen(
	MaPhanQuyen			int	 identity (1,1),
	MaQuyenHan			int					not null,
	MaLoaiNhanVien		int					not null,

	primary key (MaPhanQuyen)
)

-- Bảng vị trí
create table ViTri(
	MaViTri				int	 identity (1,1),
	TenViTri			nvarchar(50)		not null,
	MoTaViTri			nvarchar(200)

	primary key (MaViTri)
)

-- Bảng báo chí
create table Bao(
	MaBao				int	 identity (1,1),
	TenBao				nvarchar(50)		not null,
	MoTaBao				nvarchar(200)

	primary key (MaBao)
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
	MaViTri						int,
	SoLuongPhatHanhToiThieu		int,
	SoLuongPhatHanhToiDa		int,
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
	LyDoKhongDuyet		nvarchar(200)		null,

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
	LyDoKhongDuyet		nvarchar(200)		null,
	
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
	LyDoKhongDuyet					nvarchar(200)		null,
	
	primary key (MaPhieuNgungDangKyDichVu)
)


--------------------------------------------
-- Bảng chi tiết quảng cáo
create table ChiTietQuangCao(
	MaChiTietQuangCao	int	 identity (1,1),
	MaPhieuDangKy		int					not null,
	MaLoaiQuangCao		int					not null,
	MaViTri				int,
	MaBao				int,
	NgayBatDau			date,				
	NgayKetThuc			date,				
	SoLuongPhatHanh		int,
	KichThuoc			float,
	TrangThaiKiemDuyet	int					default 0 not null,
	LyDoKhongDuyet		nvarchar(200)		null,

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
	HinhAnh					varbinary(max),
	MoTaHinhAnh				nvarchar(100)	not null
	
	primary key (MaChiTietHinhAnh)
)

-- Bảng bài viết
create table BaiViet(
	MaBaiViet			int				identity (1,1),
	MaChiTietQuangCao	int				not null,
	MaNhanVien			int				not null,
	NoiDungBaiViet		nvarchar(4000)	not null,
	TrangThaiKiemDuyet	int				not null,
	LyDoKhongDuyet		nvarchar(200)		null,
	
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
	PhanTramQuangCaoCoMau		float
)	

-------------KHÓA NGOẠI-------------		
--Khóa ngoại bảng địa ốc				
alter table DiaOc add constraint FK_DiaOc_KhachHang_MaKhachHang foreign key(MaKhachHang) references KhachHang(MaKhachHang)
alter table DiaOc add constraint FK_DiaOc_LoaiDiaOc_MaLoaiDiaOc foreign key(MaLoaiDiaOc) references LoaiDiaOc(MaLoaiDiaOc)
alter table DiaOc add constraint FK_DiaOc_LoaiNha_MaLoaiNha foreign key(MaLoaiNha) references LoaiNha(MaLoaiNha)
--Khóa ngoại bảng giấy tờ			
alter table GiayTo add constraint FK_GiayTo_DiaOc_MaDiaOc foreign key(MaDiaOc) references DiaOc(MaDiaOc)
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

--Nhập thông tin bảng KHách hàng
insert into KhachHang values (N'Trần Thị Minh Trang','251043331', 1, 1996, N'Khu phố 6, phường Linh Trung, quận Thủ Đức', '01694122657', 'minhtranguit@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Thu Nguyệt','241433822', 1, 1996, N'Khu phố Tân lập, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương', '0968319031', 'thunguyetuit@gmail.com')
insert into KhachHang values (N'Nguyễn Minh Hiếu','3564886651', 0, 1996, N'Khu phố Tân lập, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương', '01637892643', 'hieuminh2705@gmail.com')
insert into KhachHang values (N'Hoàng Kim Tuấn','256358165', 0, 1996, N'Khu phố Tân lập, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương', '0977258369', 'tuanhkim@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Thùy Trang','261623974', 1, 1998, N'Hoàng Hoa Thám, phường 5, quận Tân Bình', '01688764747', 'thuytrangnt@gmail.com')
insert into KhachHang values (N'Phạm Trương Tiểu Phụng','123586797', 1, 1996, N'Đường số 8, phường An Phú, quận 9', '0985236489', 'phungptt@gmail.com')
insert into KhachHang values (N'Trịnh Ngọc Lợi','326478922', 0, 1995, N'Nguyễn Văn Trỗi, phường 6, quận Phú Nhuận', '0962892365', 'loitn1408@gmail.com')
insert into KhachHang values (N'Hà Duy Khiêm','365789152', 0, 1996, N'Hai Bà Trưng, phường Tân Định, quận 1', '0964874814', 'haduykhiem@gmail.com')
insert into KhachHang values (N'Từ Vạn Thuận','223564789', 0, 1996, N'Khu phố 6, phường Linh Trung, quận Thủ Đức', '01235687412', 'tuvanthuan@gmail.com')
insert into KhachHang values (N'Phan Đức Anh','375612896', 0, 1997, N'Nguyễn Hữu Cảnh, phường 3, quận Bình Thạnh', '0974563258', 'anhpduit@gmail.com')
insert into KhachHang values (N'Quan Chí Khánh An','235624896', 0, 1997, N'Lý Thường Kiệt, phường 2, quận Tân Bình', '01234589621', 'anqck@gmail.com')
insert into KhachHang values (N'Đặng Trung Tín','325715896', 0, 1994, N'Trường Sa, phường 2, quận 3', '01652348962', 'dttin@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Ngọc Phượng','234562299', 1, 1992, N'Nguyễn Văn Linh, phường 9, quận 7', '0987235623', 'phuong1302@gmail.com')
insert into KhachHang values (N'Trần Thị Thúy Nga','312562389', 1, 1993, N'Thuận An, Bình Dương', '01235891236', 'nganga123@gmail.com')
insert into KhachHang values (N'Hồ Văn Vinh','224589369', 0, 1990, N'Đinh Tiên Hoàng, phường Tân Định, quận 1', '01235687113', 'hvvinh123@gmail.com')
insert into KhachHang values (N'Phan Đinh Công','371237856', 0, 1991, N'Nguyễn Oanh, phường 3, quận Gò Vấp', '0972895369', 'phandinhconggt@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Thảo Nhi','312312030', 1, 1996, N'Khu phố Tân Lập, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương', '01653588619', 'nhinttt@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Như Huỳnh','3522773414', 1, 1994, N'Hoàng Sa, phường 2, quận 3', '01677775739', 'nhuhuynhnt@gmail.com')
insert into KhachHang values (N'Nguyễn Văn Hiếu','235624896', 0, 1992, N'Phạm Văn Đồng, phường Hiệp Bình Chánh, quận Thủ Đức', '0987525623', 'hieunguyen@gmail.com')
insert into KhachHang values (N'Nguyễn Thị Hiền','235621256', 1, 1990, N'Kha Vạn Cân, phường Hiệp Bình Chánh, quận Thủ Đức', '0987512323', 'hiennguyenthi@gmail.com')

--Nhập thông tin bảng Loại nhà
insert into LoaiNha values (N'Biệt thự', N'Ngôi nhà riêng biệt, có sân vườn, hàng rào bao quanh; Kết cấu chịu lực khung, sàn, tường bằng bê tông cốt thép hoặc tường gạch;Bao che nhà và tường ngăn cách các phòng bằng bê tông cốt thép hoặc xây gạch; Mái bằng hoặc mái ngói, có hệ thống cách âm và cách nhiệt tốt; Vật liệu hoàn thiện trong và ngoài nhà tốt; Tiện nghi sinh hoạt đầy đủ tiện dùng, chất lượng tốt; Số tầng không hạn chế, nhưng mỗi tầng phải có ít nhất 2 phòng để ở.')
insert into LoaiNha values (N'Nhà cấp I', N' Kết cấu chịu lực bằng bê tông cốt thép hoặc xây gạch có niên hạn sử dụng quy định trên 80 năm; Bao che nhà và tường ngăn cách các phòng bằng bê tông cốt thép hoặc xây gạch; Mái bằng bê tông cốt thép hoặc lợp ngói, có hệ thống cách nhiệt tốt; Vật liệu hoàn thiện trong và ngoài nhà tốt; Tiện nghi sinh hoạt đầy đủ, tiện lợi, không hạn chế số tầng')
insert into LoaiNha values (N'Nhà cấp II', N'Kết cấu chịu lực bằng bê tông cốt thép hoặc xây gạch có niên hạn sử dụng quy định trên 70 năm; Bao che nhà và tường ngăn cách các phòng bằng bê tông cốt thép hoặc xây gạch; Mái bằng bê tông cốt thép hoặc mái ngói bằng Fibroociment; Vật liệu hoàn thiện trong ngoài nhà tương đối tốt; Tiện nghi sinh hoạt đầy đủ. Số tầng không hạn chế.')
insert into LoaiNha values (N'Nhà cấp III', N'Kết cấu chịu lực kết hợp giữa bê tông cốt thép và xây gạch hoặc xây gạch. Niên hạn sử dụng trên 40 năm; Bao che nhà và tường ngăn bằng gạch; Mái ngói hoặc Fibroociment; Vật liệu hoàn thiện bằng vật liệu phổ thông;Tiện nghi sinh hoạt bình thường, trang bị xí, tắm bằng vật liệu bình thường. Nhà cao tối đa là 2 tầng.')
insert into LoaiNha values (N'Nhà cấp IV', N'Kết cấu chịu lực bằng gạch, gỗ. Niên hạn sử dụng tối đa 30 năm; Tường bao che và tường ngăn bằng gạch (tường 22 hoặc 11 cm); Mái ngói hoặc Fibroociment; Vật liệu hoàn thiện chất lượng thấp;')
insert into LoaiNha values (N'Nhà tạm', N'Kết cấu chịu lực bằng gỗ, tre, vầu; Bao quanh toocxi, tường đất; Lợp lá, rạ; Những tiện nghi, điều kiện sinh hoạt thấp')

--Nhập thông tin bảng Loại địa ốc
insert into LoaiDiaOc values (N'Nhà đất thổ cư', N'Nhà có giấy tờ là đất thổ cư')
insert into LoaiDiaOc values (N'Chung cư', N'Cho thuê căn hộ')
insert into LoaiDiaOc values (N'Văn phòng cho thuê', N'Văn phòng sạch đẹp để cho thuê')
insert into LoaiDiaOc values (N'Đất nền nhà phố', N'Đất nền bán để xây nhà')
insert into LoaiDiaOc values (N'Đất nền nhà biệt thự', N' Đất nền xây biệt thự')


--Nhập thông tin bảng Địa ốc (Phụ thuộc vào Loại nhà, Loại địa ốc, Khách hàng)
insert into DiaOc values (1, 1, 1, N'177 Tô Ngọc Vân, phường Linh Đông, quận Thủ Đức, Tp. HCM', 1000, 600, N'Đông Bắc', 100, 10, 60, 10, 2, N'Nhà có đầy đủ trang thiết bị tiện nghi: Tủ lạnh,Máy giặt, Nội thất', 5000000000, 0, 0,'')
insert into DiaOc values (1, 1, 3, N'20 Kha Vạn Cân, phường Linh Chiểu, quận Thủ Đức, Tp. HCM', 500, 400, N'Tây', 100, 5, 40, 10, 1, N'Nhà sạch đẹp, thoáng mát. Đầy đủ tiện nghi. Rộng rãi thoải mái.', 1000000000, 0, 0,'')
insert into DiaOc values (2, 2, 2, N'135 Võ Văn Ngân, phường Bình Thọ, quận Thủ Đức, Tp. HCM', 800, 800, N'Đông Nam', 80, 10, 80, 10, 1, N'Nhà có đầy đủ tiện nghi, có hệ thống cách nhiệt tốt, Vật liệu hoàn thiện trong và ngoài nhà', 3000000000, 0, 0,'')
insert into DiaOc values (6, 5, 1, N'27 Linh Trung, phường Trung, quận Thủ Đức, Tp. HCM', 1000, 800, N'Đông', 100, 10, 80, 10, 3, N'Nhà có khuôn viên riêng, có sân vườn. Hệ thống cách âm, cách nhiệt khá tốt', 7000000000, 0, 0,'')
insert into DiaOc values (8, 3, 5, N'100 Điện Biên Phủ, phường 8, quận Bình Thạnh, Tp. HCM', 800, 600, N'Tây Bắc', 80, 10, 60, 10, 2, N'Văn phòng sang trọng, sạch đẹp. Vị trí mặt tiền', 3000000000, 0, 0,'')
insert into DiaOc values (8, 2, 3, N'123 Hai Bà Trung, phường Tân Định, quận 1, Tp. HCM', 1000, 1000, N'Nam', 100, 10, 100, 10, 5, N'Chung cư tiện nghi, nhiều phòng, rộng rãi, trang thiết bị đầy đủ', 8000000000, 0, 0,'')
insert into DiaOc values (10, 4, 2, N'02 Lê Quang Định, phườn 3, quận Gò Vấp, Tp. HCM', 1000, 600, N'Đông Bắc', 100, 10, 60, 10, 3, N'Nhà có đầy đủ trang thiết bị tiện nghi: Tủ lạnh, Mày giặt, Nội thất đầy đủ. Trang trọng, sạch sẽ', 6000000000, 0, 0,'')
insert into DiaOc values (11, 1, 1, N'200 Nguyễn Văn Đậu, phường 8, quận Phú Nhuận, Tp. HCM', 800, 700, N'Tây Nam', 80, 10, 70, 10, 3, N'Nhà có tường bao quanh, an toàn và thoải mái', 4000000000, 0, 0,'')
insert into DiaOc values (12, 3, 5, N'200 Tô Ngọc Vân, phường Linh Đông, quận Thủ Đức, Tp. HCM', 600, 600, N'Bắc', 60, 10, 60, 10, 2, N'Văn phòng đẹp, ánh sáng đầy đủ.', 3000000000, 0, 0,'')
insert into DiaOc values (15, 1, 4, N'23 Nguyễn Hữu Cảnh, phường 8, quận Bình Thạnh, Tp. HCM', 300, 300, N'Đông', 30, 10, 30, 10, 3, N'Nhà đẹp, thoáng mát, rộng rãi, trang thiết bị đầy đủ, nội thất khá đẹp', 4000000000, 0, 0,'')

--Nhập thông tin bảng Giấy tờ (Phụ thuộc vào Địa ốc)
insert into GiayTo(MaDiaOc, TenGiayTo) values (1, N'Sổ đỏ')
insert into GiayTo(MaDiaOc, TenGiayTo) values (2, N'Giấy chứng nhận đất hoang')
insert into GiayTo(MaDiaOc, TenGiayTo) values (3, N'Sổ đỏ')
insert into GiayTo(MaDiaOc, TenGiayTo) values (4, N'Sổ đỏ')
insert into GiayTo(MaDiaOc, TenGiayTo) values (5, N'Giấy chứng nhận đất hoang')
insert into GiayTo(MaDiaOc, TenGiayTo) values (7, N'Sổ đỏ')
insert into GiayTo(MaDiaOc, TenGiayTo) values (9, N'Sổ đỏ')

--Nhập thông tin bảng Phòng ban
insert into PhongBan values (N'Phòng quảng cáo', N'Thực hiện tiếp nhận quảng cáo, chụp hình, viết bài, đăng quảng cáo')
insert into PhongBan values (N'Phòng hành chính - tổ chức', N'Thực hiện chức năng quản lý, điều hành')
insert into PhongBan values (N'Phòng kế toán', N'Thực hiện công tác kế toán tài chính')
insert into PhongBan values (N'Phòng tài chính - kế hoạch', N'Thực hiện chức năng quản lý và điều hành công việc thuộc lĩnh vực tài chính, kế hoạch')
insert into PhongBan values (N'Phòng kinh doanh', N'Xây dựng chiến lược kinh doanh')

--Nhập thông tin bảng Loại nhân viên
INSERT INTO LoaiNhanVien VALUES (N'Nhân viên quảng cáo', N'Được thêm, xóa sửa các màn hình: khách hàng, địa ốc, giấy tờ, quản lý phiếu đăng ký, hình ảnh, bài viết, phiếu gia hạn, phiếu thu tiền')
INSERT INTO LoaiNhanVien VALUES (N'Trưởng phòng quảng cáo', N'Được thêm xóa sửa các màn hình: khách hàng, địa ốc, Loại hình quảng cáo, Giá tiền quảng cáo, Báo chí, Loại nhà, loại địa ốc viên. Kiểm duyệt: Giấy tờ địa ốc, bài viết, hình ảnh')
INSERT INTO LoaiNhanVien VALUES (N'Nhân viên kế toán', N'Được xem thông tin tất cả các form không bị ẩn. Riêng form: quản lý phiếu đăng ký, phiếu gia hạn, phiếu thu tiền thì nó được sử dụng chức năng “Xuất hóa đơn”')
INSERT INTO LoaiNhanVien VALUES (N'Ban giám đốc', N'Quản lý điều hành chung')
INSERT INTO LoaiNhanVien VALUES (N'Nhân viên chăm sóc khách hàng', N'Chỉ được xem thông tin ')

--Nhập thông tin bảng Bằng cấp
insert into BangCap values (N'Không có bằng cấp')
insert into BangCap values (N'Trung cấp')
insert into BangCap values (N'Cao đẳng')
insert into BangCap values (N'Đại học')
insert into BangCap values (N'Thạc sĩ')
insert into BangCap values (N'Tiến sĩ')

--Nhập thông tin bảng Nhân viên (Phụ thuộc Loại Nhân viên, Phòng ban( ==> Mật khẩu phải mã hóa
insert into NhanVien values (1, 1, N'Trần Thị Xuân Thư','251043331', 1, '1996-11-11', N'Khu phố 6, phường Linh Trung, quận Thủ Đức', '01694122657', 'minhtranguit@gmail.com', 'minhtranguit', '123124', 1)
insert into NhanVien values (1, 1, N'Lê Thị Nga','235624693', 1, '1990-05-01', N'khu phố Tân Lập, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương', '01653217568', 'ngale@gmail.com', 'ngale', '123125', 2)
insert into NhanVien values (2, 2, N'Nguyễn Văn Vinh','369852147', 0, '1992-03-03', N'Võ Thị Sáu, phường 3, quận 3', '01237569812', 'nguyenvinh@gmail.com', 'nguyenvinh', '123126', 3)
insert into NhanVien values (2, 2, N'Trần Xuân Minh','156789245', 0, '1993-01-11', N'Lý Thường Kiệt, phường 5, quận Tân Bình', '0932568954', 'minhtran@gmail.com', 'minhtran', '123127', 1)
insert into NhanVien values (3, 3, N'Hồ Bích Phượng','125369785', 1, '1990-03-09', N'Kha Vạn Cân, phường Linh Đông, quận Thủ Đức', '0935658976', 'bichphuong@gmail.com', 'bichphuong', '123128', 2)
insert into NhanVien values (3, 3, N'Nguyễn Văn Phong','235687164', 0, '1995-05-06', N'Nguyễn Đình Chiểu, phường 2, quận 3', '0987256348', 'phongnguyen@gmail.com', 'phongnguyen', '123129', 0)
insert into NhanVien values (4, 4, N'Trần Thị Linh','235746358', 1, '1994-08-07', N'Điện Biên Phủ, phường 9, quận Bình Thạnh', '01256891165', 'linhtran@gmail.com', 'linhtran', '123130', 1)
insert into NhanVien values (4, 4, N'Hoàng Văn Huy','223585449', 0, '1997-10-12', N'Lê Thị Định, phường 3, quận Gò Vấp', '01659994523', 'hvhuy@gmail.com', 'hvhuy', '123131', 1)

--Nhập thông tin bảng Bằng cấp
INSERT INTO BangCap	VALUES('Đại học')
INSERT INTO BangCap	VALUES('Cao đẳng')
INSERT INTO BangCap	VALUES('Trung cấp')

--Nhập thông tin bảng Quyền Hạn (Cái này Trang làm cho)
INSERT INTO QuyenHan VALUES (N'Chỉnh sửa - giám đốc', N'Được thêm, xóa, sửa các màn hình: Phân quyền, Phòng ban, Nhân viên, loại nhân viên')
INSERT INTO QuyenHan VALUES (N'Điều hành', N'Thay đổi quy định, Xem báo cáo thống kê, phân quyền')
INSERT INTO QuyenHan VALUES (N'Chỉnh sửa - trưởng phòng QC', N'Được thêm xóa sửa các màn hình trừ nhân viên')
INSERT INTO QuyenHan VALUES (N'Chỉnh sửa - nhân viên quảng cáo', N'Được thêm, xóa sửa các màn hình: khách hàng, địa ốc, giấy tờ, quản lý phiếu đăng ký, hình ảnh, bài viết, phiếu gia hạn, phiếu thu tiền ')
INSERT INTO QuyenHan VALUES (N'Xuất hóa đơn', N'Các form quản lý phiếu đăng ký, phiếu gia hạn, phiếu thu tiền thì nó được sử dụng chức năng Xuất hóa đơn')
INSERT INTO QuyenHan VALUES (N'Xem thông tin', N'Xem thông tin những form không bị giới hạn')
INSERT INTO QuyenHan VALUES (N'Kiểm duyệt chung', N'Kiểm duyệt tất cả thông tin')
INSERT INTO QuyenHan VALUES (N'Kiểm duyệt QC', N'Kiểm duyệt: Giấy tờ địa ốc, bài viết, hình ảnh')

--Nhập thông tin bảng PhanQuyen 
INSERT INTO PhanQuyen VALUES (4, 1)
INSERT INTO PhanQuyen VALUES (3, 2)
INSERT INTO PhanQuyen VALUES (8, 2)
INSERT INTO PhanQuyen VALUES (5, 3)
INSERT INTO PhanQuyen VALUES (1, 4)
INSERT INTO PhanQuyen VALUES (2, 4)
INSERT INTO PhanQuyen VALUES (7, 4)
INSERT INTO PhanQuyen VALUES (6, 5)

--Nhập thông tin bảng Vị Trí
insert into ViTri values (N'Trên cùng', N'Đặt phía trên cùng, ngay dưới tiêu đề báo / website')
insert into ViTri values (N'Dưới cùng', N'Đặt cuối tờ báo / website')
insert into ViTri values (N'Ở giữa', N'Đặt ở giữa tờ báo / website')
insert into ViTri values (N'Thanh navbar trái', N'Đặt bên lề trái website / trang báo')
insert into ViTri values (N'Thanh navbar phải', N'Đặt bên lề phải website / trang báo')

--Nhập thông tin bảng Loại quảng cáo (Bảng này đủ rồi, NGuyệt không cần thêm nữa)
insert into LoaiQuangCao values (N'Quảng cáo tờ bướm', N'Quảng cáo dưới dạng tờ rơi')
insert into LoaiQuangCao values (N'Quảng cáo trên báo', N'Đăng quảng cáo địa ốc trên các tờ báo nổi tiếng: Báo tuổi trẻ, báo Người lao động,..')
insert into LoaiQuangCao values (N'Quảng cáo trên website', N'Đăng quảng cáo địa ốc trên các trang website của công ty và các website về bất động sản khác,...')

--Nhập thông tin bảng Giá tiền quảng cáo (Nguyệt phụ thuộc vào số lượng phát hành tối thiểu / tối đa, dựa vào loại hình quảng cáo mà tính đơn giá cho phù hợp. Ví dụ quảng cáo trên website đắt tiền hơn tờ bướm. In từ 0 - 50 tờ giá 500.000đ. Nhưng in từ 50 - 100 thì giá chỉ 800.000đ)
insert into GiaTienQuangCao values (1, 1, 50, 100, 1, 3, 500000)
insert into GiaTienQuangCao values (1, 2, 50, 100, 1, 3, 200000)
insert into GiaTienQuangCao values (1, 3, 50, 100, 1, 3, 400000)
insert into GiaTienQuangCao values (1, 4, 50, 100, 1, 3, 300000)
insert into GiaTienQuangCao values (1, 5, 50, 100, 1, 3, 300000)
insert into GiaTienQuangCao values (2, 1, 20, 100, 1, 2, 700000)
insert into GiaTienQuangCao values (2, 2, 20, 100, 1, 2, 400000)
insert into GiaTienQuangCao values (2, 3, 20, 100, 1, 2, 600000)
insert into GiaTienQuangCao values (2, 4, 20, 100, 1, 2, 500000)
insert into GiaTienQuangCao values (2, 5, 20, 100, 1, 2, 500000)
insert into GiaTienQuangCao values (3, 1, 30, 100, 1, 3, 1000000)
insert into GiaTienQuangCao values (3, 2, 30, 100, 1, 3, 500000)
insert into GiaTienQuangCao values (3, 3, 30, 100, 1, 3, 800000)
insert into GiaTienQuangCao values (3, 4, 30, 100, 1, 3, 700000)
insert into GiaTienQuangCao values (3, 5, 30, 100, 1, 3, 700000)

--Nhập thông tin bảng PhieuDangKy (Phụ thuộc bảng Khách hàng, Địa ốc, Nhân viên)
insert into PhieuDangKy values (1, 1, 1, '2017-12-11', '2018-01-01', '2018-02-01', 0, 0, 1000000,'')
insert into PhieuDangKy values (1, 2, 1, '2017-11-11', '2018-01-01', '2018-02-01', 0, 0, 5000000,'')
insert into PhieuDangKy values (2, 3, 5, '2017-10-02', '2018-01-01', '2018-02-01', 0, 0, 20000000,'')
insert into PhieuDangKy values (6, 4, 3, '2017-12-25', '2018-01-01', '2018-02-01', 0, 0, 50000000,'')
insert into PhieuDangKy values (8, 5, 2, '2017-11-05', '2018-01-01', '2018-02-01', 0, 0, 40000000,'')
insert into PhieuDangKy values (8, 5, 6, '2017-09-23', '2018-01-01', '2018-02-01', 0, 0, 10000000,'')
insert into PhieuDangKy values (10, 7, 8, '2017-12-11', '2018-01-01', '2018-02-01', 0, 0, 80000000,'')
insert into PhieuDangKy values (11, 8, 5, '2017-10-20', '2018-01-01', '2018-02-01', 0, 0, 10000000,'')
insert into PhieuDangKy values (12, 9, 4, '2017-06-19', '2018-01-01', '2018-02-01', 0, 0, 200000000,'')
insert into PhieuDangKy values (15, 10, 7, '2017-08-08', '2018-01-01', '2018-02-01', 0, 0, 60000000,'')

--Nhập thông tin bảng Chi tiết quảng cáo (Phụ thuộc bảng Phiếu đăng ký, Loại quảng cáo, Vị tri). Phụ thuộc vào loại quảng cáo mà có thuộc tính khác nhau
-- Ví dụ: Quảng cáo tờ bướm. Thì chỉ có MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc (Đơn vị mét vuông) TrangThaiKiemDuyet
-- Ví dụ: Quảng cáo trên báo và website. Thì có MMaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (1, 2, 1, '2018-01-01', '2018-02-01', 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet) values (2, 1 , 50, 0.5, 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (3, 3, 2, '2018-01-01', '2018-02-01', 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (4, 2, 3, '2018-01-01', '2018-02-01', 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet) values (5, 1 , 70, 0.5, 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (6, 3, 5, '2018-01-01', '2018-02-01', 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (7, 2, 5, '2018-01-01', '2018-02-01', 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet) values (8, 1 , 100, 0.4, 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc, TrangThaiKiemDuyet) values (9, 1 , 80, 0.5, 0)
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (10, 3, 4, '2018-01-01', '2018-02-01', 0)

--Nhập thông tin bảng Hình ảnh, Chi tiết hình ảnh (Để làm sau)

--Nhập thông tin bảng Bài viết (Phụ thuộc bảng Chi tiết quảng cáo, Mã nhân viên). Tham khảo: batdongsan.com, rever.com
insert into BaiViet values (1, 1, N'Cần bán nhà hẻm Lý Thường Kiệt, thổ cư 100%, có sổ riêng, nhà hiện có 1 mê có thể lên thêm mê nữa, gồm 2PN, 1 PK, 1bếp, 1VS, 1 phòng thờ, 1 gác xép, nhà còn mới vô có thể ở liền, gần chợ, trường học cấp 1 2, ngay trung tâm thành phố, giao thông thuận tiện đi lại, hẻm rộng, ngay ủy ban phường và trạm y tế, đảm bảo an ninh.', 0,'')
insert into BaiViet values (2, 1, N'Bán nhà thổ cư 1 mê khu trung cao - thiết kế hiện đại - giá 1 tỷ 950 triệu 0983082789.
									Bán nhà đẹp khu Trung Cao - đường Trương Đăng Quế (đường thông từ Trần Văn Phụ ra Y Moan).
									Diện tích: 4,5 x 30m.
									Đường dầu rộng rãi 8m. Khu dân cư sầm uất, thích hợp kinh doanh buôn bán.
									Sổ hồng thổ cư.
									Hướng: Đông nam.
									Nhà còn mới, vào ở ngay không cần sửa sang.
									Thiết kế hiện đại 1 mê gồm: Sân để ô tô, phòng khách - phòng bếp. 3 phòng ngủ (1 phòng tầng trệt 2 phòng tầng 1). 2 nhà vệ sinh. Sân thượng phơi đồ. Phòng thờ.
									Hệ thống cửa, cầu thang, tủ... Đều bằng gỗ nhóm 1 (gỗ hương, cam xe nguyên tấm). Hệ thống cửa chính 2 lớp kiên cố.
									Cách chợ Phan Chu Trinh 400m, trường mầm non Kitty 500m, trường tiểu học Nguyễn Đức Cảnh 300m. Gần ngay ủy ban phường Tân Lợi. Trong bán kính 1km đầy đủ tất cả các tiện ích xã hội.
									Khu dân cư dân trí cao. Kinh doanh buôn bán thuận lợi.
									Giá bán: 1 tỷ 950 triệu.
									Liên hệ: 0983 082 789 Hồng Oanh.', 0,'')
insert into BaiViet values (3, 2, N'Nhà song song Phan Chu Trinh (có sân ô tô) – Dt: 5x26m (hướng đông nam) – giá tốt 2,550 tỷ!!!
									** * ** 
									Bán nhà mặt tiền đường song song Phan Chu Trinh – khu dân trí cao và nằm ngay trung tâm Thành phố Buôn Ma Thuột. 
									Nhà xây kiên cố - có sân rộng để xe ô tô thoải mái. 
									Đường nhựa trước nhà rộng 8m – xe ô tô né nhau. 
									Nhà nằm ngay trung tâm tiếp cận nhanh các tiện ích: Trường mầm non Quốc Tế, Bệnh viện Thành Phố, cách siêu thị Co.op Mart chỉ 3 phút,… 
									Nhà có 1 phòng khách, 2 phòng ngủ, bếp và công trình phụ sạch sẽ. 
									- Dt: 5x26m 
									- Hướng: Đông Nam 
									- Thổ cư 100% 
									Giá: 2 tỷ 550 triệu 
									Liên hệ: Bảo Thiện 
									SĐT: 0913433977 
									Đ/c: BĐS Đại Nam – 27 Trần Quang Khải – P. Thắng Lợi', 0,'')
insert into BaiViet values (4, 1, N'Vì gia đình đã chuyển ra Hà Nội sinh sống không có người trông nom nên tôi cần bán lại căn biệt thự.
									Vị trí rất gần quảng trường (chỉ 500m).
									Diện tích: 16x16m (rộng rãi thoáng đãng).
									Hướng: Tây Nam.
									Pháp lý: Thổ cư 100%.
									Nhà biệt thự thiết kế đẹp, có gara rộng, có sân vườn, 3pn tiện nghi đầy đủ giếng trường thông thoáng.
									Giá: 6,6 tỷ thương lượng với khách thiện chí.
									Vui lòng liên hệ: 0913433977 Bảo Thiện để xem nhà và nhận thêm thông tin nhà đất.', 0,'')
insert into BaiViet values (5, 2, N'Cần tiền ngân hàng bán gấp căn nhà hẻm lớn lý tự trọng ngay chợ Tân An Buôn Ma Thuột. Nhà cấp 4 bao gồm 3 phòng ngủ, 1 phòng thờ, gác lửng.
									Diện tích 6x22m.
									Thổ cư 100%.
									Hướng Đông Nam.
									Giá bán 2,85 tỷ.
									Liên hệ 0941512299.', 0,'')
insert into BaiViet values (6, 2, N'Nhà đẹp mê lửng hẻm Ama Khê giá 1,7 tỷ.
									Vị trí đẹp, gần ngay trung tâm thành phố, dân cư đông đúc, gần các tiện ích xã hội, giao thông thuận tiện.
									Nhà đẹp mê lửng gồm 1 phòng khách, 2 phòng ngủ, phòng thờ, bếp và WC.
									Diện tích: 5x23m.
									Hướng: Nam.
									Pháp lý: Thổ cư.
									Giá: 1,7 tỷ.
									Ai có nhu cầu vui lòng liên hệ 0916285679 hoặc 0914430377 gặp Châu Nguyệt.
									Cảm ơn vì đã đọc tin nhé!', 0,'')
insert into BaiViet values (7, 1, N'- Tôi cần bán căn nhà nằm trong khu tái định cư Mai Xuân Thưởng gần thủy điện BuônKóp. Nhà mới thiết kế hiện đại, thông thoáng, phía trước nhà quy hoạch hoa viên, Mặt tiền hướng về phía trung tâm thành phố.
									- Kết cấu: 1 trệt và 1 lầu, tầng trệt gồm: Sân để ô tô, phòng khách và bếp phía trước, WC và 1 phòng ngủ. Tầng 1 gồm: Phòng thờ, 1 phòng ngủ, WC, sân thưởng trước và sau.
									- Diện tích: 5x22m.
									- Pháp lý: Thổ cư 100%.
									- Hướng: Đông.
									- Gía: 2,1 tỷ.', 0,'')
insert into BaiViet values (8, 2, N'Văn phòng chuyên cho thuê và chuyển nhượng với hơn 1000 căn có sẵn, cập nhật giỏ hàng mới nhất hotline: 0903624456 Tâm. 
									Giá căn hộ: 
									+ 1 phòng ngủ 48m2, 53m2: 
									Giá thuê: 13 - 17 triệu/tháng. 
									Giá bán: 2,450 tỷ. 
									+ 2 phòng ngủ: Diện tích 70m2, 76m2, 80m2, 90m2. 
									Giá: 16 tr - 22 triệu/tháng. 
									Giá bán: 3.3 tỷ. 
									+ 3 phòng ngủ: Diện tích 114m2, 120m2, 135m2. 
									Giá: 18 tr - 25 triệu/tháng. 
									Giá bán: 4,5 tỷ. 
									+ 4 phòng ngủ: 140m - 187m2. 
									Giá bán: 8,5 tỷ. 
									Giá: 28 triệu - 35 triệu/tháng. 
									Shophoues: 60 triệu - 100 triệu tùy diện tích và hướng view. 
									Penhoues: 45 triệu - 60 triệu tùy diện tích và hướng view. 
									
									Ngoài ra chúng tôi còn cho thuê dịch vụ căn hộ thời gian ngắn hạn. 
									+ Nhận ký gửi chủ nhà cho thuê mua bán căn hộ. 
									+ Ngoài cho thuê Tâm còn bán căn hộ Vin đã bàn giao nhà giá tốt nhất từ 1 - 4PN, giá tốt nhất đến KH. 
									Liên hệ: 0903624456 Tâm (đảm bảo quyền lợi KH tốt nhất).', 0,'')
insert into BaiViet values (9, 2, N'Aparent (căn hộ cho thuê) là hệ thống các tòa nhà, toàn bộ các căn hộ trong đó được thiết kế để cho thuê.
									Chúng tôi có các căn hộ khép kín, đủ tiện nghi gồm:
									- Loại 2 phòng ngủ + phòng khách.
									- Loại 1 phòng ngủ + phòng khách.
									- Loại thiết kế dạng Studio (Studio Apartment).
									Các căn hộ đều được thiết kế tiện nghi, khép kín có khu bếp nấu ăn, được lắp đặt các thiết bị theo tiêu chuẩn cuộc sống hiện đại, rất phù hợp với các chuyên viên làm việc, công tác tại Thủ đô, người nước ngoài hoặc làm nhà công vụ.
									Tiêu chuẩn đồng nhất của căn hộ cho thuê (Aparent):
									- Thiết kế hiện đại.
									- Sảnh chung rộng rãi.
									- Thang máy tiện nghi.
									- Ban công thoáng mát.
									- Vệ sinh nóng lạnh.
									- Miễn phí internet và truyền hình cáp.
									- Khu bếp tiện dụng.
									- Đầy đủ nội thất để phục vụ nhu cầu sinh hoạt: Điều hòa 2 chiều, tủ lạnh, máy giặt, lò vi sóng, tivi, bàn ghế ăn, giường tủ.
									- Hệ thống an ninh an toàn tuyệt đối: Camera sảnh, camera cầu thang, đội ngũ nhân viên bảo vệ trực 24/24. Trông xe miễn phí.
									- Các khu nhà được thực hiện đúng luật về phòng cháy chữa cháy.
									- Khu nhà luôn được dọn dẹp sạch sẽ, riêng biệt, yên tĩnh, đảm bảo cho những khách hàng đòi hỏi cao về không gian cá nhân.
									Địa điểm và giá:
									Ngọc Lâm, Long Biên, Hà Nội.
									Loại phòng:
									+ Phòng studio: 5.000.000/5.500.000 VNĐ/tháng.
									+ Loại 1 phòng ngủ + 1 phòng khách: 6.000.000 VNĐ/tháng - 6.500.000 VNĐ/tháng.
									+ Loại 2 phòng ngủ + 1 phòng khách: 7.500.000 VNĐ/tháng - 7.000.000 VNĐ/tháng.

									Hồng Hà chuyên cho thuê căn hộ tiêu chuẩn Aparent.
									Công ty Cổ phần Đầu tư và Thương mại Hồng Hà.
									Trụ sở: 48/66 - Ngọc Lâm - Long Biên - Hà Nội.
									Tel: 024.66816658 - Mobile: 0969252094 (Ms Trang).
									Email: trangnguyen@aparent.vn
									Xem chi tiết: www.aparent.com.vn', 0,'')
insert into BaiViet values (10, 1, N'Tôi vừa nhận bàn giao căn hộ chung cư tại Vinhome Gardenia Hàm Nghi. Do không có nhu cầu sử dụng nên muốn cho thuê ổn định lâu dài ưu tiên hộ gia đình.
									Căn hộ 54m2, 01 phòng ngủ. Đã có đầy đủ đồ cơ bản gồm bàn bếp, tủ bếp, bếp từ, nóng lạnh điều hòa, giường tủ quần áo, rèm cửa, giàn phơi. Giá tôi cho thuê 8 triệu/th.
									Căn hộ 82m2 thiết kế 02 phòng ngủ, 01 phòng khách, 01 bếp. Đã có đầy đủ đồ cơ bản gồm bàn bếp, tủ bếp, bếp từ, giường tủ quần áo, điều hòa, nóng lạnh, rèm cửa, giàn phơi. Giá tôi cho thuê 10 triệu/th.
									Còn một số căn chủ nhà gửi cần cho thuê cùng giá vui lòng gọi để xem nhà. Hình thức Thanh toán 3 tháng đặt cọc 1 tháng nhận nhà ngay. Liên hệ A Quang số điện thoại 0981.808.979 hoặc 0912.703.021. Miễn môi giới.', 0,'')

--Nhập thông tin bảng Quy định (Bảng này đủ rồi, NGuyệt không cần thêm nữa)
insert into QuyDinh values (0.1, 60, 1000, 2, 0.8, 1.3)


-------------------------------------
-- Enable all constraints
exec sp_MSforeachtable @command1="print '?'", @command2="ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"

