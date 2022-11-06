SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_tDatabaseMemoryLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [varchar](200) NULL,
	[IsActive] [bit] NULL,
	[ID_Company] [int] NULL,
	[Comment] [varchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[ID_CreatedBy] [int] NULL,
	[ID_LastModifiedBy] [int] NULL,
	[Size] [int] NULL,
	[SizeInMB] [int] NULL,
	[DateStart] [datetime] NULL,
	[DateEnd] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
