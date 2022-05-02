CREATE OR ALTER PROCEDURE PartFinder.UpdateComponentStorefront
	@StoreAddress NVARCHAR(64),
	@ZipCode INT,
	@ModelNumber NVARCHAR(128),
	@Price DECIMAL(5,2),
	@InStock BIT
AS

UPDATE PartFinder.ComponentStorefront
SET
	Price = @Price,
	InStock = @InStock
	UpdatedOn = SYSdATETIMEOFFSET()
WHERE (Price <> @Price OR InStock <> InStock) 
	AND	ComponentID = 
	(
		SELECT C.ComponentID
		FROM PartFinder.Component
		WHERE C.ModelNumber = @ModelNumber
	) AND StoreID = 
	(
		SELECT S.StoreID
		FROM PartFinder.Storefront
		WHERE S.StoreAddress = @StoreAddress AND
			S.ZipCode = @ZipCode
	) 