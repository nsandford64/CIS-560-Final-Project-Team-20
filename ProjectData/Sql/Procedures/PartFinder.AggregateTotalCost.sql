CREATE OR ALTER PROCEDURE PartFinder.AggregateInStockRatio
AS

SELECT
	SF.StoreName,
	SF.StoreAddress,
	SUM(IIF(CS.InStock = 1, 1, 0)) AS InStock,
	SUM(IIF(CS.InStock = 1, 1, 0)) / COUNT(*) AS StockRatio
FROM PartFinder.ComponentStorefront CS
	INNER JOIN PartFinder.Storefront SF ON SF.StoreID = CS.StoreID
GROUP BY StoreName, StoreAddress


