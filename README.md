# CognisunPractical

For Database : we are using two commands 

after making required models,
we run

- add-migration init (where init is a name of migration)
- update-database (this will create database and tables)


database initial entries
we have three main tables

- taxMaster
- Products
- Orders

we will make static and inital entries in TaxMasters and Products
USE [Trial]
GO
/****** Object:  Table [dbo].[ProductMasters]    Script Date: 19-11-2023 21:14:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductMasters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](max) NOT NULL,
	[SKU] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Price] [real] NOT NULL,
	[Discount] [real] NOT NULL,
 CONSTRAINT [PK_ProductMasters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxMaster]    Script Date: 19-11-2023 21:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TaxValue] [int] NOT NULL,
	[Category] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TaxMaster] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ProductMasters] ON 
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (1, N'Electronics', 452, N'Washing Machine', N'Washing Machine description here', 1500, 10)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (2, N'Electronics', 455, N'Air Conditioner', N'Air Conditioner description here', 3500, 10)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (3, N'Electronics', 459, N'Refrigerator', N'Refrigerator description here', 4000, 10)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (4, N'Cosmetics', 659, N'Shaving Cream', N'Shaving Cream description here', 40, 7)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (5, N'Cosmetics', 658, N'Razor', N'Razor description here', 45, 10)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (6, N'Clothing', 789, N'Trouser', N'Trouser description here', 26, 5)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (7, N'Clothing', 1236, N'Woven Shirt', N'Woven Shirt description here', 12, 10)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (8, N'Medicines', 990, N'Aspirin 15mg', N'Aspirin 15mg description here', 5.5, 5)
GO
INSERT [dbo].[ProductMasters] ([Id], [Category], [SKU], [Name], [Description], [Price], [Discount]) VALUES (9, N'Medicines', 991, N'VCure 30 mg', N'VCure 30 mg description here', 7.4, 5)
GO
SET IDENTITY_INSERT [dbo].[ProductMasters] OFF
GO
SET IDENTITY_INSERT [dbo].[TaxMaster] ON 
GO
INSERT [dbo].[TaxMaster] ([ID], [TaxValue], [Category]) VALUES (1, 5, N'Clothing')
GO
INSERT [dbo].[TaxMaster] ([ID], [TaxValue], [Category]) VALUES (2, 10, N'Cosmetics')
GO
INSERT [dbo].[TaxMaster] ([ID], [TaxValue], [Category]) VALUES (3, 15, N'Electronics')
GO
INSERT [dbo].[TaxMaster] ([ID], [TaxValue], [Category]) VALUES (4, 18, N'Medicines')
GO
SET IDENTITY_INSERT [dbo].[TaxMaster] OFF
GO



