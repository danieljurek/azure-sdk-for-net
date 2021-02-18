Set-StrictMode -Version 3
# Sample context: 
# {
#     "targets": [
#         {
#             "path_to_config": "bundlepackages/azure-dotnet-preview.csv",
#             "Mode": "Preview",
#             "content_folder": "api/overview/azure",
#             "suffix": "-pre"
#         },
#         {
#             "path_to_config": "bundlepackages/azure-dotnet.csv",
#             "mode": "Latest",
#             "content_folder": "api/overview/azure"
#         }
#     ]
# }
 
function GetMonikerConfig([string]$mode, $config) { 
    return $config.targets `
        | Where-Object { $_.Mode -eq $mode } `
        | Select-Object -First 1
}

# Deserializer taken from format used by nue.exe
# https://github.com/docascode/nue/blob/ebe58e26a99e1a426d2417ac8f33424d0fbb0989/Nue/Nue/Core/Extractor.cs#L114
# Sample config line of format: 
# moniker, [custom property 1;custom property 2...] package name, version 0, version 1, ... versnion n
# azuremgmtblueprint,[isPrerelease=true]Microsoft.Azure.Management.Blueprint,0.10.0-preview
function Deserialize-dotnet-Docs($ctx, $rootPath) {
    function Get-Config($configPath) {
        Write-Host "Loading csv from $configPath"
        $output = @()
        $parser = [Microsoft.VisualBasic.FileIO.TextFieldParser]::new([string]$configPath)
        $parser.TextFieldType = [Microsoft.VisualBasic.FileIO.FieldType]::Delimited
        $parser.SetDelimiters(",")

        while (!$parser.EndOfData) { 
            $fields = parser.ReadFields
            if ($fields -eq $null) { 
                continue
            }

            $rawProperties = if ($row[1] -match '\[(.*)\]') { 
                $Matches[1] 
            } else { 
                "" 
            }

            $packageProperties = @{}
            foreach ($propertyExpression in $rawProperties.Split(';')) {
                $propertyParts = $propertyExpression.Split('=')
                $packageProperties[$propertyParts[0]] = $propertyParts[1]
            }

            $packageName = if ($row[1] -match '(\[.*\])?(.*)') { 
                $Matches[2] 
            } else { 
                Write-Error "Could not find package id in row $($row[1])" 
            }
            

            $output += [DotnetDocsConfig]::new(
                $fields[0],
                $packageName,
                $packageProperties,
                ($fields | Select-Object -Skip 2)
            )
        }

        return $output
    }

    Write-Host "hello world..."
    $latestConfig = GetMonikerConfig('Latest', $ctx)
    $previewConfig = GetMonikerConfig('Preview', $ctx)

    Write-Host $latestConfig 
    Write-Host $rootPath

    $latestConfigPath = Resolve-Path $rootPath $latestConfig.path_to_config
    $previewConfigPath = Resolve-Path $rootPath $previewConfig.path_to_config

    return [DocMonikerConfig]::new(
        (Get-Config $latestConfigPath),
        (Get-Config $previewConfig)
    )
}

function Serialzie-dotnet-Docs {
    [CmdletBinding()]
    param(
        $context,

        [Parameter(ValueFromPipeline)]
        $output
    ) 
    function Get-Line ($item) { 
        $line = if ($item.PackageProperties.Count) {
            $packageProperties = $item.PackageProperties `
                | ForEach-Object { "$($_.Name)=$($_.Value)" }
            "$($item.PackageMoniker),[$packageProperties]$($item.PackageName),"
        } else { 
            "$($item.PackageMoniker),$($item.PackageName)"
        }

        $line += $item.PackageVerisonList | Join-String -Separator ";" -OutputPrefix ";"

        return $line
    }


    $latestConfig = $context | GetMonikerConfig Latest
    $previewConfig = $context | GetMonikerConfig Preview

    $output.Latest `
        | ForEach-Object { Get-Line $_ } `
        | Set-Content $latestConfig.path_to_config

    $output.Preview `
        | ForEach-Object { Get-Line $_ } `
        | Set-Content $previewConfig.path_to_config
}
