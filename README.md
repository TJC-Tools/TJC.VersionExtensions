[![NuGet Version and Downloads count](https://buildstats.info/nuget/TJC.VersionExtensions)](https://www.nuget.org/packages/TJC.VersionExtensions)

## [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[Increment](./TJC.VersionExtensions/IncrementVersionExtensions.cs)([VersionComponents](./TJC.VersionExtensions/Enums/VersionComponents.cs) component)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the specified [component](./TJC.VersionExtensions/Enums/VersionComponents.cs) **incremented by 1**, and the *following* components **reset to 0**

## [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementMajor()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **major** component **incremented by 1**, and the rest **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementMajor();
// incrementedVersion == new Version(2, 0, 0, 0)
```

## [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementMinor()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **minor** component **incremented by 1**, and the build & revision **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementMinor();
// incrementedVersion == new Version(1, 3, 0, 0)
```

## [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementBuild()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **build** component **incremented by 1**, and the revision **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementBuild();
// incrementedVersion == new Version(1, 2, 4, 0)
```

## [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementRevision()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **revision** component **incremented by 1**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementRevision();
// incrementedVersion == new Version(1, 2, 3, 5)
```
