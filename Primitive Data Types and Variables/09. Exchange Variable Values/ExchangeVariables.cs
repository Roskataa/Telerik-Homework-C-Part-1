﻿using System;


class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a:{0}\nb:{1}", a, b);
        Console.WriteLine("a:{1}\nb:{0}", a, b);
    }
}

