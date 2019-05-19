using System;
using  Console= System.String; // Force wrapper usage
namespace RegEx.Video.JobRunner
{
    public static class ConsoleHost
    {
        private static IConsole _console;

        private const string HELP_TEXT =
            "Help:\r\n" +
            "\tArguments:\r\n" +
            "\r\n\t/c <videoFile> <?jsonfile>" +
"\r\n* Creates an input json file tracking the video metadata in the current folder or at <jsonfile> if supplied."

                +"\r\n"
            ;



        public static void Main(string[] args)
        {
            _console = _console ?? new ConsoleWrapper();
            if (args == null || args.Length == 0)
            {
                _console.WriteLine(HELP_TEXT);
            }
            else
            {
                _console.WriteLine("Hello World!");
            }
        }
        public static void Main(string[] args,IConsole console)
        {
            _console=console;
            Main(args);
            
        }

    }
}
