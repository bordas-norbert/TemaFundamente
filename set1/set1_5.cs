using System;

namespace set1
{
    class set1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            string numar = Console.ReadLine();
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine()), n = int.Parse(numar);
            Test(n, k, numar.Length);


        }

        private static void Test(int n, int k, int length)
        {
            if (length < k || k <= 0)
            {
                Console.WriteLine($"Nu exista {k}. cifra");
                return;
            }
            else
                Rezolv(n, k);

        }

        private static void Rezolv(int n, int k)
        {
            int cifra = 0;
            while (k != 0)
            {
                cifra = n % 10;
                k--;
                n /= 10;
            }

            Console.WriteLine(cifra);
        }
    }
}