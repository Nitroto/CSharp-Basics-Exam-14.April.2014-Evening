using System;
using System.Globalization;
using System.Threading;

class InsideTheBuilding
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int h = int.Parse(Console.ReadLine());
        int p1x = int.Parse(Console.ReadLine());
        int p1y = int.Parse(Console.ReadLine());
        int p2x = int.Parse(Console.ReadLine());
        int p2y = int.Parse(Console.ReadLine());
        int p3x = int.Parse(Console.ReadLine());
        int p3y = int.Parse(Console.ReadLine());
        int p4x = int.Parse(Console.ReadLine());
        int p4y = int.Parse(Console.ReadLine());
        int p5x = int.Parse(Console.ReadLine());
        int p5y = int.Parse(Console.ReadLine());
        InBuilding(h,p1x,p1y);
        InBuilding(h, p2x, p2y);
        InBuilding(h,p3x,p3y);
        InBuilding(h, p4x, p4y);
        InBuilding(h, p5x, p5y);
    }

    private static void InBuilding(int h, int x, int y)
    {
        if ((((x >= 0) && (x <= 3 * h)) && ((y >= 0) && (y <= 1 * h))) || (((x >= 1 * h) && (x <= 2 * h)) && ((y >= 1 * h) && (y <= 4 * h))))
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
