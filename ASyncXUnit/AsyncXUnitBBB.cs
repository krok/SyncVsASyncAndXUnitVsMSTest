using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class AsyncXUnitBBB
    {
        [Fact]
        public async Task ASync_XUnit_3000_BBB()
        {
            Logger.LogStart();
            await SomeService.Delay(3000).ConfigureAwait(false);
            Logger.LogCompleted();
        }

        [Fact]
        public async Task ASync_XUnit_2000_BBB()
        {
            Logger.LogStart();
            await SomeService.Delay(2000).ConfigureAwait(false);
            Logger.LogCompleted();
        }

        [Fact]
        public async Task ASync_XUnit_1000_BBB()
        {
            Logger.LogStart();
            await SomeService.Delay(1000).ConfigureAwait(false);
            Logger.LogCompleted();
        }
    }
}