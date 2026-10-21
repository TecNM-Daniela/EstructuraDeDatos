using System;

class Program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.WriteLine(n);
            return;
        }

        BinarioB(n / 2);
        Console.WriteLine(n % 2);
    }

    static void BinarioB(int n)
    {
        if (n < 2)
        {
            Console.WriteLine(n);
            return;
        }

        BinarioA(n / 2);
        Console.WriteLine(n % 2);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un numero entero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Ingresa un numero no negativo: ");
            return;
        }

        Console.WriteLine("BINARIO: ");

        if (n == 0)
            Console.WriteLine("0");
        else
            BinarioA(n);

        Console.WriteLine();
    }
}