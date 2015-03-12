using System;
using System.Globalization;
using System.Threading;

class ProgrammerDNA
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int spaces = 3;
        int add = 0;
        int numberOfLetters = 1;
        int letters = 0;
        bool middPoint = true;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', spaces));
            while (letters < numberOfLetters)
            {
                Console.Write((char)(letter + add));
                if ((letter + add) < 'G')
                {
                    add++;
                }
                else
                {
                    letter = 'A';
                    add = 0;
                }
                letters++;
            }
            letters = 0;
            Console.Write(new string('.', spaces));
            if (middPoint)
            {
                numberOfLetters += 2;
                spaces--;
                if (spaces == 0)
                {
                    middPoint = false;
                }
            }
            else
            {
                numberOfLetters -= 2;
                spaces++;
                if (spaces > 3)
                {
                    middPoint = true;
                    numberOfLetters = 1;
                    spaces = 3;
                }
            }
            Console.WriteLine();
        }
    }
}
