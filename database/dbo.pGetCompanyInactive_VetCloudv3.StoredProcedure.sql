SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create      
 PROC [dbo].[pGetCompanyInactive_VetCloudv3]
AS
  BEGIN
      DECLARE @name VARCHAR(50) -- database name   
      DECLARE @dateStart DateTime
      DECLARE @dateEnd DateTime
      DECLARE @table TABLE
        (
           ID           INT,
           Name         VARCHAR(MAX),
           IsActive     BIT,
		   DateCreated DateTime,
           Guid         VARCHAR(MAX),
           DatabaseName VARCHAR(MAX)
        )
      DECLARE db_cursorppGetCompanyInactive_VetCloudv3 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  ( name LIKE 'db_vetcloudv3_server_'
                  OR name LIKE 'db_vetcloudv3_%' )

      OPEN db_cursorppGetCompanyInactive_VetCloudv3

      FETCH NEXT FROM db_cursorppGetCompanyInactive_VetCloudv3 INTO @name

      WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @dateStart = GETDATE();

            BEGIN TRY
                INSERT @table
                exec( 'SELECT ID, Name, IsActive, DateCreated, GUID, '''+ @name +''' DatabaseName FROM ' + @name +'.dbo.vCompanyInactive')

                SET @dateEnd = GETDATE();
            END TRY
            BEGIN CATCH
                DECLARE @msg VARCHAR(MAX) = ERROR_MESSAGE()
                SET @dateEnd = GETDATE();
                SELECT @msg
            END CATCH

            FETCH NEXT FROM db_cursorppGetCompanyInactive_VetCloudv3 INTO @name
        END

      CLOSE db_cursorppGetCompanyInactive_VetCloudv3

      DEALLOCATE db_cursorppGetCompanyInactive_VetCloudv3
  END

SELECT DISTINCT *
FROM   @table Order by Name
GO
