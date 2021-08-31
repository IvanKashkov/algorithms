using algorithms.csharp.Tasks;
using algorithms.csharp.tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace algorithms.csharp.tests.Tasks
{
    public class HanoiTests : BaseUnitTest
    {
        public HanoiTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Test()
        {
            HanoiState state = HanoiState.Init(3);
            HanoiTower.Solve(state.Size, state.Size, state.From, state.To, state.Buf, state);
            var logs = state.Logs.ToString();
            Output.WriteLine(logs);
        }

        [Fact]
        public void Test2()
        {
            HanoiState state = HanoiState.Init(4);
            HanoiTower.Solve(state.Size, state.Size, state.From, state.To, state.Buf, state);
            var logs = state.Logs.ToString();
            Output.WriteLine(logs);
        }

        [Fact]
        public void Test3()
        {
            HanoiState state = HanoiState.Init(5);
            HanoiTower.Solve(state.Size, state.Size, state.From, state.To, state.Buf, state);
            var logs = state.Logs.ToString();
            Output.WriteLine(logs);
        }
    }
}
