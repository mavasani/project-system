// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Packaging;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Properties
{
    internal abstract class AbstractProjectDesignerPageProvider : IVsProjectDesignerPageProvider
    {
        private readonly IProjectThreadingService _threadingService;
        private readonly IServiceProvider _serviceProvider;

        private IVsPackage _codeAnalysisPackage;
        private bool _codeAnalysisPackageLoadAttempted;

        protected AbstractProjectDesignerPageProvider(IProjectThreadingService threadingService, SVsServiceProvider serviceProvider, IProjectCapabilitiesService capabilities)
        {
            Requires.NotNull(threadingService, nameof(threadingService));
            Requires.NotNull(serviceProvider, nameof(serviceProvider));
            Requires.NotNull(capabilities, nameof(capabilities));

            _threadingService = threadingService;
            _serviceProvider = serviceProvider;
            Capabilities = capabilities;
        }

        protected IProjectCapabilitiesService Capabilities { get; }

        public abstract Task<IReadOnlyCollection<IPageMetadata>> GetPagesAsync();

        protected bool IsPackEnabled => Capabilities.Contains(ProjectCapability.Pack);

        private async Task EnsureCodeAnalysisPackageLoadedAsync()
        {
            if (!_codeAnalysisPackageLoadAttempted)
            {
                // Switch to UI thread for querying the build manager service.
                await _threadingService.SwitchToUIThread();

                var codeAnalysisGuid = new Guid(ManagedProjectSystemPackage.CodeAnalysisPackageGuid);
                var vsShell = _serviceProvider.GetService<IVsShell, SVsShell>();
                vsShell.IsPackageLoaded(ref codeAnalysisGuid, out _codeAnalysisPackage);
                if (_codeAnalysisPackage == null)
                {
                    vsShell.LoadPackage(ref codeAnalysisGuid, out _codeAnalysisPackage);
                }

                _codeAnalysisPackageLoadAttempted = true;
            }
        }

        protected async Task<bool> IsCodeAnalysisEnabledAsync()
        {
            if (!Capabilities.Contains(ProjectCapability.CodeAnalysis))
            {
                return false;
            }

            await EnsureCodeAnalysisPackageLoadedAsync().ConfigureAwait(true);

            return _codeAnalysisPackage != null;
        }
    }
}
