using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class AsyncXUnitCCC
    {
        [Fact]
        public async Task ASync_XUnit_3000_CCC()
        {
            Logger.LogStart();
            await SomeService.Delay(3000);
            Logger.LogCompleted();
        }

        [Fact]
        public async Task ASync_XUnit_2000_CCC()
        {
            Logger.LogStart();
            await SomeService.Delay(2000);
            Logger.LogCompleted();
        }

        [Fact]
        public async Task ASync_XUnit_1000_CCC()
        {
            Logger.LogStart();
            await SomeService.Delay(1000);
            Logger.LogCompleted();
        }
    }
}