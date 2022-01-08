using System;

namespace set3
{
    class set3_14
    {
        static void Main(string[] args)
        {
            ZeroLaSfarsitInVector();
        }




        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }

        static void Swap(ref int a, ref int b)
        {
            int aux = 0;
            aux = a;
            a = b;
            b = aux;
        }
        private static void ZeroLaSfarsit(ref int[] v)
        {
            int i = 0, n = v.Length, poz = n - 1;
            for (i = n - 1; i >= 0; i--)
            {
                if (v[i] == 0)
                {
                    Swap(ref v[i], ref v[poz]);
                    poz--;
                }
            }
        }

        private static void ZeroLaSfarsitInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            ZeroLaSfarsit(ref v);

            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }
    }
}