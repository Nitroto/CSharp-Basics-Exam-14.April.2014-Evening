using System;
using System.Globalization;
using System.Threading;

class StudentCables
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int cableLength = 0;
        int goodCable = 0;
        for (int i = 0; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters")
            {
                length *= 100; 
            }
            if (length >= 20)
            {
                cableLength += length;
                goodCable++;
            }
        }
        int studentCable = 504;
        cableLength -= ((goodCable-1) * 3);
        int numberOfCreatedCables = cableLength / studentCable;
        int extraCable = cableLength % studentCable;
        Console.WriteLine(numberOfCreatedCables);
        Console.WriteLine(extraCable);
    }
}
