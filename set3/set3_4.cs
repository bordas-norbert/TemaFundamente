using System;

namespace set3
{
    class set3_4
    {
        static void Main(string[] args)
        {
            Max();
        }

        private static void Max()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");
            string[] s = Console.ReadLine().Split();
            int max = int.Parse(s[0]), max_nr = 1, min = int.Parse(s[0]), min_nr = 1;
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
                if (v[i] > max)
                {
                    max = v[i];
                    max_nr = 1;
                }
                else if (v[i] == max)
                    max_nr++;
                if (v[i] < min)
                {
                    min = v[i];
                    min_nr = 1;
                }
                else if (v[i] == min)
                {
                    min_nr++;
                }
            }
            Console.WriteLine($"Numarul maxim: {max}, de {max_nr} ori apare.");
            Console.WriteLine($"Numarul minim: {min}, de {min_nr} ori apare.");
        }
    }
}
