USE [DemoSPS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/29/2024 1:12:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/29/2024 1:12:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240729051858_Add-Product', N'6.0.32')
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'2347d1aa-4f3d-4d1e-aca3-2aa9f25294cd', N'Sản phẩm 6', N'Chất lượng cao', 48, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'3495f6cd-8880-477d-9967-b60c185fca2f', N'Sản phẩm 8', N'Chất lượng cao', 64, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'89da4dfb-7f4b-4819-a06e-463cede4fe14', N'Sản phẩm 10', N'Chất lượng cao', 80, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'93e769df-1e94-48ed-8c74-8752a9cf9458', N'Sản phẩm 2', N'Chất lượng cao', 16, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'9f12dad5-376f-46f6-91cb-150eb6744ff2', N'Sản phẩm 1', N'Chất lượng cao', 8, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'ab98881b-e99e-47e5-afc8-070243492a93', N'Sản phẩm 9', N'Chất lượng cao', 72, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'b9b7137a-fa2c-499e-92aa-122ec918cffe', N'Sản phẩm 7', N'Chất lượng cao', 56, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'ddcf885c-4c08-46af-96b0-5bbbeea90b79', N'Sản phẩm 4', N'Chất lượng cao', 32, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'debddab8-a8d0-4a22-b437-6820d0bfa8e0', N'Sản phẩm 3', N'Chất lượng cao', 24, 1)
INSERT [dbo].[Products] ([Id], [Name], [Description], [Quantity], [IsActive]) VALUES (N'e688022f-d6b0-43b0-8520-597de67be1b4', N'Sản phẩm 5', N'Chất lượng cao', 40, 1)
GO
