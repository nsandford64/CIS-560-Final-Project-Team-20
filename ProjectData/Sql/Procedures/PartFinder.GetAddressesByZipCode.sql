CREATE OR ALTER PROCEDURE PartFinder.GetAddressesByZipCode
	@ZipCode INT
AS

SELECT S.StoreAddress
FROM PartFinder.Storefront S
WHERE S.ZipCode = @ZipCode;
GO