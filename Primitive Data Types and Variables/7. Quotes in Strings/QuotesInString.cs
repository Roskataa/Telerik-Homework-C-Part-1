using System;

class QuotesInString
{
    static void Main()
    {
        string without = "The \"use\" of quotations causes difficulties.";
        string with = "\"The \"use\" of quotations causes difficulties.\"";
        Console.WriteLine(without);
        Console.WriteLine(with);
    }
}

