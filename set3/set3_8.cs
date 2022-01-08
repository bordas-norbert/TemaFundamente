using System;

namespace set3
{
    class set3_8
    {
        static void Main(string[] args)
        {
            RotireInVector();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static int[] RotireElement(int n, int[] v)
        {
            int[] v2 = new int[n];
            int i = 0, j = 0, aux = 0;
            aux = v[0];

            for (i = 0; i < n - 1; i++)
            {
                v2[i] = v[i + 1];
            }
            v2[n - 1] = aux;
            return v2;

        }

        private static void RotireInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);
            v = RotireElement(v.Length, v);

            Console.WriteLine("Vectorul dupa rotire: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }


    }
}
