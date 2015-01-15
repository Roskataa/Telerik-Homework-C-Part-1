using System;

class ComparingFloats
{
    static void Main()
    {
        bool result = false;
        double eps = 0.000001;

        double a = 5.3;
        //Console.WriteLine(a);
        double b = 6.1;
        //Console.WriteLine(b);

        double ab = a - b;
        ab = Math.Abs(ab);
        Console.WriteLine("The different is:{0}", ab);

        if (ab < eps)
        {
            result = true;
            Console.WriteLine("equal", result);
        }
        else
        {
            result = false;
            Console.WriteLine("not equal", result);
        }
        Console.WriteLine("Number a is: {0} Number b is: {1} We have:{2}", a, b, result);    
    }
}

