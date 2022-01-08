using System;

namespace set3
{
    class set3_2
    {
        static void Main(string[] args)
        {
            ApareK();
        }

        private static void ApareK()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), k = 0, poz = -1;
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Va rog sa intrati {n} de numere intra singura linie separate cu un space");
            int[] v = new int[n];
            string[] IN = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(IN[i]);
                if (v[i] == k && poz == -1)
                    poz = i;
            }

            Console.WriteLine($"Primul pozitie pe care apare numarul {k} este {poz}.");
        }
    }
}
