--Manufacturers that sell products that cost more or less than an amount DONE

CREATE OR ALTER PROCEDURE Product_Cost_By_Manufacturer @PARAM_UPPER AS INT, @PARAM_LOWER AS INT
AS

SELECT M.ManufacturerName, C.MSRP
FROM PartFinder.Manufacturer M
INNER JOIN PartFinder.Component C ON C.ManufacturerID = M.ManufacturerID
WHERE C.MSRP BETWEEN @PARAM_UPPER AND @PARAM_LOWER
GO;
