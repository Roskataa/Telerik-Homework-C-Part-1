using System;

class SortThreeNumbersWithNested
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = double.Parse(Console.ReadLine());
        if (a > b && b > c)
        {
            Console.WriteLine(" {0} {1} {2} ",a,b,c);
        }
        if (b > a && a > c)
        {
            Console.WriteLine(" {0} {1} {2} ",b,a,c);
        }
        if (c > a && a > b)
        {
            Console.WriteLine(" {0} {1} {2} ",c,a,b);

        }
        if(c > b && b > a)
        {
            Console.WriteLine(" {0} {1} {2} ", c, b, a);
        }
    }
}

