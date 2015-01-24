using System;

class NumberCompare
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        int result = (((x - y) >> 0x1F) | (int)((uint)(-(x - y)) >> 0x1F));
        //returns 0 if equal
        //returns 1 if x > y
        //returns -1 if x < y
        Console.WriteLine(result);
    }
}

