Create store procedure 

//
CREATE PROCEDURE dbo.spPrizes_Insert ---
@PlaceNumber int,
@PlacName nvarchar(50), 
@PrizeAmount money,
@PrizePercentage float,
@id int =0 output  --- You don't have to pass the value in just need to output the value
AS
BEGIN
 
 Set NOCOUNT ON; 
 
INSERT into dbo.Prizes(PlaceNumber,PlacName,PrizeAmount,PrizePercentage)
values(@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage); 

select @id = SCOPE_IDENTITY(); ----the last id created for the table. What ever the value is in Id wil be capture in id.


END 
GO


drop procedure.dbo.spPrizes_Insert  ---- syntax to drop the store procedure

--New Query 
select * from  dbo.Prizes