using System;

class ChekBitAtGivenPosition
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position of the bit : ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("bit@p :" + bit);
            if (bit == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

