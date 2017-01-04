using Xunit;

namespace XUnitTestProject
{
    public class SyncXUnit_AAA
    {
        [Fact]
        public void Sync_XUnit_3000_AAA()
        {
            Logger.LogStart();
            SomeService.Delay(3000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_2000_AAA()
        {
            Logger.LogStart();
            SomeService.Delay(2000).Wait();
            Logger.LogCompleted();
        }

        [Fact]
        public void Sync_XUnit_1000_AAA()
        {
            Logger.LogStart();
            SomeService.Delay(1000).Wait();
            Logger.LogCompleted();
        }
    }
}