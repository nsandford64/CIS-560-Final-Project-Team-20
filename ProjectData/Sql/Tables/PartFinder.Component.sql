CREATE TABLE PartFinder.Component
(
	ComponentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ComponentName NVARCHAR(128) NOT NULL,
	ModelNumber NVARCHAR(128) NOT NULL,
	ManufacturerID INT NOT NULL FOREIGN KEY REFERENCES PartFinder.Manufacturer(ManufacturerID),
	ComponentCategoryID INT NOT NULL FOREIGN KEY REFERENCES PartFinder.ComponentCategory(ComponentCategoryID),
	MSRP DECIMAL(10,2) NOT NULL 

	UNIQUE(ModelNumber)
);