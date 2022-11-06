SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     
 PROC [dbo].[pGetClientMobileNumberByCompany](@Guid_Company varchar(MAX))
AS
  BEGIN
      DECLARE @name VARCHAR(MAX)
      DECLARE @dateStart DateTime
      DECLARE @dateEnd DateTime
      DECLARE @table TABLE
        (
           Name_Company  VARCHAR(MAX),
           ContactNumber VARCHAR(MAX),
           DatabaseName  VARCHAR(MAX)
        )
      DECLARE db_cursorppGetCompanyActive_VetCloudv3 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  ( name LIKE 'db_vetcloudv3_%' )

      OPEN db_cursorppGetCompanyActive_VetCloudv3

      FETCH NEXT FROM db_cursorppGetCompanyActive_VetCloudv3 INTO @name

      WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @dateStart = GETDATE();

            BEGIN TRY
                INSERT @table
                exec( 'select Name_Company, ContactNumber, DB_NAME() DatabaseName FROM dbo.fGetClientMobileNumberByCompany('''+ @Guid_Company +''')')

                SET @dateEnd = GETDATE();
            END TRY
            BEGIN CATCH
                DECLARE @msg VARCHAR(MAX) = ERROR_MESSAGE()
                SET @dateEnd = GETDATE();
                SELECT @msg
            END CATCH

            FETCH NEXT FROM db_cursorppGetCompanyActive_VetCloudv3 INTO @name
        END

      CLOSE db_cursorppGetCompanyActive_VetCloudv3

      DEALLOCATE db_cursorppGetCompanyActive_VetCloudv3

      SELECT DISTINCT *
      FROM   @table
      Order  by Name_Company,
                ContactNumber
  END

GO
