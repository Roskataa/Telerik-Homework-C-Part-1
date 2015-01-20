using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double a = 0.17;
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter weight on the earth:");
            int number = int.Parse(Console.ReadLine());
            int result = (int)(number * a);
            Console.WriteLine("Weight on the moon is :" + result);
        }
    }
}

