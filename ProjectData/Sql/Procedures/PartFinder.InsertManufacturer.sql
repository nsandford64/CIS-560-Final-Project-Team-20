CREATE OR ALTER PROCEDURE PartFinder.InsertManufacturer
	@Name NVARCHAR(32),
	@ManufacturerID INT OUTPUT
AS

INSERT INTO PartFinder.Manufacturer(ManufacturerName)
VALUES(@Name)
SET @ManufacturerID = SCOPE_IDENTITY();
GO
