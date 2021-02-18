. "${PSScriptRoot}\SemVer.ps1"

class DocMonikerConfig {
    [array] $Latest
    [array] $Preview

    DocMonikerConfig($latest, $preview) {
        $this.Latest = $latest
        $this.Preview = $preview
    }
}

class DocConfig { 
    # Full name of the published package
    [string] $PackageName

    # This value may be null if there is not a corresponding semver
    # in the case of JS the only version specifier could be a tag like @next
    [AzureEngSemanticVersion] $PackageVersion
}