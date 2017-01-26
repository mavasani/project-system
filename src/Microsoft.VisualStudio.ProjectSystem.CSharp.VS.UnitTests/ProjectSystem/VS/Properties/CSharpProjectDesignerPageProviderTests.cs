﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Properties
{
    [ProjectSystemTrait]
    public class CSharpProjectDesignerPageProviderTests
    {
        [Fact]
        public void Constructor_DoesNotThrow()
        {
            CreateInstance();
        }

        [Fact]
        public async Task GetPagesAsync_ReturnsPagesInOrder()
        {
            var provider = CreateInstance();
            var pages = await provider.GetPagesAsync();

            Assert.Equal(pages.Count(), 6);
            Assert.Same(pages.ElementAt(0), CSharpProjectDesignerPage.Application);
            Assert.Same(pages.ElementAt(1), CSharpProjectDesignerPage.Build);
            Assert.Same(pages.ElementAt(2), CSharpProjectDesignerPage.BuildEvents);
            Assert.Same(pages.ElementAt(3), CSharpProjectDesignerPage.Debug);
            Assert.Same(pages.ElementAt(4), CSharpProjectDesignerPage.ReferencePaths);
            Assert.Same(pages.ElementAt(5), CSharpProjectDesignerPage.Signing);
        }

        [Fact]
        public async Task GetPagesAsync_WithPackCapability()
        {
            var provider = CreateInstance(ProjectCapability.Pack);
            var pages = await provider.GetPagesAsync();

            Assert.Equal(pages.Count(), 7);
            Assert.Same(pages.ElementAt(0), CSharpProjectDesignerPage.Application);
            Assert.Same(pages.ElementAt(1), CSharpProjectDesignerPage.Build);
            Assert.Same(pages.ElementAt(2), CSharpProjectDesignerPage.BuildEvents);
            Assert.Same(pages.ElementAt(3), CSharpProjectDesignerPage.Package);
            Assert.Same(pages.ElementAt(4), CSharpProjectDesignerPage.Debug);
            Assert.Same(pages.ElementAt(5), CSharpProjectDesignerPage.ReferencePaths);
            Assert.Same(pages.ElementAt(6), CSharpProjectDesignerPage.Signing);
        }

        [Fact]
        public async Task GetPagesAsync_WithCodeAnalysisCapability()
        {
            var provider = CreateInstance(ProjectCapability.CodeAnalysis);
            var pages = await provider.GetPagesAsync();

            Assert.Equal(pages.Count(), 7);
            Assert.Same(pages.ElementAt(0), CSharpProjectDesignerPage.Application);
            Assert.Same(pages.ElementAt(1), CSharpProjectDesignerPage.Build);
            Assert.Same(pages.ElementAt(2), CSharpProjectDesignerPage.BuildEvents);
            Assert.Same(pages.ElementAt(3), CSharpProjectDesignerPage.Debug);
            Assert.Same(pages.ElementAt(4), CSharpProjectDesignerPage.ReferencePaths);
            Assert.Same(pages.ElementAt(5), CSharpProjectDesignerPage.Signing);
            Assert.Same(pages.ElementAt(6), CSharpProjectDesignerPage.CodeAnalysis);
        }

        private static CSharpProjectDesignerPageProvider CreateInstance(params string[] capabilities)
        {
            Func<string, bool> containsCapability = c => capabilities.Contains(c);
            var capabilitiesService = IProjectCapabilitiesServiceFactory.ImplementsContains(containsCapability);
            return new CSharpProjectDesignerPageProvider(IProjectThreadingServiceFactory.Create(), SVsServiceProviderFactory.Create(), capabilitiesService);
        }
    }
}
