﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;

namespace Microsoft.VisualStudio.ProjectSystem.Properties
{
    /// <summary>
    /// Exports a <see cref="IInterceptingPropertyValueProvider"/> extension to CPS.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    internal sealed class ExportInterceptingPropertyValueProviderAttribute : ExportAttribute
    {
        public string PropertyName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportInterceptingPropertyValueProviderAttribute"/> class.
        /// </summary>
        public ExportInterceptingPropertyValueProviderAttribute(string propertyName, ExportInterceptingPropertyValueProviderFile file)
            : base(GetFile(file), typeof(IInterceptingPropertyValueProvider))
        {
            Requires.NotNullOrEmpty(propertyName, nameof(propertyName));

            PropertyName = propertyName;
        }

        private static string GetFile(ExportInterceptingPropertyValueProviderFile file)
        {
            switch (file)
            {
                case ExportInterceptingPropertyValueProviderFile.ProjectFile:
                    return ContractNames.ProjectPropertyProviders.ProjectFile;
                case ExportInterceptingPropertyValueProviderFile.UserFile:
                    return ContractNames.ProjectPropertyProviders.UserFile;
                case ExportInterceptingPropertyValueProviderFile.UserFileWithXamlDefaults:
                    return ContractNames.ProjectPropertyProviders.UserFileWithXamlDefaults;
                default:
                    return string.Empty;
            }
        }
    }

    internal enum ExportInterceptingPropertyValueProviderFile
    {
        ProjectFile,
        UserFile,
        UserFileWithXamlDefaults
    }
}
