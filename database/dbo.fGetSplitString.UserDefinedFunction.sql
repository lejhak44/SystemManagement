SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create 
 FUNCTION [dbo].[fGetSplitString](@string    VARCHAR(MAX),
                                       @delimiter VARCHAR(2))
RETURNS @table TABLE(
  ID   INT,
  Part varchar(MAX))
as
  BEGIN
      Declare @individual varchar(MAX) = ''
      DECLARE @identifier INT = 0

      WHILE LEN(@string) > 0
        BEGIN
            IF PATINDEX('%' + @delimiter + '%', @string) > 0
              BEGIN
                  SET @individual = SUBSTRING(@string, 0, PATINDEX('%' + @delimiter + '%', @string))
                  SET @identifier = @identifier + 1

                  INSERT @table
                         (iD,
                          Part)
                  VALUES (@identifier,
                          @individual -- Part - varchar(max)    
                  )

                  SET @string = SUBSTRING(@string, LEN(@individual + ''+ @delimiter +'') + 1, LEN(@string))
              END
            ELSE
              BEGIN
                  SET @individual = @string
                  SET @string = NULL
                  SET @identifier = @identifier + 1

                  INSERT @table
                         (iD,
                          Part)
                  VALUES (@identifier,
                          @individual -- Part - varchar(max)    
                  )
              END
        END

      RETURN
  end

GO
