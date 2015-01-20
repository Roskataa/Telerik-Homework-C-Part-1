using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int count = 5;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Input number : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position of the bit : ");
            int p = int.Parse(Console.ReadLine());
            string binary =  Convert.ToString(n, 2).PadLeft(32, '0');
            Console.WriteLine("binary position {0} \n {1} ", n,binary);
            int b = int.Parse(Console.ReadLine());    
            if(b == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " | " + Convert.ToString(result, 10)); 
            }
            else
            {
                int mask = (1 << p);
                int result = n | mask;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " | " + Convert.ToString(result, 10)); 
            }    
        }
    }
}