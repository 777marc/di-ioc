using System;

namespace di_ioc.Models
{
    public class Logger : ILogger
    {
        public void WriteToLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}