CREATE OR ALTER PROCEDURE PartFinder.InsertComponent
	@Name NVARCHAR(128),
	@ModelNumber NVARCHAR(64),
	@Manufacturer NVARCHAR(64),
	@ComponentCategory NVARCHAR(64),
	@MSRP DECIMAL(10,2)
AS

INSERT INTO PartFinder.Component(ComponentName, ModelNumber, ManufacturerID, ComponentCategoryID, MSRP)
SELECT C.Name, C.ModelNumber, M.ManufacturerID, CC.ComponentCategoryID, C.MSRP
FROM
(
	VALUES(@Name, @ModelNumber, @Manufacturer, @ComponentCategory, @MSRP)
) AS C(Name, ModelNumber, Manufacturer, ComponentCategory, MSRP)
INNER JOIN PartFinder.Manufacturer M ON M.ManufacturerName = C.Manufacturer
INNER JOIN PartFinder.ComponentCategory CC ON CC.ComponentCategoryName = C.ComponentCategory
GO
