using System;

namespace set3
{
    class set3_1
    {
        static void Main(string[] args)
        {
            SumaVector();
        }

        private static void SumaVector()
        {
            long sum = 0;
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Va rog sa intrati {n} bucati de numere intr-un rand cu un space intre ele.");
            string[] input = Console.ReadLine().Split();
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(input[i]);
                sum += v[i];
            }
            Console.WriteLine($"Suma este {sum}.");
        }
    }
}
