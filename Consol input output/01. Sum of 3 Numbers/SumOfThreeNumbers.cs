using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine(" The sum of these numbers is: {0}", sum);
        }
    }
}

