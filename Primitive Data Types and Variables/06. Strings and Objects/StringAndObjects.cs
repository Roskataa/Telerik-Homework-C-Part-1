using System;

class StringAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";

        object sometext = a + " " + b;
        Console.WriteLine(sometext);

        string c = (string)sometext;
        Console.WriteLine(c);
    }
}

