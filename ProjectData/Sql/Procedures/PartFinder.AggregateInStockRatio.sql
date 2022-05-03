CREATE OR ALTER PROCEDURE PartFinder.AggregateInStockRatio
AS

SELECT
	CC.ComponentCategoryName,
	SF.StoreName,
	SF.StoreAddress,
	SF.ZipCode,
	SUM(IIF(CS.InStock = 1, 1, 0)) AS InStock,
	SUM(IIF(CS.InStock = 0, 1, 0)) AS NotInStock,
	CONVERT(DECIMAL(5, 2), SUM(IIF(CS.InStock = 1, 1.00, 0.00)) / (SUM(IIF(CS.InStock = 1, 1.00, 0.00)) +SUM(IIF(CS.InStock = 0, 1.00, 0.00)))) AS StockRatio
FROM PartFinder.Storefront SF
	INNER JOIN PartFinder.ComponentStorefront CS ON CS.StoreID = SF.StoreID
	INNER JOIN PartFinder.Component C ON C.ComponentID = CS.ComponentID
	INNER JOIN PartFinder.ComponentCategory CC ON CC.ComponentCategoryID = C.ComponentCategoryID
GROUP BY StoreName, StoreAddress, ZipCode, ComponentCategoryName
ORDER BY ComponentCategoryName, StoreName;
GO