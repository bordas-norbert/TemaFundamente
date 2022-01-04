using System;

namespace set1
{
    class set1_10
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine("Numar:");
            a = long.Parse(Console.ReadLine());
            if (Prim(a) == true)
                Console.WriteLine($"Numarul {a} este prim");
            else
                Console.WriteLine($"Numarul {a} nu este prim");

        }

        static bool Prim(long a)
        {
            if (a < 2)
                return false;
            if (a == 2 || a == 3)
                return true;
            if (a % 2 == 0)
                return false;
            for (long i = 3; i * i <= a; i = i + 2)
                if (a % i == 0)
                {
                    return false;
                }
            return true;
        }
    }
}