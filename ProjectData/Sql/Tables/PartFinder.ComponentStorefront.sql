CREATE TABLE PartFinder.ComponentStorefront
(
	ComponentID INT NOT NULL FOREIGN KEY REFERENCES PartFinder.Component(ComponentID),
	StoreID INT NOT NULL FOREIGN KEY REFERENCES PartFinder.Storefront(StoreID),
	Price DECIMAL(5,2) NOT NULL,
	InStock BIT NOT NULL,

	PRIMARY KEY(ComponentID, StoreID)
);