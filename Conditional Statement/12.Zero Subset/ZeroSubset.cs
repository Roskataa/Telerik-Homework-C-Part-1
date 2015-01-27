using System;
using System.Collections.Generic;
using System.Linq;


class ZeroSubset
{
    static void Main()
    {
        int number;
        List<int> Numbers = new List<int>();
        for (int i = 0; i <= 4; i++)
        {
            number = 0;
            bool good = false;
            while (!good)
            {
                Console.WriteLine("Input number {0}", i + 1);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    Numbers.Add(number);
                    good = true;
                }
                else
                    Console.WriteLine("Invalid input, try again");
            }
        }
    }
}

