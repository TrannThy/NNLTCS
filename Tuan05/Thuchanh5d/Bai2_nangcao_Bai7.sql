USE QLSINHVIEN;
GO

-- Tạo bảng Diem (với khóa chính gồm cặp MaSinhVien và MaMonHoc)
CREATE TABLE Diem (
    MaSinhVien VARCHAR(10),
    MaMonHoc VARCHAR(10),
    Diem FLOAT NOT NULL,
    PRIMARY KEY (MaSinhVien, MaMonHoc)
);
GO

-- Thêm dữ liệu mẫu vào bảng Diem
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('SV01', 'THDC', 8.5);
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('SV01', 'LDT', 7.0);
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('SV02', 'THDC', 9.0);
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('SV03', 'CSDL', 6.5);
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('SV04', 'CTDL', 8.0);
GO


USE QLSINHVIEN;
GO
-- Kiểm tra lại dữ liệu trong bảng
SELECT * FROM Diem;
GO