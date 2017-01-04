using System.Threading.Tasks;

namespace XUnitTestProject
{
    class SomeService
    {
        public static async Task Delay(int millisecondsDelay)
        {
            await Task.Delay(millisecondsDelay);
        }
    }
}