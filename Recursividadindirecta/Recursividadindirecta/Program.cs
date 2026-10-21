
using System;

class Program
{
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;

        if (n % 2 == 0)
            return SumaA(n - 1);

        return n + SumaB(n - 2);
    }

    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        if (n % 2 == 0)
            return SumaB(n - 1);

        return n + SumaA(n - 2);
    }

    static void Main()
    {
        Console.WriteLine("Ingresa un número:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("Por favor ingresa un número entre 0 y 1000.");
            return;
        }

        Console.WriteLine("La suma es: " + SumaA(n));
    }
}
