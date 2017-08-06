[CmdletBinding()]

$VerbosePreference="Continue"

$versionFilename = "version.xml"
$versionRegex = "(<VersionSuffix><\/VersionSuffix>)"
$buildScriptVersion = "1.0.0"

Write-Verbose "Custom build script version $buildScriptVersion"
Write-Verbose "Searching for version file: $versionFilename"

$versionFile = Get-ChildItem -Recurse -Include $versionFilename
$versionFileContent = Get-Content -Path $versionFile

$currentDateTime = [System.DateTime]::UtcNow

$versionPostfix = $currentDateTime.ToString("yyyyMMddHHmmss")

$versionFileContent -replace $versionRegex, "<VersionSuffix>$versionPostfix</VersionSuffix>" | Out-File $versionFile