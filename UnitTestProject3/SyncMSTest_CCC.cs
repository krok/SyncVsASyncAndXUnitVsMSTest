using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class SyncMSTest_CCC
    {
        [TestMethod]
        public void Sync_MSTest_3000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(3000).Wait();
            Logger.LogCompleted();
        }

        [TestMethod]
        public void Sync_MSTest_2000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(2000).Wait();
            Logger.LogCompleted();
        }

        [TestMethod]
        public void Sync_MSTest_1000_CCC()
        {
            Logger.LogStart();
            SomeService.Delay(1000).Wait();
            Logger.LogCompleted();
        }
    }
}