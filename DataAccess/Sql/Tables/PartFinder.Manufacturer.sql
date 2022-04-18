CREATE TABLE PartFinder.Manufacturer
(
	ManufacturerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ManufacturerName NVARCHAR(32) NOT NULL

	UNIQUE(ManufacturerName)
);