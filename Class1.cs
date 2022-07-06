using System;

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