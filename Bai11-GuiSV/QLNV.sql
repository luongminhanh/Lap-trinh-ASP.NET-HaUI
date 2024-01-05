use master
go
if DB_ID('QLNV') is not null
	drop database QLNV
go
create database QLNV
go
use QLNV
go
create table Phong(
Maphong int primary key identity,
Tenphong nvarchar(25)
)
insert into Phong values('Hanh chinh')
insert into Phong values('Ke toan')
insert into Phong values('Tong hop')
go
create table NhanVien(
Manv int primary key identity,
Hoten nvarchar(30),
Matkhau nvarchar(30),
Tuoi int,
Diachi nvarchar(30),
Luong int,
Maphong int foreign key references Phong(Maphong))
go
insert into NhanVien values('Lan Anh','123',32,'Ha noi',3500,1)
insert into NhanVien values('Thi Huong','456',30,'Ha noi',5000,2)
insert into NhanVien values('Van Ha','756',30,'Hai phong',4000,1)
insert into NhanVien values('Hong Linh','986',35,'Thai binh',5500,3)
insert into NhanVien values('Van Hung','812',32,'Hai phong',5000,1)
insert into NhanVien values('Hai Yen','trh',28,'Thai binh',3000,1)
insert into NhanVien values('My Ha','kjh',26,'Hai phong',3000,2)
insert into NhanVien values('Phuong Thuy','87h',24,'Hai phong',2000,3)
insert into NhanVien values('Do Minh Duc','123',24,'Ha noi',2500,2)
insert into NhanVien values('Cong Tuan','dsc',40,'Thai binh',4500,2)
go
select * from Phong
select * from NhanVien
