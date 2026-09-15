namespace TJC.VersionExtensions.Tests;


public class IncrementVersionExtensionsTests
{
    private readonly Version _version = new(1, 2, 3, 4);

    [Fact]
    public void IncrementMajor_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMajor();
        AssertVersion(newVersion, 2, 0, 0, 0);
    }

    [Fact]
    public void IncrementMinor_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMinor();
        AssertVersion(newVersion, 1, 3, 0, 0);
    }

    [Fact]
    public void IncrementBuild_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.IncrementBuild();
        AssertVersion(newVersion, 1, 2, 4, 0);
    }

    [Fact]
    public void IncrementRevision_IncrementsRevisionOnly()
    {
        var newVersion = _version.IncrementRevision();
        AssertVersion(newVersion, 1, 2, 3, 5);
    }

    [Fact]
    public void IncrementMajorType_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Major);
        AssertVersion(newVersion, 2, 0, 0, 0);
    }

    [Fact]
    public void IncrementMinorType_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Minor);
        AssertVersion(newVersion, 1, 3, 0, 0);
    }

    [Fact]
    public void IncrementBuildType_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Build);
        AssertVersion(newVersion, 1, 2, 4, 0);
    }

    [Fact]
    public void IncrementRevisionType_IncrementsRevisionOnly()
    {
        var newVersion = _version.Increment(VersionComponents.Revision);
        AssertVersion(newVersion, 1, 2, 3, 5);
    }

    [Fact]
    public void Increment_UnsupportedComponent_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _version.Increment((VersionComponents)99));
    }

    private static void AssertVersion(
        Version version,
        int major,
        int minor,
        int build,
        int revision
    )
    {
        Assert.Equal(major, version.Major);
        Assert.Equal(minor, version.Minor);
        Assert.Equal(build, version.Build);
        Assert.Equal(revision, version.Revision);
    }
}
