CREATE PROCEDURE [dbo].[spProductGetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	FROM dbo.Product
	ORDER BY ProductName
END
