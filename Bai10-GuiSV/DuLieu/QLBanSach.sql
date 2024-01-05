---Xoa CSDL QLBansach neu da co
use master
Drop Database QLBansach
-----Tao CSDL QLBansach
create database QLBANSACH
GO
use QLBANSACH
CREATE TABLE KHACHHANG
(
MaKH INT IDENTITY(1,1),
HoTen nVarchar(50) NOT NULL,
Taikhoan Varchar(50) UNIQUE,
Matkhau Varchar(50) NOT NULL,
Email Varchar(100) UNIQUE,
DiachiKH nVarchar(200),
DienthoaiKH Varchar(50),
Ngaysinh DATETIME
CONSTRAINT PK_Khachhang PRIMARY KEY(MaKH)
)
Create Table CHUDE
(
MaCD int Identity(1,1),
TenChuDe nvarchar(50) NOT NULL,
CONSTRAINT PK_ChuDe PRIMARY KEY(MaCD)
)
Create Table NHAXUATBAN
(
MaNXB int identity(1,1),
TenNXB nvarchar(50) NOT NULL,
Diachi NVARCHAR(200),
DienThoai VARCHAR(50),
CONSTRAINT PK_NhaXuatBan PRIMARY KEY(MaNXB)
)
CREATE TABLE SACH
(
Masach INT IDENTITY(1,1),
Tensach NVARCHAR(100) NOT NULL,
Giaban Decimal(18,0) CHECK (Giaban>=0),
Mota NVarchar(Max),
Anhbia VARCHAR(50),
Ngaycapnhat DATETIME,
Soluongton INT,
MaCD INT,
MaNXB INT,
Constraint PK_Sach Primary Key(Masach),
Constraint FK_Chude Foreign Key(MaCD) References CHUDE(MaCD),
Constraint FK_NhaXB Foreign Key(MaNXB)References
NHAXUATBAN(MANXB)
)
CREATE TABLE DONDATHANG
(
MaDonHang INT IDENTITY(1,1),
Dathanhtoan bit,
Tinhtranggiaohang bit,
Ngaydat Datetime,
Ngaygiao Datetime,
MaKH INT,
CONSTRAINT PK_DonDatHang PRIMARY KEY (MaDonHang),
CONSTRAINT FK_Khachhang FOREIGN KEY(MaKH) REFERENCES Khachhang(MaKH)
)
CREATE TABLE CHITIETDONTHANG
(
MaDonHang INT,
Masach INT,
Soluong Int Check(Soluong>0),
Dongia Decimal(18,0) Check(Dongia>=0),
CONSTRAINT PK_CTDatHang PRIMARY KEY(MaDonHang,Masach),
CONSTRAINT FK_Donhang FOREIGN KEY (Madonhang)
REFERENCES Dondathang(Madonhang),
CONSTRAINT FK_Sach FOREIGN KEY (Masach)
REFERENCES Sach(Masach)
)

INSERT INTO CHUDE VALUES(N'Ngoại ngữ')
INSERT INTO CHUDE VALUES(N'Công nghệ thông tin')
INSERT INTO CHUDE VALUES(N'Luật')
INSERT INTO CHUDE VALUES(N'Văn học')
INSERT INTO CHUDE VALUES(N'Khoa học kỹ thuật')

INSERT INTO NHAXUATBAN VALUES(N'Nhà xuất bản giáo dục',N'112 Cầu Giấy Hà Nội','0437685238')
INSERT INTO NHAXUATBAN VALUES(N'Nhà xuất bản khoa học kỹ thuật',N'90 Trần Hưng Đạo Hà Nội','0437686286')
INSERT INTO NHAXUATBAN VALUES(N'Nhà xuất bản thống kê',N'52A Quang Trung Hà Nội','0437685932')

INSERT INTO SACH VALUES(N'Cấu trúc Tiếng Anh',70000,N'Cuốn sách CẨM NANG CẤU TRÚC TIẾNG ANH gồm 25 phần, mỗi phần là một phạm trù kiến thức trong tiếng Anh được trình bày một cách ngắn gọn, đơn giản, cô đọng và hệ thống hoá dưới dạng sơ đồ, bảng biểu nhằm phát triển khả năng tư duy của người học và từ đó giúp người học nhớ kiến thức nhanh hơn và sâu hơn. Sau hầu hết các phần lí thuyết đều có 20-30 câu bài tập áp dụng để kiểm tra cũng như khắc sâu kiến thức cho người học.','Hinh1.jpg',2019-12-11,140,1,1)
INSERT INTO SACH VALUES(N'Học tốt Tiếng Anh 9',80000,N'Nhằm giúp các em có thể tự học thêm hay ôn tập sau những giờ lên lớp, chúng tôi đã dày công biên soạn cuốn sách HỌC TỐT TIẾNG ANH 9. Đồng thời, đây cũng là tài liệu giúp quý phụ huynh có thể kiểm tra, giúp đỡ con em mình trong quá trình học tập. Nội dung sách gồm 16 đơn vị bài học, trong đó bao gồm 12 Units và 4 bài Review (Ôn tập) với nhiều chủ đề khác nhau. ','Hinh2.jpg',2019-12-13,120,1,2)
INSERT INTO SACH VALUES(N'Cụm động từ Tiếng Anh',75000,N'Trong tiếng Anh có vô số động từ, mỗi động từ lại có thể kết hợp với rất nhiều tiểu từ để tạo nên rất nhiều nghĩa khác nhau. Do đó, việc học cụm động từ tiếng Anh trở nên khá khó khăn với người đọc. Xuất phát từ thực tế này, tác giả đã dày công nghiên cứu để tìm ra phương pháp học cụm động từ tiếng Anh một cách hiệu quả nhất. Tất cả những bí quyết đó được đúc rút và cô đọng trong cuốn sách Chinh phục cụm động từ tiếng Anh.','Hinh3.jpg',2019-12-16,160,1,1)
INSERT INTO SACH VALUES(N'Tin học văn phòng',120000,N'Trong lĩnh vực Tin học văn phòng, Microsoft Word, Excel, PowerPoint, Visio là những chương trình thuộc bộ Microsoft Office đã và đang được ứng dụng rộng rãi trong nhiều lĩnh vực: Kinh tế, kế toán, thương mại, quản lý, vẽ kỹ thuật và nhiều hơn nữa. Với Microsoft Office, bạn có trong tay đầy đủ các công cụ và lệnh để thực hiện các tiện ích trong điện toán văn phòng.','Hinh4.jpg',2019-12-04,200,2,1)
INSERT INTO SACH VALUES(N'Thương mại điện tử',140000,N'Thương mại điện tử là gì? Là quá trình tiến hành một phần hay toàn bộ hoạt động thương mại thông qua những phương tiện điện tử hiện đại. Về bản chất, thương mại điện tử không thay đổi so với các hoạt động thương mại truyền thống. Tuy nhiên, bằng các phương tiện điện tử mới, các hoạt động giao dịch, mua bán, quảng bá được thực hiện nhanh chóng, hiệu quả hơn, giúp tiết kiệm chi phí và mở rộng phạm vi kinh doanh.','Hinh5.jpg',2019-12-09,240,2,2)
INSERT INTO SACH VALUES(N'Lập trình hệ thống',160000,N'Hệ thống nhúng là một môn chuyên ngành ở một số trường kỹ thuật. Tại các trường, hai bo mạch được sử dụng nhiều nhất trong hệ thống nhúng là Arduino và raspberry. Lập Trình Hệ Thống Nhúng Với RASPBRRY là cuốn sách ứng dụng trình bày việc ứng dụng raspberry trong lĩnh vực đo lường điều khiển các đại lượng vật lý thường gặp trong công nghiệp qua các bài tập.','Hinh6.jpg',2019-12-06,180,2,2)



