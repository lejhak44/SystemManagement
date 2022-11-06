SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 VIEW [dbo].[_vDatabaseMemoryLog]
AS
  SELECT *,
         DATEDIFF(SS, DateStart, Dateend) Seconds
  FROM   [_tDatabaseMemoryLog]

GO
