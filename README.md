<a href="https://github.com/TJC-Tools/TJC.VersionExtensions/tags">
  <img alt="GitHub Tag" src="https://img.shields.io/github/v/tag/TJC-Tools/TJC.VersionExtensions?style=for-the-badge&logo=tag&logoColor=white&labelColor=24292f&color=blue" />
</a>

<a href="https://github.com/TJC-Tools/TJC.VersionExtensions/releases/latest">
  <img alt="GitHub Release" src="https://img.shields.io/github/v/release/TJC-Tools/TJC.VersionExtensions?style=for-the-badge&logo=starship&logoColor=D9E0EE&labelColor=302D41&&color=green&include_prerelease&sort=semver" />
</a>

<a href="https://www.nuget.org/packages/TJC.VersionExtensions">
  <img alt="NuGet Version" src="https://img.shields.io/nuget/v/TJC.VersionExtensions?style=for-the-badge&logo=nuget&logoColor=white&labelColor=004880&color=blue" />
</a>

<br/>

<a href="https://www.nuget.org/packages/TJC.VersionExtensions">
  <img alt="NuGet Downloads" src="https://img.shields.io/nuget/dt/TJC.VersionExtensions?style=for-the-badge&logo=nuget&logoColor=white&labelColor=004880&color=yellow" />
</a>

<a href="https://github.com/TJC-Tools/TJC.VersionExtensions">
  <img alt="Repository Size" src="https://img.shields.io/github/repo-size/TJC-Tools/TJC.VersionExtensions?style=for-the-badge&logo=files&logoColor=white&labelColor=24292f&color=orange" />
</a>

<br/>

<a href="https://www.nuget.org/packages/TJC.VersionExtensions">
  <img alt="Last commit" src="https://img.shields.io/github/last-commit/TJC-Tools/TJC.VersionExtensions?style=for-the-badge&logo=git&logoColor=D9E0EE&labelColor=302D41&color=mediumpurple"/>
</a>

<a href="LICENSE">
  <img alt="License" src="https://img.shields.io/github/license/TJC-Tools/TJC.VersionExtensions.svg?style=for-the-badge&logo=balance-scale&logoColor=white&labelColor=333333&color=blueviolet" />
</a>

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
