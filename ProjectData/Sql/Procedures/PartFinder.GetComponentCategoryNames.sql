CREATE OR ALTER PROCEDURE PartFinder.GetComponentCategoryNames
AS
SELECT CC.ComponentCategoryName
FROM PartFinder.ComponentCategory CC;
GO