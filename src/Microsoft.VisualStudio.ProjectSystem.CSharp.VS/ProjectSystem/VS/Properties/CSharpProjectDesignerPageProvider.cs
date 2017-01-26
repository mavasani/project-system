// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Properties
{
    /// <summary>
    ///     Provides project designer property pages.
    /// </summary>
    [Export(typeof(IVsProjectDesignerPageProvider))]
    [AppliesTo(ProjectCapability.CSharp)]
    internal class CSharpProjectDesignerPageProvider : AbstractProjectDesignerPageProvider
    {
        [ImportingConstructor]
        internal CSharpProjectDesignerPageProvider(IProjectThreadingService threadingService, SVsServiceProvider serviceProvider, IProjectCapabilitiesService capabilities)
            : base (threadingService, serviceProvider, capabilities)
        {
        }

        public async override Task<IReadOnlyCollection<IPageMetadata>> GetPagesAsync()
        {
            var builder = ImmutableArray.CreateBuilder<IPageMetadata>();

            builder.Add(CSharpProjectDesignerPage.Application);
            builder.Add(CSharpProjectDesignerPage.Build);
            builder.Add(CSharpProjectDesignerPage.BuildEvents);

            if (IsPackEnabled)
            {
                builder.Add(CSharpProjectDesignerPage.Package);
            }

            builder.Add(CSharpProjectDesignerPage.Debug);
            builder.Add(CSharpProjectDesignerPage.ReferencePaths);
            builder.Add(CSharpProjectDesignerPage.Signing);

            if (await IsCodeAnalysisEnabledAsync().ConfigureAwait(false))
            {
                builder.Add(CSharpProjectDesignerPage.CodeAnalysis);
            }

            return builder.ToImmutable();
        }
    }
}
