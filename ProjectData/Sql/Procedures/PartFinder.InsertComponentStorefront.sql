CREATE OR ALTER PROCEDURE PartFinder.InsertComponentStorefront
	@StoreAddress NVARCHAR(32),
	@ZipCode INT,
	@ModelNumber NVARCHAR(64),
	@Price DECIMAL(10, 2),
	@InStock BIT
AS

INSERT INTO PartFinder.ComponentStorefront(ComponentID, StoreID, Price, InStock)
SELECT C.ComponentID, ST.StoreID, S.Price, S.InStock
FROM 
(
    VALUES(@StoreAddress, @ZipCode, @ModelNumber, @Price, @InStock)
)AS S(StoreAddress, ZipCode, ModelNumber, Price, InStock)
INNER JOIN PartFinder.Component C ON S.ModelNumber = C.ModelNumber
INNER JOIN PartFinder.Storefront ST ON ST.ZipCode = S.ZipCode AND ST.StoreAddress = S.StoreAddress;
GO
