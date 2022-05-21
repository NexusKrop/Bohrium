// (C) NexusKrop & contributors. 2022.
// Licensed under Apache-2.0 license;
// see https://codeberg.org/NexusKrop/Bohrium/src/branch/trunk/LICENSE.

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

    private static readonly Regex namespaceRegex = new("^[a-z0-9_.-]+$");
    private static readonly Regex keyRegex = new("^[a-z0-9_.-/]+$");

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

    private static void VerifyNamespace(string ns)
    {
        if (!namespaceRegex.IsMatch(ns))
        {
            throw new FormatException($"Invalid resource location name-space: {ns}");
        }
    }

    private static void VerifyKey(string key)
    {
        if (!keyRegex.IsMatch(key))
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

    public string Namespace
    {
        get => _ns;
        set
        {
            VerifyNamespace(value);
            _ns = value;
        }
    }
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