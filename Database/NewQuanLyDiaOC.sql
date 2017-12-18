
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
	TrangThaiKiemDuyet	bit				default 0,
	TrangThaiMuaBan		bit				default 0,
	
	primary key (MaDiaOc)
)


-------------------------------------------
-- Bảng chi tiết giấy tờ
create table GiayTo(
	MaGiayTo			int				identity (1,1),			
	MaDiaOc				int				not null,
	TenGiayTo			nvarchar(100)	not null,
	ScanGiayTo			varchar(500),
	TrangThaiKiemDuyet	bit				default 0,
	
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
	MaViTri				int,
	NgayBatDau			date				not null,
	NgayKetThuc			date				not null,
	SoLuongPhatHanh		int,
	KichThuoc			float,
	TrangThaiKiemDuyet	int					default 0 not null,

	primary key (MaChiTietQuangCao)
)


-- Bảng hình ảnh
create table HinhAnh(
	MaHinhAnh			int				identity (1,1),
	MaPhieuDangKy		int				not null,
	MaNhanVien			int				not null,
	NgayHenChupAnh		date			not null,
	NgayChupAnh			date			not null,
	TrangThaiKiemDuyet	int				not null,
	
	primary key (MaHinhAnh)
)

-------------------------------------------
-- Bảng chi tiết hình ảnh
create table ChiTietHinhAnh(
	MaChiTietHinhAnh		int				identity (1,1),	
	MaHinhAnh				int				not null,
	HinhAnh					varchar(500),
	MoTaHinhAnh				nvarchar(100)	not null
	
	primary key (MaChiTietHinhAnh)
)

-- Bảng bài viết
create table BaiViet(
	MaBaiViet			int				identity (1,1),
	MaChiTietQuangCao	int				not null,
	MaNhanVien			int				not null,
	NoiDungBaiViet		nvarchar(1000)	not null,
	TrangThaiKiemDuyet	int				not null,
	
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

--Nhập thông tin bảng Loại nhà
insert into LoaiNha values (N'Nhà cấp 4', N'Nhà bình dân, giá rẻ,...')
insert into LoaiNha values (N'Biệt thự', N'Nhà có khuôn viên, giá cao,...')

--Nhập thông tin bảng Loại địa ốc
insert into LoaiDiaOc values (N'Nhà đất thổ cư', N'Nhà có giấy tờ là đất thổ cư')
insert into LoaiDiaOc values (N'Chung cư', N'Cho thuê căn hộ')

--Nhập thông tin bảng Địa ốc (Phụ thuộc vào Loại nhà, Loại địa ốc, Khách hàng)
insert into DiaOc values (1, 1, 1, N'177 Tô Ngọc Vân, phường Linh Đông, quận Thủ Đức, Tp. HCM', 1000, 600, N'Đông Bắc', 100, 10, 60, 10, 2, N'Nhà có đầy đủ trang thiết bị tiện nghi: Tủ lạnh,...', 5000000000, 0, 0)

--Nhập thông tin bảng Giấy tờ (Phụ thuộc vào Địa ốc)
insert into GiayTo(MaDiaOc, TenGiayTo, TrangThaiKiemDuyet) values (1, 'Sổ đỏ', 0)

--Nhập thông tin bảng Phòng ban
insert into PhongBan values (N'Phòng quảng cáo', N'Thực hiện tiếp nhận quảng cáo, chụp hình, viết bài, đăng quảng cáo')

--Nhập thông tin bảng Loại nhân viên
insert into LoaiNhanVien values (N'Nhân viên quảng cáo', N'Tiếp nhận thông tin quảng cáo, trao đổi với khách hàng, đăng quảng cáo')

--Nhập thông tin bảng Nhân viên (Phụ thuộc Loại Nhân viên, Phòng ban( ==> Mật khẩu phải mã hóa
insert into NhanVien values (1, 1, N'Trần Thị Xuân Thư','251043331', 1, '1996-21-11', N'Khu phố 6, phường Linh Trung, quận Thủ Đức', '01694122657', 'minhtranguit@gmail.com', 'minhtranguit', '123124')

--Nhập thông tin bảng Quyền Hạn (Cái này Trang làm cho)
insert into QuyenHan values (N'Nghiệp vụ tiếp nhận thông tin quảng cáo', N'Thêm, xóa, sửa thông tin quảng cáo')

--Nhập thông tin bảng PhanQuyen (Cái này Trang làm cho)
insert into PhanQuyen values (1, 1)

--Nhập thông tin bảng Vị Trí
insert into ViTri values (N'Trên cùng', N'Đặt phía trên cùng, ngay dưới tiêu đề báo / website')
insert into ViTri values (N'Thanh navbar trái', N'Đặt bên lề trái website / trang báo')

--Nhập thông tin bảng Loại quảng cáo (Bảng này đủ rồi, NGuyệt không cần thêm nữa)
insert into LoaiQuangCao values (N'Quảng cáo tờ bướm', N'Quảng cáo dưới dạng tờ rơi')
insert into LoaiQuangCao values (N'Quảng cáo trên báo', N'Đăng quảng cáo địa ốc trên các tờ báo nổi tiếng: Báo tuổi trẻ, báo Người lao động,..')
insert into LoaiQuangCao values (N'Quảng cáo trên website', N'Đăng quảng cáo địa ốc trên các trang website của công ty và các website về bất động sản khác,...')

--Nhập thông tin bảng Giá tiền quảng cáo (Nguyệt phụ thuộc vào số lượng phát hành tối thiểu / tối đa, dựa vào loại hình quảng cáo mà tính đơn giá cho phù hợp. Ví dụ quảng cáo trên website đắt tiền hơn tờ bướm. In từ 0 - 50 tờ giá 500.000đ. Nhưng in từ 50 - 100 thì giá chỉ 800.000đ)
insert into GiaTienQuangCao values (1, 1, 50, 100, 1, 3, 500000)

--Nhập thông tin bảng PhieuDangKy (Phụ thuộc bảng Khách hàng, Địa ốc, Nhân viên)
insert into PhieuDangKy values (1, 1, 1, '2017-12-11', '2018-01-01', '2018-02-01', 0, 0, 1000000, 500000, 500000)

--Nhập thông tin bảng Chi tiết quảng cáo (Phụ thuộc bảng Phiếu đăng ký, Loại quảng cáo, Vị tri). Phụ thuộc vào loại quảng cáo mà có thuộc tính khác nhau
-- Ví dụ: Quảng cáo tờ bướm. Thì chỉ có MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc (Đơn vị mét vuông) TrangThaiKiemDuyet
-- Ví dụ: Quảng cáo trên báo và website. Thì có MMaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (1, 2, 1, '2018-01-01', '2018-02-01', 0)

--Nhập thông tin bảng Hình ảnh, Chi tiết hình ảnh (Để làm sau)

--Nhập thông tin bảng Bài viết (Phụ thuộc bảng Chi tiết quảng cáo, Mã nhân viên). Tham khảo: batdongsan.com, rever.com
insert into BaiViet values (1, 1, N'Nguyệt lên mạng lấy một số bài viết từ mấy trang bất động sản bỏ vào nha', 0)

--Nhập thông tin bảng Quy định (Bảng này đủ rồi, NGuyệt không cần thêm nữa)
insert into QuyDinh values (0.1, 60, 1000, 2, 0.8, 1.3)


-------------------------------------
-- Enable all constraints
exec sp_MSforeachtable @command1="print '?'", @command2="ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"

