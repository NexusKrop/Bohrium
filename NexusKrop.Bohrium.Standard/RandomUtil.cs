// Bohrium for .NET Standard (Mono/.NET Framework/.NET/...)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://github.com/NexusKrop/Bohrium/LICENSE

namespace NexusKrop.Bohrium;
using System;

/// <summary>
/// Provides methods for pseudo-random number generation.
/// </summary>
public static class RandomUtil
{
    private static readonly Random _random = new();

    /// <inheritdoc cref="Random.Next()"/>
    public static int GetInt()
    {
        return _random.Next();
    }

    /// <inheritdoc cref="Random.Next(int)"/>
    public static int GetInt(int maxValue)
    {
        return _random.Next(maxValue);
    }

    /// <inheritdoc cref="Random.Next(int, int)"/>
    public static int GetInt(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }
}
