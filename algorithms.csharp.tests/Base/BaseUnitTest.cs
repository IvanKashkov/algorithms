using Xunit.Abstractions;

namespace algorithms.csharp.tests.Base
{
    public class BaseUnitTest
    {
        protected readonly ITestOutputHelper Output;
        public BaseUnitTest(ITestOutputHelper output)
        {
            this.Output = output;
        }
    }
}