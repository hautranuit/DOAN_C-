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

CREATE TABLE Movies (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100),
    Price NVARCHAR(50),
    Theater NVARCHAR(100),
    Country NVARCHAR(100)
);
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (1, '?ÀO, PH? VÀ PIANO (T13)', '45000 ?', 'R?p 1,2,3', 'Vi?t Nam');
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (2, 'MAI (T18)', '100000 ?', 'R?p 2,3', 'Vi?t Nam');
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (3, 'G?P L?I CH? B?U (T18)', '70000 ?', 'R?p 1', 'Vi?t Nam');
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (4, 'TAROT (T18)', '90000 ?', 'R?p 3', 'Hoa K?');
	SELECT * FROM Movies;


