INSERT INTO Storefront(StoreName,StoreAddress,Zipcode,CityID)
SELECT S.StoreName, S.StoreAddress, S.Zipcode, S.CityID
FROM 
(
    VALUES
    (N'MicroCenter', N'99 Horseshoe Ln', 30141, N'Hiram'),
(N'Rapid Computing', N'109 W 66th St', 60559, N'Westmont'),
(N'Computing Solutions', N'9 Linville Dr', 40361, N'Paris'),
(N'The Hardware Crew', N'31800 S 690th Rd', 74344, N'Grove'),
(N'Computing Excellence', N'8949 W Lockland Ct', 85382, N'Peoria'),
(N'Desktop Magic', N'2044 Lou Adams', 89021, N'Logandale'),
(N'Computer Outfitters', N'2255 Bird Rd', 42728, N'Columbia'),
(N'Vortex Computing', N'3930 Bayhan St', 48141, N'Inkster'),
(N'Pinnacle Technology', N'5701 Meadow Tate Dr', 35117, N'Mount Olive'),
(N'Top Computer Team', N'21596 Woodville Rd', 45107, N'Blanchester'),
(N'The Comp Shop', N'3610 Tumbling Falls Dr', 77578, N'Manvel'),
(N'Apex Computing', N'624 W Morrell St', 67578, N'Stafford'),
(N'The Computer Haven', N'8430 Amboy Ave', 91352, N'Sun Valley'),
(N'Best Budget Computers', N'609 S Thornton St', 64085, N'Richmond'),
(N'The Drive Mind', N'17100 NE 37th Ter', 32113, N'Citra'),
(N'Take a Byte', N'113 Meandering Ln', 76028, N'Burleson')
  
)AS S(StoreName, StoreAddress, Zipcode, CityID)
INNER JOIN Cities C on C.CityID = Storefront.CityID