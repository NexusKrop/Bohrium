// Bohrium for .NET Standard (Mono/.NET Framework/.NET/...)
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://github.com/NexusKrop/Bohrium/LICENSE

namespace NexusKrop.Bohrium.Resource;
using System;
using System.Text.RegularExpressions;
using NexusKrop.Bohrium.Util;

/// <summary>
/// Represents a resource location.
/// </summary>
public class ResourceLocation
{
    private string _ns;
    private string _key;

    /// <summary>
    /// Gets a regular expression to verify namespace of a resource location identifier.
    /// </summary>
    public static readonly Regex NamespaceVerifyPattern = new("^[a-z0-9_.-]+$");

    /// <summary>
    /// Gets a regular expression to verify key of a resource location identifier.
    /// </summary>
    public static readonly Regex KeyVerifyPattern = new("^[a-z0-9_.-/]+$");

    /// <summary>
    /// Initialises a new instance of the <see cref="ResourceLocation"/> class.
    /// </summary>
    /// <param name="ns"></param>
    /// <param name="key"></param>
    public ResourceLocation(string ns, string key)
    {
        Namespace = Objects.RequiresArgNonNull(ns, nameof(ns));
        Key = Objects.RequiresArgNonNull(key, nameof(key));
    }

    /// <summary>
    /// Converts a string representation of resource location to an instance representation of it.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>An instance of <see cref="ResourceLocation"/></returns>
    /// <exception cref="ArgumentException">The string representation was invalid.</exception>
    public static ResourceLocation Parse(string str)
    {
        if (!str.Contains(":")) throw new ArgumentException("Namespace or key not specified.", nameof(str));
        var splitted = str.Split(':');

        if (splitted.Length != 2)
        {
            throw new ArgumentException("Invalid resource location format.", nameof(str));
        }

        if (!NamespaceVerifyPattern.IsMatch(splitted[0]) || !KeyVerifyPattern.IsMatch(splitted[1]))
        {
            throw new ArgumentException("Invalid key or namespace format for resource location.", nameof(str));
        }

        return new ResourceLocation(splitted[0], splitted[1]);
    }

    private static void VerifyNamespace(string ns)
    {
        if (!NamespaceVerifyPattern.IsMatch(ns))
        {
            throw new FormatException($"Invalid resource location name-space: {ns}");
        }
    }

    private static void VerifyKey(string key)
    {
        if (!KeyVerifyPattern.IsMatch(key) || key.Contains(".."))
        {
            throw new FormatException($"Invalid resource location key: {key}");
        }
    }

    /// <summary>
    /// Returns the string representation of this resource location identifier.
    /// </summary>
    /// <remarks>
    /// String representations of resource location identifiers looks like <c>namespace:key</c>.
    /// </remarks>
    /// <returns>The string representation of this resource location identifier.</returns>
    public override string ToString()
    {
        return $"{Namespace}:{Key}";
    }

    /// <summary>
    /// Gets or sets the namespace of this instance.
    /// </summary>
    public string Namespace
    {
        get => _ns;
        set
        {
            VerifyNamespace(value);
            _ns = value;
        }
    }

    /// <summary>
    /// Gets or sets the key of this instance.
    /// </summary>
    public string Key
    {
        get => _key;
        set
        {
            VerifyKey(value);
            _key = value;
        }
    }
}