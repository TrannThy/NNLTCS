USE master;
GO

-- 1. Tạo Database nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QLSinhVien')
BEGIN
    CREATE DATABASE QLSinhVien;
END
GO

USE QLSinhVien;
GO

-- Xóa các bảng cũ theo thứ tự ngược lại (nếu có) để tránh lỗi xung đột khi chạy lại script
IF OBJECT_ID('Diem', 'U') IS NOT NULL DROP TABLE Diem;
IF OBJECT_ID('SinhVien', 'U') IS NOT NULL DROP TABLE SinhVien;
IF OBJECT_ID('Lop', 'U') IS NOT NULL DROP TABLE Lop;
IF OBJECT_ID('MonHoc', 'U') IS NOT NULL DROP TABLE MonHoc;
IF OBJECT_ID('Khoa', 'U') IS NOT NULL DROP TABLE Khoa;
GO

-- 2. Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(50) NOT NULL
);
GO

-- 3. Tạo bảng Lop (Có thêm MaKhoa liên kết với bảng Khoa)
CREATE TABLE Lop (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    MaKhoa VARCHAR(10) NOT NULL,
    CONSTRAINT FK_Lop_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
GO

-- 4. Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(50) NOT NULL
);
GO

-- 5. Tạo bảng SinhVien (Có khóa ngoại trỏ về bảng Lop để chặn lỗi nhập sai mã lớp)
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    MaLop VARCHAR(10) NOT NULL,
    CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
GO

-- 6. Tạo bảng Diem (Khóa chính gồm MaSinhVien và MaMonHoc, kèm khóa ngoại)
CREATE TABLE Diem (
    MaSinhVien VARCHAR(10),
    MaMonHoc VARCHAR(10),
    Diem FLOAT,
    PRIMARY KEY (MaSinhVien, MaMonHoc),
    CONSTRAINT FK_Diem_SinhVien FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien),
    CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);
GO

-- ==========================================
-- 7. THÊM DỮ LIỆU MẪU HỢP LỆ
-- ==========================================

-- Thêm Khoa
INSERT INTO Khoa VALUES ('NNA', N'Ngôn ngữ Anh');
INSERT INTO Khoa VALUES ('CNTT', N'Công nghệ thông tin');
INSERT INTO Khoa VALUES ('KT', N'Kế toán');       -- [MỚI THÊM CHO BÀI LISTVIEW]
INSERT INTO Khoa VALUES ('HH', N'Hóa học');       -- [MỚI THÊM CHO BÀI LISTVIEW]
GO

-- Thêm Lớp (thuộc các Khoa đã tồn tại)
INSERT INTO Lop VALUES ('04CDNTH', N'Cao đẳng Công nghệ thông tin', 'CNTT');
INSERT INTO Lop VALUES ('04CDQTK', N'Cao đẳng Quản trị kinh doanh', 'CNTT');
INSERT INTO Lop VALUES ('04CDPT', N'Cao đẳng Ngôn ngữ Anh', 'NNA');
GO

INSERT INTO Lop VALUES ('05DHKT2', N'Kế toán ngân hàng khóa 05', 'KT');
INSERT INTO Lop VALUES ('05DHTH1', N'Công nghệ phần mềm khóa 05', 'CNTT');
INSERT INTO Lop VALUES ('05DHTH2', N'Lập trình mạng khóa 05', 'CNTT');
INSERT INTO Lop VALUES ('06DHHH1', N'Hóa phân tích khóa 06', 'HH');
INSERT INTO Lop VALUES ('06DHKT1', N'Thuế doanh nghiệp khóa 06', 'KT');
INSERT INTO Lop VALUES ('06DHTH1', N'Công nghệ phần mềm khóa 06', 'CNTT');
GO
-- Thêm Môn Học
INSERT INTO MonHoc VALUES ('NNA1', N'Ngôn ngữ Anh 1');
INSERT INTO MonHoc VALUES ('LDT1', N'Lập trình cơ bản');
GO

-- Thêm Sinh Viên (MaLop bắt buộc phải có thật trong bảng Lop, không bị nhầm với MaMonHoc nữa)
INSERT INTO SinhVien VALUES ('SV01', N'Nguyễn Thị Thùy', '2006-12-12', '04CDNTH');
INSERT INTO SinhVien VALUES ('SV02', N'Trần Văn Nam', '2006-05-20', '04CDQTK');
GO

-- Thêm Điểm
INSERT INTO Diem VALUES ('SV01', 'NNA1', 9.0);
GO

--Bai2_nangcao
USE QLSinhVien;
GO

-- 1. Thêm các môn học mẫu
IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMonHoc = '1')
    INSERT INTO MonHoc VALUES ('1', N'Toán Cao cấp');
IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMonHoc = '2')
    INSERT INTO MonHoc VALUES ('2', N'Mac - Lênin');
IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMonHoc = '3')
    INSERT INTO MonHoc VALUES ('3', N'Tin học đại cương');
GO

-- 2. Thêm sinh viên mẫu khớp với hình tài liệu
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSinhVien = 'SV10')
    INSERT INTO SinhVien VALUES ('SV10', N'Trần Thanh Tùng', '1993-10-12', '04CDNTH');
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSinhVien = 'SV11')
    INSERT INTO SinhVien VALUES ('SV11', N'Nguyễn Thanh Bình', '1993-04-02', '04CDNTH');
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSinhVien = 'SV12')
    INSERT INTO SinhVien VALUES ('SV12', N'Nguyễn Đạt Nhân', '1992-03-15', '04CDQTK');
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSinhVien = 'SV13')
    INSERT INTO SinhVien VALUES ('SV13', N'Nguyễn Gia Bảo', '1993-11-05', '04CDPT');
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSinhVien = 'SV14')
    INSERT INTO SinhVien VALUES ('SV14', N'Lâm Văn Tuấn', '1993-03-08', '04CDNTH');
GO

-- 3. Thêm điểm tương ứng cho các sinh viên
DELETE FROM Diem; -- Làm sạch bảng điểm cũ để nạp dữ liệu chuẩn
INSERT INTO Diem VALUES ('SV10', '1', 4.0);
INSERT INTO Diem VALUES ('SV10', '2', 7.0);
INSERT INTO Diem VALUES ('SV11', '1', 6.0);
INSERT INTO Diem VALUES ('SV11', '2', 3.0);
INSERT INTO Diem VALUES ('SV11', '3', 5.0);
INSERT INTO Diem VALUES ('SV12', '1', 9.0);
INSERT INTO Diem VALUES ('SV12', '2', 10.0);
INSERT INTO Diem VALUES ('SV12', '3', 9.0);
INSERT INTO Diem VALUES ('SV13', '1', 3.0);
INSERT INTO Diem VALUES ('SV13', '2', 6.0);
INSERT INTO Diem VALUES ('SV14', '1', 5.0);
INSERT INTO Diem VALUES ('SV14', '3', 7.0);
INSERT INTO Diem VALUES ('SV14', '2', 8.0);
GO


-- ==========================================
-- 8. XEM LẠI TOÀN BỘ DỮ LIỆU CÁC BẢNG
-- ==========================================
SELECT * FROM Khoa;
SELECT * FROM Lop;
SELECT * FROM MonHoc;
SELECT * FROM SinhVien;
SELECT * FROM Diem;
GO