USE QLSINHVIEN;
GO

-- Tạo bảng SinhVien (với MaSinhVien là khóa chính)
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    MaLop VARCHAR(10) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL
);
GO

-- Thêm dữ liệu mẫu vào bảng SinhVien (ít nhất 5 mẫu tin)
INSERT INTO SinhVien (MaSinhVien, MaLop, HoTen, NgaySinh) VALUES ('SV01', 'CNTT1', N'Nguyễn Văn A', '2005-01-15');
INSERT INTO SinhVien (MaSinhVien, MaLop, HoTen, NgaySinh) VALUES ('SV02', 'CNTT1', N'Trần Thị B', '2005-05-20');
INSERT INTO SinhVien (MaSinhVien, MaLop, HoTen, NgaySinh) VALUES ('SV03', 'QTKD1', N'Lê Văn C', '2005-08-10');
INSERT INTO SinhVien (MaSinhVien, MaLop, HoTen, NgaySinh) VALUES ('SV04', 'KT1', N'Phạm Thị D', '2005-11-25');
INSERT INTO SinhVien (MaSinhVien, MaLop, HoTen, NgaySinh) VALUES ('SV05', 'NN1', N'Hoàng Văn E', '2005-03-30');
GO

USE QLSINHVIEN;
GO
-- Kiểm tra lại dữ liệu trong bảng
SELECT * FROM SinhVien;
GO