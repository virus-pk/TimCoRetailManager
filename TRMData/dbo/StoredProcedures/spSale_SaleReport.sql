CREATE PROCEDURE [dbo].[spSale_SaleReport]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT	[s].[SaleDate], [s].[SubTotal], [s].[Tax], [s].[Total],
			[u].[FirstName], [u].[LastName], [u].[EmailAddress]
	FROM dbo.Sale s
	INNER JOIN dbo.[User] u ON s.CashierId = u.Id;
END
