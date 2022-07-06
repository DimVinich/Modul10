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

}
