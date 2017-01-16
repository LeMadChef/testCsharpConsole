using System;
using System.Diagnostics;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("Application started.", "MyApp");
            Trace.WriteLine("working...", "MyApp");
            Trace.WriteLine("Application finished.", "MyApp");

            Trace.Flush();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
