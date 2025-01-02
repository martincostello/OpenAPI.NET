﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi.Interfaces
{
    /// <summary>
    /// Interface for service that translates a URI into a stream that can be loaded by a Reader
    /// </summary>
    public interface IStreamLoader
    {
        /// <summary>
        /// Use Uri to locate data and convert into an input object.
        /// </summary>
        /// <param name="uri">Identifier of some source of an OpenAPI Description</param>
        /// <returns>A data object that can be processed by a reader to generate an <see cref="OpenApiDocument"/></returns>
        Task<Stream> LoadAsync(Uri uri);
    }
}
