using System;

using BOEDemoMessageLibrary;

namespace ShellRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagePrinter mp = new MessagePrinter();
            mp.Message = "Hello Bob";
            mp.DisplayMessage();     
        }
    }
}
