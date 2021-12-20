﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Reloaded.Mod.Loader.Update.Interfaces;

/// <summary>
/// Represents an individual package provider which delivers downloadable packages to the user.
/// </summary>
public interface IDownloadablePackageProvider
{
    /// <summary>
    /// Searches for packages matching a given term.
    /// </summary>
    public Task<List<IDownloadablePackage>> SearchAsync(string text, CancellationToken token = default);
}