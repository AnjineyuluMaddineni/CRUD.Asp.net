USE [chandu]
GO

/****** Object:  Table [dbo].[EmployeeList]    Script Date: 3/24/2019 11:24:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeList](
	[EmpID] [nvarchar](50) NULL,
	[EmpName] [varchar](50) NULL,
	[EmpAge] [int] NULL
) ON [PRIMARY]
GO