CREATE OR ALTER PROCEDURE PartFinder.GetStateNames
AS
SELECT S.StateName
FROM PartFinder.States S;
GO