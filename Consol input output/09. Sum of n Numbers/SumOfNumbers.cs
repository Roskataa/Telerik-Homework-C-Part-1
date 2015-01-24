using System;

    class SumOfNumbers
    {
        static void Main()
        {
            int sum = 0;
            string y = "";
            Console.Write("enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                y = Console.ReadLine();
                int a = int.Parse(y);
                sum += a;
            }
            Console.WriteLine("The sum of these numbers is: {0}",sum);
        }
    }

