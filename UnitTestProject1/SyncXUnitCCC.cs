using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class SyncXUnit_CCC
    {
        [Fact]
        public void Sync_XUnit_3000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(3000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_2000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(2000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_1000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(1000).Wait();
            Logger.LogCompleted();
        }
    }
}