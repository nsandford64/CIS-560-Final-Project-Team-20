CREATE OR ALTER PROCEDURE PartFinder.GetZipCodes
AS

SELECT S.ZipCode
FROM PartFinder.Storefront S
ORDER BY S.ZipCode ASC;
GO