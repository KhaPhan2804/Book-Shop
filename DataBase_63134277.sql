CREATE DATABASE QuanLyBanSach_63134277
USE QuanLyBanSach_63134277
GO

CREATE TABLE Account
(
	Email NVARCHAR(150) primary key,
	MK VARCHAR(150),
	TenHienThi NVARCHAR(150),
	RoleID  INT, -- Vai tro 
	CreateDate DATETIME -- Ngay tao tk
)

CREATE TABLE KhachHang (
    ma_KH INT PRIMARY KEY,
    ten_KH NVARCHAR(255),
    sdt NVARCHAR(15),
    email NVARCHAR(50),
    diachi NVARCHAR(255),
    ngaysinh DATE,
    gioitinh bit DEFAULT(1)
)
GO
CREATE TABLE Sach (
    ma_Sach INT PRIMARY KEY,
    ten_Sach NVARCHAR(255),
    loai_Sach NVARCHAR(255),	
    giatien INT,
    anh_Sach NVARCHAR(255),
    mota NVARCHAR(255),
	ma_LS INT,
	FOREIGN KEY (ma_LS) REFERENCES LoaiSach(ma_LS)
	
)
GO
CREATE TABLE NhanVien (
    ma_NV INT PRIMARY KEY,
    ten_NV NVARCHAR(255),
    sdt NVARCHAR(15),
    email NVARCHAR(50),
    diachi NVARCHAR(255),
    ngaysinh DATE,
    chucvu NVARCHAR(255)
)
GO
CREATE TABLE DonHang (
    ma_DH INT IDENTITY(1,1) PRIMARY KEY,
	ma_KH INT,
    Ten_KH NVARCHAR(255),
    ghichu NVARCHAR(255),
	ngaydat DATE,
	email NVARCHAR(50),
   diachi NVARCHAR(255),
   FOREIGN KEY (ma_KH) REFERENCES KhachHang(ma_KH)  
)
GO
CREATE TABLE LoaiSach (
    ma_LS INT PRIMARY KEY,
	ten_LS NVARCHAR(255)
)
GO

Create Table ChiTietDonHang(
	ma_CDH INT IDENTITY(1,1) PRIMARY KEY,
	ma_DH INT,
	ma_Sach INT,
	soluong INT,
	tong Int,
	FOREIGN KEY (ma_DH) REFERENCES DonHang(ma_DH),
	FOREIGN KEY (ma_Sach) REFERENCES Sach(ma_Sach)
);
-- Thêm dữ liệu

INSERT INTO Account(Email, MK, TenHienThi, RoleID, CreateDate)
Values(N'luandinh1458@gmail.com', 'Anhkha123', N'Phan Anh Kha', 1, '2023-11-16'),
(N'pkha2804@gmail.com', 'Anhkha123', N'Trần Thế Mỹ', 1, '2023-11-16');
INSERT INTO KhachHang (ma_KH, ten_KH, sdt, email, diachi, ngaysinh, gioitinh)
VALUES
    (001, N'Phan Anh Kha', '0984012392', N'pak2910@gmail.com', N'Nha Trang - Khánh Hòa', '2003-10-20', 1),
    (002, N'Doãn Chí Bình', '0123456789', N'cbinh019@gmail.com', N'456 Ninh Hòa, Khánh Hòa', '2002-04-02', 1),
    (003, N'Trần Tiểu Kiều', '0987654321', N'qpkieu1092@gmail.com', N'109 Bình Thuận', '2001-01-30', 0),
    (004, N'Gia Cát Lượng', '0301929201', N'gclg10@gmail.com', N'012 Ninh Thuận', '1999-08-10', 1),
    (005, N'Khúc Thị Hương', '0339841029', N'kth931@gmail.com', N'789 Tam Kỳ, Quảng Nam', '2000-03-25', 0),
	(007, N'Tống Giang', '0981238132', N'tg2110@gmail.com', N'28 Đống Đa, Hà Nội ', '2000-01-20', 1),
    (008, N'Lư Tuấn Nghĩa', '01202391332', N'ltn9@gmail.com', N'102A Nguyễn Tất Thành, Nha Trang', '1990-02-04', 1),
    (009, N'Công Tôn Thắng', '0337209191', N'ctn0223@gmail.com', N'Thành phố Hồ Chí Minh', '1999-01-31', 0),
    (010, N'Nguyễn Tiểu Thất', '01133223145', N'ntn0293@gmail.com', N'Nha Trang - Khánh Hòa', '1999-10-08', 1),
    (011, N'Hồ Thị Cẩm Như', '03601923123', N'htcn3091@gmail.com', N'Hà Nội', '2006-03-20', 0);

INSERT INTO Sach(ma_Sach, ten_Sach, loai_Sach, giatien, anh_Sach, mota, ma_LS)
VALUES
    (001,N'Sherlock Holmes','Trinh thám',300000,N'Sherlock.jpg',N'Sherlock Holmes is a fictional detective created by British author Arthur Conan Doyle',001),
	(002,N'Adofl Hitler: A life from Beginning to End',N'Lịch sử',250000,N'Adoft.jpg',N'Adolf Hitler was an Austrian-born German politician who was the dictator of Germany from 1933 until his suicide in 1945',002),
	(003,N'The Beginning after The End',N'Phiêu lưu',350000,N'Beginning.jpg',N'King Grey has unrivaled strength, wealth, and prestige in a world governed through martial ability. However, solitude lingers closely behind those with great power',003),
	(004,N'Storytelling with data',N'Khoa học',200000,N'Data.jpg',N'Storytelling with Data teaches you the fundamentals of data visualization and how to communicate effectively with data',004),
	(005,N'R for Data Science',N'Khoa học',150000,N'R.jpg',N'You’ll learn how to get your data into R, get it into the most useful structure, transform it and visualize',004),
	(006, N'Mười Người Da Đen Nhỏ', N'Trinh Thám', 600000, N'Ten.jpg', N'Mười người phát hiện rằng mình đã bị lừa ra đảo để “trả giá” cho “tội ác” đã gây ra, họ ứng với 10 bức tượng nhỏ đặt trên bàn ở phòng khách',001),
    (007, N'Sự Im Lặng Của Bầy Cừu',N'Trinh Thám', 200000, N'Silent.jpg',N'Sự Im Lặng Của Bầy Cừu kể về vụ án giết người hàng loạt xảy ra nhưng không để lại dấu vết',001),
    (008, N'Hỏa Ngục', N'Trinh Thám', 400000,N'HN.jpg', N'Giáo sư biểu tượng học của Harvard, Robert Langdon, tỉnh lại trong một bệnh viện vào lúc nửa đêm',001),
    (009, N'Vua Gia Long',N'Lịch sử', 450000, N'GL.jpg', N'Cuốn sách lịch sử Việt Nam này là công trình biên khảo bằng tiếng Pháp của Marcel Gaultier được xuất bản lần đầu tại Sài Gòn vào năm 1933',002),
	(010, N'Tâm Lý Dân Tộc An Nam', N'Lịch sử', 200000, N'AN.jpg', N'Công trình nghiên cứu Tâm lý dân tộc An Nam (Psychologie du Peuple annamite)',002),
    (011, N'Các Triều Đại Việt Nam',N'Lịch sử', 300000, N'His.jpg',N'Cuốn sách lịch sử Việt Nam này có dung lượng vừa phải nhưng cung cấp nhiều thông tin cơ bản, bao quát toàn bộ tiến trình phát triển lịch sử dân tộc',002),
    (012, N'Jujutsu Kaisen', N'Phiêu lưu', 400000,N'jjk.jpg', N'Jujutsu Kaisen is a Japanese manga series written and illustrated by Gege Akutami',003),
    (013, N'One Piece',N'Phiêu lưu', 450000, N'one.jpg', N'One Piece is a Japanese manga series written and illustrated by Eiichiro Oda',003),
	(014, N'Naruto', N'Phiêu lưu', 500000, N'naru.jpg', N'Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village',003),
    (015, N'IT',N'Kinh dị', 300000, N'it.jpg',N'It là tiểu thuyết thuộc thể loại viễn tưởng kinh dị của nhà văn người Mỹ, Stephen King. It ra mắt năm 1986, là cuốn truyện thứ 22 của Stephen',005),
    (016, N'GOTH – Những Kẻ Hắc Ám', N'Kinh dị', 400000,N'goth.jpg', N'Một cuốn sổ ghi chép quá trình giết người.Chiếc tủ lạnh chứa đầy bàn tay. Lũ chó bị bắt cóc.Vụ treo cổ kỳ quái.Đứa trẻ bị chôn sống. Cuốn băng thu âm giọng nói của người chết…',005),
    (017, N'Bạch Dạ Hành',N'Kinh dị', 450000, N'white.jpg', N'Kosuke, chủ một tiệm cầm đồ bị sát hại tại một ngôi nhà chưa hoàn công, một triệu yên mang theo người cũng bị cướp mất.',005),
	(018, N'Phi Lý Trí ', N'Tâm lý', 500000, N'li.jpg', N'Tại sao chúng ta luôn tự hứa là sẽ ăn kiêng để rồi ý nghĩ ấy vụt biến ngay khi chiếc xe chở đồ tráng miệng đi qua? Tại sao đôi khi chúng ta hào hứng mua sắm những thứ không thật sự cần đến?',006),
    (019, N'Bản Chất Của Dối Trá',N'Tâm lý', 300000, N'doi.jpg',N'Hầu hết chúng ta đều nghĩ mình trung thực, nhưng, trên thực tế, tất cả chúng ta đều dối trá. Từ Washington đến Phố Wall, từ lớp học đến nơi làm việc, hành vi phi đạo đức xuất hiện ở khắp mọi nơi',006),
    (020, N'Lược Sử Tôn Giáo', N'Tôn giáo', 400000,N'tg.jpg', N'Hơn bảy tỷ người trên thế giới có thể viết một thứ gì đó khác chữ “Không” vào mục Tôn giáo trong hồ sơ của mình',007),
    (021, N'Sự Sống Bất Tử',N'Tôn giáo', 450000, N'su.jpg', N'Cuộc sống sau cái chết và sự tồn tại của một Đấng tối cao luôn là đề tài mà con người quan tâm trong suốt chiều dài lịch sử',007),
	(022, N'Đồi Gió Hú', N'Tiểu thuyết', 500000, N'gio.jpg', N'Đồi gió hú, câu chuyện cổ điển về tình yêu ngang trái và tham vọng chiếm hữu, cuốn tiểu thuyết dữ dội và bí ẩn về Catherine Earnshaw, cô con gái nổi loạn của gia đình Earnshaw',008),
    (023, N'Đại Gia Gatsby',N'Tiểu thuyết', 300000, N'gas.jpg',N'Gatsby đã tin vào đốm sáng xanh ấy, vào cái tương lai mê đắm đến cực điểm đang rời xa trước mắt chúng ta năm này qua năm khác.',008),
    (024, N'Hành trình vô cực', N'Văn học nghệ thuật', 400000,N'inf.jpg', N'Hành trình của Stephen Hawking và người đằng sau của ông ấy',009),
    (025, N'Tắt đèn',N'Văn học nghệ thuật', 450000, N'tat.jpg', N'Nam Cao là nhà văn hiểu hơn ai hết nghệ thuật là một hoạt động sáng tạo. Ông quan niệm: "Văn chương không cần đến những người thợ khéo tay, làm theo một vài kiểu mẫu đưa cho',009),
    (026, N'Peter Pan',N'Sách thiếu nhi', 300000, N'pe.jpg',N'Chú bé Peter Pan-chú bé không bao giờ lớn-một đêm mò đến phòng trẻ của nhà Darling gồm Wendy, Jonh và Micheal. Chú đã dạy cho chúng biết bay, và mang chúng qua bầu trời tới Neverland, xứ sở thần thoại có người Da đỏ, sói, tiên cá và… lũ cướp biển.',010),
    (027, N'Dế Mèn Phiêu Lưu Ký', N'Sách thiếu nhi', 400000,N'de.jpg', N'Dế mèn phiêu lưu ký là truyện dài của nhà văn Tô Hoài kể về cuộc phiêu lưu của chú Dế Mèn cùng các bạn bè',010),
    (028, N'Homo Deus: Lược Sử Tương Lai',N'Khoa học', 450000, N'homo.jpg', N'Trong cuốn sách khoa học này, Yuval Noah Harari phân tích 70.000 năm lịch sử loài người để đưa ra dự đoán về tương lai của chúng ta… và kết quả thật ảm đạm',004),
	(029, N'Bộ Sách Nhân Tố Enzyme', N'Khoa học', 400000,N'enz.jpg', N'Từ kết quả lâm sàng khi tiến hành kiểm tra dạ dày của hơn 300.000 người, bác sĩ Hiromi Shinya đã rút ra kết luận: “Người có sức khỏe tốt là người có dạ dày đẹp, ngược lại, người có sức khỏe kém là người có dạ dày không đẹp.”',004),
    (030, N'Lược Sử Thời Gian',N'Khoa học', 450000, N'ls.jpg', N'Cuốn sách khoa học hay về vũ trụ học này giải thích các khái niệm phức tạp như không gian, thời gian và lỗ đen cho người dân theo quan điểm khoa học',004);


INSERT INTO NhanVien (ma_NV, ten_NV, sdt, email, diachi, ngaysinh, chucvu)
VALUES
    (001, N'Lê Mạnh Cương', '0987655521', N'cuong@gmail.com', N'789 Đức Phổ, Quảng Ngãi', '1988-03-25', N'Quản lý'),
    (002, N'Đường Thị Kim Ngoan', '0112126789', N'ngoanKim@example.com', N'011 Hoàng Hoa Thám, Nha Trang', '1992-08-10', N'Thu ngân'),
    (003, N'Hoàng Văn Thụ', '0989004321', N'thuHoang@example.com', N'124 Đinh Tiên Hoàng, Lâm Đồng', '1990-05-15', N'Marketing'),
    (004, N'Trần Đồng', '0123488889', N'dongTran@example.com', N'453 Phổ An, Quảng Ngãi', '1985-10-20', N'Nhân viên kho'),
    (005, N'Đinh Thu Hiệp', '0322456789', N'hiepDinh@example.com', N'210 Nha Trang, Khánh Hòa', '1988-03-25', N'Bảo vệ'),
	(007, N'Lê Mạnh Đình', '0984019239', N'lmd9182@gmail.com', N'Thành phố Hồ Chí Minh', '1992', N'Bảo vệ'),
    (008, N'Nguyễn Chí Quân', '035092891', N'ncq3029@example.com', N'301 Nguyễn Tất Thành, Nha Trang', '2000-02-19', N'Thu ngân'),
    (009, N'Lê Thị Thanh Hằng', '0929182373', N'thanhhang@example.com', N'24/19 Hùng Vương, Nha Trang ', '2003-05-15', N'Marketing'),
    (010, N'Trận Thị Thanh', '0309193823', N'TranThanh@example.com', N'62 Hồng Bàng, Nha Trang', '1981-10-30', N'Nhân viên kho'),
    (011, N'Vũ Văn Thanh', '010938231', N'vuthanh@example.com', N'64B/15 Trần Phú,Nha Trang', '1988-03-25', N'Nhân viên kho');
 
 INSERT INTO LoaiSach(ma_LS,ten_LS)
 VALUES
 (001,N'Trinh thám'),
 (002,N'Lịch sử'),
 (003,N'Phiêu lưu'),
 (004,N'Khoa Học'),
 (005,N'Kinh dị'),
 (006,N'Tâm lý'),
 (007,N'Tôn giáo'),
 (008,N'Tiểu thuyết'),
 (009,N'Văn học nghệ thuật'),
 (010,N'Sách thiếu nhi');


