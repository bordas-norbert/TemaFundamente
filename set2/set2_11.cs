using System;


namespace set2
{
    class set2_11
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Citire(ref n);
            Sum(n);

        }
        static void Citire(ref int n)
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
        }
        private static void Sum(int n)
        {

            int nr = 0;
            if (n < 0)
            {
                Console.WriteLine("va rog sa intrati mai multe numere");
                return;
            }
            Console.WriteLine($"Va rog sa intrati {n} de numere 1 pe o linie");

            double sum = 0.0F;

            for (int i = 1; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                sum += (double)1 / nr;
            }

            Console.WriteLine("Suma inverzelor este: " + sum);

        }
    }
}