$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'

Write-Host "Setting .nuspec version tag to $env:APPVEYOR_BUILD_VERSION"

$content = (Get-Content $root\NuGet\NCalc.nuspec)
$content = $content -replace '\$version\$', $env:APPVEYOR_BUILD_VERSION

$content | Out-File $root\nuget\NCalc.compiled.nuspec

& nuget pack $root\nuget\NCalc.compiled.nuspec
