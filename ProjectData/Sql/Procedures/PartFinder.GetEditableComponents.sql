CREATE OR ALTER PROCEDURE PartFinder.GetEditableComponents
AS

SELECT
	C.ComponentName,
	C.ModelNumber,
	CS.Price,
	CS.InStock,
	SF.StoreAddress,
	SF.ZipCode
FROM PartFinder.ComponentStorefront CS
INNER JOIN PartFinder.Component C ON C.ComponentID = CS.ComponentID
INNER JOIN PartFinder.Storefront SF ON SF.StoreID = CS.StoreID	