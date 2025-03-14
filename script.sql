USE [master]
GO
/****** Object:  Database [ParkingReservationSystem]    Script Date: 21.05.2023 21:26:23 ******/
CREATE DATABASE [ParkingReservationSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ParkingReservationSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ParkingReservationSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ParkingReservationSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ParkingReservationSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ParkingReservationSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ParkingReservationSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ParkingReservationSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ParkingReservationSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ParkingReservationSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ParkingReservationSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ParkingReservationSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [ParkingReservationSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ParkingReservationSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ParkingReservationSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ParkingReservationSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ParkingReservationSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ParkingReservationSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ParkingReservationSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ParkingReservationSystem', N'ON'
GO
ALTER DATABASE [ParkingReservationSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [ParkingReservationSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ParkingReservationSystem]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 21.05.2023 21:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VIN] [varchar](20) NULL,
	[Year] [int] NULL,
	[Make] [varchar](20) NULL,
	[Model] [varchar](20) NULL,
	[Description] [varchar](10) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParkingSlots]    Script Date: 21.05.2023 21:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParkingSlots](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sector_ID] [int] NULL,
	[Description] [varchar](200) NULL,
 CONSTRAINT [PK_ParkingSlots] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 21.05.2023 21:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Car_ID] [int] NULL,
	[ParkPlace_ID] [int] NULL,
	[DateFrom] [datetime] NULL,
	[DateTo] [datetime] NULL,
	[Description] [varchar](50) NULL,
	[CreationTime] [datetime] NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectors]    Script Date: 21.05.2023 21:26:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Description] [varchar](200) NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([ID], [VIN], [Year], [Make], [Model], [Description]) VALUES (1, N'1FABP21B4CK165368', 1982, N'Ford', N'Ford', N'test5')
INSERT [dbo].[Cars] ([ID], [VIN], [Year], [Make], [Model], [Description]) VALUES (2, N'WP0AA2A79BL017244', 2011, N'Porsche', N'Porsche', N'Vedoucí')
INSERT [dbo].[Cars] ([ID], [VIN], [Year], [Make], [Model], [Description]) VALUES (3, N'4T1BF3EK5BU638805', 2011, N'Toyota', N'Toyota', N'Zaměstanec')
INSERT [dbo].[Cars] ([ID], [VIN], [Year], [Make], [Model], [Description]) VALUES (4, N'TRUWT28N011046197', 2001, N'Audi', N'Audi', N'test')
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[ParkingSlots] ON 

INSERT [dbo].[ParkingSlots] ([ID], [Sector_ID], [Description]) VALUES (1, 1, N'test5')
INSERT [dbo].[ParkingSlots] ([ID], [Sector_ID], [Description]) VALUES (2, 2, N'a')
INSERT [dbo].[ParkingSlots] ([ID], [Sector_ID], [Description]) VALUES (3, 1, N'a')
INSERT [dbo].[ParkingSlots] ([ID], [Sector_ID], [Description]) VALUES (6, 2, N'test')
SET IDENTITY_INSERT [dbo].[ParkingSlots] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([ID], [Car_ID], [ParkPlace_ID], [DateFrom], [DateTo], [Description], [CreationTime]) VALUES (1, 1, 3, CAST(N'2023-05-20T12:30:35.000' AS DateTime), CAST(N'2023-05-16T12:30:35.000' AS DateTime), N'test5', CAST(N'2023-05-20T12:30:35.000' AS DateTime))
INSERT [dbo].[Reservations] ([ID], [Car_ID], [ParkPlace_ID], [DateFrom], [DateTo], [Description], [CreationTime]) VALUES (2, 1, 3, CAST(N'2023-05-17T12:52:59.000' AS DateTime), CAST(N'2023-05-20T12:52:59.000' AS DateTime), N'', CAST(N'2023-05-20T12:30:35.000' AS DateTime))
INSERT [dbo].[Reservations] ([ID], [Car_ID], [ParkPlace_ID], [DateFrom], [DateTo], [Description], [CreationTime]) VALUES (3, 1, 6, CAST(N'2023-05-16T13:02:30.000' AS DateTime), CAST(N'2023-05-16T15:02:30.000' AS DateTime), N'', CAST(N'2023-05-20T12:30:35.000' AS DateTime))
INSERT [dbo].[Reservations] ([ID], [Car_ID], [ParkPlace_ID], [DateFrom], [DateTo], [Description], [CreationTime]) VALUES (4, 3, 6, CAST(N'2023-05-04T20:32:07.000' AS DateTime), CAST(N'2023-05-21T20:32:07.790' AS DateTime), N'aaa', CAST(N'2023-05-21T20:32:21.063' AS DateTime))
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 

INSERT [dbo].[Sectors] ([ID], [Name], [Description]) VALUES (1, N'SEC1', N'Main building')
INSERT [dbo].[Sectors] ([ID], [Name], [Description]) VALUES (2, N'SEC2', N'Main building')
INSERT [dbo].[Sectors] ([ID], [Name], [Description]) VALUES (3, N'SEC3', N'Side building')
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO
ALTER TABLE [dbo].[ParkingSlots]  WITH CHECK ADD  CONSTRAINT [FK_ParkingSlots_ParkingSlots] FOREIGN KEY([Sector_ID])
REFERENCES [dbo].[Sectors] ([ID])
GO
ALTER TABLE [dbo].[ParkingSlots] CHECK CONSTRAINT [FK_ParkingSlots_ParkingSlots]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Cars] FOREIGN KEY([Car_ID])
REFERENCES [dbo].[Cars] ([ID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Cars]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_ParkingSlots] FOREIGN KEY([ParkPlace_ID])
REFERENCES [dbo].[ParkingSlots] ([ID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_ParkingSlots]
GO
USE [master]
GO
ALTER DATABASE [ParkingReservationSystem] SET  READ_WRITE 
GO
