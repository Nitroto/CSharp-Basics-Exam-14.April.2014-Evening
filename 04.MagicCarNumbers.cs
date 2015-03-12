using System;
using System.Globalization;
using System.Threading;

class MagicCarNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int weight = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int magicNumbers = 0;
        for (int a1 = 0; a1 < 10; a1++)
        {
            for (int a2 = 0; a2 < 10; a2++)
            {
                for (int a3 = 0; a3 < 10; a3++)
                {
                    for (int a4 = 0; a4 < 10; a4++)
                    {
                        for (int b1 = 0; b1 < letters.Length; b1++)
                        {
                            for (int b2 = 0; b2 < letters.Length; b2++)
                            {
                                int numberWeight = 40 + a1 + a2 + a3 + a4 + (int)(letters[b1] - 'A' + 1) * 10 + (int)(letters[b2] - 'A' + 1) * 10;
                                if (weight == numberWeight)
                                {
                                    if (((a1 == a2) && (a1 == a3) && (a1 == a4)) || ((a2 == a3) && (a3 == a4)) || ((a1 == a2) && (a1 == a3)) || ((a1 == a2) && (a3 == a4)) || ((a1 == a3) && (a2 == a4)) || ((a1 == a4) && (a2 == a3)))
                                    {
                                        magicNumbers++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(magicNumbers);
    }
}
