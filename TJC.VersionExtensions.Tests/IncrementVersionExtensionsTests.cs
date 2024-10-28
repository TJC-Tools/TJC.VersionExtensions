namespace TJC.VersionExtensions.Tests;

[TestClass]
public class IncrementVersionExtensionsTests
{
    private readonly Version _version = new(1, 2, 3, 4);

    [TestMethod]
    public void IncrementMajor_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMajor();
        AssertVersion(newVersion, 2, 0, 0, 0);
    }

    [TestMethod]
    public void IncrementMinor_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMinor();
        AssertVersion(newVersion, 1, 3, 0, 0);
    }

    [TestMethod]
    public void IncrementBuild_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.IncrementBuild();
        AssertVersion(newVersion, 1, 2, 4, 0);
    }

    [TestMethod]
    public void IncrementRevision_IncrementsRevisionOnly()
    {
        var newVersion = _version.IncrementRevision();
        AssertVersion(newVersion, 1, 2, 3, 5);
    }

    [TestMethod]
    public void IncrementMajorType_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Major);
        AssertVersion(newVersion, 2, 0, 0, 0);
    }

    [TestMethod]
    public void IncrementMinorType_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Minor);
        AssertVersion(newVersion, 1, 3, 0, 0);
    }

    [TestMethod]
    public void IncrementBuildType_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Build);
        AssertVersion(newVersion, 1, 2, 4, 0);
    }

    [TestMethod]
    public void IncrementRevisionType_IncrementsRevisionOnly()
    {
        var newVersion = _version.Increment(VersionComponents.Revision);
        AssertVersion(newVersion, 1, 2, 3, 5);
    }

    private void AssertVersion(Version version, int major, int minor, int build, int revision)
    {
        Assert.AreEqual(major, version.Major);
        Assert.AreEqual(minor, version.Minor);
        Assert.AreEqual(build, version.Build);
        Assert.AreEqual(revision, version.Revision);
    }
}
