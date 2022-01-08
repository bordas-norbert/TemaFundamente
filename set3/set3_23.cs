using System;
using System.Collections.Generic;
namespace set3
{
    class set3_23
    {
        static void Main(string[] args)
        {
            OperatiiMultimiInVec();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static void InsertionSort(ref int[] v, int n)
        {

            for (int i = 0; i < n; ++i)
            {
                int k = v[i];
                int j = i - 1;
                while (j >= 0 && v[j] > k)
                {
                    v[j + 1] = v[j];
                    j = j - 1;
                }
                v[j + 1] = k;
            }
        }
        static void Move(ref int[] v, int poz, ref int n)
        {
            int i;
            for (i = poz; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;
        }
        private static void Elimina(ref int[] v, ref int n)
        {
            InsertionSort(ref v, n);
            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] == v[i + 1])
                {
                    Move(ref v, i, ref n);
                    i--;
                }
            }
        }
        static void Reuniune(int[] v, int[] p, int n1, int n2)
        {

            int[] uni = new int[n1 + n2];
            int buc = -1, i = 0, j = 0;
            while (i < n1 && j < n2)
            {
                buc++;
                if (v[i] < p[j])
                {
                    uni[buc] = v[i];
                    i++;
                }
                else
                {
                    uni[buc] = p[j];
                    j++;
                }
            }
            while (i < n1)
            {
                buc++;
                uni[buc] = v[i];
                i++;
            }

            while (j < n2)
            {
                buc++;
                uni[buc] = p[j];
                j++;
            }
            int nr = n1 + n2;
            Elimina(ref uni, ref nr);
            Console.Write("Reuniune: ");
            for (int c = 0; c < nr; c++)
                Console.Write($"{uni[c]} ");
            Console.WriteLine();
        }
        static void Diferente_Intersectie(int[] v, int n1, int[] p, int n2)
        {
            v1_v2(v, p, n1, n2);
            Console.Write("v2 - v1: ");
            v2_v1(v, n1, p, n2);
        }
        private static void v2_v1(int[] v, int n1, int[] p, int n2)
        {
            bool[] rezultat = new bool[n2];
            for (int i = 0; i < n2; i++)
                rezultat[i] = binarySearch(v, 0, n1 - 1, p[i]);

            for (int i = 0; i < rezultat.Length; i++)
                if (rezultat[i] == false)
                    Console.Write(p[i] + " ");
            Console.WriteLine();
        }
        private static void v1_v2(int[] v, int[] p, int n1, int n2)
        {
            bool[] rezultat = new bool[n1];
            for (int i = 0; i < n1; i++)
                rezultat[i] = binarySearch(p, 0, n2 - 1, v[i]);
            Console.Write("Intersectare: ");

            for (int i = 0; i < rezultat.Length; i++)
                if (rezultat[i] == true)
                    Console.Write(v[i] + " ");
            Console.WriteLine();
            Console.Write("v1 - v2: ");
            for (int i = 0; i < rezultat.Length; i++)
                if (rezultat[i] == false)
                    Console.Write(v[i] + " ");
            Console.WriteLine();

        }
        static bool binarySearch(int[] v, int stanga, int dreapta, int nr)
        {
            if (dreapta >= stanga)
            {
                int mid = stanga + (dreapta - stanga) / 2;
                if (v[mid] == nr)
                    return true;
                if (v[mid] > nr)
                    return binarySearch(v, stanga, mid - 1, nr);
                return binarySearch(v, mid + 1, dreapta, nr);

            }


            return false;
        }


        private static void OperatiiMultimiInVec()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();

            v = ConvertToVec(s1, n1);

            Console.Write("n2= ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Va rog sa introduceti {n2} numere pe un singur rand separate cu un space.");

            int[] p = new int[n2];
            string[] s2 = Console.ReadLine().Split();

            p = ConvertToVec(s2, n2);

            Elimina(ref v, ref n1);
            Elimina(ref p, ref n2);

            Reuniune(v, p, n1, n2);

            Diferente_Intersectie(v, n1, p, n2);
        }
    }
}