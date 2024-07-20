namespace TJC.VersionExtensions;

public static class EquivalentVersionExtensions
{
    /// <summary>
    /// Check if Version Number is Equivalent to Zero.
    /// </summary>
    /// <param name="version"></param>
    /// <returns></returns>
    public static bool IsZero(this Version version) =>
        version.Equivalent(new Version(0, 0, 0, 0));

    /// <summary>
    /// Check if two versions are equivalent.
    /// </summary>
    /// <param name="version1"></param>
    /// <param name="version2"></param>
    /// <returns></returns>
    public static bool Equivalent(this Version version1, Version version2) =>
        VersionComponentEquivalent(version1.Major, version2.Major)
     && VersionComponentEquivalent(version1.Minor, version2.Minor)
     && VersionComponentEquivalent(version1.Build, version2.Build)
     && VersionComponentEquivalent(version1.Revision, version2.Revision);

    /// <summary>
    /// Allows for differing values so long as they are both either 0 or -1 (since -1 means the value wasn't defined)
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    private static bool VersionComponentEquivalent(int num1, int num2) =>
        num1 == num2
        || (num1 == -1 && num2 == 0)
        || (num1 == 0 && num2 == -1);
}