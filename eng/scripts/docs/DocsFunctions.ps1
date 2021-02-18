
# TODO: Do we declare these here?
$UpdateDocMonikerCIFn = "Update-${Language}-MonikerConfig"
$PackageSupersedesAllPublished = "Test-${Language}-PackageSupersedesAllPublishedPackages"



# details on CSV schema can be found here
# https://review.docs.microsoft.com/en-us/help/onboard/admin/reference/dotnet/documenting-nuget?branch=master#set-up-the-ci-job
function Update-dotnet-CIConfig($pkgs, $ciRepo, $locationInDocRepo, $monikerId=$null)
{
  $csvLoc = (Join-Path -Path $ciRepo -ChildPath $locationInDocRepo)
  
  if (-not (Test-Path $csvLoc)) {
    Write-Error "Unable to locate package csv at location $csvLoc, exiting."
    exit(1)
  }

  $allCSVRows = Get-Content $csvLoc
  $visibleInCI = @{}

  # first pull what's already available
  for ($i=0; $i -lt $allCSVRows.Length; $i++) {
    $pkgDef = $allCSVRows[$i]

    # get rid of the modifiers to get just the package id
    $id = $pkgDef.split(",")[1] -replace "\[.*?\]", ""

    $visibleInCI[$id] = $i
  }

  foreach ($releasingPkg in $pkgs) {
    $installModifiers = "tfm=netstandard2.0"
    if ($releasingPkg.IsPrerelease) {
      $installModifiers += ";isPrerelease=true"
    }
    $lineId = $releasingPkg.PackageId.Replace(".","").ToLower()

    if ($visibleInCI.ContainsKey($releasingPkg.PackageId)) {
      $packagesIndex = $visibleInCI[$releasingPkg.PackageId]
      $allCSVRows[$packagesIndex] = "$($lineId),[$installModifiers]$($releasingPkg.PackageId)"
    }
    else {
      $newItem = "$($lineId),[$installModifiers]$($releasingPkg.PackageId)"
      $allCSVRows += ($newItem)
    }
  }

  Set-Content -Path $csvLoc -Value $allCSVRows
}

function Update-dotnet-MonikerConfig($SupersedingPackages, $CiConfigLocation, $previewMonikerIndex=$null, $latestMonikerIndex=$null) {
  if (-not (Test-Path $CiConfigLocation)) {
    Write-Error "Unable to locate package csv at location $csvLoc, exiting."
    exit(1)
  }

  # Using Get-Content because Import-Csv doesn't support unspecified columns
  # Since there can be many version columns it's best to split
  $allCsvRows = Get-Content $CiConfigLocation
  $supersedingPackagesCache = @{}

  foreach($package in $SupersedingPackages) { 
    $supersedingPackagesCache[$package.PackageId] = $package
  }

  # Filter out superseding packages
  $outputCsvRows = $allCsvRows `
    | Where-Object {
      # Example rows (note second column contains additional properties): 
      # cogservicespersonalizer,[isPrerelease=true]Microsoft.Azure.CognitiveServices.Personalizer,0.8.0-preview
      # azurestoragefilesdatalake,[tfm=netstandard2.0;isPrerelease=true]Azure.Storage.Files.DataLake
      $row = $_.Split(',')
      $packageMoniker = $row[0]
      $installModifiers = if ($row[1] -match '\[(.*)\]') { $Matches[1] } else { "" }
      $packageId = if ($row[1] -match '(\[.*\])?(.*)') { $Matches[2] } else { Write-Error "Could not find package id in row $($row[1])" }

      # Keep packages which do not match any of the packages in $SupersedingPackages
      if (-not $supersedingPackagesCache.ContainsKey($packageId)) { 
        return $true
      }

      $supersedingVersion = [AzureEngSemanticVersion]::ParseVersionString(
        $supersedingPackagesCache[$packageId].PackageVersion
      )

      $previewVersion = GetExistingPackageVersions($packageId) `
        | ForEach-Object { [AzureEngSemanticVersion]::ParseVersionString($_) } `
        | Where-Object { $_.IsPrerelease } `
        | Sort-Object -Descending `
        | Select-Object -First 1

        Write-Host "$($packageId)@$supersedingVersion > $previewVersion ??"
        if ($supersedingVersion -gt $previewVersion) { 
          Write-Host "SUPERSEDED"
          return $false 
        }
  
        Write-Host "NOT SUPERSEDED"
        return $true
    }

  Set-Content -Path $CiConfigLocation -Value $outputCsvRows
}
