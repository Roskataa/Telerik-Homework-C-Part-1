using System;

class OddOrEvenIntegers
{
    static void Main()
    {
         //Zakomentiranoto reshenie e po advans ako niakoj iska da go pogledne 
         // izpolzvani sa dva metoda izvikani v funkcia podhodia6to za team work...


    //    int numberLoops = 5;
    //    string clientNumber = "";
    //    for (int i = 0; i < numberLoops; i++)
    //    {
    //        clientNumber = ReadFromConsole();
    //        IsOdd(clientNumber);
    //    }
        string str = "number is:";
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(str);
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {   
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        } 
    //}
    //public static string ReadFromConsole()
    //{
    //    string str = "number is:";
    //    Console.WriteLine(str);
    //    string enteredNumber = Console.ReadLine();
    //    return enteredNumber;
    //}
    //public static void IsOdd(string x)
    //{
    //    int num = int.Parse(x);
    //    if (num % 2 == 0)
    //    {
    //        Console.WriteLine(true);
    //    }
    //    else
    //    {
    //        Console.WriteLine(false);
    //    }
    }
}

