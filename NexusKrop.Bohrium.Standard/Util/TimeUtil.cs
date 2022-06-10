namespace NexusKrop.Bohrium.Util;
using System;

/// <summary>
/// Provides utilities to manipulate date and time.
/// </summary>
public static class TimeUtil
{
    public static readonly DateTime UnixEpoch = new(1970, 1, 1, 0, 0, 0);

    /// <summary>
    /// Converts the Unix-epoch based time to the .NET time system.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <returns>An instance of <see cref="DateTime"/> representing the <paramref name="source"/> as .NET time.</returns>
    public static DateTime FromEpochTime(long source)
    {
        return UnixEpoch.AddMilliseconds(source);
    }
}
