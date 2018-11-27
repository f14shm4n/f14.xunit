using System;
using Xunit.Abstractions;

namespace f14.xunit
{
    public class XUnitTestBase
    {
        private readonly ITestOutputHelper _logger;

        public XUnitTestBase(ITestOutputHelper logger)
        {
            _logger = logger;
        }

        public ITestOutputHelper Logger => _logger;
    }
}
