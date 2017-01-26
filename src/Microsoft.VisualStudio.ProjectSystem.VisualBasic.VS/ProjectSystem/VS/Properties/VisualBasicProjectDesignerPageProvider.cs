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
    [AppliesTo(ProjectCapability.VisualBasic)]
    internal class VisualBasicProjectDesignerPageProvider : AbstractProjectDesignerPageProvider
    {
        [ImportingConstructor]
        internal VisualBasicProjectDesignerPageProvider(IProjectThreadingService threadingService, SVsServiceProvider serviceProvider, IProjectCapabilitiesService capabilities)
            : base(threadingService, serviceProvider, capabilities)
        {
        }

        public async override Task<IReadOnlyCollection<IPageMetadata>> GetPagesAsync()
        {
            var builder = ImmutableArray.CreateBuilder<IPageMetadata>();
            builder.Add(VisualBasicProjectDesignerPage.Application);

            if (IsPackEnabled)
            {
                builder.Add(VisualBasicProjectDesignerPage.Package);
            }

            builder.Add(VisualBasicProjectDesignerPage.References);
            builder.Add(VisualBasicProjectDesignerPage.Debug);

            if (await IsCodeAnalysisEnabledAsync().ConfigureAwait(false))
            {
                builder.Add(VisualBasicProjectDesignerPage.CodeAnalysis);
            }

            return builder.ToImmutable();
        }
    }
}
