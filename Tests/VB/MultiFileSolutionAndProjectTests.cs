﻿using System.Threading.Tasks;
using ICSharpCode.CodeConverter.Tests.TestRunners;
using ICSharpCode.CodeConverter.VB;
using Xunit;

namespace ICSharpCode.CodeConverter.Tests.VB
{
    /// <summary>
    /// <see cref="MultiFileTestFixture"/> for info on how these tests work.
    /// </summary>
    [Collection(MultiFileTestFixture.Collection)]
    public class MultiFileSolutionAndProjectTests
    {
        private readonly MultiFileTestFixture _multiFileTestFixture;

        public MultiFileSolutionAndProjectTests(MultiFileTestFixture multiFileTestFixture)
        {
            _multiFileTestFixture = multiFileTestFixture;
        }

        [Fact]
        public async Task ConvertWholeSolution()
        {
            await _multiFileTestFixture.ConvertProjectsWhere(p => true, DotNetTool.CodeConvProgram.Language.VB);
        }

        [Fact]
        public async Task ConvertCSharpConsoleAppOnly()
        {
            await _multiFileTestFixture.ConvertProjectsWhere(p => p.Name == "CSharpConsoleApp", DotNetTool.CodeConvProgram.Language.VB);
        }
    }
}
