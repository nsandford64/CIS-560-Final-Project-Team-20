IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'PartFinder'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [PartFinder] AUTHORIZATION [dbo]');
END;