using System;

    class Reactangle
    {
        static void Main()
        {
            int count = 3;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter width");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter heght");
                int b = int.Parse(Console.ReadLine());
                int perimeter = 2 * a * b;
                int area = a * b;
                Console.WriteLine("The perimeter is:" + perimeter);
                Console.WriteLine("The area is :" + area);  
            }
        }
    }

