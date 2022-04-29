CREATE OR ALTER PROCEDURE PartFinder.GetCitiesByState
	@StateName NVARCHAR(32)
AS

SELECT C.CityName
FROM PartFinder.Cities C
INNER JOIN PartFinder.States S ON S.StateID = C.StateID
WHERE S.StateName = @StateName