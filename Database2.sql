USE [master]
GO
/****** Object:  Database [ShoeShop]    Script Date: 11/13/2025 2:06:57 AM ******/
CREATE DATABASE [ShoeShop]
GO
USE [ShoeShop]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Total] [decimal](18, 2) NULL,
	[BillType] [nvarchar](10) NULL,
	[BrandID] [int] NULL,
	[Note] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
	[Source] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[Gender] [nvarchar](10) NULL,
	[BirthDate] [date] NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[RoleID] [int] NULL,
	[AccountID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Gender] [int] NULL,
	[Age] [nvarchar](3) NULL,
	[Size] [int] NULL,
	[TypeID] [int] NOT NULL,
	[Price] [int] NULL,
	[Stock] [int] NULL,
	[BrandID] [int] NULL,
	[Actived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 
GO
INSERT [dbo].[Account] ([ID], [Username], [Password], [Role], [Active]) VALUES (1, N'admin', N'123456', N'Admin', 1)
GO
INSERT [dbo].[Account] ([ID], [Username], [Password], [Role], [Active]) VALUES (2, N'cashier', N'123456', N'Cashier', 1)
GO
INSERT [dbo].[Account] ([ID], [Username], [Password], [Role], [Active]) VALUES (3, N'sales', N'123456', N'Sales', 1)
GO
INSERT [dbo].[Account] ([ID], [Username], [Password], [Role], [Active]) VALUES (4, N'manager', N'123456', N'Manager', 1)
GO
INSERT [dbo].[Account] ([ID], [Username], [Password], [Role], [Active]) VALUES (5, N'inactive', N'123456', N'Sales', 0)
GO
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (1, 1, CAST(N'2025-01-10T00:00:00.000' AS DateTime), CAST(8100000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Nguyễn An')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (2, 2, CAST(N'2025-02-12T00:00:00.000' AS DateTime), CAST(6700000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Lê Bình')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (3, 3, CAST(N'2025-03-05T00:00:00.000' AS DateTime), CAST(5300000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Trần Cường')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (4, 4, CAST(N'2025-04-18T00:00:00.000' AS DateTime), CAST(5100000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Mai Dung')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (5, 1, CAST(N'2025-05-09T00:00:00.000' AS DateTime), CAST(7300000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Bùi Anh')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (6, 2, CAST(N'2025-06-11T00:00:00.000' AS DateTime), CAST(5600000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Lý Thu')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (7, 3, CAST(N'2025-07-20T00:00:00.000' AS DateTime), CAST(3600000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Nguyễn Vũ')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (8, 4, CAST(N'2025-08-15T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Phạm Phương')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (9, 1, CAST(N'2025-09-25T00:00:00.000' AS DateTime), CAST(3300000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Hoàng Hải')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (10, 2, CAST(N'2025-10-19T00:00:00.000' AS DateTime), CAST(1800000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Trần Long')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (11, 3, CAST(N'2025-11-23T00:00:00.000' AS DateTime), CAST(2000000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Nguyễn Thủy')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (12, 4, CAST(N'2025-12-14T00:00:00.000' AS DateTime), CAST(6200000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách cuối năm')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (13, 1, CAST(N'2025-03-10T00:00:00.000' AS DateTime), CAST(2300000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Nguyễn Hoa')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (14, 2, CAST(N'2025-04-22T00:00:00.000' AS DateTime), CAST(1550000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Phạm Dũng')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (15, 3, CAST(N'2025-05-30T00:00:00.000' AS DateTime), CAST(5000000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Bùi Lan')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (16, 4, CAST(N'2025-06-18T00:00:00.000' AS DateTime), CAST(8400000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Đỗ Quang')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (17, 1, CAST(N'2025-07-26T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Nguyễn Văn T')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (18, 2, CAST(N'2025-08-09T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Lê Tấn')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (19, 3, CAST(N'2025-09-15T00:00:00.000' AS DateTime), CAST(4500000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Trần Hạnh')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (20, 4, CAST(N'2025-10-28T00:00:00.000' AS DateTime), CAST(2400000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Bùi Lộc')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (21, 1, CAST(N'2025-11-12T00:00:00.000' AS DateTime), CAST(2600000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Đặng Tài')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (22, 2, CAST(N'2025-12-05T00:00:00.000' AS DateTime), CAST(1600000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Lý Nam')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (23, 3, CAST(N'2025-02-08T00:00:00.000' AS DateTime), CAST(2500000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Lê Châu')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (24, 4, CAST(N'2025-01-25T00:00:00.000' AS DateTime), CAST(4600000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Đỗ Hiếu')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (25, 1, CAST(N'2025-06-05T00:00:00.000' AS DateTime), CAST(4000000.00 AS Decimal(18, 2)), N'Export', NULL, N'Khách Mai Trang')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (26, 4, CAST(N'2025-01-05T00:00:00.000' AS DateTime), CAST(5400000.00 AS Decimal(18, 2)), N'Import', 1, N'Nhập hàng Nike tháng 1')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (27, 4, CAST(N'2025-02-10T00:00:00.000' AS DateTime), CAST(1800000.00 AS Decimal(18, 2)), N'Import', 2, N'Nhập hàng Adidas tháng 2')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (28, 4, CAST(N'2025-03-15T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Import', 3, N'Nhập hàng Puma tháng 3')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (29, 4, CAST(N'2025-04-20T00:00:00.000' AS DateTime), CAST(3300000.00 AS Decimal(18, 2)), N'Import', 4, N'Nhập hàng Converse tháng 4')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (30, 4, CAST(N'2025-05-10T00:00:00.000' AS DateTime), CAST(900000.00 AS Decimal(18, 2)), N'Import', 5, N'Nhập hàng Vans tháng 5')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (31, 4, CAST(N'2025-06-25T00:00:00.000' AS DateTime), CAST(2000000.00 AS Decimal(18, 2)), N'Import', 6, N'Nhập hàng Reebok tháng 6')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (32, 4, CAST(N'2025-07-07T00:00:00.000' AS DateTime), CAST(6200000.00 AS Decimal(18, 2)), N'Import', 7, N'Nhập hàng New Balance tháng 7')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (33, 4, CAST(N'2025-08-12T00:00:00.000' AS DateTime), CAST(2300000.00 AS Decimal(18, 2)), N'Import', 8, N'Nhập hàng Skechers tháng 8')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (34, 4, CAST(N'2025-09-17T00:00:00.000' AS DateTime), CAST(1550000.00 AS Decimal(18, 2)), N'Import', 9, N'Nhập hàng Under Armour tháng 9')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (35, 4, CAST(N'2025-10-21T00:00:00.000' AS DateTime), CAST(5000000.00 AS Decimal(18, 2)), N'Import', 2, N'Nhập hàng Adidas tháng 10')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (36, 4, CAST(N'2025-11-08T00:00:00.000' AS DateTime), CAST(5600000.00 AS Decimal(18, 2)), N'Import', 3, N'Nhập hàng Puma tháng 11')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (37, 4, CAST(N'2025-12-05T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Import', 4, N'Nhập hàng Converse tháng 12')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (38, 4, CAST(N'2025-02-24T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Import', 1, N'Nhập lô Nike Air Max')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (39, 4, CAST(N'2025-03-30T00:00:00.000' AS DateTime), CAST(4500000.00 AS Decimal(18, 2)), N'Import', 5, N'Nhập lô Vans Authentic')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (40, 4, CAST(N'2025-04-11T00:00:00.000' AS DateTime), CAST(2400000.00 AS Decimal(18, 2)), N'Import', 6, N'Nhập lô Reebok Classic')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (41, 4, CAST(N'2025-05-16T00:00:00.000' AS DateTime), CAST(2600000.00 AS Decimal(18, 2)), N'Import', 7, N'Nhập lô New Balance 574')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (42, 4, CAST(N'2025-06-28T00:00:00.000' AS DateTime), CAST(1600000.00 AS Decimal(18, 2)), N'Import', 8, N'Nhập lô Skechers Go Walk')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (43, 4, CAST(N'2025-07-22T00:00:00.000' AS DateTime), CAST(2500000.00 AS Decimal(18, 2)), N'Import', 9, N'Nhập lô Under Armour HOVR')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (44, 4, CAST(N'2025-08-08T00:00:00.000' AS DateTime), CAST(4600000.00 AS Decimal(18, 2)), N'Import', 1, N'Nhập lô Nike Pegasus 40')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (45, 4, CAST(N'2025-09-25T00:00:00.000' AS DateTime), CAST(4000000.00 AS Decimal(18, 2)), N'Import', 2, N'Nhập lô Adidas Stan Smith')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (46, 4, CAST(N'2025-10-15T00:00:00.000' AS DateTime), CAST(5400000.00 AS Decimal(18, 2)), N'Import', 3, N'Nhập lô Puma Smash')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (47, 4, CAST(N'2025-11-20T00:00:00.000' AS DateTime), CAST(1800000.00 AS Decimal(18, 2)), N'Import', 4, N'Nhập lô Converse Winter')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (48, 4, CAST(N'2025-12-29T00:00:00.000' AS DateTime), CAST(2200000.00 AS Decimal(18, 2)), N'Import', 5, N'Nhập lô Vans cuối năm')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (49, 4, CAST(N'2025-01-18T00:00:00.000' AS DateTime), CAST(3300000.00 AS Decimal(18, 2)), N'Import', 6, N'Nhập lô Reebok đầu năm')
GO
INSERT [dbo].[Bill] ([ID], [AccountID], [Date], [Total], [BillType], [BrandID], [Note]) VALUES (50, 4, CAST(N'2025-03-12T00:00:00.000' AS DateTime), CAST(900000.00 AS Decimal(18, 2)), N'Import', 7, N'Nhập lô New Balance bổ sung')
GO
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillDetail] ON 
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (1, 1, 1, 1, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (2, 1, 3, 2, 2800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (3, 2, 4, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (4, 2, 5, 3, 1500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (5, 3, 2, 1, 2900000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (6, 3, 6, 2, 1200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (7, 4, 7, 2, 1300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (8, 4, 9, 1, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (9, 5, 10, 2, 2300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (10, 5, 12, 1, 2700000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (11, 6, 8, 1, 1600000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (12, 6, 11, 2, 2000000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (13, 7, 13, 2, 1800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (14, 8, 14, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (15, 9, 15, 3, 1100000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (16, 10, 16, 2, 900000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (17, 11, 17, 1, 2000000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (18, 12, 18, 2, 3100000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (19, 13, 19, 1, 2300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (20, 14, 20, 1, 1550000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (21, 15, 1, 2, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (22, 16, 2, 3, 2800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (23, 17, 3, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (24, 18, 4, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (25, 19, 5, 3, 1500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (26, 20, 6, 2, 1200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (27, 21, 7, 2, 1300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (28, 22, 8, 1, 1600000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (29, 23, 9, 1, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (30, 24, 10, 2, 2300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (31, 25, 11, 2, 2000000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (32, 26, 12, 2, 2700000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (33, 27, 13, 1, 1800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (34, 28, 14, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (35, 29, 15, 3, 1100000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (36, 30, 16, 1, 900000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (37, 31, 17, 1, 2000000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (38, 32, 18, 2, 3100000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (39, 33, 19, 1, 2300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (40, 34, 20, 1, 1550000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (41, 35, 1, 2, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (42, 36, 2, 2, 2800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (43, 37, 3, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (44, 38, 4, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (45, 39, 5, 3, 1500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (46, 40, 6, 2, 1200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (47, 41, 7, 2, 1300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (48, 42, 8, 1, 1600000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (49, 43, 9, 1, 2500000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (50, 44, 10, 2, 2300000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (51, 45, 11, 2, 2000000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (52, 46, 12, 2, 2700000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (53, 47, 13, 1, 1800000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (54, 48, 14, 1, 2200000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (55, 49, 15, 3, 1100000, NULL)
GO
INSERT [dbo].[BillDetail] ([ID], [BillID], [ItemID], [Quantity], [Price], [Source]) VALUES (56, 50, 16, 1, 900000, NULL)
GO
SET IDENTITY_INSERT [dbo].[BillDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Brand] ON 
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (1, N'Nike', N'0909009009', N'support@nike.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (2, N'Adidas', N'0908111222', N'contact@adidas.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (3, N'Puma', N'0907333444', N'info@puma.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (4, N'Converse', N'0909555666', N'hello@converse.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (5, N'Vans', N'0908666888', N'contact@vans.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (6, N'Reebok', N'0908999777', N'info@reebok.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (7, N'New Balance', N'0908777555', N'support@newbalance.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (8, N'Skechers', N'0908666444', N'help@skechers.com')
GO
INSERT [dbo].[Brand] ([ID], [Name], [Phone], [Email]) VALUES (9, N'Under Armour', N'0908111999', N'service@underarmour.com')
GO
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([ID], [FullName], [Gender], [BirthDate], [Address], [Phone], [Email], [RoleID], [AccountID]) VALUES (1, N'Nguyễn Văn A', N'Nam', CAST(N'1990-05-01' AS Date), N'Hà Nội', N'0901111111', N'a@shoeshop.com', 1, 1)
GO
INSERT [dbo].[Employee] ([ID], [FullName], [Gender], [BirthDate], [Address], [Phone], [Email], [RoleID], [AccountID]) VALUES (2, N'Lê Thị B', N'Nữ', CAST(N'1993-08-15' AS Date), N'Hồ Chí Minh', N'0902222222', N'b@shoeshop.com', 2, 2)
GO
INSERT [dbo].[Employee] ([ID], [FullName], [Gender], [BirthDate], [Address], [Phone], [Email], [RoleID], [AccountID]) VALUES (3, N'Phạm Văn C', N'Nam', CAST(N'1996-01-22' AS Date), N'Đà Nẵng', N'0903333333', N'c@shoeshop.com', 3, 3)
GO
INSERT [dbo].[Employee] ([ID], [FullName], [Gender], [BirthDate], [Address], [Phone], [Email], [RoleID], [AccountID]) VALUES (4, N'Hoàng Thị D', N'Nữ', CAST(N'1998-07-10' AS Date), N'Hải Phòng', N'0904444444', N'd@shoeshop.com', 4, 4)
GO
INSERT [dbo].[Employee] ([ID], [FullName], [Gender], [BirthDate], [Address], [Phone], [Email], [RoleID], [AccountID]) VALUES (5, N'Trần Văn E', N'Nam', CAST(N'1999-03-18' AS Date), N'Cần Thơ', N'0905555555', N'e@shoeshop.com', 3, 5)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (1, N'Nike Air Zoom', 2, N'18', NULL, 5, 2500000, 15, 1, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (2, N'Nike Pegasus 40', 2, N'18', NULL, 5, 2900000, 20, 1, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (3, N'Adidas UltraBoost', 2, N'18', NULL, 5, 2800000, 18, 2, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (4, N'Adidas Stan Smith', 1, N'18', NULL, 2, 2200000, 20, 2, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (5, N'Puma Runner', 0, N'u18', NULL, 2, 1500000, 25, 3, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (6, N'Puma Smash V2', 1, N'u11', NULL, 2, 1200000, 30, 3, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (7, N'Converse High', 0, N'u18', NULL, 2, 1300000, 40, 4, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (8, N'Vans Old Skool', 0, N'u18', NULL, 2, 1600000, 35, 5, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (9, N'Reebok Nano X', 2, N'18', NULL, 5, 2500000, 20, 6, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (10, N'New Balance 574', 0, N'18', NULL, 2, 2300000, 18, 7, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (11, N'Skechers Go Walk', 1, N'18', NULL, 2, 2000000, 25, 8, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (12, N'Under Armour HOVR', 2, N'18', NULL, 5, 2700000, 12, 9, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (13, N'Adidas High Heel', 1, N'18', NULL, 4, 1800000, 15, 2, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (14, N'Puma Elegant Step', 1, N'18', NULL, 4, 2200000, 10, 3, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (15, N'Nike Air Sandal', 0, N'18', NULL, 1, 1100000, 30, 1, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (16, N'Adidas Comfort Sandal', 0, N'u11', NULL, 1, 900000, 25, 2, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (17, N'Converse Winter Boot', 0, N'u18', NULL, 3, 2000000, 20, 4, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (18, N'Nike Trail Boot', 2, N'18', NULL, 3, 3100000, 15, 1, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (19, N'Reebok Classic Leather', 2, N'18', NULL, 4, 2300000, 22, 6, 1)
GO
INSERT [dbo].[Item] ([ID], [Name], [Gender], [Age], [Size], [TypeID], [Price], [Stock], [BrandID], [Actived]) VALUES (20, N'Vans Authentic Low', 0, N'u18', NULL, 4, 1550000, 28, 5, 1)
GO
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Description]) VALUES (1, N'Admin', N'Quản trị hệ thống')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Description]) VALUES (2, N'Cashier', N'Thu ngân')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Description]) VALUES (3, N'Sales', N'Nhân viên bán hàng')
GO
INSERT [dbo].[Role] ([ID], [RoleName], [Description]) VALUES (4, N'Manager', N'Quản lý')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 
GO
INSERT [dbo].[Type] ([ID], [Name]) VALUES (1, N'Sandal')
GO
INSERT [dbo].[Type] ([ID], [Name]) VALUES (2, N'Shoes')
GO
INSERT [dbo].[Type] ([ID], [Name]) VALUES (3, N'Boot')
GO
INSERT [dbo].[Type] ([ID], [Name]) VALUES (4, N'Heels')
GO
INSERT [dbo].[Type] ([ID], [Name]) VALUES (5, N'Sport')
GO
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Account__536C85E4258863FF]    Script Date: 11/13/2025 2:06:58 AM ******/
ALTER TABLE [dbo].[Account] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Brand__737584F6CC553272]    Script Date: 11/13/2025 2:06:58 AM ******/
ALTER TABLE [dbo].[Brand] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Role__8A2B6160EE8DD9DD]    Script Date: 11/13/2025 2:06:58 AM ******/
ALTER TABLE [dbo].[Role] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[Item] ADD  DEFAULT ((1)) FOR [Actived]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Account]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brand] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Brand]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Bill] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Bill]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Item] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Item]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Account]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brand] ([ID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Brand]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([ID])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Type]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD CHECK  (([BillType]='Export' OR [BillType]='Import'))
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD CHECK  (([Price]>=(0)))
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD CHECK  (([Quantity]>(0)))
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD CHECK  (([Age]='18' OR [Age]='u18' OR [Age]='u11' OR [Age]='u5'))
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD CHECK  (([Gender]=(2) OR [Gender]=(1) OR [Gender]=(0)))
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD CHECK  (([Price]>=(0)))
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD CHECK  (([Stock]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[GetBillByDate]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[GetBillByDate]
	@day int = null,
	@month int = null,
	@year int = null
as
begin
/*
    Proc Name : GetBillByDate
    Purpose   : Lấy Bill trong thời gian cụ thể, có thể lọc theo ngày/tháng/năm nếu được cung cấp.
                Quy tắc lọc:
                - Nếu có đủ @day, @month, @year => lọc theo ngày/tháng/năm
                - Nếu có @month, @year nhưng @day null => lọc theo tháng/năm
                - Nếu chỉ có @year => lọc theo năm
                - Nếu tất cả null => không lọc theo thời gian (đương tương với GetAll)
*/
declare 
        @isDayNull bit = case when @day is null then 1 else 0 end,
        @isMonthNull bit = case when @month is null then 1 else 0 end,
        @isYearNull bit = case when @year is null then 1 else 0 end;

select *
from Bill b
where (
		(
		@isDayNull = 0 and @isMonthNull = 0 and @isYearNull = 0
		and day(b.[Date]) = @day and month(b.[Date]) = @month and year(b.[Date]) = @year
		)
		or
		(
		@isDayNull = 1 and @isMonthNull = 0 and @isYearNull = 0
		and  month(b.[Date]) = @month and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 0
		and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 1
		)
		)
end;
GO
/****** Object:  StoredProcedure [dbo].[GetTotal]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[GetTotal]
	@BillID int,
	@ItemID int,
	@day int = null,
	@month int = null,
	@year int = null
as
begin
/*
    Proc Name : GetBillTotal
    Purpose   : Tính total theo chi tiết hóa đơn (Quantity * Price) có thể lọc theo ngày/tháng/năm nếu được cung cấp.
                Quy tắc lọc:
                - Nếu có đủ @day, @month, @year => lọc theo ngày/tháng/năm
                - Nếu có @month, @year nhưng @day null => lọc theo tháng/năm
                - Nếu chỉ có @year => lọc theo năm
                - Nếu tất cả null => không lọc theo thời gian
*/
declare 
        @isDayNull bit = case when @day is null then 1 else 0 end,
        @isMonthNull bit = case when @month is null then 1 else 0 end,
        @isYearNull bit = case when @year is null then 1 else 0 end;

select (bd.Quantity * bd.Price) as Total, b.[Date]
from BillDetail bd
join Bill b on b.ID = bd.BillID
where b.ID = @BillID
	and bd.ItemID = @ItemID
	and(
		(
		@isDayNull = 0 and @isMonthNull = 0 and @isYearNull = 0
		and day(b.[Date]) = @day and month(b.[Date]) = @month and year(b.[Date]) = @year
		)
		or
		(
		@isDayNull = 1 and @isMonthNull = 0 and @isYearNull = 0
		and  month(b.[Date]) = @month and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 0
		and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 1
		)
		)
end;
GO
/****** Object:  Trigger [dbo].[trg_UpdateBillTotal]    Script Date: 11/13/2025 2:06:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------------------------------------
-- 8️⃣ Trigger cập nhật tổng tiền Bill
----------------------------------------------------
CREATE TRIGGER [dbo].[trg_UpdateBillTotal]
ON [dbo].[BillDetail]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE Bill
    SET Total = (
        SELECT ISNULL(SUM(Quantity * Price), 0)
        FROM BillDetail
        WHERE BillDetail.BillID = Bill.ID
    )
    WHERE Bill.ID IN (
        SELECT DISTINCT BillID FROM inserted
        UNION
        SELECT DISTINCT BillID FROM deleted
    );
END;
GO
ALTER TABLE [dbo].[BillDetail] ENABLE TRIGGER [trg_UpdateBillTotal]
GO
USE [master]
GO
ALTER DATABASE [ShoeShop] SET  READ_WRITE 
GO
