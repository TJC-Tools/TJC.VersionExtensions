namespace TJC.VersionExtensions.Tests;


[TestClass]
public class EquivalentVersionExtensionsTests
{
    #region Equivalent (True) 

    [TestMethod]
    public void Equivalent_AllDefinedSame_ReturnsTrue()
    {
        var version1 = new Version(1, 2, 3, 4);
        var version2 = new Version(1, 2, 3, 4);

        var result = version1.Equivalent(version2);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equivalent_MajorMinorBuildDefined_ReturnsTrue()
    {
        var version1 = new Version(1, 2, 3);
        var version2 = new Version(1, 2, 3, 0);

        var result = version1.Equivalent(version2);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equivalent_MajorMinorDefined_ReturnsTrue()
    {
        var version1 = new Version(1, 2);
        var version2 = new Version(1, 2, 0, 0);

        var result = version1.Equivalent(version2);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equivalent_NoneDefined_ReturnsTrue()
    {
        var version1 = new Version();
        var version2 = new Version(0, 0, 0, 0);

        var result = version1.Equivalent(version2);

        Assert.IsTrue(result);
    }

    #endregion

    #region Equivalent (False)

    [TestMethod]
    public void Equivalent_DifferentMajors_ReturnsFalse()
    {
        var version1 = new Version(1, 0, 0, 0);
        var version2 = new Version(2, 0, 0, 0);

        var result = version1.Equivalent(version2);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equivalent_DifferentMinors_ReturnsFalse()
    {
        var version1 = new Version(1, 2, 0, 0);
        var version2 = new Version(1, 3, 0, 0);

        var result = version1.Equivalent(version2);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equivalent_DifferentBuilds_ReturnsFalse()
    {
        var version1 = new Version(1, 2, 3, 0);
        var version2 = new Version(1, 2, 4, 0);

        var result = version1.Equivalent(version2);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equivalent_DifferentRevisions_ReturnsFalse()
    {
        var version1 = new Version(1, 2, 3, 4);
        var version2 = new Version(1, 2, 3, 5);

        var result = version1.Equivalent(version2);

        Assert.IsFalse(result);
    }

    #endregion

    #region Is Zero



    [TestMethod]
    public void IsZero_NoneDefined_ReturnsTrue()
    {
        var version = new Version();

        var result = version.IsZero();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsZero_MajorMinorDefined_ReturnsTrue()
    {
        var version = new Version(0, 0);

        var result = version.IsZero();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsZero_AllDefined_ReturnsTrue()
    {
        var version = new Version(0, 0, 0, 0);

        var result = version.IsZero();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsZero_NonZeroVersion_ReturnsFalse()
    {
        var version = new Version(0, 1, 0, 0);

        var result = version.IsZero();

        Assert.IsFalse(result);
    }

    #endregion
}