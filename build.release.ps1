[CmdletBinding()]

$VerbosePreference="Continue"

$versionFilename = "semver.version"
$versionRegex = "\d+\.\d+\.\d+"
$assemblyInfoFilename = "AssemblyInfo.cs"
$buildScriptVersion = "1.0.0"

Write-Verbose "Custom build script version $buildScriptVersion"

Write-Verbose "Searching for version file: $versionFilename"
$versionFile = Get-ChildItem -Recurse -Include $versionFilename

if(-not $versionFile) {
    Write-Error -Message "Version file not found"
    exit 1
} else {
    Write-Verbose "Version file found"
}

$version = Get-Content -Path $versionFile

if($version -notmatch $versionRegex) {
    Write-Error -Message "Version: $version doesn't match format: $versionRegex"
    exit 1
} else {
    Write-Verbose -Message "Set build version to: $version"
}

$assemblyInfoFiles = Get-ChildItem -Recurse -Include $assemblyInfoFilename

if($assemblyInfoFiles) {
    foreach($assemblyInfoFile in $assemblyInfoFiles) {
		Write-Verbose -Message "Looking for assembly info file"

		$assemblyInfoFileContents = Get-Content -Path $assemblyInfoFile
		$assemblyInfoFileContents -replace $versionRegex, $version | Out-File $assemblyInfoFile

		Write-Verbose -Message "Applied version: $version to assembly info file: $assemblyInfoFile"
	}
} else {
    Write-Verbose -Message "Assembly info file not found"
}

Write-Host "##vso[task.setvariable variable=build_version]$version"
