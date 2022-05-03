CREATE OR ALTER PROCEDURE PartFinder.InsertManufacturer
	@Name NVARCHAR(32)
AS

INSERT INTO PartFinder.Manufacturer(ManufacturerName)
VALUES(@Name)
GO
