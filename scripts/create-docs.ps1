param([string]$SolutionDir = "..\..", [string]$ConfigurationName = "Release")

if ($ConfigurationName -eq "Release") {
    defaultdocumentation -j $SolutionDir\docs\api.json $SolutionDir\docs\api.xml
}