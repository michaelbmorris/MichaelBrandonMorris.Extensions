del *.nupkg
nuget pack *.csproj
nuget push *.nupkg -source https://www.nuget.org/api/v2/package