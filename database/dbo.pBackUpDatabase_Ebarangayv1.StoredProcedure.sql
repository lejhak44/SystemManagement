SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 PROC [dbo].[pBackUpDatabase_Ebarangayv1]
AS
  BEGIN
      DECLARE @name VARCHAR(50) -- database name 
      DECLARE @dateStart DateTime
      DECLARE @dateEnd DateTime
      DECLARE db_cursorpBackUpDatabase_Ebarangayv1 CURSOR FOR
        SELECT name
        FROM   MASTER.dbo.sysdatabases
        WHERE  name LIKE 'db_ebarangayv1_%'

      OPEN db_cursorpBackUpDatabase_Ebarangayv1

      FETCH NEXT FROM db_cursorpBackUpDatabase_Ebarangayv1 INTO @name

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

            FETCH NEXT FROM db_cursorpBackUpDatabase_Ebarangayv1 INTO @name
        END

      CLOSE db_cursorpBackUpDatabase_Ebarangayv1

      DEALLOCATE db_cursorpBackUpDatabase_Ebarangayv1
  END

GO
