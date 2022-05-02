CREATE OR ALTER PROCEDURE PartFinder.GetData
	@STATE NVARCHAR(32),
	@ADDRESS NVARCHAR(128), --CHECK IF HITTING CORRECT ADDRESS LENGTH
	@ZIPCODE INT, -- CHECK IF ZIP CODE IS GREATER 5 DIGITS
	@STOREFRONT NVARCHAR(64),
	@COMPONENT_CATEGORY NVARCHAR(32),
	@COMPONENT_NAME NVARCHAR(64),
	@COMPONENT_MANUFACTURER NVARCHAR(64),
	@MIN_PRICE DECIMAL(5,2),
	@MAX_PRICE DECIMAL(5,2)
AS


SELECT C.ComponentName, C.ModelNumber, M.ManufacturerName, CC.ComponentCategoryID, C.MSRP, CS.Price, CS.InStock, S.StoreName, S.StoreAddress, S.ZipCode, CIT.CityName, ST.StateName
FROM PartFinder.ComponentStorefront CS
INNER JOIN PartFinder.Component C ON C.ComponentID = CS.ComponentID
INNER JOIN PartFinder.Manufacturer M ON M.ManufacturerID = C.ManufacturerID
INNER JOIN PartFinder.ComponentCategory CC ON CC.ComponentCategoryID = C.ComponentCategoryID
INNER JOIN PartFinder.Storefront S ON S.StoreID = CS.StoreID
INNER JOIN PartFinder.Cities CIT ON CIT.CityID = S.CityID
INNER JOIN PartFinder.States ST ON ST.StateID = CIT.StateID
WHERE  (ST.StateName LIKE '%' + @STATE + '%' OR @STATE IS NULL)
AND    (S.StoreAddress LIKE '%' + @ADDRESS + '%' OR @ADDRESS IS NULL)
AND    (S.ZipCode LIKE @ZIPCODE OR @ZIPCODE IS NULL)
AND    (S.StoreName LIKE '%' + @STOREFRONT + '%' OR @STOREFRONT IS NULL)
AND	   (CC.ComponentCategoryName LIKE '%' + @COMPONENT_CATEGORY + '%' OR @COMPONENT_CATEGORY IS NULL)
AND    (C.ComponentName LIKE '%' + @COMPONENT_NAME + '%' OR @COMPONENT_NAME IS NULL)
AND    (M.ManufacturerName LIKE '%' + @COMPONENT_MANUFACTURER + '%' OR @COMPONENT_MANUFACTURER IS NULL)
AND    ((CS.Price >= @MIN_PRICE) OR @MIN_PRICE IS NULL)
AND    ((CS.Price <= @MAX_PRICE) OR @MAX_PRICE IS NULL)

