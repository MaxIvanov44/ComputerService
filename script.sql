USE [master]
GO
/****** Object:  Database [ComputerService]    Script Date: 14.01.2020 14:33:08 ******/
CREATE DATABASE [ComputerService]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ComputerService', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ComputerService.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ComputerService_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ComputerService_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ComputerService] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ComputerService].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ComputerService] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ComputerService] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ComputerService] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ComputerService] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ComputerService] SET ARITHABORT OFF 
GO
ALTER DATABASE [ComputerService] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ComputerService] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ComputerService] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ComputerService] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ComputerService] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ComputerService] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ComputerService] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ComputerService] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ComputerService] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ComputerService] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ComputerService] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ComputerService] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ComputerService] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ComputerService] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ComputerService] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ComputerService] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ComputerService] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ComputerService] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ComputerService] SET  MULTI_USER 
GO
ALTER DATABASE [ComputerService] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ComputerService] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ComputerService] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ComputerService] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ComputerService] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ComputerService] SET QUERY_STORE = OFF
GO
USE [ComputerService]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id_admin] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[block] [tinyint] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[id_comp] [int] IDENTITY(1,1) NOT NULL,
	[problem] [nvarchar](100) NULL,
	[brand] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[model] [nvarchar](100) NOT NULL,
	[price] [nvarchar](50) NULL,
	[description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Computers] PRIMARY KEY CLUSTERED 
(
	[id_comp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[Order] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[Parts] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[id_manager] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[middle_name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[serial_passport] [nvarchar](4) NOT NULL,
	[number_passport] [nvarchar](6) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Managers] PRIMARY KEY CLUSTERED 
(
	[id_manager] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masters]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masters](
	[id_master] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[middle_name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Masters] PRIMARY KEY CLUSTERED 
(
	[id_master] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[order_status] [int] NOT NULL,
	[client] [int] NOT NULL,
	[master] [int] NOT NULL,
	[date_of_acceptance] [date] NULL,
	[date_of_return] [date] NULL,
	[cost] [int] NULL,
	[description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusManager]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusManager](
	[id_status] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusManager] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusMaster]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusMaster](
	[id_status] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusMaster] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnlockRequest]    Script Date: 14.01.2020 14:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnlockRequest](
	[id_request] [int] IDENTITY(1,1) NOT NULL,
	[client] [int] NOT NULL,
	[message] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_UnlockRequest] PRIMARY KEY CLUSTERED 
(
	[id_request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_email]  DEFAULT (N'not specified') FOR [email]
GO
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_block]  DEFAULT ((0)) FOR [block]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_repair_price]  DEFAULT ((0)) FOR [cost]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_description]  DEFAULT (N'Не указано') FOR [description]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([client])
REFERENCES [dbo].[Clients] ([id_user])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Masters] FOREIGN KEY([master])
REFERENCES [dbo].[Masters] ([id_master])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Masters]
GO
USE [master]
GO
ALTER DATABASE [ComputerService] SET  READ_WRITE 
GO
