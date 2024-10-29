namespace TJC.VersionExtensions;

public static class IncrementVersionExtensions
{
    /// <summary>
    /// Increments the version build (a.k.a. patch), unless minor or major are specified instead.
    /// </summary>
    /// <param name="version">Version to Increment</param>
    /// <param name="component">Increment Type (default: <seealso cref="VersionComponents.Build"/></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static Version Increment(
        this Version version,
        VersionComponents component = VersionComponents.Build
    )
    {
        ArgumentNullException.ThrowIfNull(component, nameof(component));
        return component switch
        {
            VersionComponents.Major => version.IncrementMajor(),
            VersionComponents.Minor => version.IncrementMinor(),
            VersionComponents.Build => version.IncrementBuild(),
            VersionComponents.Revision => version.IncrementRevision(),
            _ => throw new ArgumentOutOfRangeException(nameof(component), component, null),
        };
    }

    /// <summary>
    /// Increments the major &amp; returns the new version.
    /// </summary>
    /// <param name="version"></param>
    /// <returns></returns>
    public static Version IncrementMajor(this Version version) => new(version.Major + 1, 0, 0, 0);

    /// <summary>
    /// Increments the minor &amp; returns the new version.
    /// </summary>
    /// <param name="version"></param>
    /// <returns></returns>
    public static Version IncrementMinor(this Version version) =>
        new(version.Major, version.Minor + 1, 0, 0);

    /// <summary>
    /// Increments the build (a.k.a. patch) &amp; returns the new version.
    /// </summary>
    /// <param name="version"></param>
    /// <returns></returns>
    public static Version IncrementBuild(this Version version) =>
        new(version.Major, version.Minor, version.Build + 1, 0);

    /// <summary>
    /// Increments the revision &amp; returns the new version.
    /// </summary>
    /// <param name="version"></param>
    /// <returns></returns>
    public static Version IncrementRevision(this Version version) =>
        new(version.Major, version.Minor, version.Build, version.Revision + 1);
}
