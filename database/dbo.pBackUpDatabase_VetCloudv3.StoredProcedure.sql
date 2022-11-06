SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE         
 PROC [dbo].[pBackUpDatabase_VetCloudv3]      
AS      
  BEGIN      
      DECLARE @name VARCHAR(50) -- database name       
      DECLARE @dateStart DateTime      
      DECLARE @dateEnd DateTime      
      DECLARE db_cursorpBackUpDatabase_VetCloudv3 CURSOR FOR      
        SELECT name      
        FROM   MASTER.dbo.sysdatabases      
        WHERE  ( name LIKE 'db_vetcloudv3_%' OR Name = 'db_ProvincialVet_test')      Order by crdate
      
      OPEN db_cursorpBackUpDatabase_VetCloudv3      
      
      FETCH NEXT FROM db_cursorpBackUpDatabase_VetCloudv3 INTO @name      
      
      WHILE @@FETCH_STATUS = 0      
        BEGIN      
            SET @dateStart = GETDATE();      
      
            BEGIN TRY      
                exec( @name +'.dbo._pBackUpDatabase')      
      
                SET @dateEnd = GETDATE();      
      
                exec _pLogDatabaseMemory      
                  @name,      
                  @dateStart,      
                  @dateEnd,      
                  'Back up Success'      
            END TRY      
            BEGIN CATCH      
                DECLARE @msg VARCHAR(MAX) = ERROR_MESSAGE()      
                SET @dateEnd = GETDATE();      
                exec _pLogDatabaseMemory      
                  @name,      
                  @dateStart,      
                  @dateEnd,      
                  @msg      
            END CATCH      
      
            FETCH NEXT FROM db_cursorpBackUpDatabase_VetCloudv3 INTO @name      
        END      
      
      CLOSE db_cursorpBackUpDatabase_VetCloudv3      
      
      DEALLOCATE db_cursorpBackUpDatabase_VetCloudv3      
  END 
GO
