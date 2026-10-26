-- Sử dụng database QLSinhVien cũ
USE QLSinhVien;
GO

-- Tạo bảng SinhVien (MaLop, MaSinhVien, HoTen, NgaySinh)
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    MaLop VARCHAR(10) NOT NULL
);
GO

USE QLSinhVien;
GO
SELECT * FROM SinhVien;