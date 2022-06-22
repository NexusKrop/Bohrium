namespace NexusKrop.Bohrium.Util;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Provides methods for unit conversions.
/// </summary>
public static class UnitConversions
{
    /// <summary>
    /// Gets the conversion rate of BAC - mg/DL (mg/100ml) in <see cref="double"/>.
    /// </summary>
    public static readonly double BacToMilligramsDouble = 1000d;
    /// <summary>
    /// Gets the conversion rate of BAC - mg/DL (mg/100ml) in <see cref="float"/>.
    /// </summary>
    public static readonly float BacToMilligramsSingle = 1000f;

    /// <summary>
    /// Converts the alcohol rate from Blood Alcohol Concentration ratio to mg/100ml in double-precision
    /// floating point number.
    /// </summary>
    /// <param name="bac">The alcohol rate in Blood Alcohol Concentration ratio.</param>
    /// <returns>The alcohol rate in mg/100ml.</returns>
    public static double BacToMilligrams(double bac)
    {
        return bac * BacToMilligramsDouble;
    }

    /// <summary>
    /// Converts the alcohol rate from Blood Alcohol Concentration ratio to mg/100ml in single-precision
    /// floating point number.
    /// </summary>
    /// <param name="bac">The alcohol rate in Blood Alcohol Concentration ratio.</param>
    /// <returns>The alcohol rate in mg/100ml.</returns>
    public static float BacToMilligrams(float bac)
    {
        return bac * BacToMilligramsSingle;
    }

    /// <summary>
    /// Converts the alcohol rate from mg/100ml to Blood Alcohol Concentration ratio in single-precision
    /// floating point number.
    /// </summary>
    /// <param name="mg">The alcohol rate in mg/100ml.</param>
    /// <returns>The alcohol rate in Blood Alcohol Concentration ratio.</returns>
    public static double MilligramsToBac(double mg)
    {
        return mg / BacToMilligramsDouble;
    }

    /// <summary>
    /// Converts the alcohol rate from mg/100ml to Blood Alcohol Concentration ratio in single-precision
    /// floating point number.
    /// </summary>
    /// <param name="mg">The alcohol rate in mg/100ml.</param>
    /// <returns>The alcohol rate in Blood Alcohol Concentration ratio.</returns>
    public static float MilligramsToBac(float mg)
    {
        return mg / BacToMilligramsSingle;
    }
}
