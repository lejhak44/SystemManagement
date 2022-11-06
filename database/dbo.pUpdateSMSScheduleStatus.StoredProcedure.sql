SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE 
 PROC [dbo].[pUpdateSMSScheduleStatus](@UniqueID       VARCHAR(MAX),
                                    @iTextMo_Status INT)
AS
  BEGIN
      DECLARE @Success BIT = 1
      DECLARE @message VARCHAR(MAX)= ''
      DECLARE @databaseName VARCHAR(MAX)= ''
      DECLARE @Oid VARCHAR(MAX)= ''
      DECLARE @ID_Reference VARCHAR(MAX)= ''
      DECLARE @sql VARCHAR(MAX)= ''

      BEGIN TRY
          DECLARE @part TABLE
            (
               ID   INT,
               Part varchar(MAX)
            )

          INSERT @part
          SELECT *
          FROM   dbo.[fGetSplitString](@UniqueID, '##')

          SELECT @databaseName = Part
          FROM   @part
          WHERE  ID = 1

          SELECT @Oid = Part
          FROM   @part
          WHERE  ID = 2

          SELECT @ID_Reference = Part
          FROM   @part
          WHERE  ID = 3

          set @sql ='exec /*database*/.dbo.pNoteSOAPPlanAsSend /*ID_Reference*/, ''/*Oid_Model*/'', /*iTextMo_Status*/'
          set @sql = REPLACE(@sql, '/*database*/', @databaseName)
          set @sql = REPLACE(@sql, '/*ID_Reference*/', CONVERT(varchar(MAX), @ID_Reference))
          set @sql = REPLACE(@sql, '/*Oid_Model*/', CONVERT(varchar(MAX), @Oid))
          set @sql = REPLACE(@sql, '/*iTextMo_Status*/', CONVERT(varchar(MAX), @iTextMo_Status))

          select @sql

          exec (@sql)
      END TRY
      BEGIN CATCH
          SET @Success = 0
          SET @message = ERROR_MESSAGE()
          SELECT '_'
          SELECT @Success Success,
                 @message Message
      END CATCH
  END

GO
