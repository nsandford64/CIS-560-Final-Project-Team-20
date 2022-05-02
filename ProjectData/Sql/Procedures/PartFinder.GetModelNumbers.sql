CREATE OR ALTER PROCEDURE PartFinder.GetModelNumbers
AS

SELECT C.ModelNumber
FROM PartFinder.Component C;
GO