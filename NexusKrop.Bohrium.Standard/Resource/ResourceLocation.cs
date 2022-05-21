// (C) NexusKrop & contributors. 2022.
// Licensed under Apache-2.0 license;
// see https://codeberg.org/NexusKrop/Bohrium/src/branch/trunk/LICENSE.

namespace NexusKrop.Bohrium.Resource;
using System;
using System.Text.RegularExpressions;
using NexusKrop.Bohrium.Util;

public class ResourceLocation
{
    private string _ns;
    private string _key;

    private static readonly Regex namespaceRegex = new Regex("^[a-z0-9_.-]+$");
    private static readonly Regex keyRegex = new Regex("^[a-z0-9_.-/]+$");

    public ResourceLocation(string ns, string key)
    {
        Namespace = Objects.RequiresArgNonNull(ns, nameof(ns));
        Key = Objects.RequiresArgNonNull(key, nameof(key));
    }

    private static void VerifyNamespace(string ns)
    {
        if (!namespaceRegex.IsMatch(ns))
        {
            throw new FormatException($"Invalid resource location namespace: {ns}");
        }
    }

    private static void VerifyKey(string key)
    {
        if (!keyRegex.IsMatch(key))
        {
            throw new FormatException($"Invalid resource location key: {key}");
        }
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
    public string Key { get; set; }
}