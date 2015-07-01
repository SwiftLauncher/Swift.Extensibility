$project = "Swift.Extensibility"
$revisionNumberPrefix = "0-alpha"

$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\$project\bin\Release\$project.dll").GetName().Version
$versionStr = "1.0.$revisionNumberPrefix{0}" -f ($version.Revision)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\$project.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\$project.compiled.nuspec

& $root\NuGet\NuGet.exe pack $root\nuget\$project.compiled.nuspec
Remove-Item $root\nuget\$project.compiled.nuspec