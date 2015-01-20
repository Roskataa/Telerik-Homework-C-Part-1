using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int count = 7;
        int a = 5;
        int b = 7;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            if (number % a == 0 && number % b == 0)
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

