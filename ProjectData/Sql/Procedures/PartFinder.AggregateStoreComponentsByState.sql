CREATE OR ALTER PROCEDURE PartFinder.AggregateStoreComponentsByState
AS

SELECT 
	CC.ComponentCategoryName,
	S.StateName,
	C.CityName,
	COUNT(DISTINCT SF.StoreID) AS StoreCount,
	COUNT(*) AS ComponentCount
FROM PartFinder.States S
	INNER JOIN PartFinder.Cities C ON C.StateID = S.StateID
	INNER JOIN PartFinder.Storefront SF ON SF.CityID = C.CityID
	INNER JOIN PartFinder.ComponentStorefront CS ON CS.StoreID = SF.StoreID
	INNER JOIN PartFinder.Component CO ON CO.ComponentID = CS.ComponentID
	INNER JOIN PartFinder.ComponentCategory CC ON CC.ComponentCategoryID = CO.ComponentCategoryID
WHERE CS.InStock = 1
GROUP BY StateName, CityName, ComponentCategoryName, SF.StoreID;
GO