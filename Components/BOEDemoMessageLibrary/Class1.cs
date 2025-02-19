using System;

namespace BOEDemoMessageLibrary
{
    public class MessagePrinter
    {
        public string? Message { get; set; }

        public void DisplayMessage()
        {
            Console.WriteLine("Your message is as follows....: {0}", Message);
        }
    }
}
