CREATE OR ALTER PROCEDURE PartFinder.GetManufacturerNames
AS
SELECT M.ManufacturerName
FROM PartFinder.Manufacturer M;
GO