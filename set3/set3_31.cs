using System;
using System.Collections.Generic;
namespace set3
{
    class set3_31
    {
        static void Main(string[] args)
        {
            Problema31();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }

        static int MajElement(int[] v, int n1)
        {
            int maj_index = 0, k = 1;
            for (int i = 1; i < n1; i++)
            {
                if (v[maj_index] == v[i])
                    k++;
                else
                    k--;
                if (k == 0)
                {
                    maj_index = i;
                    k = 1;
                }
            }
            return v[maj_index];
        }


        static bool EsteMajor(int[] v, int n1, int nr)
        {
            int k = 0;
            for (int i = 0; i < n1; i++)
                if (v[i] == nr)
                    k++;
            if (k > n1 / 2)
                return true;
            return false;
        }

        static void Rezolvare(int[] a, int n1)
        {
            int nr = MajElement(a, n1);
            if (EsteMajor(a, n1, nr) == true)
                Console.WriteLine(nr + " este elementul major.");
            else
                Console.WriteLine("<nu exista>");
        }
        private static void Problema31()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();

            v = ConvertToVec(s1, n1);

            Rezolvare(v, n1);
        }

    }
}