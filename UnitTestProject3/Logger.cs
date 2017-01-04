using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MSTestProject
{
    public class Logger
    {
        public static void LogStart([CallerMemberName] string functionName = null)
        {
            Debug.WriteLine("Started: " + functionName);
        }

        public static void LogCompleted([CallerMemberName] string functionName = null)
        {
            Debug.WriteLine("Completed: " + functionName);
        }
    }
}