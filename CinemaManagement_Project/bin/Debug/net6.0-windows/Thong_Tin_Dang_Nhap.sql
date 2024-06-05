CREATE DATABASE Bai_Thuc_Hanh_01;
GO
USE Bai_Thuc_Hanh_01;
GO

	CREATE TABLE Thong_Tin_Dang_Nhap (
    TenTk NVARCHAR(50) NOT NULL PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL,
	Email NVARCHAR(100) NOT NULL
);
INSERT INTO Thong_Tin_Dang_Nhap (TenTk, MatKhau, Email)
VALUES ('22520412', '1158142831', 'hau322004hd@gmail.com');
SELECT * FROM Thong_Tin_Dang_Nhap;