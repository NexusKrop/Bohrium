// (C) NexusKrop & contributors. 2022.
// Licensed under Apache-2.0 license;
// see https://codeberg.org/NexusKrop/Bohrium/src/branch/trunk/LICENSE.

namespace NexusKrop.Bohrium.Util;

using System;

/// <summary>
/// Provides utilities to check, manipulate and monitor objects.
/// </summary>
public static class Objects
{
    /// <summary>
    /// Requires an argument not <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T">The type of the <paramref name="arg"/>.</typeparam>
    /// <param name="arg">The argument.</param>
    /// <param name="name">The name of the <paramref name="arg"/> in the calling method/</param>
    /// <returns>The value in <paramref name="arg"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="arg"/> was null.</exception>
    public static T RequiresArgNonNull<T>(T arg, string name)
    {
        if (arg == null)
        {
            throw new ArgumentNullException(name);
        }

        return arg;
    }
}