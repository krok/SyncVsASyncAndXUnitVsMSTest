using Xunit;

namespace AllSyncXUnit
{
    public class SyncXUnit_BBB
    {
        [Fact]
        public void Sync_XUnit_3000_BBB()
        {
            Logger.LogStart();
            SomeService.Delay(3000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_2000_BBB()
        {
            Logger.LogStart();
            SomeService.Delay(2000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_1000_BBB()
        {
            Logger.LogStart();
            SomeService.Delay(1000).Wait();
            Logger.LogCompleted();
        }
    }
}