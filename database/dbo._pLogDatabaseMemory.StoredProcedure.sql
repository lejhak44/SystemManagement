SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 PROC [dbo].[_pLogDatabaseMemory](@databaseName VARCHAR(MAX),
                               @dateStart    DATETIME,
                               @dateEnd      DATETIME,
                               @comment      VARCHAR(MAX))
as
    Declare @dbMemory Table
      (
         DatabaseName Varchar(MAX),
         Size         Int,
         SizeInMB     int
      )

    Insert @dbMemory
    SELECT sys.databases.name,
           SUM(size),
           SUM(size) * 8 / 102
    FROM   sys.databases
           JOIN sys.master_files
             ON sys.databases.database_id = sys.master_files.database_id
    WHERE  sys.databases.name = @databaseName
    GROUP  BY sys.databases.name
    ORDER  BY sys.databases.name

    INSERT INTO [dbo].[_tDatabaseMemoryLog]
                ([Name],
                 [Size],
                 [SizeInMB],
                 DateStart,
                 DateEnd,
                 [DateCreated],
                 [IsActive],
                 [Code],
                 [ID_Company],
                 [Comment],
                 [ID_CreatedBy],
                 [ID_LastModifiedBy])
    SELECT DatabaseName,
           Size,
           SizeInMB,
           @dateStart,
           @dateEnd,
           GETDATE(),
           1,
           NULL,
           1,
           @comment,
           1,
           1
    FROM   @dbMemory

GO
