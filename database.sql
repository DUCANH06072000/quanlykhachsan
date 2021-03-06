USE [master]
GO
/****** Object:  Database [Hotel_Manager_Data]    Script Date: 19/03/2022 3:05:09 CH ******/
CREATE DATABASE [Hotel_Manager_Data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel_Manager_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel_Manager_Data.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_Manager_Data_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hotel_Manager_Data_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel_Manager_Data] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel_Manager_Data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel_Manager_Data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel_Manager_Data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel_Manager_Data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hotel_Manager_Data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel_Manager_Data] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotel_Manager_Data] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel_Manager_Data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel_Manager_Data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel_Manager_Data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel_Manager_Data] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel_Manager_Data] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel_Manager_Data] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotel_Manager_Data', N'ON'
GO
ALTER DATABASE [Hotel_Manager_Data] SET QUERY_STORE = OFF
GO
USE [Hotel_Manager_Data]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[phanquyen] [int] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[id_hoadon] [nvarchar](15) NOT NULL,
	[MaPhong] [nvarchar](15) NULL,
	[Makh] [nvarchar](15) NULL,
	[Manv] [nvarchar](15) NULL,
	[Ngaydatphong] [date] NULL,
	[Ngaynhanphong] [date] NULL,
	[Ngaytraphong] [date] NULL,
	[soluongnguoi] [int] NULL,
	[phiphong] [real] NULL,
	[phiphuthu] [real] NULL,
	[thanhtien] [real] NULL,
	[trangthai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKh] [nvarchar](15) NOT NULL,
	[Tenkh] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khohang]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khohang](
	[Maitem] [nvarchar](15) NOT NULL,
	[TenItem] [nvarchar](500) NULL,
	[gianhap] [real] NULL,
	[soluong] [int] NULL,
	[giaban] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maitem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LPhong]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LPhong](
	[loaiphong] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](50) NULL,
	[giaphong] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [nvarchar](15) NOT NULL,
	[Tennv] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[Id_hd] [nvarchar](15) NOT NULL,
	[sanpham] [nvarchar](500) NULL,
	[ngaynhap] [date] NULL,
	[Thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](15) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[loaiphong] [nvarchar](50) NULL,
	[Mota] [nvarchar](500) NULL,
	[songtoida] [int] NULL,
	[trangthai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phuthu]    Script Date: 19/03/2022 3:05:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phuthu](
	[MaPhu] [nvarchar](15) NOT NULL,
	[MaKh] [nvarchar](15) NULL,
	[Maitem] [nvarchar](15) NULL,
	[tensp] [nvarchar](500) NULL,
	[soluong] [int] NULL,
	[gia] [real] NULL,
	[trangthai] [int] NULL,
	[thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Makh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [f1] FOREIGN KEY([loaiphong])
REFERENCES [dbo].[LPhong] ([loaiphong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [f1]
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD FOREIGN KEY([Maitem])
REFERENCES [dbo].[Khohang] ([Maitem])
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
USE [master]
GO
ALTER DATABASE [Hotel_Manager_Data] SET  READ_WRITE 
GO
