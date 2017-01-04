using System.Threading.Tasks;

namespace AllSyncXUnit
{
    class SomeService
    {
        public static async Task Delay(int millisecondsDelay)
        {
            await Task.Delay(millisecondsDelay);
        }
    }
}