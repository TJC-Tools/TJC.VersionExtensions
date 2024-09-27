![GitHub Tag](https://img.shields.io/github/v/tag/TJC-Tools/TJC.VersionExtensions) [![NuGet Version](https://img.shields.io/nuget/v/TJC.VersionExtensions)](https://www.nuget.org/packages/TJC.VersionExtensions)

[![NuGet Downloads](https://img.shields.io/nuget/dt/TJC.VersionExtensions)](https://www.nuget.org/packages/TJC.VersionExtensions) ![Size](https://img.shields.io/github/repo-size/TJC-Tools/TJC.VersionExtensions) [![License](https://img.shields.io/github/license/TJC-Tools/TJC.VersionExtensions.svg)](LICENSE)

## Table of Contents
- [Increments](#increments)
- [Comparisons](#comparisons)

---

## Increments

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[Increment](./TJC.VersionExtensions/IncrementVersionExtensions.cs)([VersionComponents](./TJC.VersionExtensions/Enums/VersionComponents.cs))
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the specified [component](./TJC.VersionExtensions/Enums/VersionComponents.cs) **incremented by 1**, and the *following* components **reset to 0**

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementMajor()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **major** component **incremented by 1**, and the rest **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementMajor();
// incrementedVersion == new Version(2, 0, 0, 0)
```

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementMinor()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **minor** component **incremented by 1**, and the build & revision **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementMinor();
// incrementedVersion == new Version(1, 3, 0, 0)
```

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementBuild()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **build** component **incremented by 1**, and the revision **reset to 0**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementBuild();
// incrementedVersion == new Version(1, 2, 4, 0)
```

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IncrementRevision()](./TJC.VersionExtensions/IncrementVersionExtensions.cs)
- Returns a new [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version) with the **revision** component **incremented by 1**
```c#
var version = new Version(1, 2, 3, 4);
var incrementedVersion = version.IncrementRevision();
// incrementedVersion == new Version(1, 2, 3, 5)
```

---

## Comparisons

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[Equivalent](./TJC.VersionExtensions/EquivalentVersionExtensions.cs)([Version](https://learn.microsoft.com/en-us/dotnet/api/system.version))
- Returns `true` if the components are equivalent (if *undefined*, they are considered equivalent to `0`), `false` otherwise
```c#
var version = new Version(1, 0, 0, 0);
var other = new Version(1);
var result = version.Equivalent(other);
// result == true
```

### [Version](https://learn.microsoft.com/en-us/dotnet/api/system.version).[IsZero()](./TJC.VersionExtensions/EquivalentVersionExtensions.cs)
- Returns `true` if the components are equivalent (if *undefined*, they are considered equivalent to `0`), `false` otherwise
```c#
var zero = new Version(0, 0, 0, 0);
var undefined = new Version();
var result1 = zero.IsZero();
var result2 = undefined.IsZero();
// result1 == true
// result2 == true
```
