using System;

namespace RegEx.Video.JobRunner
{
    public class ConsoleWrapper:IConsole{
        public void WriteLine(string a){
            Console.WriteLine(a);
        }
    }
}