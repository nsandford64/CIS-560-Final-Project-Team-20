
--Inserts ID's into first two columsn
INSERT INTO PartFinder.ComponentStorefront(ComponentID, StoreID)
SELECT C.ComponentID, S.StoreID
FROM PartFinder.ComponentStorefront SF
INNER JOIN PartFinder.Component C ON C.ComponentID = SF.ComponentID
INNER JOIN PartFinder.Storefront S ON S.StoreID = SF.StoreID



INSERT INTO PartFinder.ComponentStorefront(ComponentID, StoreID, Price, InStock)
SELECT C.ComponentID, S.StoreID, CS.Price, CS.InStock
FROM 
(
    VALUES
    (N'GV-N1060G1GAMING-6GD', N'99 Horseshoe Ln', N'30141', 199.99, 1),
(N'GV-N1060WF2OC-6GD', N'99 Horseshoe Ln', N'30141', 239.99, 0),
(N'GTX 1060 GAMING X 6G', N'99 Horseshoe Ln', N'30141', 239.99, 1),
(N'06G-P4-6368-KR', N'99 Horseshoe Ln', N'30141', 229.9, 0),
(N'TURBO-GTX1060-6G', N'99 Horseshoe Ln', N'30141', 229.99, 1),
(N'06G-P4-6161-KR', N'99 Horseshoe Ln', N'30141', 189.99, 1),
(N'ZT-P10600A-10L', N'99 Horseshoe Ln', N'30141', 159.99, 1),
(N'03G-P4-6367-KR', N'99 Horseshoe Ln', N'30141', 119.99, 1),
(N'DUAL-GTX1060-O3G', N'99 Horseshoe Ln', N'30141', 309.99, 0),
(N'03G-P4-6162-KR', N'99 Horseshoe Ln', N'30141', 389.99, 0),
(N'GV-N1060WF2OC-3GD', N'99 Horseshoe Ln', N'30141', 222.1, 0),
(N'GTX 1060 ARMOR 3G OCV1', N'99 Horseshoe Ln', N'30141', 80.87, 0),
(N'03G-P4-6160-KR', N'99 Horseshoe Ln', N'30141', 296.98, 1),
(N'NVIDIA GEFORCE GTX 1060 6GB FOUNDERS EDITION', N'99 Horseshoe Ln', N'30141', 394.1, 0),
(N'GV-N1070G1 GAMING-8GD', N'99 Horseshoe Ln', N'30141', 139.99, 0),
(N'08G-P4-6173-KR', N'99 Horseshoe Ln', N'30141', 159.99, 0),
(N'GV-N1070WF2OC-8GD', N'99 Horseshoe Ln', N'30141', 109.99, 1),
(N'GV-N1070IXOC-8GD', N'99 Horseshoe Ln', N'30141', 104.99, 1),
(N'DUAL-GTX1070-O8G', N'99 Horseshoe Ln', N'30141', 129.99, 1),
(N'GTX 1070 GAMING 8G', N'99 Horseshoe Ln', N'30141', 139.99, 1),
(N'GeForce GTX 1070 SEA HAWK X', N'99 Horseshoe Ln', N'30141', 54.97, 1),
(N'TURBO-GTX1070-8G', N'99 Horseshoe Ln', N'30141', 69.99, 1),
(N'08G-P4-6170-KR', N'109 W 66th St', N'60559', 99.99, 1),
(N'GTX 1080 ARMOR 8G OC', N'109 W 66th St', N'60559', 59.98, 1),
(N'GV-N1080G1 GAMING-8GD', N'109 W 66th St', N'60559', 134.99, 1),
(N'08G-P4-6183-KR', N'109 W 66th St', N'60559', 109.99, 1),
(N'GV-N1080XTREME-8GD Premium Pack', N'109 W 66th St', N'60559', 104.99, 1),
(N'GTX 1080 GAMING X 8G', N'109 W 66th St', N'60559', 129.99, 1),
(N'STRIX-GTX1080-A8G-GAMING', N'109 W 66th St', N'60559', 139.99, 0),
(N'GTX 1080 AERO 8G OC', N'109 W 66th St', N'60559', 139.99, 0),
(N'GTX 1080 GAMING 8G', N'109 W 66th St', N'60559', 169.99, 0),
(N'GV-N1080WF3OC-8GD', N'109 W 66th St', N'60559', 139.99, 0),
(N'GeForce GTX 1080 SEA HAWK', N'109 W 66th St', N'60559', 159.99, 0),
(N'GV-N1080D5X-8GD-B', N'109 W 66th St', N'60559', 174.99, 0),
(N'02G-P4-3757-KR', N'109 W 66th St', N'60559', 179.99, 1),
(N'GV-N75TWF2OC-4GI', N'109 W 66th St', N'60559', 189.99, 0),
(N'STRIX-GTX750TIOC2GD5', N'109 W 66th St', N'60559', 159.99, 0),
(N'11 ZT-70605-10M', N'109 W 66th St', N'60559', 119.99, 1),
(N'02G-P4-1953-KR', N'109 W 66th St', N'60559', 309.99, 0),
(N'02G-P4-2957-KR', N'109 W 66th St', N'60559', 104.99, 1),
(N'STRIX-GTX950-DC2OC-2GD5-GAMING', N'109 W 66th St', N'60559', 129.99, 0),
(N'GTX 950 GAMING 2G', N'109 W 66th St', N'60559', 139.99, 1),
(N'GV-N950WF2OC-2GD (rev. 1.0)', N'109 W 66th St', N'60559', 54.97, 0),
--(N'asdfghj', N'109 W 66th St', N'60559', 69.99, 1),
(N'ZT-90301-10M', N'109 W 66th St', N'60559', 99.99, 0),
(N'VCGGTX9602XPB-XE-OC', N'109 W 66th St', N'60559', 59.98, 1),
(N'GV-N960WF2OC-4GD', N'109 W 66th St', N'60559', 134.99, 0),
(N'n/a', N'109 W 66th St', N'60559', 109.99, 0),
(N'MINI-GTX950-2G', N'109 W 66th St', N'60559', 104.99, 1),
(N'100379NTOC+SR', N'109 W 66th St', N'60559', 129.99, 0),
(N'R9-FURY-4QFA', N'109 W 66th St', N'60559', 139.99, 1),
(N'100380SR', N'109 W 66th St', N'60559', 139.99, 0),
(N'AXR9 NANO 4GBHBM-DH', N'109 W 66th St', N'60559', 169.99, 1),
(N'100409-2GOCL', N'109 W 66th St', N'60559', 119.99, 0),
(N'DUAL-RX460-O2G', N'109 W 66th St', N'60559', 309.99, 1)

)AS CS(ModelNumber, [Address], Zipcode, Price, InStock)
INNER JOIN PartFinder.Component C ON C.ModelNumber = CS.ModelNumber
INNER JOIN PartFinder.Storefront S ON S.StoreAddress = CS.Address AND S.Zipcode = CS.Zipcode



