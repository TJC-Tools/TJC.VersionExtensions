# NuGet Package Template
This repository is a template for **Public C# Libraries** that will be published as **NuGet Packages**.

## Setup
1. Clone the repository
2. Open `Testing.sln` & create `LibraryName/TJC.LibraryName.csproj` & `LibraryName.Tests/TJC.LibraryName.Tests.csproj`
3. Set **NuGet Package** settings in the `.csproj`, such as `RepositoryUrl`, `PackageReadmeFile`, `Title`, `Description` & `Author`
4. Add the `InternalsVisibleToAttribute` to the **project** `.csproj`, so that the **tests** `.csproj` can see `internal` **classes**, **methods** & **properties**
```xml
	<ItemGroup>
		<AssemblyAttribute Include="System.Runtime.CompilerServices.InternalsVisibleToAttribute">
			<_Parameter1>TJC.LibraryName.Tests</_Parameter1>
		</AssemblyAttribute>
	</ItemGroup>
```
5. Copy `Nuget.config` into the `LibraryName` directory
6. In `workflows` replace the `{REPLACE_ME}` placeholders
7. Replace this `README.md` with something relevant to the library
8. Amend the initial commit & force push the changes
9. ~~Set `GitHub NuGet Package` visibility to `public`~~
10. **Repository Settings**
  - Import repository permissions from [ruleset](.github/ruleset.json) & **delete** it
  - **Pull Requests**
    - Disable `Allow merge commits`
    - Enable `Always suggest updating pull request branches`
    - Enable `Automatically delete head branches`
11. Add **badges** to `README.md` (if applicable)
  - `[![NuGet Version and Downloads count](https://buildstats.info/nuget/TJC.LibraryName)](https://www.nuget.org/packages/TJC.LibraryName)`
