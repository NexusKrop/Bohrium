namespace NexusKrop.Borhium.Tests;
using NexusKrop.Bohrium.Util;

[TestClass]
public class StringExtensionTests
{
    public const string ExceptedSnakeCaseResult = "snake_case_test";

    [TestMethod]
    public void PascalToSnakeTest()
    {
        Assert.AreEqual(ExceptedSnakeCaseResult, "SnakeCaseTest".ToSnakeCase());
    }

    [TestMethod]
    public void CamelToSnakeTest()
    {
        Assert.AreEqual(ExceptedSnakeCaseResult, "snakeCaseTest".ToSnakeCase());
    }
}
