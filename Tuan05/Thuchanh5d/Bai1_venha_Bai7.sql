USE QLSINHVIEN;
GO

-- Tạo bảng Lop (với MaLop là khóa chính)
CREATE TABLE Lop (
    MaLop VARCHAR(10) PRIMARY KEY,
    MaKhoa VARCHAR(10) NOT NULL,
    TenLop NVARCHAR(100) NOT NULL
);
GO

-- Thêm dữ liệu mẫu vào bảng Lop (ít nhất 5 mẫu tin)
INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES ('CNTT1', 'CNTT', N'Công nghệ thông tin 1');
INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES ('CNTT2', 'CNTT', N'Công nghệ thông tin 2');
INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES ('QTKD1', 'QTKD', N'Quản trị kinh doanh 1');
INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES ('KT1', 'KT', N'Kế toán 1');
INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES ('NN1', 'NN', N'Ngoại ngữ 1');
GO


USE QLSINHVIEN;
GO
-- Kiểm tra lại dữ liệu trong bảng
SELECT * FROM Lop;
GO