CREATE DATABASE [QLDIENTHOAI]

USE QLDIENTHOAI
GO

CREATE TABLE HANGDT
(
	ID_HangDT int IDENTITY(1,1) NOT NULL primary key,
	tenHang nvarchar(50) NOT NULL,
	moTa text NOT NULL,
	ghiChu text NOT NULL
)
GO
CREATE TABLE LOAIDT
(
	ID_LoaiDT int IDENTITY(1,1) NOT NULL primary key,
	tenLoaiDT nvarchar(50) NOT NULL,
	moTa text NULL,
)
GO
CREATE TABLE [ROLE]
(
	ID_Role int IDENTITY(1,1) NOT NULL primary key,
	tenRole nvarchar(50) NOT NULL,
	ghiChu text NULL,
)
GO
CREATE TABLE DIENTHOAI
(
	ID_dienThoai int IDENTITY(1,1) NOT NULL primary key,
	tenDienThoai nvarchar(50) not null,
	soLuongTon int NOT NULL,
	donGia money NULL,
	hinhAnh nvarchar(150) NULL,
	moTa text NULL,
	ID_LoaiDT int NOT NULL FOREIGN KEY(ID_LoaiDT) REFERENCES LOAIDT(ID_LoaiDT),
	ID_HangDT int NOT NULL FOREIGN KEY(ID_HangDT) REFERENCES HANGDT(ID_HangDT),
	ghiChu text NULL,
	hanBaoHanh date NULL,
	thongSoKyThuat text NULL,

)
GO
CREATE TABLE KHACHHANG
(
	ID_KhachHang int IDENTITY(1,1) NOT NULL primary key,
	email varchar(50) NOT NULL,
	SDT varchar(11) NOT NULL,
	tenKhachHang nvarchar(50) NOT NULL,
	diaChi text NOT NULL,
	SCMND varchar(10) NOT NULL Unique,
)
GO
CREATE TABLE [USER]
(
	ID_User int NOT NULL IDENTITY(1,1) primary key,
	taiKhoan varchar(50) NOT NULL,
	matKhau varchar(50) NOT NULL,
	email varchar(50) NULL,
	SDT varchar(11) NOT NULL,
	gioitinh bit null,
	tenNhanVien nvarchar(50) NOT NULL,
	diaChi text NOT NULL,
	[role] int NOT NULL FOREIGN KEY([role]) REFERENCES [ROLE](ID_Role),
	luong int NOT NULL,
)
GO
CREATE TABLE HOADON
(
	ID_HoaDon int primary key IDENTITY(1,1) NOT NULL,
	ID_KhachHang int NOT NULL FOREIGN KEY(ID_KhachHang) REFERENCES KHACHHANG(ID_KhachHang),
	ngayLap date NOT NULL,
	ghiChu text NULL,
	ngayGiaoHang date NOT NULL,
	ngayNhanHang date NULL,
	thanhtien money null,
)
GO
CREATE TABLE CTHOADON
(
	ID_HoaDon int NOT NULL FOREIGN KEY(ID_HoaDon) REFERENCES HOADON(ID_HoaDon),
	ID_DienThoai int NOT NULL FOREIGN KEY(ID_DienThoai) REFERENCES DIENTHOAI(ID_DienThoai),
	soLuongMua int NOT NULL,
	ID_User int NOT NULL FOREIGN KEY(ID_User) REFERENCES [USER](ID_User),
	primary key (ID_HoaDon,ID_DienThoai)
)

--Insert Data--
GO
INSERT INTO LOAIDT VALUES (N'Cảm ứng',N'')
INSERT INTO LOAIDT VALUES (N'Bàn Phím',N'')
INSERT INTO LOAIDT VALUES (N'Tablet',N'')
GO
INSERT INTO HANGDT VALUES (N'SamSung',N'',N'')
INSERT INTO HANGDT VALUES (N'Apple',N'',N'')
INSERT INTO HANGDT VALUES (N'Xiaomi',N'',N'')
INSERT INTO HANGDT VALUES (N'Vivo',N'',N'')
INSERT INTO HANGDT VALUES (N'HTC',N'',N'')
INSERT INTO HANGDT VALUES (N'Sony',N'',N'')
GO
INSERT INTO DIENTHOAI VALUES (N'SamSung J7 Pro Vàng Đồng',100,5000000,N'',N'',1,1,N'',N'',N'')
INSERT INTO DIENTHOAI VALUES (N'IPhone Xs Đen',100,20000000,N'',N'',1,2,N'',N'',N'')
GO
INSERT INTO KHACHHANG VALUES ('lebaothinh.krb@gmail.com','0347013955',N'Lê Bảo Thịnh',N'Bình Dương','241566767')
INSERT INTO KHACHHANG VALUES ('hoangminhtu.krb@gmail.com','0347013955',N'Hoàng Minh Tú',N'Bình Dương','243156767')
INSERT INTO KHACHHANG VALUES ('nguyencongthanh.krb@gmail.com','0347013955',N'Nguyễn Công Thành',N'Bình Dương','241536767')
GO
INSERT INTO [ROLE] VALUES (N'Quản Lý',N'')
INSERT INTO [ROLE] VALUES (N'Nhân Viên',N'')
GO
INSERT INTO [USER] VALUES ('lebaothinh','thinh123','lebaothinh.krb@gmail.com','0347013955',1,N'Lê Bảo Thịnh',N'Bình Dương',1,20000000)
INSERT INTO [USER] VALUES ('hoangminhtu','thinh123','hoangminhtu.krb@gmail.com','0347013966',0,N'Hoàng Minh Tú',N'Bình Dương',2,20000000)
INSERT INTO [USER] VALUES ('nguyencongthanh','thinh123','nguyencongthanh.krb@gmail.com',1,'0347016555',N'Nguyễn Công Thành',N'Bình Dương',2,20000000)
GO
INSERT INTO HOADON VALUES (1,GETDATE(),N'',GETDATE(),GETDATE(),null)
INSERT INTO HOADON VALUES (2,GETDATE(),N'',GETDATE(),GETDATE(),null)
INSERT INTO HOADON VALUES (3,GETDATE(),N'',GETDATE(),GETDATE(),null)
GO
INSERT INTO CTHOADON VALUES (1,2,1,1)
INSERT INTO CTHOADON VALUES (1,1,1,1)
INSERT INTO CTHOADON VALUES (2,1,1,2)
INSERT INTO CTHOADON VALUES (3,1,2,3)