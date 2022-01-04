using System;

namespace set1
{
    class set1_17
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 2 numere: ");
            Console.Write("a= ");
            long a = long.Parse(Console.ReadLine());
            Console.Write("b= ");
            long b = long.Parse(Console.ReadLine());
            EuclidCMMD(a, b);

        }

        private static void EuclidCMMD(long a, long b)
        {
            long r, a1 = a, b1 = b;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine($"cel mai mare divizor comun: {a}");
            Console.WriteLine($"cel mai mic multiplu comun: {(a1 * b1) / a}");
        }
    }
}