using System;


namespace set2
{
    class set2_10
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Citire(ref n);
            MaxSame(n);
        }

        private static void MaxSame(int n)
        {

            int old = 0, nevv = 0, k = 1, max = 0;
            if (n <= 1)
            {
                Console.WriteLine("va rog sa intrati mai multe numere");
                return;
            }
            Console.WriteLine($"Va rog sa intrati {n} de numere 1 pe rand");
            old = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                nevv = int.Parse(Console.ReadLine());
                if (nevv == old)
                    k++;
                else
                {
                    if (k > max)
                        max = k;
                    k = 1;
                }
                old = nevv;
            }
            if (k > max)
                max = k;
            Console.WriteLine($"{max} este numarul maxim de numere consecutive egale din secventa");

        }

        static void Citire(ref int x)
        {
            Console.Write("n = ");
            x = int.Parse(Console.ReadLine());

        }
    }
}