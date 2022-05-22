// Bohrium Unit Tests (.NET)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://gitlab.com/NexusKrop/Bohrium/-/blob/trunk/LICENSE

namespace NexusKrop.Borhium.Tests;
using NexusKrop.Bohrium.Resource;

[TestClass]
public class ResourceLocationTests
{
    [TestMethod]
    public void ValidValueTest()
    {
        try
        {
            _ = new ResourceLocation("bohrium", "tests/test1");
        }
        catch
        {
            Assert.Fail();
        }
    }

    [TestMethod]
    public void InvalidValueTest()
    {
        try
        {
            _ = new ResourceLocation("bohr@ium","tests/test2@@");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
            return;
        }

        Assert.Fail("Does not found invalid character");
    }

    [TestMethod]
    public void InvalidNamespaceTest()
    {
        try
        {
            _ = new ResourceLocation("bohr@ium", "tests/test3");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
            return;
        }

        Assert.Fail("Does not found invalid character in name-space");
    }

    [TestMethod]
    public void InvalidKeyTest()
    {
        try
        {
            _ = new ResourceLocation("bohrium", "tests/test4@@");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
            return;
        }

        Assert.Fail("Does not found invalid character in key");
    }
}