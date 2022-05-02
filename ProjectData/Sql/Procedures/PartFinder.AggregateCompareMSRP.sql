/*This query counts the number of Manufacturers that produce parts that are being sold above their MSRP in Storefronts.
This is done by comparing the Price column in the ComponentStorefront table to the MSRP column in the Component, and 
counting when Price > MSRP. The query also aggregates the number of such components, and groups the component and manufacturer 
counts by the ComponentCategory*/
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
