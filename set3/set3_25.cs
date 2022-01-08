using System;
using System.Collections.Generic;
namespace set3
{
    class set3_25
    {
        static void Main(string[] args)
        {
            Inter();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        static void InterClasare(int[] v, int[] p, int n1, int n2)
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

            Console.Write("Interclasare: ");
            for (int c = 0; c < nr; c++)
                Console.Write($"{uni[c]} ");
            Console.WriteLine();
        }

        private static void Inter()
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

            InterClasare(v, p, n1, n2);
        }
    }
}