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