CREATE OR ALTER PROCEDURE PartFinder.AggregateInStockRatio
AS

SELECT
	SF.StoreName,
	SF.StoreAddress,
	SUM(IIF(CS.InStock = 1, 1, 0)) AS InStock,
	SUM(IIF(CS.InStock = 1, 1, 0)) / COUNT(*) AS StockRatio
FROM PartFinder.Storefront SF
	INNER JOIN PartFinder.ComponentStorefront CS ON CS.StoreID = SF.StoreID
GROUP BY StoreName, StoreAddress;
GO
