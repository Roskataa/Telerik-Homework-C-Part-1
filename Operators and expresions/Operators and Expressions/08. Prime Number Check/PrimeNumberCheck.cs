using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
		{
            Console.WriteLine("Enter number unless :");
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine("It's not a prime");
            }
            else
            {
               for(int a = 2; a <= n / 2; a++)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("It's not a prime");
                        return;
                    }
                }
               Console.WriteLine("It's a prime");
               Console.ReadLine();
            }
        }
    }
}

