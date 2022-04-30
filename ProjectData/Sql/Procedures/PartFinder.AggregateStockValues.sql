CREATE OR ALTER PROCEDURE PartFinder.AggregateStockValues
	@Value DECIMAL(5,2)
AS

SELECT 
	SF.StoreName,
	SF.StoreAddress,
	SF.ZipCode,
	SUM(IIF(CS.InStock = 1, CS.Price, 0.00)) AS TotalValue,
	SUM(IIF(CS.InStock = 1, 1, 0)) AS NumberInStock,
	SUM(IIF(CS.InStock = 1, CS.Price, 0.00)) / SUM(IIF(CS.InStock = 1, 1, 0)) AS AveragePrice
FROM PartFinder.Storefront SF
	INNER JOIN PartFinder.ComponentStorefront CS ON SF.StoreID = CS.StoreID
GROUP BY StoreName, StoreAddress, ZipCode
HAVING SUM(IIF(CS.InStock = 1, CS.Price, 0.00)) >= @Value;
GO