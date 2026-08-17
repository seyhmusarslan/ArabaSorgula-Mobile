$ErrorActionPreference = "Stop"

$repoRoot = Split-Path -Parent $PSScriptRoot
$project = Join-Path $repoRoot "src\ArabaSorgula.Mobile\ArabaSorgula.Mobile.csproj"

Write-Host "Building ArabaSorgula.Mobile (Debug / net10.0-android)..."
dotnet restore $project
dotnet build $project -f net10.0-android -c Debug --no-restore

if ($LASTEXITCODE -ne 0) {
    exit $LASTEXITCODE
}

Write-Host "Build succeeded."
