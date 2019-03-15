# Source Link Demo

## Demo Notes

Before running the demo, ensure that:

1. NuGet Symbol Server has been added `https://symbols.nuget.org/download/symbols`.
2. Show that "Just My Code" is disabled for debugging

Demo:

1. Run the "bad" demo
    1. Ask if people can see the input
    2. Type in the inputs "1" and "2", show the result of "3"
    3. Type in the inputs "5" and "1", show the generic error message
    4. Do a quick intro of the code
        1. Show that the demo depends on "GoodDependency" and "BadDependency"
        2. Show that the code loops, asks for two inputs, and passes that off to dependencys
        3. Show that on exception, message is logged
    5. Add a break point
    6. Step through the code, show that the dependency's code is skipped, goes straight to catch clause
2. Run the "good" demo
    1. Remove the break point
    2. Type in the inputs "1" and "2", show the result of "3"
    3. Type in the inputs "5" and "1", show the generic error message.
    4. Re-add the break point
    5. Type in the inputs "5" and "1" again
    6. Step through the code until Source Link popup
    7. Explain Source Link
        1. This package has snupkg symbols package
        2. This package is source linked
        3. The debugger has loaded the symbols from NuGet's symbol server
        4. The debugger is now asking to load the package's source files
    8. Step through the dependency, find the bug! \o/

## Setup Instructions

```ps1
dotnet pack
nuget push .\SourceLinkDemo.BadDependency\bin\Debug\SourceLinkDemo.BadDependency.1.0.1.nupkg -Source https://api.nuget.org/v3/index.json
nuget push .\SourceLinkDemo.GoodDependency\bin\Debug\SourceLinkDemo.GoodDependency.1.0.1.nupkg -Source https://api.nuget.org/v3/index.json
```