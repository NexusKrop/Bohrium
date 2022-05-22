// Bohrium for .NET
// (C) NexusKrop & contributors 2022. Licensed under Apache-2.0 licence.
// See https://gitlab.com/NexusKrop/Bohrium/-/blob/trunk/LICENSE

namespace NexusKrop.Bohrium;
using System.Diagnostics;

/// <summary>
/// Provides methods to manipulate and create processes.
/// </summary>
public static class ProcessUtil
{
    /// <summary>
    /// Opens the specified file via the default program associated with the type of such
    /// file. If such file is an executable, starts that executable. 
    /// </summary>
    /// <param name="fileName">The name (or path to) the file to open.</param>
    /// <returns><inheritdoc href="Process.Start(string)"/></returns>
    public static Process? Execute(string fileName)
    {
        var info = new ProcessStartInfo()
        {
            UseShellExecute = true,
            FileName = fileName
        };

        return Process.Start(info);
    }
}