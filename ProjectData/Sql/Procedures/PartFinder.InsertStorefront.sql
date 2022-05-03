CREATE OR ALTER PROCEDURE PartFinder.InsertStorefront
	@Name NVARCHAR(32),
	@Address NVARCHAR(32),
	@Zipcode INT,
	@CityName NVARCHAR(32),
	@StateName NVARCHAR(32)
AS

INSERT INTO PartFinder.Storefront(StoreName,StoreAddress,Zipcode,CityID)
SELECT S.StoreName, S.StoreAddress, S.Zipcode, C.CityID
FROM 
(
    VALUES(@Name, @Address, @Zipcode, @CityName, @StateName)
)AS S(StoreName, StoreAddress, Zipcode, CityName, StateName)
INNER JOIN PartFinder.States ST ON ST.StateName = S.StateName
INNER JOIN PartFinder.Cities C on C.CityName = S.CityName AND C.StateID = ST.StateID;
GO
