using System;
using System.Threading;

namespace Modul10
{
    internal class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);

            worker1.Wokr();
            worker2.Wokr();
            worker3.Wokr();


            Console.ReadKey();
        }

    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message); 
        }

        public void Event(string message)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Black;
            // Можно воткнуть отправку в поток, почту или кудысь нужно.
            Console.WriteLine(message);
        }
    }

    public interface IWorker
    {
        void Wokr();
    }

    public class Worker1 : IWorker
    {
        ILogger Logger { get; }

        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Wokr()
        {
            Logger.Event("Worker 1 начал свою работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 1 завершил свою работу");
        }
    }

    public class Worker2 : IWorker
    {
        ILogger Logger { get; }

        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Wokr()
        {
            Logger.Event("Worker 2 начал свою работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 2 завершил свою работу");
        }
    }

    public class Worker3 : IWorker
    {
        ILogger Logger { get; }

        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Wokr()
        {
            Logger.Event("Worker 3 начал свою работу");
            Thread.Sleep(1000);
            Logger.Event("Worker 3 завершил свою работу");
        }
    }

}
