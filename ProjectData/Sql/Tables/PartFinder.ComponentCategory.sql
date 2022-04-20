CREATE TABLE PartFinder.ComponentCategory
(
	ComponentCategoryID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ComponentCategoryName NVARCHAR(32) NOT NULL 

	UNIQUE(ComponentCategoryName)
);