USE [ApıDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24.06.2022 20:40:17 ******/
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
/****** Object:  Table [dbo].[Bootcamps]    Script Date: 24.06.2022 20:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bootcamps](
	[BootcampId] [int] IDENTITY(1,1) NOT NULL,
	[BootcampName] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Active] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Bootcamps] PRIMARY KEY CLUSTERED 
(
	[BootcampId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.06.2022 20:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[NameSurname] [nvarchar](max) NOT NULL,
	[BootcampId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623115437_createdb', N'6.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623130748_new_mig', N'6.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220623130927_add-migration mig_new_2', N'6.0.6')
GO
SET IDENTITY_INSERT [dbo].[Bootcamps] ON 

INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (1, N'Arvato', N'.Net Core Bootcamp', 1, 0, CAST(N'2022-06-13T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (2, N'Akbank', N'React Bootcamp', 1, 0, CAST(N'2022-06-21T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (3, N'Arçelik', N'Node.js Bootcamp', 1, 0, CAST(N'2022-06-21T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (4, N'Trendyol', N'Database Bootcamp', 1, 0, CAST(N'2022-06-21T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (5, N'Yapı Kredi ', N'Data Engineer Bootcamp', 0, 1, CAST(N'2022-04-21T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (6, N'Cicek Sepeti', N'Java Developer', 1, 1, CAST(N'2022-06-20T13:45:30.4680000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (7, N'PayCo', N'.Net Developer', 1, 0, CAST(N'2022-04-23T15:01:23.8710000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (8, N'Getir', N'Vue.js Bootcamp', 1, 0, CAST(N'2022-05-15T15:01:23.8710000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (9, N'Vestel', N'AI Bootcamp', 0, 1, CAST(N'2022-03-24T11:28:47.6700000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (10, N'Iş Bankası', N'Java Spring Bootcamp', 0, 1, CAST(N'2022-04-24T12:11:13.5460000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (11, N'Sıemenss', N'Angular Bootcamp', 0, 1, CAST(N'2022-02-24T11:36:23.9360000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (12, N'Protein', N'.Net Core Bootcamp', 0, 1, CAST(N'2022-02-24T11:37:35.4170000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (13, N'Link Computer', N'.Net Core Bootcamp', 1, 0, CAST(N'2022-05-24T11:43:46.4160000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (14, N'Yemek Sepeti', N'Angular Bootcamp', 1, 0, CAST(N'2022-06-24T12:02:26.4570000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (15, N'BiTaksi', N'Full Stack Developer Bootcamp', 1, 0, CAST(N'2022-06-24T12:03:59.2480000' AS DateTime2))
INSERT [dbo].[Bootcamps] ([BootcampId], [BootcampName], [Description], [Active], [Deleted], [CreatedDate]) VALUES (16, N'Iş Bankası', N'Java Spring Bootcamp', 1, 0, CAST(N'2022-06-24T12:08:41.1500000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Bootcamps] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [NameSurname], [BootcampId]) VALUES (1, N'Cem Sahin', 1)
INSERT [dbo].[Users] ([UserId], [NameSurname], [BootcampId]) VALUES (3, N'Musa Aydın', 2)
INSERT [dbo].[Users] ([UserId], [NameSurname], [BootcampId]) VALUES (4, N'Ali Ocakbaşı', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
