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
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (3, 'GẶP LẠI CHỊ BẦU (T18)', '70000 đ', 'RẠP 1,3', 'Việt Nam');
INSERT INTO Movies (Id, Name, Price, Theater, Country) VALUES (4, 'TAROT (T18)', '90000 ?', 'R?p 3', 'Hoa K?');
	SELECT * FROM Movies;

CREATE TABLE Trailer (
    MovieId INT PRIMARY KEY,
    Name NVARCHAR(100),
    Genre NVARCHAR(50),
    Duration NVARCHAR(20),
    Country NVARCHAR(50),
    SubtitleOrDubbing NVARCHAR(40),
    Director NVARCHAR(100),
    Actors NVARCHAR(255),
    ReleaseDate DATE,
    Synopsis NVARCHAR(MAX),
    TrailerVideoPath NVARCHAR(255) 
);
SELECT * FROM Trailer
INSERT INTO Trailer (MovieId, Name, Genre, Duration, Country, SubtitleOrDubbing, Director, Actors, ReleaseDate, Synopsis, TrailerVideoPath)
VALUES 
(1, N'ĐÀO, PHỞ VÀ PIANO', N'Chiến tranh/Lãng mạn', N'1 giờ 40 phút', N'Việt Nam', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Phi Tiến Sơn', N'Cao Thị Thùy Linh, Doãn Quốc Đam', N'2024-03-14', 
N'Lấy bối cảnh trận chiến đông xuân kéo dài 60 ngày đêm từ cuối năm 
1946 đến đầu năm 1947 ở Hà Nội, câu chuyện theo chân chàng dân quân 
Văn Dân và chuyện tình với nàng tiểu thư đam mê dương cầm Thục Hương. 
Khi những người khác đã di tản lên chiến khu, họ quyết định cố thủ lại 
mảnh đất thủ đô đã tan hoang vì bom đạn, mặc cho những hiểm nguy đang 
chờ đợi trước mắt.', 
N'E:\NAM 2\NNLT C#\FINAL_PROJECT\DOAN_C-\CinemaManagement_Project\bin\Debug\net6.0-windows\VideoTrailer\dao-pho-va-piano-trailer.mp4');

INSERT INTO Trailer (MovieId, Name, Genre, Duration, Country, SubtitleOrDubbing, Director, Actors, ReleaseDate, Synopsis, TrailerVideoPath)
VALUES 
(2, N'MAI', N'Tâm Lý, Tình cảm', N'2 giờ 10 phút', N'Việt Nam', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Trấn Thành', N'Phương Anh Đào, Tuấn Trần', N'2024-02-10', 
N'"Mai" xoay quanh cuộc đời của một người phụ nữ đẹp tên Mai 
(do Phương Anh Đào thủ vai) có số phận rất đặc biệt. Bởi làm nghề mát 
xa, Mai thường phải đối mặt với ánh nhìn soi mói, phán xét từ những 
người xung quanh. Và rồi Mai gặp Dương (Tuấn Trần)- chàng trai đào hoa
lãng tử. Những tưởng bản thân không còn thiết tha yêu đương và mưu cầu 
hạnh phúc cho riêng mình thì khao khát được sống một cuộc đời mới trong 
Mai trỗi dậy khi Dương tấn công cô không khoan nhượng. Họ cho mình... 
', 
N'E:\NAM 2\NNLT C#\FINAL_PROJECT\DOAN_C-\CinemaManagement_Project\bin\Debug\net6.0-windows\VideoTrailer\mai_trailer.mp4');

INSERT INTO Trailer (MovieId, Name, Genre, Duration, Country, SubtitleOrDubbing, Director, Actors, ReleaseDate, Synopsis, TrailerVideoPath)
VALUES 
(3, N'GẶP LẠI CHỊ BẦU', N'Gia đình, Hài, Tình cảm', N'1 giờ 54 phút', N'Việt Nam', N'Tiếng Việt - Phụ đề Tiếng Anh', N'Đoàn Nhất Trung', N'Diệu Nhi, Anh Tú', N'2024-02-10', 
N'"Một bộ phim tình cảm gia đình đầy ắp tiếng cười dịp Tết Giáp Thìn. 
“Gặp Lại Chị Bầu” xoay quanh Phúc, một thanh viên trẻ với đam mê diễn 
xuất nhưng phải trải qua cuộc sống muôn vàn khó khăn. Anh tình cờ lưu 
lạc đến xóm trọ của bà Lê và cùng những người bạn ở đây trải qua những 
ngày tháng thanh xuân đáng nhớ nhất cuộc đời.', 
N'E:\NAM 2\NNLT C#\FINAL_PROJECT\DOAN_C-\CinemaManagement_Project\bin\Debug\net6.0-windows\VideoTrailer\GapLaiChiBau_Trailer.mp4');

INSERT INTO Trailer (MovieId, Name, Genre, Duration, Country, SubtitleOrDubbing, Director, Actors, ReleaseDate, Synopsis, TrailerVideoPath)
VALUES 
(4, N'TAROT', N'Hồi hộp, Kinh Dị', N'1 giờ 32 phút', N'Hoa Kỳ', N'Tiếng Anh - Phụ đề Tiếng Việt', N'Spenser Cohen', N'Avantika, Jacob Batalon', N'2024-05-03', 
N'"Phim kể về một nhóm bạn vi phạm quy tắc thiêng liêng của việc xem 
Tarot bằng cách sử dụng bộ bài của người khác. Hành động bất cẩn này đã 
giải phóng một lực lượng ma quỷ bị giam giữ trong các lá bài bị nguyền 
rủa. Từng người một phải đối mặt với số phận của mình và tham gia vào 
cuộc chạy đua chống lại cái chết để thoát khỏi số phận đã được tiên đoán.', 
N'E:\NAM 2\NNLT C#\FINAL_PROJECT\DOAN_C-\CinemaManagement_Project\bin\Debug\net6.0-windows\VideoTrailer\tarot_trailer.mp4');

DELETE FROM Movies WHERE Id = 3
DELETE FROM Trailer WHERE MovieId = 3
DELETE FROM Trailer WHERE MovieId = 4	