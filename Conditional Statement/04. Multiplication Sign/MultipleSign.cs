using System;

class MultipleSign
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());
        bool positiv = ((a > 0 && b > 0 && c > 0) && (a < 0 && b < 0 && c > 0));
        bool zeros = (a == 0 || b == 0 || c == 0);
        if (positiv)
        {
            Console.WriteLine("the sign is +");
        }
        if (zeros)
        {
            Console.WriteLine("the sign is 0");
        }
        else
        {
            Console.WriteLine("the sign is -");
        }
    }
}

