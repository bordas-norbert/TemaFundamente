using System;

namespace set1
{
    class set1_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Bisect(n);

        }

        private static void Bisect(int n)
        {
            if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
            {
                Console.WriteLine($"{n} este an bisect.");
            }
            else
            {
                Console.WriteLine($"{n} nu este an bisect.");
            }
        }


    }
}