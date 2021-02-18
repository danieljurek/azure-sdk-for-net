. $PSScriptRoot/../../common/scripts/common.ps1 

Write-Host "Roundtrip serializer"

$sampleConfig = @"
{
    "targets": [
        {
            "path_to_config": "./roundtrip-preview.csv",
            "Mode": "Preview",
            "content_folder": "api/overview/azure",
            "suffix": "-pre"
        },
        {
            "path_to_config": "./roundtrip-latest.csv",
            "mode": "Latest",
            "content_folder": "api/overview/azure"
        }
    ]
}
"@ | ConvertFrom-Json

$expectedPreviewContent = Get-Content ./roundtrip-preview.csv -Raw 
$expectedLatestContent = Get-Content ./roundtrip-latest.csv -Raw

$docsConf = Deserialize-dotnet-Docs($sampleConfig, $PSScriptRoot) #`
    #| Serialzie-dotnet-Docs($sampleConfig, $PSScriptRoot)

$actualPreviewContent = Get-Content ./roundtrip-preview.csv -Raw 
$actualLatestContent = Get-Content ./roundtrip-latest.csv -Raw

if ($expectedPreviewContent -ne $actualPreviewContent) { 
    Write-Error "Preview roundtrip content does not match"
}

if ($expectedLatestContent -ne $actualLatestContent) { 
    Write-Error "Latest roundtrip content does not match"
}