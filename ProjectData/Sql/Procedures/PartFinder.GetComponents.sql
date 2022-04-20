CREATE OR ALTER PROCEDURE PartFinder.GetComponents
	@Name NVARCHAR(64)
AS

SELECT *
FROM PartFinder.Component C
WHERE C.ComponentName = @Name;
GO