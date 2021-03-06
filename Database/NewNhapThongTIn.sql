
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
insert into DiaOc values (1, 1, 1, N'177 Tô Ngọc Vân, phường Linh Đông, quận Thủ Đức, Tp. HCM', 1000, 600, N'Đông Bắc', 100, 10, 60, 10, 2, N'Nhà có đầy đủ trang thiết bị tiện nghi: Tủ lạnh,...', 5000000000, 0, 0,'')

--Nhập thông tin bảng Giấy tờ (Phụ thuộc vào Địa ốc)
insert into GiayTo(MaDiaOc, TenGiayTo, TrangThaiKiemDuyet) values (1, 'Sổ đỏ', 0)

--Nhập thông tin bảng Phòng ban
insert into PhongBan values (N'Phòng quảng cáo', N'Thực hiện tiếp nhận quảng cáo, chụp hình, viết bài, đăng quảng cáo')

--Nhập thông tin bảng Loại nhân viên
insert into LoaiNhanVien values (N'Nhân viên quảng cáo', N'Tiếp nhận thông tin quảng cáo, trao đổi với khách hàng, đăng quảng cáo')

--Nhập thông tin bảng Nhân viên (Phụ thuộc Loại Nhân viên, Phòng ban( ==> Mật khẩu phải mã hóa
insert into NhanVien values (1, 1, N'Trần Thị Xuân Thư','251043331', 1, '1996-21-11', N'Khu phố 6, phường Linh Trung, quận Thủ Đức', '01694122657', 'minhtranguit@gmail.com', 'minhtranguit', '123124',1)

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
insert into PhieuDangKy values (1, 1, 1, '2017-12-11', '2018-01-01', '2018-02-01', 0, 0, 1000000, 500000, 500000,'')

--Nhập thông tin bảng Chi tiết quảng cáo (Phụ thuộc bảng Phiếu đăng ký, Loại quảng cáo, Vị tri). Phụ thuộc vào loại quảng cáo mà có thuộc tính khác nhau
-- Ví dụ: Quảng cáo tờ bướm. Thì chỉ có MaPhieuDangKy, MaLoaiQuangCao, SoLuongPhatHanh, KichThuoc (Đơn vị mét vuông) TrangThaiKiemDuyet
-- Ví dụ: Quảng cáo trên báo và website. Thì có MMaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet
insert into ChiTietQuangCao(MaPhieuDangKy, MaLoaiQuangCao, MaViTri, NgayBatDau, NgayKetThuc, TrangThaiKiemDuyet) values (1, 2, 1, '2018-01-01', '2018-02-01', 0)

--Nhập thông tin bảng Hình ảnh, Chi tiết hình ảnh (Để làm sau)

--Nhập thông tin bảng Bài viết (Phụ thuộc bảng Chi tiết quảng cáo, Mã nhân viên). Tham khảo: batdongsan.com, rever.com
insert into BaiViet values (1, 1, N'Nguyệt lên mạng lấy một số bài viết từ mấy trang bất động sản bỏ vào nha', 0)

--Nhập thông tin bảng Quy định (Bảng này đủ rồi, NGuyệt không cần thêm nữa)
insert into QuyDinh values (0.1, 60, 1000, 2, 0.8, 1.3)


