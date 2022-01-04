using System;

namespace set1
{
    class set1_14
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            long a = long.Parse(Console.ReadLine());
            palindrom(a);

        }

        private static void palindrom(long a)
        {
            long pali = 0, a2 = a;
            while (a != 0)
            {
                pali = pali * 10 + a % 10;
                a /= 10;
            }
            if (pali == a2)
                Console.WriteLine($"{a2} este palindrom");
            else
                Console.WriteLine($"{a2} nu este palindrom");
        }
    }
}