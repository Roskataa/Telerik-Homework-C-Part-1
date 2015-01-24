using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("enter n: ");
        double n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

