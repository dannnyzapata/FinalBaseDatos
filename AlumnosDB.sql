USE [master]
GO
/****** Object:  Database [AlumnosDB]    Script Date: 08/06/2020 06:56:26 p. m. ******/
CREATE DATABASE [AlumnosDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlumnosDB', FILENAME = N'D:\Gaymes\MSSQL14.SQLEXPRESS\MSSQL\DATA\AlumnosDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AlumnosDB_log', FILENAME = N'D:\Gaymes\MSSQL14.SQLEXPRESS\MSSQL\DATA\AlumnosDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AlumnosDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlumnosDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AlumnosDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AlumnosDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AlumnosDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AlumnosDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AlumnosDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AlumnosDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AlumnosDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AlumnosDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AlumnosDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AlumnosDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AlumnosDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AlumnosDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AlumnosDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AlumnosDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AlumnosDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AlumnosDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AlumnosDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AlumnosDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AlumnosDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AlumnosDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AlumnosDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AlumnosDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AlumnosDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AlumnosDB] SET  MULTI_USER 
GO
ALTER DATABASE [AlumnosDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AlumnosDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AlumnosDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AlumnosDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AlumnosDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AlumnosDB] SET QUERY_STORE = OFF
GO
USE [AlumnosDB]
GO
/****** Object:  Table [dbo].[Basico]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basico](
	[Folio] [int] IDENTITY(922,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Graduado] [bit] NOT NULL,
	[Upgrade] [bit] NOT NULL,
	[IdProf] [int] NOT NULL,
 CONSTRAINT [PK_Basico] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correo]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correo](
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IntermedioI]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IntermedioI](
	[Folio] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Graduado] [bit] NOT NULL,
	[Upgrade] [bit] NOT NULL,
	[IdProf] [int] NOT NULL,
 CONSTRAINT [PK_Intermedio1] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IntermedioII]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IntermedioII](
	[Folio] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Graduado] [bit] NOT NULL,
	[Upgrade] [bit] NOT NULL,
	[IdProf] [int] NOT NULL,
 CONSTRAINT [PK_IntermedioII] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IntermedioIII]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IntermedioIII](
	[Folio] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Graduado] [bit] NOT NULL,
	[Upgrade] [bit] NOT NULL,
	[IdProf] [int] NOT NULL,
 CONSTRAINT [PK_IntermedioIII] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IntermedioIV]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IntermedioIV](
	[Folio] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[Foto] [image] NULL,
	[Graduado] [bit] NOT NULL,
	[Upgrade] [bit] NOT NULL,
	[IdProf] [int] NOT NULL,
 CONSTRAINT [PK_IntermedioIV] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 08/06/2020 06:56:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[IdProf] [int] NOT NULL,
	[Nombre] [nchar](50) NOT NULL,
	[PrimerApellido] [nchar](50) NOT NULL,
	[SegundoApellido] [nchar](50) NOT NULL,
	[Correo] [nchar](50) NOT NULL,
	[Foto] [image] NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[IdProf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Profesores] ([IdProf], [Nombre], [PrimerApellido], [SegundoApellido], [Correo], [Foto]) VALUES (1, N'Juan                                              ', N'Perez                                             ', N'Zavala                                            ', N'JuPe@icsm.org                                     ', NULL)
INSERT [dbo].[Profesores] ([IdProf], [Nombre], [PrimerApellido], [SegundoApellido], [Correo], [Foto]) VALUES (2, N'Pedro                                             ', N'Rodriguez                                         ', N'Suarez                                            ', N'PeRo@icsm.org                                     ', NULL)
INSERT [dbo].[Profesores] ([IdProf], [Nombre], [PrimerApellido], [SegundoApellido], [Correo], [Foto]) VALUES (3, N'Adalberto                                         ', N'Jimenez                                           ', N'Yañez                                             ', N'AdJi@icsm.org                                     ', NULL)
INSERT [dbo].[Profesores] ([IdProf], [Nombre], [PrimerApellido], [SegundoApellido], [Correo], [Foto]) VALUES (4, N'Oscar                                             ', N'Guiterez                                          ', N'Renteria                                          ', N'OsGu@icsm.org                                     ', NULL)
INSERT [dbo].[Profesores] ([IdProf], [Nombre], [PrimerApellido], [SegundoApellido], [Correo], [Foto]) VALUES (5, N'Miriam                                            ', N'Perez                                             ', N'Reyes                                             ', N'MiPe@icsm.org                                     ', NULL)
ALTER TABLE [dbo].[IntermedioI]  WITH CHECK ADD  CONSTRAINT [FK_IntermedioI_IntermedioI] FOREIGN KEY([Folio])
REFERENCES [dbo].[IntermedioI] ([Folio])
GO
ALTER TABLE [dbo].[IntermedioI] CHECK CONSTRAINT [FK_IntermedioI_IntermedioI]
GO
USE [master]
GO
ALTER DATABASE [AlumnosDB] SET  READ_WRITE 
GO
