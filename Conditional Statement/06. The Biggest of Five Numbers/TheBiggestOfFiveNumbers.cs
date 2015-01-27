using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter d");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter e");
        double e = double.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.Write("The biggest is a");
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.Write("The biggest is b");
        }
        if (c > b && c > a && c > d && c > e)
        {
            Console.Write("The biggest is c");
        }
        if (d > b && d > a && e < d && c < d)
        {
            Console.Write("The biggest is d");
        }
        if (e > b && e > a && e > d && c < e)
        {
            Console.Write("The biggest is e");
        }
    }
}

