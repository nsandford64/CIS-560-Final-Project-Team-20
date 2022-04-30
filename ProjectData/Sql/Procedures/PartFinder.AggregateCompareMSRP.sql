CREATE OR ALTER PROCEDURE PartFinder.AggregateCompareMSRP
AS

SELECT 
	CC.ComponentCategoryName,
	COUNT(DISTINCT M.ManufacturerID) AS ManufacturerCount, 
	COUNT(*) AS ComponentCount
FROM PartFinder.ComponentCategory CC
INNER JOIN PartFinder.Component C ON CC.ComponentCategoryID = C.ComponentCategoryID
INNER JOIN PartFinder.Manufacturer M ON M.ManufacturerID = C.ManufacturerID
INNER JOIN PartFinder.ComponentStorefront CS ON CS.ComponentID = C.ComponentID
WHERE C.MSRP > CS.Price AND CS.InStock = 1
GROUP BY ComponentCategoryName;
GO
