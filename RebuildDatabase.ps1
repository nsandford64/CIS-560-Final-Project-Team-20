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

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\InsertStates.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\InsertCities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\InsertManufacturer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\InsertComponentCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ProjectData\Sql\Data\InsertComponents.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
