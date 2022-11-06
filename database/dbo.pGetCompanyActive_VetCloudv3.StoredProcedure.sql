SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   
 PROC [dbo].[pGetCompanyActive_VetCloudv3]
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
      DECLARE db_cursorppGetCompanyActive_VetCloudv3 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  ( name LIKE 'db_vetcloudv3_server_'
                  OR name LIKE 'db_vetcloudv3_%' )

      OPEN db_cursorppGetCompanyActive_VetCloudv3

      FETCH NEXT FROM db_cursorppGetCompanyActive_VetCloudv3 INTO @name

      WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @dateStart = GETDATE();

            BEGIN TRY
                INSERT @table
                exec( '
				SELECt _soap.ID   ID_CurrentObject,
					   _soap.Code Code_CurrentObject,
					   FORMAT(Convert(int, labImage.ImageNo), ''''D6'''', ''''en-us'''') ImageID,
					   filePath SourceImage, ''''MedicalRecord\\'''' + _soap.Code + ''''\\'''' + ''''LaboratoryImages-'''' +  FORMAT(Convert(int, labImage.ImageNo), ''''D6'''', ''''en-us'''') + RIGHT(FilePath, 4)
				FROM   '+ @name +'.dbo.tPatient_SOAP _soap
					   inner join '+ @name +'.dbo.vPatient_SOAP_LaboratoryImages labImage
							   on _soap.ID = labImage.ID_Patient_SOAP
					   INNER JOIN '+ @name +'.dbo.vCompanyActive _company
							   on _soap.ID_Company = _company.ID 
				WHERE ISNULL(FilePath, '') <> ''
				')

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
  END

SELECT DISTINCT *
FROM   @table
Order  by Name 
GO
