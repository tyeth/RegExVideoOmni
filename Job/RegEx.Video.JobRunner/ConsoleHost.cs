using System;
using  Console= System.String; // Force wrapper usage
namespace RegEx.Video.JobRunner
{
    public static class ConsoleHost
    {
        private static IConsole _console;

        public static void Main(string[] args)
        {
            _console = _console ?? new ConsoleWrapper();
            _console.WriteLine("Hello World!");
        }
        public static void Main(string[] args,IConsole console)
        {
            _console=console;
            Main(args);
            
        }

    }
}
