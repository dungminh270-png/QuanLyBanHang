USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QLBanHang')
BEGIN
    CREATE DATABASE QLBanHang;
END
GO
USE [QLBanHang]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[Soluong] [int] NULL,
    [DonGiaBan] [decimal](12,0) NOT NULL,
	[ThanhTien] AS (ISNULL(Soluong,0) * DonGiaBan) PERSISTED,
CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [nvarchar](20) NOT NULL,
	[NgayLapHD] [datetime] NOT NULL,
	[NgayNhanHang] [datetime] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE VIEW v_HoaDon AS
SELECT 
    hd.*,
    ISNULL(SUM(ct.Soluong * ct.DonGiaBan), 0) AS TongTien
FROM HoaDon hd
LEFT JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
GROUP BY 
    hd.MaHD, hd.MaKH, hd.NgayLapHD, hd.NgayNhanHang, hd.MaNV;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[MaDN] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [UQ_NhanVien_MaDN] UNIQUE ([MaDN]),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](60) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[NgaySinh] [date] NULL,
	[GTinh] [bit] NULL,
	[MaThanhPho] [int] NULL,
	[HinhAnh] [nvarchar] (50) NULL,
    [MaDN] [nvarchar](50) NOT NULL DEFAULT(''),
    [MatKhau] [nvarchar] (128) NOT NULL DEFAULT(''),
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[MaThanhPho] [int] IDENTITY(1,1) NOT NULL,
	[TenThanhPho] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThanhPho] PRIMARY KEY CLUSTERED 
(
	[MaThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](40) NOT NULL,
	[MaLoai] [int] NOT NULL,
	[DonGiaBan] [decimal](12, 0) NOT NULL,
	[SoLuongTon] [int] NOT NULL DEFAULT 0,
	[HinhAnh] [nvarchar](255) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO	
SET IDENTITY_INSERT [dbo].[ThanhPho] ON 
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (1, N'Hà Nội')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (2, N'Sài Gòn')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (3, N'Đà Nẵng')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (4, N'Hải Phòng')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (5, N'Cần Thơ')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (6, N'Vũng Tàu')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (7, N'Quảng Ninh')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (8, N'Nha Trang')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (9, N'Huế')
INSERT [dbo].[ThanhPho] ([MaThanhPho], [TenThanhPho]) VALUES (10, N'Vinh')
SET IDENTITY_INSERT [dbo].[ThanhPho] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 
GO
INSERT [dbo].[SanPham] ([MaSP],[TenSP],[MaLoai],[DonGiaBan],[SoLuongTon],[HinhAnh]) VALUES
(1001, N'Bút bi Thiên Long TL-079 xanh',      1, 4000,  1200, N'sp/tl079_xanh.jpg'),
(1002, N'Bút bi Thiên Long TL-079 đỏ',        1, 4000,   900, N'sp/tl079_do.jpg'),
(1003, N'Bút bi Thiên Long TL-027 đen',       1, 3500,  1500, N'sp/tl027_den.jpg'),
(1004, N'Bút gel Thiên Long GEL-08 đen',      2, 8500,   800, N'sp/gel08_den.jpg'),
(1005, N'Bút gel Zebra Sarasa Clip 0.5 đen',  2,25000,   500, N'sp/zebra_black.jpg'),
(1006, N'Bút gel Muji 0.38 đen',              2,22000,   300, N'sp/muji038.jpg'),
(1007, N'Bút gel Pilot G2 0.5 xanh',          2,28000,   400, N'sp/pilot_g2.jpg'),
(1008, N'Bút mực Hồng Hà 03 xanh',            3, 8000,  1000, N'sp/hongha03.jpg'),
(1009, N'Bút mực Thiên Long FM-01',           3, 7500,  1100, N'sp/fm01.jpg'),
(1010, N'Bút chì 2B Thiên Long',              4, 5000,  3000, N'sp/chi2b.jpg'),
(1011, N'Bút chì bấm Pentel 0.5',             4,35000,   600, N'sp/pentel05.jpg'),
(1012, N'Bút máy Kim Thành 18',               5,48000,   200, N'sp/kimthanh18.jpg'),
(1013, N'Bút lông dầu Horse 2 đầu',           6,12000,  1500, N'sp/horse2dau.jpg'),
(1014, N'Bút xóa kéo Tombow Mono 5mm',        7,35000,   800, N'sp/tombow5mm.jpg'),
(1015, N'Bút dạ quang Stabilo Boss vàng',     8,28000,  1200, N'sp/stabilo_yellow.jpg')
GO
INSERT [dbo].[SanPham] ([MaSP],[TenSP],[MaLoai],[DonGiaBan],[SoLuongTon],[HinhAnh]) VALUES 
(1021, N'Bút bi Thiên Long TL-047 xanh',                     1,  3200, 1500, N'tl047_xanh.jpg'),
(1022, N'Bút bi Thiên Long TL-047 đỏ',                       1,  3200, 1400, N'tl047_do.jpg'),
(1023, N'Bút bi FlexOffice FO-001 đen',                      1,  3000, 2000, N'fo001_den.jpg'),
(1024, N'Bút gel Bến Nghé G-202 xanh',                       2,  6500,  900, N'benghe_g202.jpg'),
(1025, N'Bút gel Zebra Sarasa Clip 0.5 đỏ',                  2, 25000,  600, N'zebra_red.jpg'),
(1026, N'Bút gel Muji 0.5 xanh navy',                        2, 22000,  400, N'muji_navy.jpg'),
(1027, N'Bút gel Pentel Energel 0.5 đen',                    2, 32000,  500, N'energel_black.jpg'),
(1028, N'Bút gel Pilot Juice 0.5 hồng',                      2, 28000,  450, N'juice_pink.jpg'),
(1029, N'Bút mực Kim Thành 36',                              3, 55000,  300, N'kimthanh36.jpg'),
(1030, N'Bút máy Lamy Safari charcoal',                      5,650000,   80, N'lamy_safari.jpg'),
(1031, N'Bút máy Platinum Preppy 0.3',                       5, 85000,  200, N'preppy03.jpg'),
(1032, N'Bút chì bấm Ohto Sharp 0.5',                        4, 45000,  350, N'ohto05.jpg'),
(1033, N'Bút chì gỗ Faber-Castell 9000 2B',                  4, 12000, 2500, N'faber9000.jpg'),
(1034, N'Bút xóa nước Plus 5mm',                             7, 25000,  800, N'plus5mm.jpg'),
(1035, N'Bút xóa kéo Deli 10m',                              7, 18000, 1200, N'deli10m.jpg'),
(1036, N'Bút lông bảng Horse trắng',                         6,  9000, 3000, N'horse_whiteboard.jpg'),
(1037, N'Bút dạ quang Stabilo Boss xanh lá',                 8, 28000, 1000, N'stabilo_green.jpg'),
(1038, N'Bút dạ quang FlexOffice FO-HL01 hồng',              8, 12000, 1500, N'fo_hl01_pink.jpg'),
(1039, N'Bút bi 4 màu Thiên Long',                           1, 15000, 1800, N'tl_4color.jpg'),
(1040, N'Bút bi 4 màu Bizner',                               1, 18000, 1200, N'bizner_4color.jpg'),
(1041, N'Ruột bút bi Thiên Long 0.5mm (hộp 20)',             1, 35000,  500, N'ruot_tl05.jpg'),
(1042, N'Ngòi bút gel Zebra 0.5mm',                          2, 12000, 1000, N'ngoi_zebra05.jpg'),
(1043, N'Ống mực bút máy Platinum xanh',                     5, 45000,  600, N'muc_platinum.jpg'),
(1044, N'Bút bi nước Deli Q3 xanh',                          1,  8500, 1300, N'deli_q3.jpg'),
(1045, N'Bút gel xóa được Pilot Frixion 0.5',                2, 38000,  700, N'frixion05.jpg'),
(1046, N'Bút chì màu Colormate 12 màu',                      4, 45000,  800, N'colormate12.jpg'),
(1047, N'Bút chì màu Stabilo Swans 24 màu',                  4,125000,  400, N'stabilo24.jpg'),
(1048, N'Bút lông màu Horse 12 màu',                         6, 38000,  900, N'horse12color.jpg'),
(1049, N'Bút bi Thiên Long TL-036 đen',                      1,  2800, 3000, N'tl036_den.jpg'),
(1050, N'Bút bi Thiên Long TL-090 xanh',                     1,  5500, 1800, N'tl090_xanh.jpg');
GO
SET IDENTITY_INSERT [dbo].[SanPham] OFF 
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GTinh], [NgaySinh], [DiaChi], [DienThoai], [Email], [HinhAnh], [MaDN], [MatKhau]) VALUES 
(1, N'Thạch Minh Dũng', 1, '2006-07-04', N'Quận 10', '0902002001', 'dungminh@gmail.com', N'1.gif', N'dungnv123', N'123456')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GTinh], [NgaySinh], [DiaChi], [DienThoai], [Email], [HinhAnh], [MaDN], [MatKhau]) VALUES 
(2, N'Nguyễn Thị Kim Thoa', 0, '2006-12-28', N'Quận 6', '0902002002', 'nguyenthoa@gmail.com', N'2.gif', N'kthoannv', N'123456')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GTinh], [NgaySinh], [DiaChi], [DienThoai], [Email], [HinhAnh], [MaDN], [MatKhau]) VALUES 
(3, N'Hồ Thị Mỹ Thuận', 0, '2006-08-20', N'Quận 3', '0903003003', 'hothuannv@gmail.com', N'3.gif', N'hothuan123', N'123456')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GTinh], [NgaySinh], [DiaChi], [DienThoai], [Email], [HinhAnh], [MaDN], [MatKhau]) VALUES 
(4, N'Huỳnh Nguyễn Ngọc Nhân', 1, '2006-11-10', N'Quận 5', '0904004004', 'ngocnhan@gmail.com', N'4.gif', N'ngocnhannv', N'123456')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [GTinh], [NgaySinh], [DiaChi], [DienThoai], [Email], [HinhAnh], [MaDN], [MatKhau]) VALUES 
(5, N'Võ Văn Minh', 1, '2006-03-22', N'Quận 8', '0905005005', 'vanminh@gmail.com', N'5.gif', N'vanminhnv', N'123456')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT INTO [dbo].[KhachHang] 
    ([MaKH], [TenKH], [DiaChi], [DienThoai], [NgaySinh], [GTinh], [MaThanhPho], [HinhAnh], [MaDN], [MatKhau])
VALUES
-- 01
(N'KH001', N'Nguyễn Văn Nam',    N'123 Lê Lợi, Q.1',          N'0901111111', '1990-03-15', 1, 2, N'kh1.jpg', N'kh001', N'123456'),
-- 02
(N'KH002', N'Trần Thị Lan',      N'56 Nguyễn Trãi, Q.5',      N'0902222222', '1992-07-20', 0, 1, N'kh2.jpg', N'kh002', N'123456'),
-- 03
(N'KH003', N'Lê Minh Hoàng',     N'789 Pasteur, Q.3',         N'0903333333', '1988-11-10', 1, 3, N'kh3.jpg', N'kh003', N'123456'),
-- 04
(N'KH004', N'Phạm Quốc Hùng',    N'321 Hai Bà Trưng, Q.1',    N'0904444444', '1995-05-05', 1, 2, N'kh4.jpg', N'kh004', N'123456'),
-- 05
(N'KH005', N'Vũ Thị Mai Anh',    N'555 CMT8, Q.10',           N'0905555555', '1993-09-25', 0, 2, N'kh5.jpg', N'kh005', N'123456'),
-- 06
(N'KH006', N'Đỗ Văn Tuấn',       N'12 Trần Hưng Đạo, Q.1',    N'0906666666', '1985-01-30', 1, 1, N'kh6.jpg', N'kh006', N'123456'),
-- 07
(N'KH007', N'Hồ Ngọc Hà',        N'88 Võ Văn Tần, Q.3',       N'0907777777', '1991-12-12', 0, 3, N'kh7.jpg', N'kh007', N'123456'),
-- 08
(N'KH008', N'Bùi Quang Vinh',    N'45 Lý Thường Kiệt, Q.10',  N'0908888888', '1987-06-18', 1, 2, N'kh8.jpg', N'kh008', N'123456'),
-- 09
(N'KH009', N'Ngô Bảo Châu',      N'99 Lê Văn Sỹ, Q.3',        N'0909999999', '1994-04-22', 0, 3, N'kh9.jpg', N'kh009', N'123456'),
-- 10
(N'KH010', N'Đinh Tiến Dũng',    N'33 Nguyễn Thị Minh Khai',  N'0910000000', '1989-08-08', 1, 1, N'kh10.jpg', N'kh010', N'123456'),
-- 11
(N'KH011', N'Phan Thị Kim Ngân', N'67 Điện Biên Phủ, Q.1',    N'0911111111', '1996-02-14', 0, 1, N'kh11.jpg', N'kh011', N'123456'),
-- 12
(N'KH012', N'Trương Văn Bảo',    N'11 Nguyễn Huệ, Q.1',       N'0912222222', '1990-10-05', 1, 2, N'kh12.jpg', N'kh012', N'123456'),
-- 13
(N'KH013', N'Lý Thu Thảo',       N'22 Bạch Đằng, Q. Bình Thạnh', N'0913333333', '1997-11-11', 0, 1, N'kh13.jpg', N'kh013', N'123456'),
-- 14
(N'KH014', N'Mai Văn Hùng',      N'55 Lê Đại Hành, Q.11',     N'0914444444', '1986-07-07', 1, 2, N'kh14.jpg', N'kh014', N'123456'),
-- 15
(N'KH015', N'Hoàng Thị Ngọc',    N'77 Nguyễn Văn Cừ, Q.5',    N'0915555555', '1998-03-20', 0, 1, N'kh15.jpg', N'kh015', N'123456');
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [NgayLapHD], [NgayNhanHang], [MaNV]) VALUES
(10248, N'KH001', '2025-11-01', NULL, 2),
(10249, N'KH002', '2025-11-02', NULL, 3),
(10250, N'KH003', '2025-11-03', NULL, 2),
(10251, N'KH001', '2025-11-04', NULL, 1),
(10252, N'KH002', '2025-11-05', NULL, 1),
(10253, N'KH003', '2025-11-06', NULL, 1),
(10254, N'KH004', '2025-11-07', NULL, 1);
GO
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
INSERT INTO [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGiaBan]) VALUES
(10248, 1001, 20, 4000),
(10248, 1005,  5, 25000),
(10248, 1012, 10, 48000),
(10249, 1003, 50, 3500),
(10249, 1011, 15, 35000),
(10249, 1008, 12, 8000),
(10250, 1015,  8, 28000),
(10250, 1006,  6, 22000),
(10250, 1010, 30, 5000),
(10248, 1025,  3, 25000),
(10249, 1045,  2, 38000),
(10250, 1030,  1, 650000); 
GO
ALTER TABLE [dbo].[ChiTietHoaDon] WITH CHECK 
    ADD CONSTRAINT [FK_ChiTiet_HoaDon] FOREIGN KEY([MaHD]) 
    REFERENCES [dbo].[HoaDon] ([MaHD]) ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTiet_HoaDon]
GO

ALTER TABLE [dbo].[ChiTietHoaDon] WITH CHECK 
    ADD CONSTRAINT [FK_ChiTiet_SanPham] FOREIGN KEY([MaSP]) 
    REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTiet_SanPham]
GO

ALTER TABLE [dbo].[HoaDon] WITH CHECK 
    ADD CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV]) 
    REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO

ALTER TABLE [dbo].[HoaDon] WITH CHECK 
    ADD CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH]) 
    REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO

ALTER TABLE [dbo].[KhachHang] WITH CHECK 
    ADD CONSTRAINT [FK_KhachHang_ThanhPho] FOREIGN KEY([MaThanhPho]) 
    REFERENCES [dbo].[ThanhPho] ([MaThanhPho])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ThanhPho]
GO
