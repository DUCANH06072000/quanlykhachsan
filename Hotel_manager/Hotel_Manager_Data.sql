Create Database Hotel_Manager_Data
go

Use Hotel_Manager_Data
go


-- tạo bảng Login -----
CREATE TABLE DangNhap (
    Taikhoan nvarchar(50) NOT NULL PRIMARY KEY, -- tao khoa chinh
    Matkhau nvarchar(50),
    FullName nvarchar(50),
	Email varchar(50),
    phanquyen int,
	trangthai int NOT NULL,
)


CREATE TABLE Nhanvien (
    Manv nvarchar(15) NOT NULL PRIMARY KEY, -- tao khoa chinh
    Tennv nvarchar(50),
    Ngaysinh date,
    gioitinh nvarchar(10),
    sdt nvarchar(15),
	Cmnd nvarchar(30),
	Email nvarchar(500), 
)


CREATE TABLE Khachhang (
    MaKh nvarchar(15) NOT NULL PRIMARY KEY,-- tao khoa chinh
    Tenkh nvarchar(50),
    Ngaysinh date,
    gioitinh nvarchar(10),
    sdt nvarchar(15),
	Cmnd nvarchar(30),
	Email nvarchar(500), 
)


Create TABLE Phong (
	MaPhong nvarchar(15) NOT NULL PRIMARY KEY,-- tao khoa chinh
	TenPhong nvarchar(50),
	loaiphong nvarchar(50),
	Mota nvarchar(500),
	songtoida int,
	trangthai nvarchar(50) NOT NULL, 	
	FOREIGN KEY (loaiphong) REFERENCES LPhong(loaiphong) -- tao rang buoc khoa giua 2 bang Phong va Loai phong 
)


Create Table LPhong
(
	loaiphong nvarchar(50) NOT NULL PRIMARY KEY,
	mota nvarchar(50),
	giaphong real
)

Create Table Khohang (
	Maitem nvarchar(15) not null primary key,
	TenItem nvarchar(500),
	gianhap real,
	soluong int,
	giaban real
)

Create Table NhapKho(
	Id_hd nvarchar(15) not null primary key,
	sanpham nvarchar(500),
	ngaynhap date,
	Thanhtien real
)

Create Table Phuthu(
	MaPhu nvarchar(15) not null primary key,
	MaKh nvarchar(15),
	Maitem nvarchar(15),
	tensp nvarchar(500),
	soluong int,
	gia real,
	trangthai int,
	thanhtien real,
	 FOREIGN KEY (Makh) REFERENCES Khachhang(Makh),
	 FOREIGN KEY (Maitem) REFERENCES Khohang(Maitem)
)

Create Table Hoadon
(
	id_hoadon nvarchar(15) not null primary key,
	MaPhong nvarchar(15),
	Makh nvarchar(15),
	Manv nvarchar(15),
	Ngaydatphong date,
	Ngaynhanphong date,
	Ngaytraphong date,
	soluongnguoi int,
	phiphong real,
	phiphuthu real,
	thanhtien real,
	trangthai nvarchar(50),
	 FOREIGN KEY (Makh) REFERENCES Khachhang(Makh),
	 FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
	 FOREIGN KEY (Manv) REFERENCES Nhanvien(Manv),
)


-- Insert Login --
Insert into DangNhap(Taikhoan,Matkhau,FullName,Email,phanquyen,trangthai) 
Values('admin','123456',N'Trần Hữu Anh','anh@gmail.com',1,1),
('quanly','123456',N'Trần Mạnh Hùng','hung@gmail.com',2,1),
('nguoidung','123456',N'Ngô Khai Anh','anhkh@gmail.com',3,1),
('nguoidung2','123456',N'Trần Hữu Anh','anhkh@gmail.com',3,0);


-- Insert Nhanvien ---
Insert into Nhanvien(Manv,Tennv,Ngaysinh,gioitinh,sdt,Cmnd,Email) 
Values ('nv01',N'Trần Hữu Anh','1996-08-25','Nam','0386143805','145715186','anhth.hh@gmail.com'),
('nv02',N'Trần Văn Hiệp','1998-12-15','Nam','0366524687','145715189','hieptr.hh@gmail.com'),
('nv03',N'Hoang Van Nam','1999-03-02','Nam','0385145235','145715125','namhv.hh@gmail.com'),
('nv04',N'Trần Thị Linh','2000-06-07',N'Nữ','0366888521','154862123','linhtt.hh@gmail.com');


-- Insert Khach hang --
Insert into Khachhang(MaKh,Tenkh,Ngaysinh,gioitinh,sdt,Cmnd,Email) values
('kh01',N'Đoàn Duy Khanh','1993-02-03',N'Nam',0386123242,'146582362','khach@gmail.com'),
('kh02',N'Trần Doãn Mạnh','1992-12-05',N'Nam',0386427880,'146582895','manh@gmail.com'),
('kh03',N'Trần Văn Minh','1996-09-11',N'Nam' ,0366421315,'146582662','Minh@gmail.com'),
('kh04',N'Trần Hoài Nam','1999-01-14',N'Nam' ,0976445444,'146582321','Namhh@gmail.com');

-- Insert Lphong -- 
Insert into LPhong(loaiphong,mota,giaphong) Values
('VIP',N'Phòng cao cấp',600000),
('Phòng đơn',N'Phòng thường',400000),
('Phòng đôi',N'Phòng thường',500000),


-- Insert phong --

Insert into Phong(MaPhong,TenPhong,loaiphong,Mota,songtoida,trangthai) values
('ph01',N'6001',N'VIP',N'Phòng đẹp, rộng 5*15m, có cửa sổ, view đẹp nhìn ra biển',4,N'Đã đặt'),
('ph02',N'4001',N'Standard',N'Phòng đẹp, rộng 4*6m, có cửa sổ, view hồ ',2,N'Trống'),
('ph03',N'4002',N'Superior ',N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển',4,N'Trống'),
('ph04',N'4003',N'Deluxe',N'Phòng đẹp, rộng 3*8m, có cửa sổ, view đẹp nhìn ra biển',4,N'Trống'),
('ph05',N'4004',N'Standard',N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển',2,N'Trống'),
('ph06',N'4005',N'Standard',N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển',2,N'Trống'),
('ph07',N'4006',N'Superior',N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển',4,N'Trống');

-- Insert kho hang --

Insert into Khohang (Maitem,TenItem,gianhap,giaban,soluong) Values
('it06',N'BimBims',8000,10000,500),
('it01',N'Cocacola',6000,10000,2000),
('it02',N'Khăn giương',10000,20000,200),
('it04',N'xe đạp',50000,100000,20)


-- Insert hoadon -- 
Insert into Hoadon (id_hoadon,MaPhong,Makh,Manv,Ngaydatphong,Ngaynhanphong,Ngaytraphong,soluongnguoi,phiphong,phiphuthu,thanhtien,trangthai) Values
('hd01','ph01','kh01','nv01','2020-10-26','2020-10-27','2020-10-30',4,3600000,300000,2100000,N'Đã đặt');


-- Insert Phuthu --

insert into Phuthu (MaPhu,MaKh,Maitem,tensp,gia,soluong,thanhtien,trangthai) Values
('ph01','kh01','it01',N'BimBims',10000,10,100000,0),
('ph02','kh01','it02',N'Khăn giương',10000,1,100000,0),
('ph04','kh01','it05',N'Khăn mặt',10000,10,100000,0);
