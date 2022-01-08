using System;

namespace set3
{
    class set3_6
    {
        static void Main(string[] args)
        {
            DeleteInVector();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static int[] DeleteElement(int n, int k, int[] v)
        {
            int[] v2 = new int[n - 1];
            v2 = v;
            int i = 0;
            for (i = k; i < n - 1; i++)
            {
                v2[i] = v[i + 1];
            }
            return v2;
        }

        private static void DeleteInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), k;
            int[] v = new int[n];
            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");
            string[] s = Console.ReadLine().Split();
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            if (k >= n)
            {
                Console.WriteLine($"Nu existe pozitia {k}.");
                return;
            }
            v = ConvertToVec(s, n);
            v = DeleteElement(v.Length, k, v);
            Console.WriteLine("Vectorul dupa stergere: ");
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{v[i]} ");

        }


    }
}
