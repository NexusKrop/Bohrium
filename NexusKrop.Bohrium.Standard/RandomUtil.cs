namespace NexusKrop.Borhium;
using System;

/// <summary>
/// Provides methods for pseudo-random number generation.
/// </summary>
public static class RandomUtil
{
    private static readonly Random _random = new();

    /// <inheritdoc cref="Random.Next"/>
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
