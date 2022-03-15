using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class csharpExercise
{
    static void Main(string[] args)
    {

        int num, last;

        // Reading number
        Console.Write("Введiть трьохзначне число: ");
        num = Convert.ToInt32(Console.ReadLine());

        last = num % 10;
        Console.WriteLine("Остання цифра введеного числа: " + last);

        while (num >= 10)
        {
            num = num / 10;
        }

        Console.WriteLine("Перша цифра введеного числа: " + num);
        Console.ReadLine();
    }
}