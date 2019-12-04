USE [master]
GO
/****** Object:  Database [QuanLyPhongMach]    Script Date: 11/26/2019 6:33:31 PM ******/
CREATE DATABASE [QuanLyPhongMach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyPhongMach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyPhongMach.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyPhongMach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyPhongMach_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyPhongMach] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyPhongMach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyPhongMach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyPhongMach] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyPhongMach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyPhongMach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyPhongMach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyPhongMach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyPhongMach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyPhongMach] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyPhongMach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyPhongMach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyPhongMach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyPhongMach] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyPhongMach]
GO
/****** Object:  Table [dbo].[Benh]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benh](
	[MaBenh] [int] IDENTITY(1,1) NOT NULL,
	[TenBenh] [nvarchar](255) NOT NULL,
	[TrangThai] [int] NOT NULL DEFAULT ('1'),
PRIMARY KEY CLUSTERED 
(
	[MaBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TrangThai] [int] NOT NULL DEFAULT ('1'),
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietBenh]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBenh](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuKham] [int] NOT NULL,
	[MaBenh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonThuoc]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonThuoc](
	[SoThuTu] [int] IDENTITY(1,1) NOT NULL,
	[MaThuoc] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[MaDonThuoc] [int] NOT NULL,
	[CachDung] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThuTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDonThuoc] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuKham] [int] NOT NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaVaiTro] [int] NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[TrangThai] [int] NOT NULL DEFAULT ('1'),
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKham](
	[MaPhieuKham] [int] IDENTITY(1,1) NOT NULL,
	[MaBenhNhan] [int] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[TrieuChung] [nvarchar](255) NULL,
	[NgayKham] [date] NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](100) NOT NULL,
	[DonGia] [float] NULL,
	[SoLuongTon] [int] NULL,
	[DonVi] [nvarchar](50) NULL,
	[TrangThai] [int] NOT NULL DEFAULT ('1'),
PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 11/26/2019 6:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[MaVaiTro] [int] IDENTITY(1,1) NOT NULL,
	[TenVaiTro] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Benh] ON 

INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (1, N'Cảm cúm', 1)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (2, N'Sốt', 1)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (3, N'Sổ mũi', 1)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (4, N'Đau bụng', 1)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (5, N'Viêm họng', 0)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (6, N'Viêm họng', 1)
INSERT [dbo].[Benh] ([MaBenh], [TenBenh], [TrangThai]) VALUES (7, N'Cảm cúm', 0)
SET IDENTITY_INSERT [dbo].[Benh] OFF
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (1, N'Nguyễn Thuý Hường', N'Nữ', CAST(N'1995-05-13' AS Date), N'185/12 Trần Quốc Toản P1 Q3', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (2, N'Trần Văn Dưỡng', N'Nam', CAST(N'1989-01-20' AS Date), N'23A Nguyễn Chí Thanh Q5', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (3, N'Nguyễn Tấn Đạt', N'Nam', CAST(N'1990-01-28' AS Date), N'131/38 Bà Huyện Thanh Quan Q3', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (4, N'Mai Huỳnh Phương', N'Nữ', CAST(N'1997-08-17' AS Date), N'83A Nguyễn Tri Phương P4 Q10', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (5, N'Ngô Quỳnh Chi', N'Nữ', CAST(N'1996-10-02' AS Date), N'203 Lê Văn Tám P9 Q4', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (6, N'Văn Mai Hương', N'Nữ', CAST(N'1993-08-10' AS Date), N'91 Võ Văn Tần P1 Q3', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (7, N'Trần Thế Trung', N'Nam', CAST(N'1998-10-05' AS Date), N'231/12 Bà Hạt P5 Q10', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (8, N'Hoàng Thuỳ Linh', N'Nữ', CAST(N'1994-03-19' AS Date), N'182/36 Kỳ Đồng Q3', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (9, N'Phạm Minh Hoàng', N'Nam', CAST(N'1999-11-24' AS Date), N'40/4 Lê Đại Hành P14 Q11', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (10, N'Hồ Ngọc Hà', N'Nữ', CAST(N'1989-09-21' AS Date), N'80 Tôn Đức Thắng P5 Q1', 0)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (11, N'Phạm Minh Tiến', N'Nam', CAST(N'1999-11-01' AS Date), N'40/26 Huỳnh Tịch Của P14 Q3', 1)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (12, N'Nguyễn Thuý Hường', N'Nữ', CAST(N'1995-05-13' AS Date), N'185/12 Trần Quốc Toản P1 Q3', 0)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TrangThai]) VALUES (13, N'Nguyễn Tạm', N'Nam', CAST(N'1999-10-04' AS Date), N'148/56/18,Quang Trung,P8,GV', 1)
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
SET IDENTITY_INSERT [dbo].[ChiTietBenh] ON 

INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (1, 3, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (2, 3, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (3, 3, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (4, 7, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (5, 8, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (6, 5, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (7, 9, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (8, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (9, 11, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (10, 10, 2)
SET IDENTITY_INSERT [dbo].[ChiTietBenh] OFF
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] ON 

INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (1, 1, 1, 3000, 1, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (2, 1, 2, 6000, 2, N'Uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (3, 3, 1, 10000, 2, N'Uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (4, 1, 2, 6000, 3, N'Uống sau khi ăn')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (5, 1, 6, 18000, 4, N'Sáng tối hai viên ')
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] OFF
SET IDENTITY_INSERT [dbo].[DonThuoc] ON 

INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (1, 2, 3000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (2, 3, 16000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (3, 4, 6000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (4, 11, 18000)
SET IDENTITY_INSERT [dbo].[DonThuoc] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau], [TrangThai]) VALUES (1, 1, N'Phạm Minh Hiển', N'Nam', CAST(N'1999-03-27' AS Date), N'Tân Bình', N'pmhien273', N'8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau], [TrangThai]) VALUES (2, 2, N'Mạc Vĩ Hào', N'Nam', CAST(N'1999-02-20' AS Date), N'Quận 11', N'mvhao202', N'8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau], [TrangThai]) VALUES (3, 2, N'Nguyễn Hữu Đức', N'Nam', CAST(N'1999-10-04' AS Date), N'Gò Vấp', N'nhduc104', N'8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau], [TrangThai]) VALUES (4, 3, N'Trần Giám Đốc', N'Nam', CAST(N'1990-08-23' AS Date), N'Quận 1', N'admin', N'8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau], [TrangThai]) VALUES (5, 2, N'Nguyễn Văn A', N'Nam', CAST(N'1995-10-12' AS Date), N'ABC', N'bacsi5', N'8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuKham] ON 

INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (1, 1, 3, NULL, CAST(N'2019-11-17' AS Date), N'Đã lập')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (2, 3, 2, N'Cảm', CAST(N'2019-11-17' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (3, 4, 2, N'Bí lù', CAST(N'2019-11-20' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (4, 2, 2, N'Nhức đầu', CAST(N'2019-11-20' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (5, 5, 3, N'Nóng', CAST(N'2019-11-20' AS Date), N'Đã chẩn đoán')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (6, 7, 3, NULL, CAST(N'2019-11-21' AS Date), N'Đã lập')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (7, 9, 2, N'Đi ngoài nhiều', CAST(N'2019-11-21' AS Date), N'Đã chẩn đoán')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (8, 8, 2, N'Nhiệt độ cơ thể thấp', CAST(N'2019-11-21' AS Date), N'Đã chẩn đoán')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (9, 10, 3, N'Ho nhiều', CAST(N'2019-11-21' AS Date), N'Đã chẩn đoán')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (10, 10, 2, N'Hoang mang', CAST(N'2019-11-25' AS Date), N'Đã chẩn đoán')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (11, 13, 3, N'sốt trên 38 độ', CAST(N'2019-11-26' AS Date), N'Đã lập đơn thuốc')
SET IDENTITY_INSERT [dbo].[PhieuKham] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (1, N'Paracetamol', 3000, 29, N'Viên', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (2, N'NatriCloRat', 2500, 17, N'Chai', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (3, N'Oresol', 10000, 98, N'Viên', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (4, N'Pantenol', 25000, 10, N'Tuýp', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (5, N'Eurax', 5000, 17, N'Chai', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (6, N'Ivacflu-S 0,5ml', 150000, 46, N'Kim tiêm', 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi], [TrangThai]) VALUES (7, N'Glucose', 170000, 20, N'Chai', 1)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
SET IDENTITY_INSERT [dbo].[VaiTro] ON 

INSERT [dbo].[VaiTro] ([MaVaiTro], [TenVaiTro]) VALUES (1, N'Nhân viên')
INSERT [dbo].[VaiTro] ([MaVaiTro], [TenVaiTro]) VALUES (2, N'Bác sĩ')
INSERT [dbo].[VaiTro] ([MaVaiTro], [TenVaiTro]) VALUES (3, N'Quản trị viên')
SET IDENTITY_INSERT [dbo].[VaiTro] OFF
ALTER TABLE [dbo].[ChiTietBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBenh_MaBenh] FOREIGN KEY([MaBenh])
REFERENCES [dbo].[Benh] ([MaBenh])
GO
ALTER TABLE [dbo].[ChiTietBenh] CHECK CONSTRAINT [FK_ChiTietBenh_MaBenh]
GO
ALTER TABLE [dbo].[ChiTietBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBenh_MaPhieuKham] FOREIGN KEY([MaPhieuKham])
REFERENCES [dbo].[PhieuKham] ([MaPhieuKham])
GO
ALTER TABLE [dbo].[ChiTietBenh] CHECK CONSTRAINT [FK_ChiTietBenh_MaPhieuKham]
GO
ALTER TABLE [dbo].[ChiTietDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonThuoc_MaDonThuoc] FOREIGN KEY([MaDonThuoc])
REFERENCES [dbo].[DonThuoc] ([MaDonThuoc])
GO
ALTER TABLE [dbo].[ChiTietDonThuoc] CHECK CONSTRAINT [FK_ChiTietDonThuoc_MaDonThuoc]
GO
ALTER TABLE [dbo].[ChiTietDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonThuoc_MaThuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietDonThuoc] CHECK CONSTRAINT [FK_ChiTietDonThuoc_MaThuoc]
GO
ALTER TABLE [dbo].[DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_DonThuoc_MaPhieuKham] FOREIGN KEY([MaPhieuKham])
REFERENCES [dbo].[PhieuKham] ([MaPhieuKham])
GO
ALTER TABLE [dbo].[DonThuoc] CHECK CONSTRAINT [FK_DonThuoc_MaPhieuKham]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaVaiTro] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VaiTro] ([MaVaiTro])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaVaiTro]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_MaBenhNhan] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_MaBenhNhan]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_MaNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QuanLyPhongMach] SET  READ_WRITE 
GO
