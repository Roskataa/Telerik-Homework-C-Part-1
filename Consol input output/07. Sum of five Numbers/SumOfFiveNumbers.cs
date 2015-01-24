using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("number e: ");
        double e = double.Parse(Console.ReadLine());
        double sum = a + b + c + d + e;
        Console.WriteLine("{0} {1} {2} {3} {4} {5, 10}", a,b,c,d,e,sum);

    }
}
