using System;

class BonusScore
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if(n <= 3)
        {
            n *= 10;
            Console.WriteLine(n);
        }
        if (n <= 6 && n >= 4)
        {
            n *= 100;
            Console.WriteLine(n);
        }
        if (n >= 7 && n <= 9)
        {
            n *= 1000;
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

