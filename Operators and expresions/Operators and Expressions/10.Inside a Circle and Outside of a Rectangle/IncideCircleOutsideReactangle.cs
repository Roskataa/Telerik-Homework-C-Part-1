using System;

class IncideCircleOutsideReactangle
{
    static void Main()
    {
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter x : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            double b = double.Parse(Console.ReadLine());
            double c = 1.5;
            if (((a - 1) * (a - 1)) + ((b - 1) * (b - 1)) <= c * c)
            {
                Console.WriteLine("inside in circle");
            }
            else
            {
                Console.WriteLine("outside of circle");
            }
            if ((a > -1) ^ (a > 5) ^ (b > -1) ^ (b > 1))
            {
                Console.WriteLine("is in reactangle");
            }
            else
            {
                Console.WriteLine("is out of reactangle");
            }
        }
    }
}
