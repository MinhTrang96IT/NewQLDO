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