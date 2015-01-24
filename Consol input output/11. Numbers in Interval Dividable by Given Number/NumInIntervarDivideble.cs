using System;

class NumInIntervarDivideble
{
    static void Main()
    {
        Console.Write("Enter positive integer number x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter positive integer number y: ");
        int y = int.Parse(Console.ReadLine());
        int count = 0;
        if (x > y)
        {
            int temp = x = y;  
        }
        for (int i = x; i <= y; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Start = {0}, end = {1}, p = {2}.", x, y, count);
    }
}

