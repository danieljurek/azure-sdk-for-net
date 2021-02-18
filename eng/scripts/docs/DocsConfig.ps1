. $PSScriptRoot/../common/scripts/DocsConfigs.ps1
. $PSScriptRoot/docs.ps1

class DotnetDocsConfig : DocsConfig { 
    # Different from "Moniker" used in docs. This is a unique identifier for a
    # package
    [string] $PackageMoniker

    [array] $PackageVersionList

    [Hashtable] $PackageProperties

    DotnetDocsConfig(
        [string] $packageMoniker, 
        [string] $packageName, 
        [Hashtable] $packageProperties, 
        [array] $packageVersionList
    ) {
        $this.PackageMoniker = $packageMoniker
        $this.PackageName = $packageName 
        $this.PackageProperties = $packageProperties
        $this.PackageVerisons = $packageVersionList 

        $this.PackageVersion = if ($packageVersionList) { 
            [AzureEngSemanticVersion]::ParseVersionString($packageVersionList[0]) 
        } else { 
            $null
        }
    }

}