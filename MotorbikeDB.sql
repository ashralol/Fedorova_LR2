USE [master]
GO
CREATE DATABASE [MotorbikeDB]
GO
USE [MotorbikeDB]
GO
CREATE TABLE [dbo].[Table_Motorbike](
	[ID] [int] NOT NULL,
	[Model] [nvarchar](50) NULL,
	[Brand] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Horsepower] [int] NULL,
	[Mileage] [float] NULL,
	[Picture] [nvarchar](max) NULL,
 CONSTRAINT [PK_Table_Motorbike] PRIMARY KEY CLUSTERED ([ID] ASC)
) ON [PRIMARY]
GO
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (1, N'Multistrada 950', N'Ducati', 1200000, 113, 6300, N'1.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (2, N'FXDR 114', N'Harley-Davidson', 4500000, 90, 12, N'2.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (3, N'R 1200 GS', N'BMW', 775000, 105, 50454, N'3.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (4, N'Africa Twin CRF 1000L/1100L', N'Honda', 1095000, 95, 37620, N'4.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (5, N'R 1200 R', N'BMW', 725000, 110, 28000, N'5.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (6, N'SL 750 Shiver', N'Aprilia', 357000, 95, 357000, N'6.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (7, N'390 Adventure', N'KTM', 679900, 44, 15, N'7.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (8, N'XVS1300', N'Yamaha', 620000, 76, 60000, N'8.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (9, N'VFR 1200', N'Honda', 750000, 111, 38800, N'9.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (10, N'Street Triple', N'Triumph', 1015000, 116, 4700, N'10.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (11, N'Monster', N'Ducati', 950000, 109, 20334, N'11.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (12, N'XV950 Bolt', N'Yamaha', 630000, 52, 39729, N'12.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (13, N'XDiavel', N'Ducati', 2020000, 152, 7429, N'13.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (14, N'XLR', N'Honda', 200000, 33, 31000, N'14.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (15, N'VT 750', N'Honda', 470000, 45, 16400, N'15.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (16, N'R 1200 R', N'BMW', 840000, 110, 16200, N'16.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (17, N'R 1250 GS Adventure', N'BMW', 3200000, 136, 5, N'17.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (18, N'Sportster S', N'Harley-Davidson', 1930000, 122, 352, N'18.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (19, N'F 900 XR', N'BMW', 1050000, 105, 3100, N'19.png')
INSERT [dbo].[Table_Motorbike] ([ID], [Model], [Brand], [Price], [Horsepower], [Mileage], [Picture]) VALUES (20, N'X 250', N'Minsk', 130000, 16, 284, N'20.png')
GO
