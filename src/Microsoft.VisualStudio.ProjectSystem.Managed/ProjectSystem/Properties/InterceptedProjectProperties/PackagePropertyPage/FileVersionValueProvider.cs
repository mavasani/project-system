﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.ProjectSystem.Properties.Package
{
    [ExportInterceptingPropertyValueProvider(FileVersionPropertyName, ExportInterceptingPropertyValueProviderFile.ProjectFile)]
    internal sealed class FileVersionValueProvider : BaseVersionValueProvider
    {
        private const string FileVersionPropertyName = "FileVersion";
        private static readonly Version s_DefaultFileVersion = new Version(1, 0, 0, 0);

        protected override string PropertyName => FileVersionPropertyName;

        protected async override Task<Version> GetDefaultVersionAsync(IProjectProperties defaultProperties)
        {
            // Default semantic/package version just has 3 fields, we need to append an additional Revision field with value "0".
            var defaultVersion = await base.GetDefaultVersionAsync(defaultProperties).ConfigureAwait(true);
            if (ReferenceEquals(defaultVersion, s_DefaultVersion))
            {
                return s_DefaultFileVersion;
            }

            return new Version(defaultVersion.Major, defaultVersion.Minor, defaultVersion.Build, revision: 0);
        }
    }
}
