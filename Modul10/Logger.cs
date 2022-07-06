using System;
using System.Collections.Generic;
using System.Text;

namespace Modul10
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
