using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int year = int.Parse(Console.ReadLine());

        if (EsBisiesto(year))
        {
            Console.WriteLine("Es bisiesto");
        }
        else
        {
            Console.WriteLine("No es bisiesto.");
        }
    }

    static bool EsBisiesto(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}
