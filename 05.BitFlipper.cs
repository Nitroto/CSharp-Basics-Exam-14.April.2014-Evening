using System;
using System.Globalization;
using System.Threading;

class BitFlipper
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong num = ulong.Parse(Console.ReadLine());
        for (int bit = 61; bit >= 0; bit--)
        {
            int checkBits = (int)((num >> bit) & 7);
            if (checkBits == 7 || checkBits == 0)
            {
                num ^= (ulong)7 << bit;
                bit -= 2;
            }
        }
        Console.WriteLine(num);
    }
}
