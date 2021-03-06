USE [master]
GO
/****** Object:  Database [diplomski]    Script Date: 11/4/2020 2:56:26 PM ******/
CREATE DATABASE [diplomski]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'diplomski', FILENAME = N'C:\Users\draga\diplomski.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'diplomski_log', FILENAME = N'C:\Users\draga\diplomski_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [diplomski] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [diplomski].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [diplomski] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [diplomski] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [diplomski] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [diplomski] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [diplomski] SET ARITHABORT OFF 
GO
ALTER DATABASE [diplomski] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [diplomski] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [diplomski] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [diplomski] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [diplomski] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [diplomski] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [diplomski] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [diplomski] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [diplomski] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [diplomski] SET  DISABLE_BROKER 
GO
ALTER DATABASE [diplomski] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [diplomski] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [diplomski] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [diplomski] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [diplomski] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [diplomski] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [diplomski] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [diplomski] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [diplomski] SET  MULTI_USER 
GO
ALTER DATABASE [diplomski] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [diplomski] SET DB_CHAINING OFF 
GO
ALTER DATABASE [diplomski] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [diplomski] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [diplomski] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [diplomski] SET QUERY_STORE = OFF
GO
USE [diplomski]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [diplomski]
GO
/****** Object:  Table [dbo].[Jezik]    Script Date: 11/4/2020 2:56:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jezik](
	[IDJezik] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
 CONSTRAINT [PK_Jezik] PRIMARY KEY CLUSTERED 
(
	[IDJezik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[IDKurs] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
	[DatumOd] [date] NULL,
	[DatumDo] [date] NULL,
	[Aktivan] [int] NULL,
	[IDNivo] [int] NULL,
	[Cena] [numeric](18, 0) NULL,
	[IDProfesor] [int] NULL,
 CONSTRAINT [PK_Kurs] PRIMARY KEY CLUSTERED 
(
	[IDKurs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nivo]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nivo](
	[IDNivo] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
	[IDJezik] [int] NULL,
 CONSTRAINT [PK_Nivo] PRIMARY KEY CLUSTERED 
(
	[IDNivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pohadjanje]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pohadjanje](
	[IDPohadjanje] [int] NOT NULL,
	[IDUcenik] [int] NULL,
	[IDKurs] [int] NULL,
	[DatumUpisa] [date] NULL,
 CONSTRAINT [PK_Pohadjanje] PRIMARY KEY CLUSTERED 
(
	[IDPohadjanje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prisustvo]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prisustvo](
	[IDPrisustvo] [int] NOT NULL,
	[IDTermin] [int] NULL,
	[IDUcenik] [int] NULL,
	[IDKurs] [int] NULL,
 CONSTRAINT [PK_Prisustvo] PRIMARY KEY CLUSTERED 
(
	[IDPrisustvo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[IDProfesor] [int] NOT NULL,
	[ImePrezime] [varchar](50) NULL,
	[JMBG] [varchar](50) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[IDProfesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[IDRadnik] [int] NOT NULL,
	[ImePrezime] [varchar](50) NULL,
	[Lozinka] [varchar](50) NULL,
	[KorisnickoIme] [varchar](50) NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[IDRadnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sertifikat]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sertifikat](
	[IDSertifikat] [int] NOT NULL,
	[Naziv] [varchar](50) NULL,
	[IDJezik] [int] NULL,
	[IDProfesor] [int] NULL,
 CONSTRAINT [PK_Sertifikat] PRIMARY KEY CLUSTERED 
(
	[IDSertifikat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Termin]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Termin](
	[IDTermin] [int] NOT NULL,
	[IDKurs] [int] NOT NULL,
	[Datum] [date] NULL,
 CONSTRAINT [PK_Termin] PRIMARY KEY CLUSTERED 
(
	[IDTermin] ASC,
	[IDKurs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucenik]    Script Date: 11/4/2020 2:56:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucenik](
	[IDUcenik] [int] NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[JMBG] [varchar](50) NULL,
	[DatumRodjenja] [date] NULL,
	[BrojTelefona] [varchar](50) NULL,
	[Adresa] [varchar](50) NULL,
 CONSTRAINT [PK_Ucenik] PRIMARY KEY CLUSTERED 
(
	[IDUcenik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Jezik] ([IDJezik], [Naziv]) VALUES (1, N'Engleski')
INSERT [dbo].[Jezik] ([IDJezik], [Naziv]) VALUES (2, N'Nemacki')
INSERT [dbo].[Jezik] ([IDJezik], [Naziv]) VALUES (3, N'Italijanski')
INSERT [dbo].[Jezik] ([IDJezik], [Naziv]) VALUES (4, N'Ruski')
INSERT [dbo].[Jezik] ([IDJezik], [Naziv]) VALUES (5, N'Francuski')
INSERT [dbo].[Kurs] ([IDKurs], [Naziv], [DatumOd], [DatumDo], [Aktivan], [IDNivo], [Cena], [IDProfesor]) VALUES (1, N'Eng A2 sep-dec', CAST(N'2020-09-01' AS Date), CAST(N'2020-12-30' AS Date), 0, 2, CAST(30000 AS Numeric(18, 0)), 1)
INSERT [dbo].[Kurs] ([IDKurs], [Naziv], [DatumOd], [DatumDo], [Aktivan], [IDNivo], [Cena], [IDProfesor]) VALUES (2, N'Eng A2 okt-dec', CAST(N'2020-10-10' AS Date), CAST(N'2020-12-12' AS Date), 0, 2, NULL, 1)
INSERT [dbo].[Kurs] ([IDKurs], [Naziv], [DatumOd], [DatumDo], [Aktivan], [IDNivo], [Cena], [IDProfesor]) VALUES (3, N'Nem A1 jan-dec', CAST(N'2021-01-10' AS Date), CAST(N'2021-12-10' AS Date), 0, 3, NULL, 2)
INSERT [dbo].[Nivo] ([IDNivo], [Naziv], [IDJezik]) VALUES (1, N'End A1', 1)
INSERT [dbo].[Nivo] ([IDNivo], [Naziv], [IDJezik]) VALUES (2, N'Eng A2', 1)
INSERT [dbo].[Nivo] ([IDNivo], [Naziv], [IDJezik]) VALUES (3, N'Nem A1', 2)
INSERT [dbo].[Nivo] ([IDNivo], [Naziv], [IDJezik]) VALUES (4, N'Franc A1', 5)
INSERT [dbo].[Nivo] ([IDNivo], [Naziv], [IDJezik]) VALUES (5, N'Rus A2', 4)
INSERT [dbo].[Pohadjanje] ([IDPohadjanje], [IDUcenik], [IDKurs], [DatumUpisa]) VALUES (1, 1, 1, CAST(N'2020-08-20' AS Date))
INSERT [dbo].[Pohadjanje] ([IDPohadjanje], [IDUcenik], [IDKurs], [DatumUpisa]) VALUES (2, 2, 1, CAST(N'2020-08-20' AS Date))
INSERT [dbo].[Pohadjanje] ([IDPohadjanje], [IDUcenik], [IDKurs], [DatumUpisa]) VALUES (3, NULL, NULL, NULL)
INSERT [dbo].[Pohadjanje] ([IDPohadjanje], [IDUcenik], [IDKurs], [DatumUpisa]) VALUES (4, 3, 3, CAST(N'2020-10-01' AS Date))
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (4, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (5, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (8, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (11, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (12, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (13, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (17, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (19, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (20, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (21, 1, 3, 3)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (22, 2, 1, 1)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (23, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (24, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (26, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (27, 3, 1, 1)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (29, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (30, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (33, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (34, NULL, NULL, NULL)
INSERT [dbo].[Prisustvo] ([IDPrisustvo], [IDTermin], [IDUcenik], [IDKurs]) VALUES (36, 1, 1, 1)
INSERT [dbo].[Profesor] ([IDProfesor], [ImePrezime], [JMBG]) VALUES (1, N'Srna Brkic', N'52820207209')
INSERT [dbo].[Profesor] ([IDProfesor], [ImePrezime], [JMBG]) VALUES (2, N'Milos Simic', N'91369137513')
INSERT [dbo].[Radnik] ([IDRadnik], [ImePrezime], [Lozinka], [KorisnickoIme]) VALUES (1, N'Pera Peric', N'Pera', N'Pera')
INSERT [dbo].[Sertifikat] ([IDSertifikat], [Naziv], [IDJezik], [IDProfesor]) VALUES (1, N'Sert 1', 1, 1)
INSERT [dbo].[Sertifikat] ([IDSertifikat], [Naziv], [IDJezik], [IDProfesor]) VALUES (2, N'Sert 2', 2, 2)
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (1, 1, CAST(N'2020-09-01' AS Date))
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (1, 2, CAST(N'2020-10-10' AS Date))
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (1, 3, CAST(N'2021-01-10' AS Date))
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (2, 1, CAST(N'2020-09-12' AS Date))
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (2, 2, CAST(N'2020-10-12' AS Date))
INSERT [dbo].[Termin] ([IDTermin], [IDKurs], [Datum]) VALUES (3, 1, CAST(N'2020-09-07' AS Date))
INSERT [dbo].[Ucenik] ([IDUcenik], [Ime], [Prezime], [JMBG], [DatumRodjenja], [BrojTelefona], [Adresa]) VALUES (1, N'Dragana', N'Vincic', N'047509300', CAST(N'1996-12-30' AS Date), N'0645536672', N'Simiceva 3a')
INSERT [dbo].[Ucenik] ([IDUcenik], [Ime], [Prezime], [JMBG], [DatumRodjenja], [BrojTelefona], [Adresa]) VALUES (2, N'Mirjana', N'Nikolic', N'943043049', CAST(N'1990-12-22' AS Date), N'0656018534', N'Antifasisticke borbe 4')
INSERT [dbo].[Ucenik] ([IDUcenik], [Ime], [Prezime], [JMBG], [DatumRodjenja], [BrojTelefona], [Adresa]) VALUES (3, N'Milos', N'Panzalovic', N'20583743', CAST(N'2000-04-24' AS Date), N'0657893378', N'Simiceva 3')
INSERT [dbo].[Ucenik] ([IDUcenik], [Ime], [Prezime], [JMBG], [DatumRodjenja], [BrojTelefona], [Adresa]) VALUES (4, N'Gordana', N'Gojic', N'92759250', CAST(N'1987-07-25' AS Date), N'0653456672', N'Gandijeva 5')
INSERT [dbo].[Ucenik] ([IDUcenik], [Ime], [Prezime], [JMBG], [DatumRodjenja], [BrojTelefona], [Adresa]) VALUES (5, N'', N'', N'', CAST(N'1900-01-01' AS Date), N'1/1/0001 12:00:00 AM', N'')
ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_Nivo] FOREIGN KEY([IDNivo])
REFERENCES [dbo].[Nivo] ([IDNivo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_Nivo]
GO
ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_Profesor] FOREIGN KEY([IDProfesor])
REFERENCES [dbo].[Profesor] ([IDProfesor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_Profesor]
GO
ALTER TABLE [dbo].[Nivo]  WITH CHECK ADD  CONSTRAINT [FK_Nivo_Jezik] FOREIGN KEY([IDJezik])
REFERENCES [dbo].[Jezik] ([IDJezik])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Nivo] CHECK CONSTRAINT [FK_Nivo_Jezik]
GO
ALTER TABLE [dbo].[Pohadjanje]  WITH CHECK ADD  CONSTRAINT [FK_Pohadjanje_Kurs] FOREIGN KEY([IDKurs])
REFERENCES [dbo].[Kurs] ([IDKurs])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pohadjanje] CHECK CONSTRAINT [FK_Pohadjanje_Kurs]
GO
ALTER TABLE [dbo].[Pohadjanje]  WITH CHECK ADD  CONSTRAINT [FK_Pohadjanje_Ucenik] FOREIGN KEY([IDUcenik])
REFERENCES [dbo].[Ucenik] ([IDUcenik])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pohadjanje] CHECK CONSTRAINT [FK_Pohadjanje_Ucenik]
GO
ALTER TABLE [dbo].[Prisustvo]  WITH CHECK ADD  CONSTRAINT [FK_Prisustvo_Termin] FOREIGN KEY([IDTermin], [IDKurs])
REFERENCES [dbo].[Termin] ([IDTermin], [IDKurs])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Prisustvo] CHECK CONSTRAINT [FK_Prisustvo_Termin]
GO
ALTER TABLE [dbo].[Prisustvo]  WITH CHECK ADD  CONSTRAINT [FK_Prisustvo_Ucenik] FOREIGN KEY([IDUcenik])
REFERENCES [dbo].[Ucenik] ([IDUcenik])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Prisustvo] CHECK CONSTRAINT [FK_Prisustvo_Ucenik]
GO
ALTER TABLE [dbo].[Sertifikat]  WITH CHECK ADD  CONSTRAINT [FK_Sertifikat_Jezik] FOREIGN KEY([IDJezik])
REFERENCES [dbo].[Jezik] ([IDJezik])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sertifikat] CHECK CONSTRAINT [FK_Sertifikat_Jezik]
GO
ALTER TABLE [dbo].[Sertifikat]  WITH CHECK ADD  CONSTRAINT [FK_Sertifikat_Profesor] FOREIGN KEY([IDProfesor])
REFERENCES [dbo].[Profesor] ([IDProfesor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sertifikat] CHECK CONSTRAINT [FK_Sertifikat_Profesor]
GO
ALTER TABLE [dbo].[Termin]  WITH CHECK ADD  CONSTRAINT [FK_Termin_Kurs] FOREIGN KEY([IDKurs])
REFERENCES [dbo].[Kurs] ([IDKurs])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Termin] CHECK CONSTRAINT [FK_Termin_Kurs]
GO
USE [master]
GO
ALTER DATABASE [diplomski] SET  READ_WRITE 
GO
