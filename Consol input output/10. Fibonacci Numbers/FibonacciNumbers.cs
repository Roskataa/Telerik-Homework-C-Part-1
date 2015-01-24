using System;

class FibonacciNumbers
{
    static void Main()
    {
        int x = 0;
        int y = 1;
        int sum = x + y;
        Console.Write("enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(x);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
                x = y;
                y = sum;
                sum = x + y;
        }
        Console.WriteLine();
    }
}

