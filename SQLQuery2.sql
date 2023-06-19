CREATE DATABASE QuanLyNhaHang1
GO
USE QuanLyNhaHang1
GO

CREATE TABLE TAIKHOAN(
	TenTaiKhoan varchar(50) primary key,
	MatKhau varchar(50),
	MaNV varchar(10),
	CapDoQuyen int,

)
INSERT INTO TAIKHOAN VALUES('admin','123','01','1')
INSERT INTO TAIKHOAN VALUES('nvql1','123','04','2')
INSERT INTO TAIKHOAN VALUES('nvlt1','123','05','3')


CREATE TABLE DANHMUC(
	MaDM varchar(50) primary key,
	TenDM nvarchar(50),
)

INSERT INTO DANHMUC VALUES('dm01',N'Món Khai Vị')
INSERT INTO DANHMUC VALUES('dm02',N'Món Súp')
INSERT INTO DANHMUC VALUES('dm03',N'Món Chính')
INSERT INTO DANHMUC VALUES('dm04',N'Nước Uống Không Cồn')
INSERT INTO DANHMUC VALUES('dm05',N'Nước Uống Có Cồn')
INSERT INTO DANHMUC VALUES('dm06',N'Món Tráng Miệng')
INSERT INTO DANHMUC VALUES('dm07',N'Món Ăn Kèm')


CREATE TABLE SANPHAM(
	MaSP varchar(50) primary key,
	TenSP nvarchar(50),
	MaLoaiSP varchar(50),
	TenLoaiSP nvarchar(50),
	GiaSP float,
	AnhSP VARBINARY(MAX) null
	FOREIGN KEY (MaLoaiSP) REFERENCES DANHMUC (MaDM)
)

INSERT INTO SANPHAM VALUES('sp01', N'Baguette', 'dm07', N'Món Ăn Kèm',10000, NULL);
INSERT INTO SANPHAM VALUES('sp02', N'Tortilla Española', 'dm01', N'Món Khai Vị',10000, NULL);
INSERT INTO SANPHAM VALUES('sp03', N'Jambon de Paris', 'dm01', N'Món Khai Vị', 150000, NULL);
INSERT INTO SANPHAM VALUES('sp04', N'Foie gras', 'dm01', N'Món Khai Vị', 50000, NULL);
INSERT INTO SANPHAM VALUES('sp05', N'Quiche Lorraine', 'dm01', N'Món Khai Vị',100000, NULL);
INSERT INTO SANPHAM VALUES('sp06', N'Un blinis au caviar', 'dm01', N'Món Khai Vị' , 230000, NULL);

INSERT INTO SANPHAM VALUES('sp07', N'Bouillabaisse', 'dm02', N'Món Súp',20000, NULL);
INSERT INTO SANPHAM VALUES('sp08', N'Potage Parmentier', 'dm02', N'Món Súp',20000, NULL);
INSERT INTO SANPHAM VALUES('sp09', N'Beef Steak', 'dm03', N'Món Chính', 25000, NULL);
INSERT INTO SANPHAM VALUES('sp010', N'Coq au vin', 'dm03', N'Món Chính', 25000, NULL);
INSERT INTO SANPHAM VALUES('sp011', N'Confit de canard', 'dm03', N'Món Chính', 25000, NULL);
INSERT INTO SANPHAM VALUES('sp012', N'Kebab', 'dm03', N'Món Chính', 25000, NULL);
INSERT INTO SANPHAM VALUES('sp013', N'chemin de la gourmandise', 'dm05', N'Món Tráng Miệng', 200000, NULL);

INSERT INTO SANPHAM VALUES('sp014', N'Chantilly aux cerises', 'dm06', N'Món Tráng Miệng' , 230000, NULL);
INSERT INTO SANPHAM VALUES('sp015', N'Don Melchor', 'dm05', N'Nước Uống Có Cồn' , 230000, NULL);
INSERT INTO SANPHAM VALUES('sp016', N'Silver Oak', 'dm05', N'Nước Uống Có Cồn' , 230000, NULL);
INSERT INTO SANPHAM VALUES('sp017', N'Chivas 12', 'dm05', N'Nước Uống Có Cồn' , 230000, NULL);
INSERT INTO SANPHAM VALUES('sp018', N'Coca-Cola', 'dm04', N'Nước Uống Không Cồn',10000, NULL);
INSERT INTO SANPHAM VALUES('sp019', N'Croissant', 'dm07', N'Món Ăn Kèm',10000, NULL);
INSERT INTO SANPHAM VALUES('sp020', N'Yorkshire Pudding ', 'dm07', N'Món Ăn Kèm',10000, NULL);
INSERT INTO SANPHAM VALUES('sp021', N'Beef Wellington', 'dm03', N'Món Chính',100000, NULL);
INSERT INTO SANPHAM VALUES('sp022', N'Pommes Duchesse', 'dm01', N'Món Khai Vị',100000, NULL);
INSERT INTO SANPHAM VALUES('sp023', N'Boeuf Bourguignon', 'dm03', N'Món Chính',100000, NULL);
INSERT INTO SANPHAM VALUES('sp024', N'Coffee', 'dm04', N'Nước Uống Không Cồn',10000, NULL);
INSERT INTO SANPHAM VALUES('sp025', N'Soda', 'dm04', N'Nước Uống Không Cồn',10000, NULL);
INSERT INTO SANPHAM VALUES('sp026', N'Jus de Fruits', 'dm04', N'Nước Uống Không Cồn',10000, NULL);
CREATE TABLE BAN
(
	Tid varchar(50) primary key,
	Tname nvarchar(50),
	Tstate nvarchar(50) 
)
INSERT INTO BAN VALUES('t1', N'bàn số 1', N'Bàn Trống');
INSERT INTO BAN VALUES('t2', N'bàn số 2', N'Đã Đặt');
INSERT INTO BAN VALUES('t3', N'bàn số 3', N'Bàn Trống');
INSERT INTO BAN VALUES('t4', N'bàn số 4', N'Bàn Trống');
INSERT INTO BAN VALUES('t5', N'bàn số 5', N'Đã Đặt');
INSERT INTO BAN VALUES('t6', N'bàn số 6', N'Bàn Trống');
INSERT INTO BAN VALUES('t7', N'bàn số 7', N'Bàn Trống');
INSERT INTO BAN VALUES('t8', N'bàn số 8', N'Bàn Trống');
INSERT INTO BAN VALUES('t9', N'bàn số 9', N'Bàn Trống');
INSERT INTO BAN VALUES('t10', N'bàn số 10', N'Bàn Trống');

CREATE TABLE NHANVIEN(
	Manv varchar(50) primary key,
	Ten nvarchar(50),
	SDT varchar(50),
	ChucVu nvarchar(50),
	Luong float
)

INSERT INTO NHANVIEN VALUES('NV1', N'Trần Văn Nghĩa', '0239584793', N'Bếp Trưởng', 15000000);
INSERT INTO NHANVIEN VALUES('NV2', N'Nguyễn Thế Tài', '0378624589', N'Phụ Bếp',10000000);
INSERT INTO NHANVIEN VALUES('NV3',N'Lê Thế Cương', '0872534158', N'Phục Vụ',6000000);
INSERT INTO NHANVIEN VALUES('NV4',N'Võ Thị Lan', '0354698721', N'Phục Vụ', 6000000);
INSERT INTO NHANVIEN VALUES('NV5', N'Tran Nguyen Vy Oanh', '0258613487', N'Thu Ngân', 8000000);
INSERT INTO NHANVIEN VALUES('NV6', N'Nguyễn Văn Khoa', '0358613489', N'Giao Hàng', 8000000);
INSERT INTO NHANVIEN VALUES('NV7', N'Trần Đông', '0858613487', N'Giao Hàng', 8000000);
INSERT INTO NHANVIEN VALUES('NV8', N'Huỳnh Anh', '0538613487', N'Phụ Bếp', 8000000);
INSERT INTO NHANVIEN VALUES('NV9', N'Lê An', '0569613487', N'Quản Lý', 20000000);
INSERT INTO NHANVIEN VALUES('NV10',N'Lý Tuấn', '0862932158', N'Phục Vụ',6000000);

Create table tblMain
(

aDate date,
aTime Varchar(50),
TableName nvarchar(50), WaiterName nvarchar(50), status varchar(15), orderType varchar(20),
total float,
received float, change float,
driverID nvarchar(50),
cusName nvarchar(50),
cusPhone varchar(50)
)
ALTER TABLE tblMain
ADD MaBill INT IDENTITY(1,1) primary key

Create table tblDetails
(
MaBill int,
proID varchar(50) ,
proName nvarchar(50), qty int,
price float,
amount float
)
ALTER TABLE tblDetails
ADD DetailID INT IDENTITY(1,1) primary key


