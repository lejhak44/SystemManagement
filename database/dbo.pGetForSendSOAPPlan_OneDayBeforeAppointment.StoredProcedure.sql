SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
CREATE   
 PROC [dbo].[pGetForSendSOAPPlan_OneDayBeforeAppointment]  
AS  
  BEGIN  
      DECLARE @DateSending DateTime = GETDATE();  
  
      SET @DateSending = DATEADD(DAY, 0, @DateSending)  
  
      exec pGetSendSOAPPlan  
        @DateSending,  
        0  , ''
  END  
  
GO
