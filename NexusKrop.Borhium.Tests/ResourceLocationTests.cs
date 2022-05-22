// Bohrium Unit Tests (.NET)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://gitlab.com/NexusKrop/Bohrium/LICENSE

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

    [TestMethod]
    public void StringToLocationTest()
    {
        var rl = ResourceLocation.Parse("bohrium:tests/test5");
        Assert.AreEqual("bohrium", rl.Namespace);
        Assert.AreEqual("tests/test5", rl.Key);
    }

    [TestMethod]
    public void LocationToStringTest()
    {
        var str = new ResourceLocation("bohrium", "tests/test6").ToString();
        Assert.AreEqual("bohrium:tests/test6", str);
    }

    [TestMethod]
    public void LooseResourcePathTest()
    {
        var path = ResourceUtil.GetResourcePath(new ResourceLocation("bohrium", "tests/test7"));
        var verify = $"bohrium{Path.DirectorySeparatorChar}tests{Path.DirectorySeparatorChar}test7";

        Assert.AreEqual(verify, path);
    }

    [TestMethod]
    public void StrictResourcePathFunctionTest()
    {
        var path = ResourceUtil.GetResourcePathStrict(new ResourceLocation("bohrium", "tests/test8"));
        var verify = $"bohrium{Path.DirectorySeparatorChar}tests{Path.DirectorySeparatorChar}test8";

        Assert.AreEqual(verify, path);
    }

    [TestMethod]
    public void StrictResourcePathVerifyTest()
    {
        try
        {
            _ = ResourceUtil.GetResourcePathStrict(new ResourceLocation("bohrium", "tests.test9"));
        }
        catch (ArgumentException aex)
        {
            Console.WriteLine(aex);
            return;
        }
        Assert.Fail();
    }

    [TestMethod]
    public void LooseResourcePathFixTest()
    {
        var path = ResourceUtil.GetResourcePath(new ResourceLocation("bohrium", "tests.test10"));
        var verify = $"bohrium{Path.DirectorySeparatorChar}tests{Path.DirectorySeparatorChar}test10";

        Assert.AreEqual(verify, path);
    }

    [TestMethod]
    public void RecursePreventionTest()
    {
        try
        {
            _ = new ResourceLocation("bohrium", "tests/../test11");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
            return;
        }

        Assert.Fail("Does not found recurse");
    }
}