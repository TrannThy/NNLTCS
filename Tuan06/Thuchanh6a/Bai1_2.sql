-- Tạo cơ sở dữ liệu QLSinhVien
CREATE DATABASE QLSinhVien;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QLSinhVien;
GO

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(50) NOT NULL
);
GO
-- Chọn đúng database QLSinhVien
USE QLSinhVien;
GO
-- Xem toàn bộ danh
SELECT * FROM Khoa;