SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 PROC [dbo].[pGetDatabaseMemoryLogInformations]
AS
  BEGIN
      SELECT Comment,
             COUNT(*)         Count,
             Max(DateCreated) DateLatestCreatedLog
      FROM   _vDatabaseMemoryLog
      GROUP  BY Comment

      SELECT *
      FROm   _vDatabaseMemoryLog_Listview
      Order  by DateCreated DESC
  END 


GO
