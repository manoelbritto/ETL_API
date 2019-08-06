USE master
GO

CREATE DATABASE DBCRIME
GO 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Homicide](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Event_Unique_ID] [varchar](50) NOT NULL,
	[Occurrence_year] [varchar](50) NULL,
	[Division] [varchar](50) NULL,
	[Homicide_Type] [varchar](40) NULL,
	[Occurrence_Date] [varchar](50) NULL,
	[Hood_ID] [varchar](50) NULL,
	[Neighbourhood] [varchar](100) NULL,
	[Lat] [varchar](50) NULL,
	[Long] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Country] [varchar](80) NULL,
 CONSTRAINT [PK_Homicide] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
