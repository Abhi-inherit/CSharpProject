USE [FirstMCV_PartialView]
GO
/****** Object:  Table [dbo].[tbl_Place]    Script Date: 09/11/2017 16:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Place](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceName] [varchar](50) NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_tbl_Place] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Place] ON
INSERT [dbo].[tbl_Place] ([Id], [PlaceName], [Status]) VALUES (1, N'Thrissur', N'A')
INSERT [dbo].[tbl_Place] ([Id], [PlaceName], [Status]) VALUES (2, N'Ernakullam', N'A')
SET IDENTITY_INSERT [dbo].[tbl_Place] OFF
/****** Object:  Table [dbo].[tbl_People]    Script Date: 09/11/2017 16:01:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[DateOfBirth] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[Phone] [varchar](50) NULL,
	[Image] [varchar](50) NULL,
	[Place] [int] NULL,
	[Status] [char](1) NULL,
 CONSTRAINT [PK_tbl_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_People] ON
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (2, N'Soumya s', N'2016-01-07', N'aitrich,mg road thrissur', N'9567122708', N'img21.jpg', 2, N'D')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (7, N'Vinayk', N'1/7/2016', N'aitrich, thrissur', N'9895969323', N'photo1.jpg', 2, N'D')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (31, N'varsha', N'1/2/1993', N'aitrich, thrissur', N'9895986468', N'img21.jpg', 1, N'A')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (32, N'varsha', N'1/2/1993', N'aitrich, thrissur', N'9895986468', N'img21.jpg', 2, N'D')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (33, N'kavya', N'1/2/1993', N'aitrich, thrissur', N'9895986468', N'img21.jpg', 1, N'A')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (34, N'cvgcx', N'1/2/1993', N'aitrich, thrissur', N'90615447254', N'photo1.jpg', 1, N'A')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (48, N'ss', N'1/2/1993', N'aitrich, thrissur', N'5658', N'photo1.jpg', 1, N'A')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (49, N'qqqq', N'1/2/1993', N'xcxcvxcv', N'4356346', N'photo1.jpg', 2, N'D')
INSERT [dbo].[tbl_People] ([Id], [Name], [DateOfBirth], [Address], [Phone], [Image], [Place], [Status]) VALUES (50, N'bbbb', N'11/02/2012', N'dfgdfg', N'456456546', N'photo1.jpg', 2, N'D')
SET IDENTITY_INSERT [dbo].[tbl_People] OFF
/****** Object:  ForeignKey [FK_tbl_People_tbl_Place]    Script Date: 09/11/2017 16:01:23 ******/
ALTER TABLE [dbo].[tbl_People]  WITH CHECK ADD  CONSTRAINT [FK_tbl_People_tbl_Place] FOREIGN KEY([Place])
REFERENCES [dbo].[tbl_Place] ([Id])
GO
ALTER TABLE [dbo].[tbl_People] CHECK CONSTRAINT [FK_tbl_People_tbl_Place]
GO
