CREATE TABLE PartFinder.ComponentCategory
(
	ComponentCategoryID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ComponentCategoryName NVARCHAR(64) NOT NULL 

	UNIQUE(ComponentCategoryName)
);