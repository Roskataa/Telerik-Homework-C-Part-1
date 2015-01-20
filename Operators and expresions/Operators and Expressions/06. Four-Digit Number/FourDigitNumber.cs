using System;

class FourDigitNumber
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int a = (num % 10);
            int b = ((num / 10) % 10);
            int c = ((num / 100) % 10);
            int d = ((num / 1000) % 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            int sum = (a + b + c + d);

            Console.WriteLine("sum of digits is :" + sum);
            Console.WriteLine("reverse number is : {0}{1}{2}{3}", a, b, c, d);
            Console.WriteLine("last digit in front : {0}{1}{2}{3}", a, d, b, c);
            Console.WriteLine("second and third digits exchanged : {3}{2}{1}{0}", a, c, b, d);
        }
    }
}
