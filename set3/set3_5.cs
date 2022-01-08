using System;

namespace set3
{
    class set3_5
    {
        static void Main(string[] args)
        {
            InsertInVector();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static int[] InsertElement(int n, int k, int e, int[] v)
        {
            int[] v2 = new int[n + 1];
            int i = 0;
            for (i = 0; i < k; i++)
            {
                v2[i] = v[i];
            }
            v2[k] = e;
            for (i = k; i < n; i++)
            {
                v2[i + 1] = v[i];
            }
            return v2;
        }

        private static void InsertInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), e, k;
            int[] v = new int[n];
            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");
            string[] s = Console.ReadLine().Split();
            Console.Write("e= ");
            e = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            if (k > n)
            {
                Console.WriteLine("k este mai mare decat n");
                return;
            }
            v = ConvertToVec(s, n);
            v = InsertElement(v.Length, k, e, v);
            Console.WriteLine("Vectorul dupa insertare: ");
            for (int i = 0; i < n + 1; i++)
                Console.Write($"{v[i]} ");

        }


    }
}
