// Bohrium for .NET Standard (Mono/.NET Framework/.NET/...)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://gitlab.com/NexusKrop/Bohrium/-/blob/trunk/LICENSE

namespace NexusKrop.Bohrium.Resource;
using System;
using System.IO;
using System.Text;

/// <summary>
/// Provides utilities to manipulate and acquire external resource files based on
/// namespace and <see cref="ResourceLocation"/>.
/// </summary>
public static class ResourceUtil
{
    /// <summary>
    /// Gets the raw resource path from a <see cref="ResourceLocation"/>.
    /// Dots (<c>.</c>) are automatically converted to <see cref="Path.DirectorySeparatorChar"/>.
    /// </summary>
    /// <param name="location">The resource location instance.</param>
    /// <remarks>
    /// This method simply replaces dots with <see cref="Path.DirectorySeparatorChar"/>. In some
    /// cases where dots should not be allowed, use <see cref="GetResourcePathStrict(ResourceLocation)"/>.
    /// </remarks>
    /// <returns>The raw resource path from a <see cref="ResourceLocation"/> instance.</returns>
    public static string GetResourcePath(ResourceLocation location)
    {
        var builder = new StringBuilder();
        builder.Append(location.Namespace).Append(Path.DirectorySeparatorChar);
        var key = location.Key.Replace('.', Path.DirectorySeparatorChar);

        if (Path.DirectorySeparatorChar != '/')
        {
            key = key.Replace('/', Path.DirectorySeparatorChar);
        }

        builder.Append(key);

        return builder.ToString();
    }

    /// <summary>
    /// Gets the raw resource path from a <see cref="ResourceLocation"/>.
    /// </summary>
    /// <param name="location">The resource location instance.</param>
    /// <returns>The raw resource path from a <see cref="ResourceLocation"/> instance.</returns>
    /// <remarks>
    /// This method do not allow dots in resource location. If you need to convert dots to
    /// directory separators, use <see cref="GetResourcePath(ResourceLocation)"/>, or an
    /// <see cref="ArgumentException"/> will be thrown if dots found in <paramref name="location"/>.
    /// </remarks>
    /// <exception cref="ArgumentException">Dots found in the key of <paramref name="location"/>.</exception>
    public static string GetResourcePathStrict(ResourceLocation location)
    {
        if (location.Key.Contains("."))
        {
            throw new ArgumentException("Dots not allowed in key", nameof(location));
        }
        var builder = new StringBuilder();
        builder.Append(location.Namespace).Append(Path.DirectorySeparatorChar);

        var key = location.Key.Replace('.', Path.DirectorySeparatorChar);
        if (Path.DirectorySeparatorChar != '/')
        {
            key = key.Replace('/', Path.DirectorySeparatorChar);
        }

        builder.Append(key);

        return builder.ToString();
    }
}
