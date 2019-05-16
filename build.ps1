pushd $scriptroot -v
choco install nuget.commandline -y
nuget restore  "C#\WebApiHelpPageGenerator.sln"
msbuild
nuget pack WebApiHelpPageGenerator.nuspec  -basepath "C#\WebApiHelpPageGenerator\bin\Debug" 