using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter r: ");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("The pi is: " + String.Format("{0:0.00}",pi));
        double area = pi * (Math.Pow(r, 2));
        double perimeter = 2 * pi * r;

        Console.WriteLine();
        Console.WriteLine("The perimeter is: " + (String.Format("{0:0.00} {0}",perimeter)));
        int a = (int)(perimeter);
        Console.WriteLine("And binary perimeter is: " + Convert.ToString(a, 2).PadLeft(32, '0'));

        int b = (int)(area);
        Console.WriteLine();
        Console.WriteLine("The area is: " + (String.Format("{0:0.00} {0}", area)));
        Console.WriteLine("And binary area is: " + Convert.ToString(b, 2).PadLeft(32, '0'));
    }
}

