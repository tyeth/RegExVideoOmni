using System;

namespace RegEx.Video.JobRunner
{
    public static class ConsoleHost
    {
        private static IConsole _console;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void Main(string[] args,IConsole console)
        {
            _console=console;
            Main(args);
        }

    }
}
