namespace TJC.VersionExtensions.Tests;

[TestClass]
public class IncrementVersionExtensionsTests
{
    private readonly Version _version = new(1, 2, 3, 4);

    [TestMethod]
    public void IncrementMajor_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMajor();
        Assert.AreEqual(2, newVersion.Major);
        Assert.AreEqual(0, newVersion.Minor);
        Assert.AreEqual(0, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementMinor_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.IncrementMinor();
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(3, newVersion.Minor);
        Assert.AreEqual(0, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementBuild_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.IncrementBuild();
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(2, newVersion.Minor);
        Assert.AreEqual(4, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementRevision_IncrementsRevisionOnly()
    {
        var newVersion = _version.IncrementRevision();
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(2, newVersion.Minor);
        Assert.AreEqual(3, newVersion.Build);
        Assert.AreEqual(5, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementMajorType_IncrementsMajorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Major);
        Assert.AreEqual(2, newVersion.Major);
        Assert.AreEqual(0, newVersion.Minor);
        Assert.AreEqual(0, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementMinorType_IncrementsMinorAndSetsTheFollowingToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Minor);
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(3, newVersion.Minor);
        Assert.AreEqual(0, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementBuildType_IncrementsBuildAndSetsRevisionToZero()
    {
        var newVersion = _version.Increment(VersionComponents.Build);
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(2, newVersion.Minor);
        Assert.AreEqual(4, newVersion.Build);
        Assert.AreEqual(0, newVersion.Revision);
    }

    [TestMethod]
    public void IncrementRevisionType_IncrementsRevisionOnly()
    {
        var newVersion = _version.Increment(VersionComponents.Revision);
        Assert.AreEqual(1, newVersion.Major);
        Assert.AreEqual(2, newVersion.Minor);
        Assert.AreEqual(3, newVersion.Build);
        Assert.AreEqual(5, newVersion.Revision);
    }
}