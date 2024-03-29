USE [master]
GO
/****** Object:  Database [QuanLyPhongMach]    Script Date: 11/15/2019 9:56:34 AM ******/
CREATE DATABASE [QuanLyPhongMach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyPhongMach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyPhongMach.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyPhongMach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyPhongMach_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[Benh]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benh](
	[MaBenh] [int] IDENTITY(1,1) NOT NULL,
	[TenBenh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietBenh]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBenh](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuKham] [int] NULL,
	[MaBenh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonThuoc]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonThuoc](
	[SoThuTu] [int] IDENTITY(1,1) NOT NULL,
	[MaThuoc] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[MaDonThuoc] [int] NULL,
	[CachDung] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThuTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDonThuoc] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuKham] [int] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaVaiTro] [int] NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKham](
	[MaPhieuKham] [int] IDENTITY(1,1) NOT NULL,
	[MaBenhNhan] [int] NULL,
	[MaNhanVien] [int] NULL,
	[TrieuChung] [nvarchar](255) NULL,
	[NgayKham] [date] NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](100) NULL,
	[DonGia] [float] NULL,
	[SoLuongTon] [int] NULL,
	[DonVi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 11/15/2019 9:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[MaVaiTro] [int] IDENTITY(1,1) NOT NULL,
	[TenVaiTro] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Benh] ON 

INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (1, N'Cảm')
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (2, N'Sốt')
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (3, N'Sổ mũi')
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (4, N'Đau bụng')
INSERT [dbo].[Benh] ([MaBenh], [TenBenh]) VALUES (5, N'Viêm họng')
SET IDENTITY_INSERT [dbo].[Benh] OFF
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (1, N'Lung Thị Linh', N'Nữ', CAST(N'2019-05-13' AS Date), N'Vũng Tàu')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (2, N'Trần Văn A', N'Nam', CAST(N'2018-01-15' AS Date), N'Cần Thơ')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (3, N'Trần T', N'Nam', CAST(N'2019-01-28' AS Date), N'Tây Nguyên')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
SET IDENTITY_INSERT [dbo].[ChiTietBenh] ON 

INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (1, 1, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (2, 1, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (4, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (5, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (6, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (7, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (8, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (9, 3, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (10, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (11, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (12, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (13, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (14, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (15, 4, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (16, 4, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (17, 4, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (18, 4, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (19, 4, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (20, 4, 1)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (21, 5, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (22, 5, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (23, 6, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (24, 7, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (25, 7, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (26, 8, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (27, 8, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (28, 9, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (29, 11, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (30, 11, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (31, 12, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (32, 12, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (33, 12, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (34, 13, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (35, 13, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (36, 13, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (37, 14, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (38, 14, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (39, 15, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (40, 15, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (41, 15, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (42, 16, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (43, 16, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (44, 16, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (45, 17, 2)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (46, 17, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (47, 17, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (48, 19, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (49, 20, 3)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (50, 21, 5)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (51, 22, 4)
INSERT [dbo].[ChiTietBenh] ([STT], [MaPhieuKham], [MaBenh]) VALUES (52, 23, 5)
SET IDENTITY_INSERT [dbo].[ChiTietBenh] OFF
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] ON 

INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (1, 1, 5, 15000, 1, N'Uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (2, 3, 2, 20000, 1, N'Sau khi ăn')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (3, 2, 2, 5000, 2, N'Nhỏ sau khi thức dậy')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (4, 4, 2, 50000, 2, N'Uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (5, 1, 3, 9000, 3, N'uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (6, 1, 5, 15000, 4, N'Uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (7, 1, 2, 6000, 5, N'uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (8, 1, 2, 6000, 6, N'uống trước khi ngủ')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (9, 1, 10, 30000, 7, N'Sau khi ăn')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (10, 1, 1, 3000, 8, N'aaa')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (11, 1, 1, 3000, 9, N'a')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (12, 3, 1, 10000, 9, N'a')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (13, 4, 1, 25000, 9, N'a')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (14, 1, 2, 6000, 10, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (15, 4, 3, 75000, 10, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (16, 6, 4, 600000, 10, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (17, 1, 14, 42000, 11, N'Liếm')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (18, 1, 5, 15000, 12, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (19, 1, 5, 15000, 13, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (20, 1, 1, 3000, 14, N'a')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (21, 2, 1, 2500, 14, N'a')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (22, 1, 1, 3000, 15, N'uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (23, 1, 1, 3000, 16, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (24, 4, 2, 50000, 17, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (25, 5, 3, 15000, 17, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (26, 1, 2, 6000, 18, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (27, 1, 6, 18000, 19, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (28, 4, 2, 50000, 20, N'Uống')
INSERT [dbo].[ChiTietDonThuoc] ([SoThuTu], [MaThuoc], [SoLuong], [ThanhTien], [MaDonThuoc], [CachDung]) VALUES (29, 1, 2, 6000, 21, N'Uống')
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] OFF
SET IDENTITY_INSERT [dbo].[DonThuoc] ON 

INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (1, 1, 10000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (2, 3, 20000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (3, 4, 52000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (4, 5, 12500)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (5, 6, 10000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (6, 7, 15000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (7, 8, 30000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (8, 9, 3000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (9, 10, 38000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (10, 11, 681000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (11, 12, 42000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (12, 13, 15000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (13, 14, 15000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (14, 15, 5500)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (15, 16, 3000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (16, 17, 3000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (17, 19, 65000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (18, 20, 6000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (19, 21, 18000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (20, 22, 50000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongTien]) VALUES (21, 23, 6000)
SET IDENTITY_INSERT [dbo].[DonThuoc] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau]) VALUES (1, 1, N'Phạm Minh Hiển', N'Nam', CAST(N'1999-03-27' AS Date), N'Tân Bình', N'user1                                             ', N'123456                                            ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau]) VALUES (2, 2, N'Mạc Vĩ Hào', N'Nam', CAST(N'1999-01-01' AS Date), N'Quận 4', N'user2                                             ', N'123456                                            ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau]) VALUES (3, 2, N'Nguyễn Hữu Đức', N'Nam', CAST(N'1999-01-01' AS Date), N'Gò Vấp', N'user3                                             ', N'123456                                            ')
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaVaiTro], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [TenDangNhap], [MatKhau]) VALUES (4, 3, N'Trần Giám Đốc', N'Nữ', CAST(N'1990-01-01' AS Date), N'Quận 1', N'admin                                             ', N'123456                                            ')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuKham] ON 

INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (1, 1, 2, N'Hài Hước', CAST(N'2019-11-08' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (2, 2, 3, N'Mệt', CAST(N'2019-11-09' AS Date), N'Đã lập')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (3, 2, 2, N'Mỏi', CAST(N'2019-11-09' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (4, 3, 2, N'Nhức đầu, thân nhiệt cao', CAST(N'2019-11-09' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (5, 1, 2, N'Ngây ngô', CAST(N'2019-11-09' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (6, 1, 2, N'Chóng mặt', CAST(N'2019-11-09' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (7, 2, 2, N'Ho nhiều', CAST(N'2019-11-09' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (8, 2, 2, N'Ho nhiều', CAST(N'2019-11-11' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (9, 3, 2, N'Ho nhiều', CAST(N'2019-11-11' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (10, 1, 2, N'Ho ra máu', CAST(N'2019-11-11' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (11, 1, 2, N'Ho', CAST(N'2019-11-11' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (12, 1, 2, N'Khôi hài', CAST(N'2019-11-11' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (13, 1, 2, N'Khùng', CAST(N'2019-11-13' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (14, 1, 2, N'Mắc ói', CAST(N'2019-11-13' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (15, 1, 2, N'Mệt', CAST(N'2019-11-13' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (16, 1, 2, N'Cảm cúm', CAST(N'2019-11-13' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (17, 1, 2, N'Sốt siêu vi', CAST(N'2019-11-13' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (18, 2, 3, NULL, CAST(N'2019-11-14' AS Date), N'Đã lập')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (19, 1, 2, N'Chảy nước mũi', CAST(N'2019-11-14' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (20, 3, 2, N'Hài hước', CAST(N'2019-11-14' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (21, 1, 2, N'Ngô nghê', CAST(N'2019-11-14' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (22, 3, 2, N'Đi ngoài nhiều', CAST(N'2019-11-14' AS Date), N'Đã lập đơn thuốc')
INSERT [dbo].[PhieuKham] ([MaPhieuKham], [MaBenhNhan], [MaNhanVien], [TrieuChung], [NgayKham], [TrangThai]) VALUES (23, 2, 2, N'Ho ra máu', CAST(N'2019-11-14' AS Date), N'Đã lập đơn thuốc')
SET IDENTITY_INSERT [dbo].[PhieuKham] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (1, N'Paracetamol', 3000, 37, N'Viên')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (2, N'NatriCloRat', 2500, 17, N'Chai')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (3, N'Oresol', 10000, 99, N'Viên')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (4, N'Pantenol', 25000, 10, N'Tuýp')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (5, N'Eurax', 5000, 17, N'Chai')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (6, N'Ivacflu-S 0,5ml', 150000, 46, N'Kim Tiêm')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuongTon], [DonVi]) VALUES (7, N'Glucose', 170000, 20, N'Chai')
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
