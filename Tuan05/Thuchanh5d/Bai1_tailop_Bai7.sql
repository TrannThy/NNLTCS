-- Sử dụng cơ sở dữ liệu QLSINHVIEN đã có sẵn
USE QLSINHVIEN;
GO

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
);
GO

-- Thêm dữ liệu mẫu vào bảng MonHoc (ít nhất 5 mẫu tin)
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES ('THDC', N'Tin học đại cương');
INSERT INTO MonHoc(MaMonHoc, TenMonHoc) VALUES ('LDT', N'Lập trình .NET');
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES ('CSDL', N'Cơ sở dữ liệu');
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES ('CTDL', N'Cấu trúc dữ liệu và giải thuật');
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES ('MMT', N'Mạng máy tính');
GO



USE QLSINHVIEN;
GO

-- Kiểm tra lại dữ liệu trong bảng
SELECT * FROM MonHoc;--
GO