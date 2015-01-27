using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        
        CultureInfo enUS = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = enUS;
        Console.WriteLine("enter time in AM/PM: ");
        string time = Console.ReadLine();
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        try
        {
            DateTime date = DateTime.Parse(time, CultureInfo.InvariantCulture);
            if ((date >= startTime)||(date < endTime))
            {
                Console.WriteLine("get beer");
            }
            else
            {
                Console.WriteLine("non beer");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
        }
    }
}

