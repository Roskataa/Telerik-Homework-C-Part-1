using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The biggest is a");
        }
        if (b > a && b > c)
        {
            Console.WriteLine("The biggest is b");
        }
        if (c > b && c > a)
        {
            Console.WriteLine("The biggest is c");
        }
    }
}

