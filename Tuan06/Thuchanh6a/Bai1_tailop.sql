-- Chọn đúng database cũ
USE QLSinhVien;
GO

-- Tạo bảng MonHoc (theo cấu trúc tài liệu môn học)
CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(50) NOT NULL
);
GO
-- Chọn đúng database QLSinhVien
USE QLSinhVien;
GO
-- Xem toàn bộ danh sách các khoa có trong bảng
SELECT * FROM MonHoc;