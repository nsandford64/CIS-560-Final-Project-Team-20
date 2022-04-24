

INSERT INTO PartFinder.Storefront(StoreName,StoreAddress,Zipcode,CityID)
SELECT S.StoreName, S.StoreAddress, S.Zipcode, C.CityID
FROM 
(
    VALUES
    (N'MicroCenter', N'99 Horseshoe Ln', 30141, N'Abbeville city'),
    (N'Rapid Computing', N'109 W 66th St', 60559, N'Adamsville city')
  
)AS S(StoreName, StoreAddress, Zipcode, CityName)
INNER JOIN PartFinder.Cities C on C.CityName = S.CityName