using System;

class FloatingPointsNumber
{
    static void Main()
    {
    Console.Write("number a: ");
    int a = int.Parse(Console.ReadLine());
    if (a > 500)
    {
        Console.WriteLine("The number is bigger then 500:");  
    }
    else
    {
        Console.Write("number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("number c: ");
        double c = double.Parse(Console.ReadLine());
        string str = Convert.ToString(a, 2);
        Console.WriteLine(str);
        if (str.Length > 10)
        {
            int strLength = str.Length;
            str = str.Substring(strLength -10);
        }
            Console.WriteLine("| {0,-10:X} | {3} | {1,10:F2} | {1,-10:F3} |", a, b, c, str.PadLeft(10, '0'));
        }   
    }
}

