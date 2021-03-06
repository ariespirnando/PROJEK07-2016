USE [master]
GO
/****** Object:  Database [MI_TA2016]    Script Date: 08/03/2016 02:02:34 ******/
CREATE DATABASE [MI_TA2016] ON  PRIMARY 
( NAME = N'MI_TA2016', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\MI_TA2016.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MI_TA2016_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\MI_TA2016_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MI_TA2016] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MI_TA2016].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MI_TA2016] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MI_TA2016] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MI_TA2016] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MI_TA2016] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MI_TA2016] SET ARITHABORT OFF
GO
ALTER DATABASE [MI_TA2016] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [MI_TA2016] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MI_TA2016] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MI_TA2016] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MI_TA2016] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MI_TA2016] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MI_TA2016] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MI_TA2016] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MI_TA2016] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MI_TA2016] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MI_TA2016] SET  DISABLE_BROKER
GO
ALTER DATABASE [MI_TA2016] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MI_TA2016] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MI_TA2016] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MI_TA2016] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MI_TA2016] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MI_TA2016] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MI_TA2016] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MI_TA2016] SET  READ_WRITE
GO
ALTER DATABASE [MI_TA2016] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MI_TA2016] SET  MULTI_USER
GO
ALTER DATABASE [MI_TA2016] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MI_TA2016] SET DB_CHAINING OFF
GO
USE [MI_TA2016]
GO
/****** Object:  Table [dbo].[tbl_Karyawan]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Karyawan](
	[no_Karyawan] [char](3) NOT NULL,
	[nama_Karyawan] [varchar](30) NULL,
	[Jabatan] [varchar](12) NULL,
	[alamat_Rumah] [text] NULL,
	[no_Handphone] [varchar](16) NULL,
 CONSTRAINT [PK_tbl_Karyawan] PRIMARY KEY CLUSTERED 
(
	[no_Karyawan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Gaji]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Gaji](
	[idGaji] [int] NOT NULL,
	[Jabatan] [varchar](12) NULL,
	[UpahperHari] [float] NULL,
	[BPJSperusahaan] [float] NULL,
	[BPJSpegawai] [float] NULL,
	[lemburLibur] [float] NULL,
	[lemburBiasa] [float] NULL,
 CONSTRAINT [PK_tbl_Gaji] PRIMARY KEY CLUSTERED 
(
	[idGaji] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[Username] [varchar](15) NULL,
	[Password] [varchar](15) NULL,
	[Email] [varchar](30) NULL,
	[id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Penggajian]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Penggajian](
	[kodTransaksi] [char](16) NOT NULL,
	[Tanggaltransaksi] [date] NULL,
	[no_Karyawan] [char](3) NULL,
	[idGaji] [int] NULL,
	[jumlahHadir] [int] NULL,
	[jumlahLemburBiasa] [int] NULL,
	[jumlahLemburLibur] [int] NULL,
	[TotalLemburBiasa] [float] NULL,
	[TotalLemburLibur] [float] NULL,
	[TotalLembur] [float] NULL,
	[jumlahperBulan] [float] NULL,
	[jumlahGajiKotor] [float] NULL,
	[jumlahPotongan] [float] NULL,
	[jumlahGajiBersih] [float] NULL,
 CONSTRAINT [PK_tbl_Penggajian] PRIMARY KEY CLUSTERED 
(
	[kodTransaksi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_TransaksiGaji]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_TransaksiGaji]
AS
SELECT     dbo.tbl_Penggajian.kodTransaksi, dbo.tbl_Penggajian.Tanggaltransaksi, dbo.tbl_Karyawan.nama_Karyawan, dbo.tbl_Karyawan.Jabatan, 
                      dbo.tbl_Penggajian.jumlahGajiKotor, dbo.tbl_Penggajian.jumlahPotongan, dbo.tbl_Penggajian.jumlahGajiBersih, dbo.tbl_Karyawan.no_Karyawan
FROM         dbo.tbl_Gaji INNER JOIN
                      dbo.tbl_Penggajian ON dbo.tbl_Gaji.idGaji = dbo.tbl_Penggajian.idGaji INNER JOIN
                      dbo.tbl_Karyawan ON dbo.tbl_Penggajian.no_Karyawan = dbo.tbl_Karyawan.no_Karyawan
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[38] 2[2] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Gaji"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Penggajian"
            Begin Extent = 
               Top = 6
               Left = 452
               Bottom = 125
               Right = 632
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "tbl_Karyawan"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 125
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TransaksiGaji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TransaksiGaji'
GO
/****** Object:  View [dbo].[View_Slip]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Slip]
AS
SELECT     dbo.tbl_Penggajian.kodTransaksi, dbo.tbl_Penggajian.Tanggaltransaksi, dbo.tbl_Karyawan.nama_Karyawan, dbo.tbl_Karyawan.Jabatan, 
                      dbo.tbl_Karyawan.alamat_Rumah, dbo.tbl_Karyawan.no_Handphone, dbo.tbl_Penggajian.jumlahHadir, dbo.tbl_Gaji.UpahperHari, dbo.tbl_Penggajian.jumlahperBulan, 
                      dbo.tbl_Penggajian.TotalLemburBiasa, dbo.tbl_Penggajian.TotalLemburLibur, dbo.tbl_Penggajian.TotalLembur, dbo.tbl_Gaji.BPJSperusahaan, 
                      dbo.tbl_Gaji.BPJSpegawai, dbo.tbl_Penggajian.jumlahPotongan, dbo.tbl_Penggajian.jumlahGajiBersih
FROM         dbo.tbl_Gaji INNER JOIN
                      dbo.tbl_Penggajian ON dbo.tbl_Gaji.idGaji = dbo.tbl_Penggajian.idGaji INNER JOIN
                      dbo.tbl_Karyawan ON dbo.tbl_Penggajian.no_Karyawan = dbo.tbl_Karyawan.no_Karyawan
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Gaji"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_Karyawan"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 125
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbl_Penggajian"
            Begin Extent = 
               Top = 6
               Left = 452
               Bottom = 125
               Right = 632
            End
            DisplayFlags = 280
            TopColumn = 10
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Slip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Slip'
GO
/****** Object:  View [dbo].[View_Rekapitulasi]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Rekapitulasi]
AS
SELECT     SUM(dbo.tbl_Penggajian.jumlahGajiKotor) AS Expr1, SUM(dbo.tbl_Penggajian.jumlahGajiBersih) AS Expr2, SUM(dbo.tbl_Gaji.BPJSperusahaan) AS Expr3
FROM         dbo.tbl_Gaji INNER JOIN
                      dbo.tbl_Penggajian ON dbo.tbl_Gaji.idGaji = dbo.tbl_Penggajian.idGaji
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Gaji"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Penggajian"
            Begin Extent = 
               Top = 6
               Left = 261
               Bottom = 125
               Right = 457
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Rekapitulasi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Rekapitulasi'
GO
/****** Object:  View [dbo].[View_Laporan]    Script Date: 08/03/2016 02:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Laporan]
AS
SELECT     dbo.tbl_Karyawan.nama_Karyawan, dbo.tbl_Penggajian.jumlahHadir, dbo.tbl_Gaji.UpahperHari, dbo.tbl_Penggajian.jumlahperBulan, dbo.tbl_Gaji.BPJSperusahaan, 
                      dbo.tbl_Penggajian.TotalLemburLibur, dbo.tbl_Penggajian.TotalLemburBiasa, dbo.tbl_Penggajian.TotalLembur, dbo.tbl_Penggajian.jumlahGajiKotor, 
                      dbo.tbl_Gaji.BPJSpegawai, dbo.tbl_Penggajian.jumlahPotongan, dbo.tbl_Penggajian.jumlahGajiBersih, dbo.tbl_Penggajian.Tanggaltransaksi, 
                      dbo.tbl_Karyawan.Jabatan
FROM         dbo.tbl_Gaji INNER JOIN
                      dbo.tbl_Penggajian ON dbo.tbl_Gaji.idGaji = dbo.tbl_Penggajian.idGaji INNER JOIN
                      dbo.tbl_Karyawan ON dbo.tbl_Penggajian.no_Karyawan = dbo.tbl_Karyawan.no_Karyawan
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Gaji"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_Penggajian"
            Begin Extent = 
               Top = 6
               Left = 452
               Bottom = 125
               Right = 632
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Karyawan"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 125
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Laporan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Laporan'
GO
/****** Object:  Default [DF_tbl_User_id]    Script Date: 08/03/2016 02:02:36 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_id]  DEFAULT ((1)) FOR [id]
GO
/****** Object:  ForeignKey [FK_tbl_Penggajian_tbl_Gaji]    Script Date: 08/03/2016 02:02:36 ******/
ALTER TABLE [dbo].[tbl_Penggajian]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Penggajian_tbl_Gaji] FOREIGN KEY([idGaji])
REFERENCES [dbo].[tbl_Gaji] ([idGaji])
GO
ALTER TABLE [dbo].[tbl_Penggajian] CHECK CONSTRAINT [FK_tbl_Penggajian_tbl_Gaji]
GO
/****** Object:  ForeignKey [FK_tbl_Penggajian_tbl_Karyawan]    Script Date: 08/03/2016 02:02:36 ******/
ALTER TABLE [dbo].[tbl_Penggajian]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Penggajian_tbl_Karyawan] FOREIGN KEY([no_Karyawan])
REFERENCES [dbo].[tbl_Karyawan] ([no_Karyawan])
GO
ALTER TABLE [dbo].[tbl_Penggajian] CHECK CONSTRAINT [FK_tbl_Penggajian_tbl_Karyawan]
GO
