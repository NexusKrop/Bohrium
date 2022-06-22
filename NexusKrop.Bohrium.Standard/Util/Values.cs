namespace NexusKrop.Bohrium.Util;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Provides methods to validate values.
/// </summary>
public static class Values
{
    #region NotNegative
    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static float NotNegative(float input)
    {
        if (input < 0f) throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <param name="paramName">The name of the parameter.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static float NotNegative(float input, string paramName)
    {
        if (input < 0f) throw new ArgumentOutOfRangeException(paramName);
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static double NotNegative(double input)
    {
        if (input < 0d) throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <param name="paramName">The name of the parameter.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static double NotNegative(double input, string paramName)
    {
        if (input < 0d) throw new ArgumentOutOfRangeException(paramName);
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static int NotNegative(int input)
    {
        if (input < 0) throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <param name="paramName">The name of the parameter.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static int NotNegative(int input, string paramName)
    {
        if (input < 0) throw new ArgumentOutOfRangeException(paramName);
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static short NotNegative(short input)
    {
        if (input < 0) throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <param name="paramName">The name of the parameter.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static short NotNegative(short input, string paramName)
    {
        if (input < 0) throw new ArgumentOutOfRangeException(paramName);
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static long NotNegative(long input)
    {
        if (input < 0L) throw new ArgumentOutOfRangeException(nameof(input));
        return input;
    }

    /// <summary>
    /// Ensures the specified number is not negative.
    /// </summary>
    /// <param name="input">The input number.</param>
    /// <param name="paramName">The name of the parameter.</param>
    /// <returns>The input number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The input is negative.</exception>
    public static long NotNegative(long input, string paramName)
    {
        if (input < 0L) throw new ArgumentOutOfRangeException(paramName);
        return input;
    }
    #endregion
}
