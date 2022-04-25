CREATE OR ALTER PROCEDURE PartFinder.InsertCity
	@CityName NVARCHAR(32),
	@StateName NVARCHAR(32),
	@CityID INT OUTPUT
AS

INSERT INTO PartFinder.Cities(CityName, StateID)
SELECT C.CityName, S.StateID
FROM
(
	VALUES(@CityName, @StateName)
) AS C(CityName, StateName)
INNER JOIN PartFinder.States S ON S.StateName = C.StateName
SET @CityID = SCOPE_IDENTITY();
GO
