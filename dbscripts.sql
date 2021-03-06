USE [Travel-Blog]
GO
/****** Object:  Table [dbo].[experiences]    Script Date: 8/1/2017 4:41:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[experiences](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](255) NOT NULL,
	[date] [datetime] NOT NULL,
	[personId] [int] NOT NULL,
	[locationId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[locations]    Script Date: 8/1/2017 4:41:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[locations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[region] [nvarchar](255) NOT NULL,
	[planet] [nvarchar](255) NOT NULL,
	[biome] [nvarchar](255) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[people]    Script Date: 8/1/2017 4:41:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[people](
	[id] [int] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[species] [nvarchar](255) NOT NULL,
	[affiliation] [nvarchar](255) NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[experiences] ON 

INSERT [dbo].[experiences] ([id], [description], [date], [personId], [locationId]) VALUES (2, N'That one time...', CAST(N'1976-05-27T00:00:00.000' AS DateTime), 1, 3)
SET IDENTITY_INSERT [dbo].[experiences] OFF
SET IDENTITY_INSERT [dbo].[locations] ON 

INSERT [dbo].[locations] ([id], [region], [planet], [biome]) VALUES (1, N'Core', N'Coruscant', N'Urban')
INSERT [dbo].[locations] ([id], [region], [planet], [biome]) VALUES (2, N'Mid Rim', N'Kashyyyk', N'Arboreal')
INSERT [dbo].[locations] ([id], [region], [planet], [biome]) VALUES (3, N'Outer Rim', N'Tatooine', N'Desert')
SET IDENTITY_INSERT [dbo].[locations] OFF
