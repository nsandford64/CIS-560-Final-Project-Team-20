CREATE TABLE PartFinder.States
(
	StateID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	StateAbbrev NVARCHAR(2) NOT NULL,
	StateName NVARCHAR(32) NOT NULL

	UNIQUE(StateName),
	UNIQUE(StateAbbrev)
);