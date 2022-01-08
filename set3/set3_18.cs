using System;
using System.Collections.Generic;
namespace set3
{
    class set3_18
    {
        static void Main(string[] args)
        {
            Polinom();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }

        static long Fast(int x, int k)
        {
            int res = 1;
            while (k > 0)
            {
                if (k % 2 == 1)
                {
                    res *= x;
                }
                x = x * x;
                k /= 2;
            }
            return res;
        }
        static long Poli(ref int[] v, int x)
        {
            int n = v.Length;
            n--;
            long rezultat = 0;

            for (int i = 0; i <= n; i++)
            {
                rezultat += v[i] * Fast(x, n - i);
            }
            return rezultat;
        }
        private static void Polinom()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            n++;
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");
            Console.WriteLine("Primul numar sa fie coeficientul lui x^n iar ultima lui x^0");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            long rez = Poli(ref v, x);

            Console.WriteLine($"Valoarea polinomului in punctul {x} este {rez}");

        }
    }
}