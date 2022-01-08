using System;

namespace set3
{
    class set3_3
    {
        static void Main(string[] args)
        {
            MinMax();
        }

        private static void MinMax()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), min = 0, max = 0, pozmin =0, pozmax =0;
            Console.WriteLine($"Va rog sa intrati {n} numere intr-un singur rand separate cu un space.");
            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();
            min = max = int.Parse(s[0]);

            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
                if (min > v[i])
                {
                    min = v[i];
                    pozmin = i;
                }

                if (max < v[i])
                {
                    max = v[i];
                    pozmax = i;
                }
            }
            Console.WriteLine($"Minimumul se afla pe pozitia: {pozmin}");
            Console.WriteLine($"Maximumul se afla pe pozitia: {pozmax}");

        }

    }
}
