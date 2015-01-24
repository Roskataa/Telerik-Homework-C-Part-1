using System;


class PrintCompanyInformation
{
    static void Main()
    {
        string co = "Telerik academy";
        string ad = "Adress: 231 Al. Malinov, Sofia";
        string ph = "Tel: +359 888 55 55 555";
        string fax = "Fax: (no fax)";
        string web = "Web site: http://telerikacademy.com/";
        string fname = "Nikolai";
        string lname = "Kostov";
        string age = "age: 25";
        string manph = "tel. +359 2 981 981";
        Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4}", co, ad, ph, fax, web);
        Console.Write(fname);
        Console.Write("\t");
        Console.Write(lname);
        Console.Write("(");
        Console.Write(age);
        Console.Write(")");
        Console.Write(manph);
        Console.Write(")");
        Console.WriteLine();
        Console.WriteLine();
       
    }
}

