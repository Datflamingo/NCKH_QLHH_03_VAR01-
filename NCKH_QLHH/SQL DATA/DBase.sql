create database NCKH_QLHH
go
use NCKH_QLHH
go
create table dbo.QLHH_main
(
	id bigint PRIMARY KEY,
	Ten_san_pham nvarchar(30) NOT nULL,
	So_thung int nOT Null,
	So_luong_trong_1_thung int not null,
)
go
insert into QLHH_main values (124352531658337, N'Trà xanh không độ', 12, 24);
insert into QLHH_main values (12435253151211630, N'Sting dâu', 12, 24);
insert into QLHH_main values (12435253137616, N'Coca cola vị nguyên bản', 150, 24);
insert into QLHH_main values (12435253157137100, N'Pepsi vị chanh không calo', 10, 24);
insert into QLHH_main values (1243525316111999, N'Red Bull', 120, 24);
insert into QLHH_main values (124352531356739, N'Nabati phô mai', 1000, 40);
go


ALTER TABLE QLHH_main 
ADD So_donvi_da_nhap as So_thung*So_luong_trong_1_thung ; 

ALTER TABLE QLHH_main 
ADD So_donvi_da_xuat int;

ALTER TABLE QLHH_main 
ADD So_thung_da_xuat int;

ALTER TABLE QLHH_main 
ADD So_donvi_con_lai as (So_thung*So_luong_trong_1_thung)-So_donvi_da_xuat;

ALTER TABLE QLHH_main 
ADD So_thung_con_lai as (((So_thung*So_luong_trong_1_thung)-So_donvi_da_xuat)/So_luong_trong_1_thung)-So_thung_da_xuat;

ALTER TABLE QLHH_main 
ADD So_le as ((So_thung*So_luong_trong_1_thung)-So_donvi_da_xuat)%So_luong_trong_1_thung;

ALTER TABLE QLHH_main 
ADD Don_gia int;

ALTER TABLE QLHH_main 
ADD Gia_si int;

ALTER TABLE QLHH_main 
ADD Doanh_thu as (So_donvi_da_xuat*Don_gia) + (So_thung_da_xuat*Gia_si);



create table dbo.Nhan_vien
(
	TaiKhoan nvarchar(30) not null,
	MatKhau nvarchar(30) not null,
)
go

ALTER TABLE Nhan_vien 
ADD Ten nvarchar(100);


