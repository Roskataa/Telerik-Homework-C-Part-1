using System;

class QudraticEuation
{
    static void Main()
    {
        string ans = "";
        double root1 = 0;
        double root2 = 0; 
        double expr = 0;
        Console.Write("number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("number c: ");
        double c = double.Parse(Console.ReadLine());

        expr = b * b - (4 * a * c);
        if (expr > 0)
        {
            root1 = (-b + (Math.Sqrt(expr) / (2 * a)));
            root2 = (-b - (Math.Sqrt(expr) / (2 * a)));
            string r1 = Convert.ToString(root1);
            string r2 = Convert.ToString(root2);
            ans = "Root1 =" + r1 + "Root2 = " + r2;
            Console.WriteLine(ans);
        }
        if (expr < 0)
        {
            double Real = (-b / (2 * a));
            double Complex = ((Math.Sqrt((expr * (-1.00))) / (2 * a)));
            string SReal = Convert.ToString(Real);
            string SComplex = Convert.ToString(Complex);
            ans = "Roots = " + SReal + " +/- " + SComplex + "i";
            Console.WriteLine(ans);
        }
        if (expr == 0)
        {
            root1 = (-b / (2 * a));
            string Root = Convert.ToString(root1);
            ans = "Repeated roots : " + Root;
        }
    }
}

