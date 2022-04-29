--Number of Components from each manufacturer DONE
CREATE OR ALTER PROCEDURE Number_Of_Components_From_Each_Manufacture
AS
SELECT  M.ManufacturerID, M.ManufacturerName,  COUNT(C.ComponentID) AS  [Number Of Components]
FROM PartFinder.Component C
INNER JOIN PartFinder.ComponentCategory CC ON CC.ComponentCategoryID = C.ComponentCategoryID
INNER JOIN PartFinder.Manufacturer M ON M.ManufacturerID = C.ManufacturerID
GROUP BY M.ManufacturerID, M.ManufacturerName

GO;

