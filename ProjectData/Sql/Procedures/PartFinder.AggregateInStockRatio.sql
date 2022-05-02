CREATE OR ALTER PROCEDURE PartFinder.AggregateInStockRatio
AS

SELECT
	SF.StoreName,
	SF.StoreAddress,
	SF.ZipCode,
	SUM(IIF(CS.InStock = 1, 1.00, 0.00)) AS InStock,
	SUM(IIF(CS.InStock = 0, 1.00, 0.00)) AS NotInStock,
	CONVERT(DECIMAL(5, 2), SUM(IIF(CS.InStock = 1, 1.00, 0.00)) / (SUM(IIF(CS.InStock = 1, 1.00, 0.00)) +SUM(IIF(CS.InStock = 0, 1.00, 0.00)))) AS StockRatio
FROM PartFinder.Storefront SF
	INNER JOIN PartFinder.ComponentStorefront CS ON CS.StoreID = SF.StoreID
GROUP BY StoreName, StoreAddress, ZipCode;