SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 VIEW [dbo].[_vDatabaseMemoryLog_Listview]
AS
  SELECT ID,
         DateCreated,
         Name,
         DateStart,
         DateEnd,
         Seconds,
         Comment
  FROM   _vDatabaseMemoryLog

GO
