$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\Evaluant.Calculator\bin\Release\NCalc.dll").GetName().Version
$versionStr = "{0}.{1}.{2}.{3}" -f ($version.Major, $version.Minor, $version.Build, $version.Revision)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\NCalc.nuspec)
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\NCalc.compiled.nuspec

& nuget pack $root\nuget\NCalc.compiled.nuspec
