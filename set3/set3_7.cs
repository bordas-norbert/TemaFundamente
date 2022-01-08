using System;

namespace set3
{
    class set3_7
    {
        static void Main(string[] args)
        {
            ReverseInVector();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static int[] ReverseElement(int n, int[] v)
        {
            int[] v2 = new int[n];

            int i = 0, j = 0; ;
            for (i = n - 1; i >= 0; i--)
            {
                v2[j] = v[i];
                j++;
            }
            return v2;
        }

        private static void ReverseInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);
            v = ReverseElement(v.Length, v);
            Console.WriteLine("Vectorul reversat: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }


    }
}
