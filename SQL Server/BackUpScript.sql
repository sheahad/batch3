--CREATE DATABASE  [StudentDB]
USE [StudentDB]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/11/2019 11:26:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (1, N'Ali', 21)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (2, N'Asad', 22)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (3, N'Asad', 30)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (5, N'Arif', 31)
SET IDENTITY_INSERT [dbo].[Students] OFF
