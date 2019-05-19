using System;

namespace RegEx.Video.JobRunner
{
    public static class IConsoleFactory{
        private static IConsole _console;  
        public static IConsole GetIConsoleInstance(){
            _console = _console ?? (IConsole)  new Object();
            return _console ;
        }
    }
}