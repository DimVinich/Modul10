using System;
using System.Threading;

namespace Modul10
{
    internal class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            double number1;
            double number2;
            double summa;
            ISumma Summa = new Summa();
            Logger = new Logger();
            var inputDecimal = new InputDecimal(Logger);

            //  ввод первого числа
            //lbh = inputDecimal.
            if (inputDecimal.InputDecimalWithCheck(out number1))
            {
                Console.ReadKey();
                return;
            }

            //  ввод второго числа
            if (inputDecimal.InputDecimalWithCheck(out number2))
            {
                Console.ReadKey();
                return;
            }

            //  расчёт суммы 
            summa = Summa.Summa(number1, number2);

            Console.WriteLine($"Сумма введённых чисел = {summa}");

            Console.ReadKey();
        }

    }

    // Интерфейс логера
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    // Реализация логера
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    // Реализация воода числа  , с проверкой на оишбку, с записью в лог. В кастве носителя лога - консоль
    public class InputDecimal
    {
        ILogger Logger { get; }

        public InputDecimal(ILogger logger)
        {
            Logger = logger;
        }

        public bool InputDecimalWithCheck(out double aInput)
        {
            Logger.Event(" Событие - Ввод значения ");
            Console.WriteLine("Введите число:");
            try
            {
                //aInput = Convert.ToDouble(Console.ReadLine());
                aInput = double.Parse((Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                aInput = 0; 
                return true;
            }

            return false;

        }

    }

    // Интерфейс сложения
    interface ISumma
    {
        double Summa(double a1, double a2);
    }

    // Реализация сложения
    public class Summa : ISumma
    {

        double ISumma.Summa(double a1, double a2)
        {
            return a1 + a2;
        }
    }

}
