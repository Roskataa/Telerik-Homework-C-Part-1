using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? al = null;
        al  = 6;
        Console.WriteLine(al.HasValue);
        int a = 5;
        int n = al.Value;
        a = al.Value;
        Console.WriteLine(al);

        double? bl = null;
        bl = 6;
        Console.WriteLine(bl.HasValue);
        Console.WriteLine(bl);
    }
}

