SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 PROC [dbo].[pGetSendSoapPlan](@DateSending     DATETIME,
                                    @IsSentSMS       BIT,
                                    @IDCompanyString VARCHAR(MAX))
AS
  BEGIN
      DECLARE @table TABLE
        (
           DatabaseName         VARCHAR(MAX),
           ID_Company           INT,
           Name_Company         VARCHAR(MAX),
           Name_Client          VARCHAR(MAX),
           ContactNumber_Client VARCHAR(MAX),
           DateReturn           DATETIME,
           Name_Item            VARCHAR(MAX),
           Comment              VARCHAR(MAX),
           Message              VARCHAR(MAX),
           DateSending          DATETIME,
           DateCreated          DATETIME,
           ID_Reference         INT,
           Oid_Model            VARCHAR(MAX),
           Code                 VARCHAR(MAX),
           Count                INT
        )
      DECLARE db_cursorpGetSendSoapPlan_VetCloudv3 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  ( name IN ( 'db_ProvincialVet_test' )
                  OR Name LIKE 'db_vetcloudv3_%' )
      DECLARE @name VARCHAR(MAX) = ''
      DECLARE @Sql VARCHAR(MAX) = ''

      OPEN db_cursorpGetSendSoapPlan_VetCloudv3

      FETCH NEXT FROM db_cursorpGetSendSoapPlan_VetCloudv3 INTO @name

      WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @Sql = 'SELECT ''' + @name
                       + ''' DatabaseName, * FROM ' + @name
                       + '.dbo.fGetSendSoapPlan('''
                       + FORMAT(@DateSending, 'yyyy-MM-dd')
                       + ' 00:00:00'', '
                       + CONVERT(VARCHAR(MAX), @IsSentSMS) + ', '''
                       + @IDCompanyString + ''')'

            print @sql

            INSERT @table
            EXEC (@Sql)

            FETCH NEXT FROM db_cursorpGetSendSoapPlan_VetCloudv3 INTO @name
        END

      CLOSE db_cursorpGetSendSoapPlan_VetCloudv3

      DEALLOCATE db_cursorpGetSendSoapPlan_VetCloudv3

      ----------------------------  
      SELECT '_',
             '' SummaryByDatabase,
             '' SummaryByCompany,
             '' Records

      Select Convert(bit, 1) Success

      SELECT DatabaseName,
             Count(*) SMSCount
      FROM   @table
      GROUP  BY DatabaseName
      ORDER  BY DatabaseName

      SELECT DatabaseName,
             Name_Company,
             Count(*) SMSCount
      FROM   @table
      GROUP  BY DatabaseName,
                Name_Company
      ORDER  BY DatabaseName,
                Name_Company

      SELECT hed.*,
             hed.DatabaseName + '##' + hed.Oid_Model + '##'
             + CONVERT(VARCHAR(MAX), hed.ID_Reference) UniqueID
      FROM   @table hed
      Order  by DatabaseName,
                Name_Company
  END

GO
