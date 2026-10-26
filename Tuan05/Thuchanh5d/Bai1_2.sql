-- 1. Tạo cơ sở dữ liệu QLSINHVIEN
CREATE DATABASE QLSINHVIEN;
GO

-- 2. Chuyển sang sử dụng cơ sở dữ liệu vừa tạo
USE QLSINHVIEN;
GO

-- 3. Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);
GO

-- 4. Thêm dữ liệu mẫu vào bảng Khoa (ít nhất 5 mẫu tin theo yêu cầu)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('QTKD', N'Quản trị kinh doanh');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('KT', N'Kế toán');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('NN', N'Ngoại ngữ');
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CK', N'Cơ khí');
GO


USE QLSINHVIEN;
GO
-- 5. Kiểm tra dữ liệu trong bảng Khoa
SELECT * FROM Khoa;--bôi đen chạy coi cập nhật
GO