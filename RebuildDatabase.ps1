Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "partfinder"
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
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Schemas\PartFinder.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.ComponentCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.Manufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.Component.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.States.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.Cities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.Storefront.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Tables\PartFinder.ComponentStorefront.sql"


Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetComponents.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.InsertComponent.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.InsertCity.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.InsertManufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.InsertStorefront.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.InsertComponentStorefront.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\HolyGrailQuery.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetManufacturerNames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetStateNames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetComponentCategoryNames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetCityNames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.GetCitiesByState.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.AggregateStockValues.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.AggregateCompareMSRP.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.AggregateStoreComponentsByState.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Procedures\PartFinder.AggregateInStockRatio.sql"




Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateComponentCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateManufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateComponents.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateStates.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateCities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateStorefront.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\PopulateComponentStorefront.sql"




Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
