namespace NexusKrop.Borhium.Tests;

using NexusKrop.Bohrium.Util;

[TestClass]
public class UnitConversionTests
{
    [TestMethod]
    public void BacToMilliTest()
    {
        Assert.AreEqual(80, UnitConversions.BacToMilligrams(0.08));
        Assert.AreEqual(80f, UnitConversions.BacToMilligrams(0.08f));
    }

    [TestMethod]
    public void MilliToBacTest()
    {
        Assert.AreEqual(0.08, UnitConversions.MilligramsToBac(80d));
        Assert.AreEqual(0.08f, UnitConversions.MilligramsToBac(80f));
    }
}
