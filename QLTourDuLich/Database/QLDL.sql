--DESKTOP-K4N035T\SQLEXPRESS
--TAO CO SO DU LIEU
create database QUANLYTOURDULICH
--SU DUNG CO SO DU LIEU
use QUANLYTOURDULICH

--TAO CAC BANG
create table TOURDULICH
(
	MATOUR char(4) not null,
	TENGOI nvarchar(100) not null,
	DACDIEM nvarchar(100) not null,
	MALOAIHINH char(4) not null --FK
)
create table DIADIEM
(
	MADIADIEM char(4) not null,
	TENDIADIEM nvarchar(100) not null
)
create table CHITIETTOUR
(
	MATOUR char(4) not null,
	MADIADIEM char(4) not null, 
	THUTU int not null
)
create table LOAIHINHDULICH
(
	MALOAIHINH char(4) not null,
	TENLOAIHINH nvarchar(100) not null
)
create table GIATOUR
(
	MAGIA char(4) not null,
	MATOUR char(4) not null, --FK
	THANHTIEN float,
	TG_BATDAU datetime,
	TG_KETTHUC datetime
)
create table DOANDULICH
(
	MADOAN char(4) not null,
	MATOUR char(4) not null, --FK
	NGAYKHOIHANH datetime,
	NGAYKETTHUC datetime,
	DOANHTHU float not null  --Doanh thu = gia tour * so luong khach
)
create table CHITIETDOAN
(
	MADOAN char(4) not null,
	MAKH char(4) not null,
	VAITROKH nvarchar(100)
)
create table NOIDUNG
(
	MADOAN char(4) not null,
	HANHTRINH nvarchar(100),
	KHACHSAN nvarchar(100) not null
)
create table KHACH
(
	MAKH char(4) not null,
	HOTEN nvarchar(100) not null,
	CMND char(12),
	DIACHI nvarchar(100),
	GIOITINH nvarchar(3),
	SDT char(10),
	QUOCTICH nvarchar(100)
)
create table NHANVIEN
(
	MANV char(4) not null,
	TENNV nvarchar(100) not null
)
create table PHANBONHANVIEN
(
	MANV char(4) not null,
	MADOAN char(4) not null,
	NHIEMVU nvarchar(100)
)
create table CHIPHI
(
	MACHIPHI char(4) not null,
	MADOAN char(4) not null, 
	SOTIEN float
)
create table LOAICHIPHI
(
	MACHIPHI char(4) not null,
	TENLOAICHIPHI nvarchar(100) not null
)

--TAO KHOA
--TAO KHOA CHINH
alter table TOURDULICH add constraint PK_TOURDULICH primary key (MATOUR)
alter table DIADIEM add constraint PK_DIADIEM primary key (MADIADIEM)
alter table CHITIETTOUR add constraint PK_CHITIETTOUR primary key (MATOUR,MADIADIEM)
alter table LOAIHINHDULICH add constraint PK_LOAIHINHDULICH primary key (MALOAIHINH)
alter table GIATOUR add constraint PK_GIATOUR primary key (MAGIA)
alter table DOANDULICH add constraint PK_DOANDULICH primary key (MADOAN)
alter table CHITIETDOAN add constraint PK_CHITIETDOAN primary key (MADOAN,MAKH)
alter table NOIDUNG add constraint PK_NOIDUNG primary key (MADOAN)
alter table KHACH add constraint PK_KHACH primary key (MAKH)
alter table NHANVIEN add constraint PK_NHANVIEN primary key (MANV)
alter table PHANBONHANVIEN add constraint PK_PHANBONHANVIEN primary key (MANV,MADOAN)
alter table CHIPHI add constraint PK_CHIPHI primary key (MACHIPHI,MADOAN)
alter table LOAICHIPHI add constraint PK_LOAICHIPHI primary key (MACHIPHI)
--TAO KHOA NGOAI
alter table TOURDULICH add constraint FK_TOURDULICH foreign key (MALOAIHINH) references LOAIHINHDULICH(MALOAIHINH)
alter table CHITIETTOUR add constraint FK_CHITIETTOUR foreign key (MATOUR) references TOURDULICH(MATOUR)
alter table CHITIETTOUR add constraint FK_CHITIETTOUR1 foreign key (MADIADIEM) references DIADIEM(MADIADIEM)
alter table GIATOUR add constraint FK_GIATOUR foreign key (MATOUR) references TOURDULICH(MATOUR)
alter table DOANDULICH add constraint FK_DOANDULICH foreign key (MATOUR) references TOURDULICH(MATOUR)
alter table CHITIETDOAN add constraint FK_CHITIETDOAN foreign key (MADOAN) references DOANDULICH(MADOAN)
alter table CHITIETDOAN add constraint FK_CHITIETDOAN1 foreign key (MAKH) references KHACH(MAKH)
alter table NOIDUNG add constraint FK_NOIDUNG foreign key (MADOAN) references DOANDULICH(MADOAN)
alter table PHANBONHANVIEN add constraint FK_PHANBONHANVIEN foreign key (MANV) references NHANVIEN(MANV)
alter table CHIPHI add constraint FK_CHIPHI foreign key (MACHIPHI) references LOAICHIPHI(MACHIPHI)
alter table CHIPHI add constraint FK_CHIPHI1 foreign key (MADOAN) references DOANDULICH(MADOAN)

--THEM DU LIEU
--NHAP DU LIEU TABLE: TOURDULICH
insert into TOURDULICH(MATOUR,TENGOI,DACDIEM,MALOAIHINH) values ('T001',N'S??I G??N - NHA TRANG',N'2 ng??y 1 ????m','LH01')
insert into TOURDULICH(MATOUR,TENGOI,DACDIEM,MALOAIHINH) values ('T002',N'S??I G??N - ???? L???T',N'2 ng??y 1 ????m','LH02')
insert into TOURDULICH(MATOUR,TENGOI,DACDIEM,MALOAIHINH) values ('T003',N'S??I G??N - MI???N T??Y',N'2 ng??y 1 ????m','LH03')
insert into TOURDULICH(MATOUR,TENGOI,DACDIEM,MALOAIHINH) values ('T004',N'S??I G??N - T??Y NGUY??N',N'2 ng??y 1 ????m','LH04')
--NHAP DU LIEU TABLE: DIADIEM
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D001',N'?????o H??n Mun')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D002',N'?????o B??nh Ba')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D003',N'Th??c Datanla ???? L???t')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D004',N'N??i Langbiang ???? L???t')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D005',N'Ch??? n???i C??i R??ng')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D006',N'B???n Ninh Ki???u')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D007',N'Hang Ch?? Bluk (Hang D??i)')
insert into DIADIEM(MADIADIEM,TENDIADIEM) values ('D008',N'Khu du l???ch sinh th??i n??i M??r??k')
--NHAP DU LIEU TABLE: THAMQUAN
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T001','D001','1')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T001','D002','2')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T002','D003','1')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T002','D004','2')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T003','D005','1')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T003','D006','2')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T004','D007','1')
insert into CHITIETTOUR(MATOUR,MADIADIEM,THUTU) values ('T004','D008','2')
--NHAP DU LIEU TABLE: LOAIHINHDULICH
insert into LOAIHINHDULICH(MALOAIHINH,TENLOAIHINH) values ('LH01',N'Du l???ch x?? h???i v?? gia ????nh')
insert into LOAIHINHDULICH(MALOAIHINH,TENLOAIHINH) values ('LH02',N'Du l???ch c?? nh??n')
insert into LOAIHINHDULICH(MALOAIHINH,TENLOAIHINH) values ('LH03',N'Du l???ch teambuilding')
insert into LOAIHINHDULICH(MALOAIHINH,TENLOAIHINH) values ('LH04',N'Du l???ch sinh th??i')
--NHAP DU LIEU TABLE: GIATOUR
insert into GIATOUR(MAGIA,MATOUR,THANHTIEN,TG_BATDAU,TG_KETTHUC) values ('GT01','T001','1200000','2022-02-22','2022-04-22')
insert into GIATOUR(MAGIA,MATOUR,THANHTIEN,TG_BATDAU,TG_KETTHUC) values ('GT02','T002','950000','2022-06-12','2022-08-12')
insert into GIATOUR(MAGIA,MATOUR,THANHTIEN,TG_BATDAU,TG_KETTHUC) values ('GT03','T003','600000','2022-01-05','2022-06-05')
insert into GIATOUR(MAGIA,MATOUR,THANHTIEN,TG_BATDAU,TG_KETTHUC) values ('GT04','T004','2000000','2022-05-17','2022-09-17')
--NHAP DU LIEU TABLE: DOANDULICH
insert into DOANDULICH(MADOAN,MATOUR,NGAYKHOIHANH,NGAYKETTHUC,DOANHTHU) values ('DO01','T001','2022-03-15','2022-03-17','6000000')
insert into DOANDULICH(MADOAN,MATOUR,NGAYKHOIHANH,NGAYKETTHUC,DOANHTHU) values ('DO02','T002','2022-06-25','2022-06-27','4750000')
insert into DOANDULICH(MADOAN,MATOUR,NGAYKHOIHANH,NGAYKETTHUC,DOANHTHU) values ('DO03','T003','2022-04-16','2022-04-18','3000000')
insert into DOANDULICH(MADOAN,MATOUR,NGAYKHOIHANH,NGAYKETTHUC,DOANHTHU) values ('DO04','T004','2022-05-19','2022-05-21','10000000')
--NHAP DU LIEU TABLE: CHITIETDOAN
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO01','KH01',N'Kh??ch ??i du l???ch v???i gia ????nh')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO01','KH02',N'Kh??ch ??i du l???ch v???i gia ????nh')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO01','KH03',N'Kh??ch ??i du l???ch v???i gia ????nh')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO01','KH04',N'Kh??ch ??i du l???ch v???i gia ????nh')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO01','KH05',N'Kh??ch ??i du l???ch v???i gia ????nh')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO02','KH06',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO02','KH07',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO02','KH08',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO02','KH09',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO02','KH10',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO03','KH11',N'Kh??ch h??ng ??i du l???ch theo c??ng ty')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO03','KH12',N'Kh??ch h??ng ??i du l???ch theo c??ng ty')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO03','KH13',N'Kh??ch h??ng ??i du l???ch theo c??ng ty')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO03','KH14',N'Kh??ch h??ng ??i du l???ch theo c??ng ty')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO03','KH15',N'Kh??ch h??ng ??i du l???ch theo c??ng ty')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO04','KH16',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO04','KH17',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO04','KH18',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO04','KH19',N'Kh??ch ??i du l???ch c?? nh??n')
insert into CHITIETDOAN(MADOAN,MAKH,VAITROKH) values ('DO04','KH20',N'Kh??ch ??i du l???ch c?? nh??n')
--NHAP DU LIEU TABLE: NOIDUNG
insert into NOIDUNG(MADOAN,HANHTRINH,KHACHSAN) values ('DO01','',N'Rex Hotel & Apartment')
insert into NOIDUNG(MADOAN,HANHTRINH,KHACHSAN) values ('DO02','',N'Lamie Hotel & Studio')
insert into NOIDUNG(MADOAN,HANHTRINH,KHACHSAN) values ('DO03','',N'ConVoi Hotel')
insert into NOIDUNG(MADOAN,HANHTRINH,KHACHSAN) values ('DO04','',N'Tay Nguyen Hotel')
--NHAP DU LIEU TABLE: KHACH
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH01',N'Nguy???n Th??y Chi','072145783465',N'T???nh L??? 10, Qu???n B??nh T??n, TP HCM',N'N???','0321589102',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH02',N'Nguy???n ?????c Minh','072182374584',N'T???nh L??? 10, Qu???n B??nh T??n, TP HCM',N'Nam','0705145202',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH03',N'Nguy???n Tuy???t Nhi','072148376014',N'T???nh L??? 10, Qu???n B??nh T??n, TP HCM',N'N???','0934123521',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH04',N'Nguy???n Gia An','072132459731',N'T???nh L??? 10, Qu???n B??nh T??n, TP HCM',N'Nam','0924151325',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH05',N'Nguy???n Thanh Nh???t','072103502234',N'T???nh L??? 10, Qu???n B??nh T??n, TP HCM',N'Nam','0935120275',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH06',N'Ph???m ??nh D????ng','072147582390',N'Nguy???n C??ng Tr???, Qu???n B??nh Th???nh, TP HCM',N'N???','0935120275',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH07',N'Ph???m Thi??n ??n','072177381353',N'Phan V??n H???n, Huy???n H??c M??n, TP HCM',N'Nam','0950123589',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH08',N'?????ng Gia H??n','072131453401',N'Hu???nh V??n Ngh???, Qu???n G?? V???p, TP HCM',N'N???','0795342467',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH09',N'?????ng Ng???c Gia Nguy??n','072243531123',N'Nguy???n V??n Tr???i, Qu???n Ph?? Nhu???n, TP HCM',N'Nam','0940567316',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH10',N'????? Ph????ng Th???o','072158301345',N'B???ch ?????ng, Qu???n T??n B??nh, TP HCM',N'N???','0775428796',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH11',N'????? Quang Kh???i','072192843592',N'Phan Ch??u Trinh, Qu???n T??n Ph??, TP HCM',N'Nam','0902464703',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH12',N'Ph???m Di???u Linh','072132151233',N'Ph???m V??n S??ng, Huy???n B??nh Ch??nh, TP HCM',N'N???','0762190538',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH13',N'Ph???m H??ng C?????ng','072113857182',N'Nguy???n Huy T?????ng, Qu???n B??nh Th???nh, TP HCM',N'Nam','0351298632',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH14',N'?????ng Tr??c L??m','072132183731',N'C??y Tr??m, Qu???n G?? V???p, TP HCM',N'N???','0924582906',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH15',N'?????ng Minh Qu??n','072100345812',N'Tr???n Quang Di???u, Qu???n Ph?? Nhu???n, TP HCM',N'Nam','0705643219',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH16',N'????? ??an H???','072153941753',N'Ng??? B??nh, Qu???n T??n B??nh, TP HCM',N'N???','0399641785',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH17',N'????? Th??i D????ng','072157601234',N'Ph???m V??n ?????ng, Qu???n Th??? ?????c, TP HCM',N'Nam','0761297518',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH18',N'Ho??ng V??n Kh??nh','072149502586',N'An Th???i ????ng, Huy???n C???n Gi???, TP HCM',N'N???','0388127529',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH19',N'??inh Nh?? Uy??n','072134151349',N'Quang Trung, Qu???n 12, TP HCM',N'N???','0937841679',N'Vi???t Nam')
insert into KHACH(MAKH,HOTEN,CMND,DIACHI,GIOITINH,SDT,QUOCTICH) values ('KH20',N'V?? H?? My','072143178913',N'T??n ?????n, Qu???n 4, TP HCM',N'N???','0367189002',N'Vi???t Nam')
--NHAP DU LIEU TABLE: NHANVIEN
insert into NHANVIEN(MANV,TENNV) values ('NV01',N'T?? Ng???c B??ch')
insert into NHANVIEN(MANV,TENNV) values ('NV02',N'?????ng Thi??n H????ng')
insert into NHANVIEN(MANV,TENNV) values ('NV03',N'L?? Thanh H???ng')
insert into NHANVIEN(MANV,TENNV) values ('NV04',N'Nguy???n Trung Ki??n')
--NHAP DU LIEU TABLE: PHANBONHANVIEN
insert into PHANBONHANVIEN(MANV,MADOAN,NHIEMVU) values ('NV01','DO01',N'H?????ng d???n vi??n')
insert into PHANBONHANVIEN(MANV,MADOAN,NHIEMVU) values ('NV02','DO02',N'H?????ng d???n vi??n')
insert into PHANBONHANVIEN(MANV,MADOAN,NHIEMVU) values ('NV03','DO03',N'H?????ng d???n vi??n')
insert into PHANBONHANVIEN(MANV,MADOAN,NHIEMVU) values ('NV04','DO04',N'H?????ng d???n vi??n')
--NHAP DU LIEU TABLE: CHIPHI
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP01','DO01','600000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP02','DO01','500000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP03','DO01','100000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP01','DO02','450000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP02','DO02','400000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP03','DO02','100000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP01','DO03','300000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP02','DO03','200000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP03','DO03','100000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP01','DO04','1200000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP02','DO04','700000')
insert into CHIPHI(MACHIPHI,MADOAN,SOTIEN) values ('CP03','DO04','100000')
--NHAP DU LIEU TABLE: LOAICHIPHI
insert into LOAICHIPHI(MACHIPHI,TENLOAICHIPHI) values ('CP01',N'Chi ph?? tr???c ti???p')
insert into LOAICHIPHI(MACHIPHI,TENLOAICHIPHI) values ('CP02',N'Chi ph?? nh??n vi??n h?????ng d???n vi??n')
insert into LOAICHIPHI(MACHIPHI,TENLOAICHIPHI) values ('CP03',N'Chi ph?? qu???n l?? ph???c v???')

--T??nh S??? L?????ng Kh??ch M???i ??o??n
select COUNT(CHITIETDOAN.MAKH)
from (CHITIETDOAN inner join DOANDULICH on DOANDULICH.MADOAN = CHITIETDOAN.MADOAN inner join KHACH on KHACH.MAKH=CHITIETDOAN.MAKH)
group by DOANDULICH.MADOAN


SELECT MATOUR,TENGOI, DACDIEM, TENLOAIHINH FROM dbo.TOURDULICH TOUR, dbo.LOAIHINHDULICH LOAI WHERE TOUR.MALOAIHINH = LOAI.MALOAIHINH

SELECT MATOUR, TENDIADIEM, THUTU FROM dbo.CHITIETTOUR CTT, dbo.DIADIEM DD WHERE CTT.MADIADIEM = DD.MADIADIEM  AND MATOUR ='T001' 

select * from LOAIHINHDULICH

select * from TOURDULICH


