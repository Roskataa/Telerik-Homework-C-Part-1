using System;

class Trapezoids
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.Write("sides a :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("sides b :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("height :");
            double h = double.Parse(Console.ReadLine());
            double m = 2.0;
            double area = (double)(((a + b) / m) * h);
            Console.WriteLine("Area is : " + area);
        }
    }
}

