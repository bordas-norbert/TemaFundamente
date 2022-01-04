using System;


namespace set2
{
    class set2_12
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Citire(ref n);
            Cuvinte(n);

        }
        static void Citire(ref int n)
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
        }

        private static void Cuvinte(int n)
        {

            int k = 0, next = 0, old = 0;
            if (n == 1)
            {
                Console.WriteLine("0 grupuri de numere consecutive diferite de zero sunt in secventa de" + n + " numere.");
                return;
            }
            old = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                next = int.Parse(Console.ReadLine());
                if (next == 0 && old != 0)
                {
                    k++;
                    old = next;
                }
                old = next;
            }
            if (next != 0)
                k++;
            Console.WriteLine(k + " cuvinte am gasit.");


        }
    }
}