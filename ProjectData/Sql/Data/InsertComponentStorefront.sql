
--Inserts ID's into first two columsn
INSERT INTO ComponentStorefront(ComponentID, StoreID)
SELECT C.ComponentID, S.StoreID, 
FROM ComponentStorefront SF
INNER JOIN Component C ON C.ComponentID = SF.ComponentID
INNER JOIN Storefront S ON S.StoreID = SF.StoreID

INSERT INTO ComponentStorefront(Price, InStock)
SELECT CS.Price, CS.InStock
FROM 
(
    VALUES
    (199.99, 1),
(239.99, 0),
(239.99, 1),
(229.9, 0),
(229.99, 1),
(189.99, 1),
(159.99, 1),
(119.99, 1),
(309.99, 0),
(389.99, 0),
(222.1, 0),
(80.87, 0),
(296.98, 1),
(394.1, 0),
(139.99, 0),
(159.99, 0),
(109.99, 1),
(104.99, 1),
(129.99, 1),
(139.99, 1),
(54.97, 1),
(69.99, 1),
(99.99, 1),
(59.98, 1),
(134.99, 1),
(109.99, 1),
(104.99, 1),
(129.99, 1),
(139.99, 0),
(139.99, 0),
(169.99, 0),
(139.99, 0),
(159.99, 0),
(174.99, 0),
(179.99, 1),
(189.99, 0),
(159.99, 0),
(119.99, 1),
(309.99, 0),
(104.99, 1),
(129.99, 0),
(139.99, 1),
(54.97, 0),
(69.99, 1),
(99.99, 0),
(59.98, 1),
(134.99, 0),
(109.99, 0),
(104.99, 1),
(129.99, 0),
(139.99, 1),
(139.99, 0),
(169.99, 1),
(119.99, 0),
(309.99, 1),
)AS CS(Price,InStock)


