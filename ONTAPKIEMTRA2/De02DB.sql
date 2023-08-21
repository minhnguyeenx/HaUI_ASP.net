use master
go
create database [De2]

go
use [De2]
go

--Tao bang san pham
create table [dbo].[SanPham](
	[Masp] [nchar] (10) not null primary key,
	[Tensp] [nvarchar] (50) null,
	[Donvitinh] [nvarchar] (50) null,
	[Soluong] [int] null
)

drop table SanPham

--chen du lieu
insert into SanPham(Masp, Tensp, Donvitinh, Soluong) values('01', N'Gạo bắc hương', N'Kg', 100)
insert into SanPham(Masp, Tensp, Donvitinh, Soluong) values('02', N'Gạo thái', N'Kg', 120)
insert into SanPham(Masp, Tensp, Donvitinh, Soluong) values('03', N'Sữa đài loan', N'Kg', 180)
insert into SanPham(Masp, Tensp, Donvitinh, Soluong) values('04', N'Sữa ông thọ', N'Kg', 130)

select * from SanPham