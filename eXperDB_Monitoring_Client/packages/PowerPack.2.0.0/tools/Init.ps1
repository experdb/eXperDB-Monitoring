# Solution-level install script.
# See http://docs.nuget.org/create/Creating-and-Publishing-a-Package
# and http://stackoverflow.com/questions/6460854/adding-solution-level-items-in-a-nuget-package

param($installPath, $toolsPath, $package, $project)


#Write-Host "installPath = $installPath"
#Write-Host "toolsPath = $toolsPath"
#Write-Host "package = $package"
#Write-Host "project = $project"

$vsSolution = Get-Interface $dte.Solution ([EnvDTE80.Solution2])
$slnDir = Split-Path -Parent $vsSolution.FullName
# Reuse this folder, it gets created when using solution-level packages.
$powerPackDir = Join-Path -Path $slnDir -ChildPath ".nuget"         

# NuGet is a PITA...runs this script every time if the Package Manager console window is open. Sigh.
if (Test-Path "$powerPackDir\PowerPack.psm1")
{
	return
}

Write-Host "Installing PowerPack into your solution..."


#Write-Host "slnDir = $slnDir, powerPackDir = $powerPackDir"
$vsProject = $vsSolution.Projects | Where {$_.ProjectName -eq ".nuget"}
if (!$vsProject)
{
    $vsProject = $vsSolution.AddSolutionFolder(".nuget")
}

<#
$src1 = "$installPath\PowerPack\PowerPack.psm1"
$src2 = "$installPath\PowerPack\en-US\about_PowerPack.help.txt"
$dest1 = $powerPackDir + "\PowerPack.psm1"
$dest2 = $powerPackDir + "\en-US\about_PowerPack.help.txt"
$dir = Split-Path -Parent $dest2
if (!(Test-Path $dir))
{
	New-Item $dir -ItemType Directory
}

Write-Host "Installing $dest1"
Copy-Item -Path $src1 -Destination $dest1 -Force
Write-Host "Installing $dest2"
Copy-Item -Path $src2 -Destination $dest2 -Force

$vsProject.ProjectItems.AddFromFile($dest1)
#$vsProject.ProjectItems.AddFolder("en-US", [EnvDTE.Constants]::vsProjectItemKindVirtualFolder)     # Not implemented
#$vsProject.ProjectItems.AddFolder("en-US", [EnvDTE.Constants]::vsProjectItemKindPhysicalFolder)    # Not implemented 
#$vsProject.ProjectItems.AddFolder("en-US", [EnvDTE.Constants]::vsProjectItemKindSubProject)        # Not implemented 
#$vsProject.ProjectItems.AddFolder("en-US", [EnvDTE.Constants]::vsProjectItemKindSolutionItems)     # Not implemented 
#$vsProject.ProjectItems
#$vsProject2 = $vsProject.AddSolutionFolder("en-US")
#>

# Copy our files to the .nuget folder. Only add PackMe.ps1. Can't figure out how to
# create subfolders under .nuget. http://stackoverflow.com/questions/27475143/create-or-get-solution-folder-in-nuget-init-ps1?lq=1
foreach ($file in Get-ChildItem "$installPath\PowerPack" -Recurse -File)
{
	$destFile = $powerPackDir + $file.FullName.Substring($installPath.Length + "\PowerPack".Length)

    Write-Host "Installing $($file.FullName) to $destFile"
	$dir = Split-Path -Parent $destFile
	if (!(Test-Path $dir))
	{
		New-Item $dir -ItemType Directory
	}

    Copy-Item -Path $file.FullName -Destination $destFile -Force
	if ($destFile.EndsWith("PackMe.ps1") -or $destFile.EndsWith("PowerPack.psm1"))
	{
		$vsProject.ProjectItems.AddFromFile($destFile)
	}
}


Write-Host "Type 'Import-Module .\PowerPack; Get-Help PowerPack' to get started."
