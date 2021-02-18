$configs = @"
{
    "targets": [
        {
            "path_to_config": "bundlepackages/azure-dotnet-preview.csv",
            "Mode": "Preview",
            "content_folder": "api/overview/azure",
            "suffix": "-pre"
        },
        {
            "path_to_config": "bundlepackages/azure-dotnet.csv",
            "mode": "Latest",
            "content_folder": "api/overview/azure"
        }
    ]
}
"@

$docRepoLocation =  "D:\pub\docs-ci\dotnet\docs\"

# Push-Location $docRepoLocation
# git checkout . 
# Pop-Location

./eng/common/scripts/update-docs-ci.ps1 `
    -ArtifactLocation "D:\pub\docs-ci\dotnet\artifacts" `
    -WorkDirectory "D:\pub\docs-ci\dotnet\scratch" `
    -ReleaseSHA "430f2eba747d6de99a43f4f8bd63cd28e673f979" `
    -RepoId "azure/azure-sdk-for-net" `
    -Repository "Nuget" `
    -DocRepoLocation $docRepoLocation `
    -Configs $configs

# Push-Location $docRepoLocation
# git status 
# git diff
# Pop-Location