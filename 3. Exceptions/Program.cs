using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        const int minNumber = 0;
        const int maxNumber = 100;
        Console.Write("Insert number [{0}:{1}]: ", minNumber, maxNumber);
        try
        {
            Console.WriteLine("Inserted number: " + GetConsoleNumber(minNumber, maxNumber));
        }
        catch (InvalidRangeException<int> ire)
        {
            Console.WriteLine("InvalidRangeException:");
            Console.WriteLine("Number {0} is not in range: [{1}:{2}].",
                ire.Value, ire.Min, ire.Max);
        }

    }

    public static int GetConsoleNumber(int min, int max)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < min || number > max)
        {
            throw new InvalidRangeException<int>("Number is not in range:", number, min, max);
        }

        return number;
    }

    private static DateTime GetConsoleDateTime(DateTime min, DateTime max)
    {
        DateTime date = DateTime.Parse(Console.ReadLine());
        if (date < min || date > max)
        {
            throw new InvalidRangeException<DateTime>("Date is not in range.", date, min, max);
        }

        return date;
    }
}