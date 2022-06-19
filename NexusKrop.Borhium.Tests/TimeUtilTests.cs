namespace NexusKrop.Borhium.Tests;

using NexusKrop.Bohrium.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class TimeUtilTests
{
    [TestMethod]
    public void FromUnixEpochTimeTest()
    {
        const long fromTime = 1655583368L;
        var dateTime = new DateTime(2022, 06, 19, 04, 16, 08);

        var actual = TimeUtil.FromEpochTime(fromTime);
        Console.WriteLine(actual);
        Assert.AreEqual(dateTime, actual);
    }

    [TestMethod]
    public void ToUnixEpochTimeTest()
    {
        const long epochTime = 1655583368L;
        var dateTime = new DateTime(2022, 06, 19, 04, 16, 08);

        var actual = TimeUtil.ToEpochTime(dateTime);
        Console.WriteLine(actual);
        Assert.AreEqual(epochTime, actual);
    }
}
