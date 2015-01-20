using System;

//re6enieto e dadeno ot lekciite
class BitwizseExtract
{
    static void Main()
    {
        int count = 3;
        for (int i = 0; i < count; i++)
		{
            Console.Write("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("The third bit of the enter number is :" + bit);
		}
    }
}

