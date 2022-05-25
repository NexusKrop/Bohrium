// Bohrium for .NET Standard (Mono/.NET Framework/.NET/...)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://github.com/NexusKrop/Bohrium/LICENSE

namespace NexusKrop.Bohrium.Util;
using System.Linq;

/// <summary>
/// Provides methods to manipulate strings.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Converts a <c>PascalCase</c> or <c>camelCase</c> string to a snake case string.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <returns>The converted string.</returns>
    public static string ToSnakeCase(this string str)
    {
        return string.Concat(
            str.Select(
                (x, i) => i > 0 && char.IsUpper(x)
                    ? "_" + x
                    : x.ToString()
                    )
            ).ToLower();
    }
}
