USE master
GO
CREATE DATABASE [QLNhanVien]
GO
USE [QLNhanVien]
GO
--Tạo bảng Phong
CREATE TABLE [dbo].[Phong](
	[Maphong] [char](10) NOT NULL PRIMARY KEY,
	[Tenphong] [nvarchar](50) NOT NULL)
GO
--Tạo bảng Nhanvien
CREATE TABLE [dbo].[NhanVien](
	[Manv] [char](10) NOT NULL PRIMARY KEY,
	[Hoten] [nvarchar](50) NULL,
	[Maphong] [char](10) NULL,
	[Luong] [float] NULL)
GO

--Chèn dữ liệu cho bảng Phong
Insert into Phong(Maphong,Tenphong) values('P01',N'Tài vụ')
Insert into Phong(Maphong,Tenphong) values('P02',N'Kỹ thuật')

--Chèn dữ liệu cho bảng NhanVien
Insert into NhanVien(Manv,Hoten,Maphong,Luong) values('01',N'Lê Thị Hà','P01',4000000)
Insert into NhanVien(Manv,Hoten,Maphong,Luong) values('02',N'Trần Minh Đại','P01',5000000)
Insert into NhanVien(Manv,Hoten,Maphong,Luong) values('03',N'Đỗ Thị Vân','P02',7000000)
Insert into NhanVien(Manv,Hoten,Maphong,Luong) values('04',N'Ngô Văn Hà','P02',6000000)
Select * From Nhanvien