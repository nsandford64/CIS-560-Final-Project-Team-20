--Most expensive components in a store DONE
CREATE OR ALTER PROCEDURE Most_Expensive_Component_In_Specific_Store @STORE_NAME AS NVARCHAR(32)
AS
With ComCTE (ComponentID, Price) AS
(
SELECT TOP(1) CS.ComponentID, CS.Price
FROM PartFinder.ComponentStorefront CS
INNER JOIN PartFinder.Storefront S ON S.StoreID = CS.StoreID
WHERE S.StoreName = @STORE_NAME
)
Select C.ComponentName,C.ModelNumber,CTE.Price 
From ComCTE CTE
INNER JOIN PartFinder.Component C On C.ComponentID = CTE.ComponentID

GO;