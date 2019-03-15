# Source Link Demo

## Demo Notes

See https://github.com/loic-sharma/SourceLinkDemo/tree/demo

## Setup Instructions

```ps1
dotnet pack
nuget push .\SourceLinkDemo.BadDependency\bin\Debug\SourceLinkDemo.BadDependency.1.0.1.nupkg -Source https://api.nuget.org/v3/index.json
nuget push .\SourceLinkDemo.GoodDependency\bin\Debug\SourceLinkDemo.GoodDependency.1.0.1.nupkg -Source https://api.nuget.org/v3/index.json
```