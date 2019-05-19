using System;

namespace RegEx.Video.JobRunner
{
    public static class IConsoleFactory{
        private static dynamic _console;  
        public static IConsole GetIConsoleInstance(){
            _console = _console ?? new ConsoleWrapper();
            return _console ;
        }
    }
}