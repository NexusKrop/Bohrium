// Bohrium Unit Tests (.NET)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://github.com/NexusKrop/Bohrium/LICENSE

namespace NexusKrop.Borhium.Tests;
using NexusKrop.Bohrium.Util;
using System;

[TestClass]
public class ObjectsTest
{
    [TestMethod]
    public void RequiresNonNullArgTest()
    {
        try
        {
            _ = Objects.RequiresArgNonNull<object>(null!, "test");
        }
        catch (ArgumentNullException anex)
        {
            Console.WriteLine("Success: {0}", anex);
            return;
        }

        Assert.Fail("No exception thrown");
    }

    [TestMethod]
    public void RequiresNonNullArgPassTest()
    {
        try
        {
            _ = Objects.RequiresArgNonNull("hah", "test");
        }
        catch (ArgumentNullException anex)
        {
            Console.WriteLine(anex);
            Assert.Fail("exception thrown after non-null");
        }
    }
}
