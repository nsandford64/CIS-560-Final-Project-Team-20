Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "nsandford64"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Schemas\PartFinder.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.ComponentCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.Manufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.Component.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.States.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.Cities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.Storefront.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Tables\PartFinder.ComponentStorefront.sql"

<#
Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.CreatePerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrievePersons.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.FetchPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.GetPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.SavePersonAddress.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"
#>

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Data\InsertStates.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Data\InsertCities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Data\InsertManufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Data\InsertComponentCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataAccess\Sql\Data\InsertComponents.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
