using System;

namespace set1
{
    class set1_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua numere al intervalului: ");
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar: ");
            long n = long.Parse(Console.ReadLine());
            if (a <= b)
                Div(a, b, n);
            else
                Div(b, a, n);

        }

        private static void Div(long a, long b, long n)
        {
            long counter = 0;
            for (long i = a; i <= b; i++)
                if (i % n == 0)
                    counter++;
            Console.WriteLine($"{counter} numere sunt intre {a} si {b} care sunt divizibile cu {n}.");
        }
    }
}