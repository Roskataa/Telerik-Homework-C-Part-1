using System;

    class PlayWithIntdoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Enter 1-->int, 2-->double or 3-->sting: ");
            short var = short.Parse(Console.ReadLine());
            switch (var)
            { 
                case 1:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} + {1}",a + 1);
                    break;
                case 2:
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} ", b + 1);
                    break;
                case 3:
                    string str = (Console.ReadLine());
                    Console.WriteLine("{0} *", str);
                    break;
                default :
                    Console.WriteLine("Invalid types");
                    break;
            }
        }
    }

