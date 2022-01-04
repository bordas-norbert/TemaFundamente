using System;

namespace set1
{
    class set1_13
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            long a = long.Parse(Console.ReadLine());
             Console.Write("b= ");
            long b = long.Parse(Console.ReadLine());

            if (a <= b)
                Bisect(a, b);
            else
                Bisect(b, a);

        }

        private static void Bisect(long a, long b)
        {
            int counter = 0;
            for (long i = a; i <= b; i++)
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    counter++;
            Console.WriteLine($"Sunt {counter} ani intre {a} si {b} care sunt bisecte.");
        }
    }
}