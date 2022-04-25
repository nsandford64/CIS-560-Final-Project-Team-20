

INSERT INTO PartFinder.Storefront(StoreName,StoreAddress,Zipcode,CityID)
SELECT S.StoreName, S.StoreAddress, S.Zipcode, C.CityID
FROM 
(
    VALUES
    (N'MicroCenter', N'99 Horseshoe Ln', 30141, N'Abbeville city', N'Alabama'),
    (N'Rapid Computing', N'109 W 66th St', 60559, N'Adamsville city', N'Alabama')
  
)AS S(StoreName, StoreAddress, Zipcode, CityName, StateName)
INNER JOIN PartFinder.States ST ON ST.StateName = S.StateName
INNER JOIN PartFinder.Cities C on C.CityName = S.CityName AND C.StateID = ST.StateID