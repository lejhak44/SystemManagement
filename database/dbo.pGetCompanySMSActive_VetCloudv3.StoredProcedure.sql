SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE       
 PROC [dbo].[pGetCompanySMSActive_VetCloudv3]
AS
  BEGIN
      DECLARE @name VARCHAR(MAX) -- database name     
      DECLARE @dateStart DateTime
      DECLARE @dateEnd DateTime
      DECLARE @table TABLE
        (
           ID           INT,
           Name         VARCHAR(MAX),
           IsActive     BIT,
           DateCreated  DateTime,
           Guid         VARCHAR(MAX),
           DatabaseName VARCHAR(MAX)
        )
      DECLARE db_cursorppGetCompanySMSActive_VetCloudv3 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  ( name LIKE 'db_vetcloudv3_server_'
                  OR name LIKE 'db_vetcloudv3_%' )

      OPEN db_cursorppGetCompanySMSActive_VetCloudv3

      FETCH NEXT FROM db_cursorppGetCompanySMSActive_VetCloudv3 INTO @name

      WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @dateStart = GETDATE();

            BEGIN TRY
                INSERT @table
                exec( 'SELECT c.ID, c.Name, s.IsActive, s.DateCreated, c.GUID, '''+ @name +''' DatabaseName FROM ' + @name +'.dbo.vCompanyActive c inner join ' + @name +'.dbo.tCompany_SMSSetting s on c.ID = s.ID_Company')

                SET @dateEnd = GETDATE();
            END TRY
            BEGIN CATCH
                DECLARE @msg VARCHAR(MAX) = ERROR_MESSAGE()
                SET @dateEnd = GETDATE();
                SELECT @msg
            END CATCH

            FETCH NEXT FROM db_cursorppGetCompanySMSActive_VetCloudv3 INTO @name
        END

      CLOSE db_cursorppGetCompanySMSActive_VetCloudv3

      DEALLOCATE db_cursorppGetCompanySMSActive_VetCloudv3
  END

SELECT 'Company Active SMS' Label

SELECT DISTINCT *
FROM   @table
Order  by Name

GO
