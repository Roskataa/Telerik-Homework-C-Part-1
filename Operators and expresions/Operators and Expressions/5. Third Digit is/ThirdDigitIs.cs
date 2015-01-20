using System;

class ThirdDigitIs
{
    static void Main()
    {
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            int digit = ((a / 100)%10);
            Console.WriteLine(digit);
            if (digit == 7)
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
