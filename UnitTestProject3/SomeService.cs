using System.Threading.Tasks;

namespace MSTestProject
{
    class SomeService
    {
        public static async Task Delay(int millisecondsDelay)
        {
            await Task.Delay(millisecondsDelay);
        }
    }
}