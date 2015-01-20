using System;

class Program
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter x : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            double b = double.Parse(Console.ReadLine());
            double c = 2;
            if ((a * a) + (b * b) <= c * c)
            {
                Console.WriteLine("inside", true);
            }
            else
            {
                Console.WriteLine("outside", false);
            }
        }
    }
}

