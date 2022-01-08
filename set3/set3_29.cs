using System;
using System.Collections.Generic;
namespace set3
{
    class set3_29
    {
        static void Main(string[] args)
        {
            MergeSortInVec();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        static int repartiza(int stanga, int dreapta, int[] t)
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

        static void MergeSort(int stanga, int dreapta, int[] v)
        {
            int m;
            if (stanga < dreapta)
            {
                m = repartiza(stanga, dreapta, v);
                MergeSort(stanga, m - 1, v);
                MergeSort(m + 1, dreapta, v);
            }
        }
        static void PrintVec(int[] v)
        {
            Console.Write("Vectorul sortat: ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i] + " ");
        }
        void merge(int[] vektor, int stanga, int mijloc, int dreapta, int n)
        {
            int i = stanga, j = mijloc + 1, k = stanga;
            int[] aux = new int[n];
            while (i <= mijloc && j <= dreapta)
            {
                if (vektor[i] <= vektor[j])
                {
                    aux[k] = vektor[i];
                    i++;
                    k++;
                }
                else
                {
                    aux[k] = vektor[j];
                    j++;
                    k++;
                }
            }

            while (i <= mijloc)
            {
                aux[k] = vektor[i];
                i++;
                k++;
            }


            while (j <= dreapta)
            {
                aux[k] = vektor[j];
                j++;
                k++;
            }

            for (int lep = stanga; lep <= dreapta; lep++)
            {
                vektor[lep] = aux[lep];
            }
        }
        void mergeSort(int[] vektor, int stanga, int dreapta, int n)
        {
            if (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;
                mergeSort(vektor, stanga, mijloc, n);
                mergeSort(vektor, mijloc + 1, dreapta, n);
                merge(vektor, stanga, mijloc, dreapta, n);
            }
        }
        private static void MergeSortInVec()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();

            v = ConvertToVec(s1, n1);

            MergeSort(0, n1 - 1, v);
            PrintVec(v);
        }

    }
}