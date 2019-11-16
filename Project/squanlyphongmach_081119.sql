USE [QuanLyPhongMach]
GO
/****** Object:  Table [dbo].[Benh]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[ChiTietBenh]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[ChiTietDonThuoc]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/8/2019 11:39:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaVaiTro] [int] NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TenDangNhap] [nchar](50) NULL,
	[MatKhau] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 11/8/2019 11:39:53 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaPhieuKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 11/8/2019 11:39:53 AM ******/
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
/****** Object:  Table [dbo].[VaiTro]    Script Date: 11/8/2019 11:39:53 AM ******/
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
