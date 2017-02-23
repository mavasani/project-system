﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Threading;
using Microsoft.VisualStudio.ProjectSystem.LanguageServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;
using IOLEServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
using Task = System.Threading.Tasks.Task;

namespace Microsoft.VisualStudio.ProjectSystem.VS.LanguageServices
{
    internal abstract class VsContainedLanguageComponentsFactoryBase : OnceInitializedOnceDisposedAsync, IVsContainedLanguageComponentsFactory
    {
        public VsContainedLanguageComponentsFactoryBase(
            IUnconfiguredProjectCommonServices commonServices,
            SVsServiceProvider serviceProvider,
            IUnconfiguredProjectVsServices projectServices,
            IProjectHostProvider projectHostProvider,
            ILanguageServiceHost languageServiceHost,
            Guid languageServiceGuid)
            : base(commonServices.ThreadingService.JoinableTaskContext)
        {
            ServiceProvider = serviceProvider;
            ProjectServices = projectServices;
            LanguageServiceGuid = languageServiceGuid;
            ProjectHostProvider = projectHostProvider;
            LanguageServiceHost = languageServiceHost;
        }

        private Guid LanguageServiceGuid { get; }
        private SVsServiceProvider ServiceProvider { get; }
        private IUnconfiguredProjectVsServices ProjectServices { get; }
        private IProjectHostProvider ProjectHostProvider { get; }
        private ILanguageServiceHost LanguageServiceHost { get; }

        protected override async Task InitializeCoreAsync(CancellationToken cancellationToken)
        {
            await LanguageServiceHost.InitializeAsync(cancellationToken).ConfigureAwait(false);
        }

        protected override Task DisposeCoreAsync(bool initialized)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        ///     Gets an object that represents a host-specific IVsContainedLanguageFactory implementation and
        ///     IVsHierarchy and itemId specific to currently active target framework.
        /// </summary>
        /// <param name="filePath">Path to a file</param>
        /// <param name="hierarchy">Project hierarchy containing given file for current language service</param>
        /// <param name="itemid">item id of the given file</param>
        /// <param name="containedLanguageFactory">an instance of IVsContainedLanguageFactory specific for current language service</param>
        /// <returns></returns>
        public int GetContainedLanguageFactoryForFile(string filePath, 
                                                      out IVsHierarchy hierarchy, 
                                                      out uint itemid, 
                                                      out IVsContainedLanguageFactory containedLanguageFactory)
        {
            uint myItemId = 0;
            IVsHierarchy myHierarchy = null;
            IVsContainedLanguageFactory myContainedLanguageFactory = null;

            ProjectServices.ThreadingService.JoinableTaskFactory.Run(async () =>
            {
                await ProjectServices.ThreadingService.JoinableTaskFactory.SwitchToMainThreadAsync();

                await InitializeAsync().ConfigureAwait(true);

                var priority = new VSDOCUMENTPRIORITY[1];
                HResult result = ProjectServices.VsProject.IsDocumentInProject(filePath, 
                                                                               out int isFound, 
                                                                               priority, 
                                                                               out myItemId);
                if (result.Failed || isFound == 0)
                {
                    return;
                }
             
                myHierarchy = (IVsHierarchy)ProjectHostProvider.UnconfiguredProjectHostObject.ActiveIntellisenseProjectHostObject;

                var oleServiceProvider = ServiceProvider.GetService(typeof(IOLEServiceProvider)) as IOLEServiceProvider;
                if (oleServiceProvider == null)
                {
                    return;
                }

                myContainedLanguageFactory = (IVsContainedLanguageFactory)PackageUtilities.QueryService(
                                                oleServiceProvider,
                                                LanguageServiceGuid);
            });

            hierarchy = myHierarchy;
            itemid = myItemId;
            containedLanguageFactory = myContainedLanguageFactory;

            return (myHierarchy == null || containedLanguageFactory == null) 
                ? VSConstants.E_FAIL 
                : VSConstants.S_OK;
        }
    }
}
