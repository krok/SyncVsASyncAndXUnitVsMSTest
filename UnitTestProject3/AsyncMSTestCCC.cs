using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class AsyncMSTestCCC
    {
        [TestMethod]
        public async Task ASync_MSTest_3000_CCC()
        {
            Logger.LogStart();
            await Task.Delay(3000);
            Logger.LogCompleted();
        }

        [TestMethod]
        public async Task ASync_MSTest_2000_CCC()
        {
            Logger.LogStart();
            await Task.Delay(2000);
            Logger.LogCompleted();
        }

        [TestMethod]
        public async Task ASync_MSTest_1000_CCC()
        {
            Logger.LogStart();
            await Task.Delay(1000);
            Logger.LogCompleted();
        }
    }
}