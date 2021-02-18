Import-Module .\eng\scripts\Language-Settings.ps1
Import-Module .\eng\common\scripts\SemVer.ps1

Test-dotnet-PackageSupersedesAllPublishedPackages( `
    New-Object psobject -Property @{ PackageId = 'Azure.Storage.Files.Shares'; PackageVersion = '12.6.0-beta.1' } `
)