using System;
using System.Collections.Generic;
namespace set3
{
    class set3_28
    {
        static void Main(string[] args)
        {
            QuickSortInVec();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        static int repartizare(int stanga, int dreapta, int[] t)
        {
            int p, x, i;
            p = t[stanga];
            i = stanga;
            for (int j = stanga + 1; j <= dreapta; j++)
            {
                if (p > t[j])
                {
                    i++;
                    x = t[j];
                    t[j] = t[i];
                    t[i] = x;
                }
            }
            x = t[i];
            t[i] = t[stanga];
            t[stanga] = x;
            return i;
        }

        static void QuickSort(int stanga, int dreapta, int[] v)
        {
            int m;
            if (stanga < dreapta)
            {
                m = repartizare(stanga, dreapta, v);
                QuickSort(stanga, m - 1, v);
                QuickSort(m + 1, dreapta, v);
            }
        }
        static void PrintVec(int[] v)
        {
            Console.Write("Vectorul sortat: ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i] + " ");
        }
        private static void QuickSortInVec()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();

            v = ConvertToVec(s1, n1);

            QuickSort(0, n1 - 1, v);
            PrintVec(v);
        }

    }
}