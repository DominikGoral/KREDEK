USE [master]
GO
/****** Object:  Database [DominikGoralLab3Zadanie1_2]    Script Date: 30.11.2018 17:00:19 ******/
CREATE DATABASE [DominikGoralLab3Zadanie1_2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DominikGoralLab3Zadanie1_2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DominikGoralLab3Zadanie1_2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DominikGoralLab3Zadanie1_2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DominikGoralLab3Zadanie1_2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DominikGoralLab3Zadanie1_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET RECOVERY FULL 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET  MULTI_USER 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DominikGoralLab3Zadanie1_2', N'ON'
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET QUERY_STORE = OFF
GO
USE [DominikGoralLab3Zadanie1_2]
GO
/****** Object:  Table [dbo].[Contestants]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contestants](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[Surname] [nvarchar](255) NULL,
	[Age] [int] NULL,
	[Position] [nvarchar](255) NULL,
	[TeamID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContestantsResult]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContestantsResult](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MatchID] [int] NULL,
	[ContestantID] [int] NULL,
	[FirstHeat] [int] NULL,
	[SecondHeat] [int] NULL,
	[ThirdHeat] [int] NULL,
	[FourthHeat] [int] NULL,
	[FifthHeat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[League]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[League](
	[Tier] [int] IDENTITY(1,1) NOT NULL,
	[LeagueName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Tier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matches]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matches](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstTeamID] [int] NULL,
	[SecondTeamID] [int] NULL,
	[Result] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supporters]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supporters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[FirstName] [nvarchar](255) NULL,
	[Surname] [nvarchar](255) NULL,
	[FavouriteTeam] [nvarchar](255) NULL,
	[FavouriteContestant] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 30.11.2018 17:00:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LeagueTier] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[ManagerName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contestants] ON 

INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (3, N'Bartosz', N'Zmarzlik', 23, N'senior', 2)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (4, N'Patryk', N'Dudek', 26, N'senior', 3)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (5, N'Maciej', N'Janowski', 26, N'senior', 4)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (6, N'Piotr', N'Pawlicki', 24, N'senior', 5)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (7, N'Bartosz', N'Smektała', 20, N'junior', 5)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (8, N'Karol', N'Jaskółka', 43, N'Senior', 6)
INSERT [dbo].[Contestants] ([ID], [FirstName], [Surname], [Age], [Position], [TeamID]) VALUES (9, N'Noriaki', N'Kasai', 46, N'Senior', 6)
SET IDENTITY_INSERT [dbo].[Contestants] OFF
SET IDENTITY_INSERT [dbo].[ContestantsResult] ON 

INSERT [dbo].[ContestantsResult] ([ID], [MatchID], [ContestantID], [FirstHeat], [SecondHeat], [ThirdHeat], [FourthHeat], [FifthHeat]) VALUES (2, 1, 3, 2, 3, 3, 3, 3)
SET IDENTITY_INSERT [dbo].[ContestantsResult] OFF
SET IDENTITY_INSERT [dbo].[League] ON 

INSERT [dbo].[League] ([Tier], [LeagueName]) VALUES (1, N'PGE Ekstraliga')
INSERT [dbo].[League] ([Tier], [LeagueName]) VALUES (2, N'Nice 1. liga żużlowa')
INSERT [dbo].[League] ([Tier], [LeagueName]) VALUES (3, N'Druga liga żużlowa')
SET IDENTITY_INSERT [dbo].[League] OFF
SET IDENTITY_INSERT [dbo].[Matches] ON 

INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (1, 2, 4, N'45-45')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (4, 8, 5, N'48-42')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (6, 7, 10, N'46-44')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (7, 2, 3, N'55-35')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (8, 4, 8, N'46-44')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (9, 5, 9, N'47-43')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (10, 7, 3, N'48-42')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (11, 4, 5, N'45-45')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (12, 4, 6, N'45-45')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (13, 3, 5, N'45-45')
INSERT [dbo].[Matches] ([ID], [FirstTeamID], [SecondTeamID], [Result]) VALUES (14, 6, 8, N'45-45')
SET IDENTITY_INSERT [dbo].[Matches] OFF
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (2, 1, N'Stal Gorzów', N'Stanisław Chomski')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (3, 1, N'Falubaz Zielona Góra', N'Adam Skórnicki')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (4, 1, N'Sparta Wrocław', N'Dariusz Śledź')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (5, 1, N'Unia Leszno', N'Piotr Baron')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (6, 1, N'Apator Toruń', N'Jacek Frątczak')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (7, 1, N'Włókniarz Częstochowa', N'Marek Cieślak')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (8, 1, N'Motor Lublin', N'')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (9, 1, N'GKM Grudziądz', N'Robert Kempiński')
INSERT [dbo].[Teams] ([ID], [LeagueTier], [Name], [ManagerName]) VALUES (10, 2, N'Unia Tarnów', N'Stanisław Chomski')
SET IDENTITY_INSERT [dbo].[Teams] OFF
ALTER TABLE [dbo].[Contestants]  WITH CHECK ADD FOREIGN KEY([TeamID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[ContestantsResult]  WITH CHECK ADD FOREIGN KEY([ContestantID])
REFERENCES [dbo].[Contestants] ([ID])
GO
ALTER TABLE [dbo].[ContestantsResult]  WITH CHECK ADD FOREIGN KEY([MatchID])
REFERENCES [dbo].[Matches] ([ID])
GO
ALTER TABLE [dbo].[Matches]  WITH CHECK ADD FOREIGN KEY([FirstTeamID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[Matches]  WITH CHECK ADD FOREIGN KEY([SecondTeamID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[Teams]  WITH CHECK ADD FOREIGN KEY([LeagueTier])
REFERENCES [dbo].[League] ([Tier])
GO
USE [master]
GO
ALTER DATABASE [DominikGoralLab3Zadanie1_2] SET  READ_WRITE 
GO
