SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE
  
   
 PROC [dbo].[pGetForSendSOAPPlan_YesterdayAppointment]  
AS  
  BEGIN  
      DECLARE @Date DateTime = GETDATE();  
  
      SET @Date = DATEADD(DAY, -1, @Date)  
  
      exec pGetSendSOAPPlan  
        @Date,  
        0, ''  
  END  
  
GO
