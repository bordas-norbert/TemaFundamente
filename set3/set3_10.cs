using System;

namespace set3
{
    class set3_10
    {
        static void Main(string[] args)
        {
            BinarySearchInVector();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        private static int BinarySearchElement(int[] v, int k)
        {
            int stanga = 0, dreapta = v.Length - 1;

            while (stanga <= dreapta)
            {
                int mid = (stanga + dreapta) / 2;
                if (k == v[mid])
                {
                    return mid;
                }
                else if (k < v[mid])
                {
                    dreapta = mid - 1;
                }
                else
                {
                    stanga = mid + 1;
                }
            }
            return -1;

        }

        private static void BinarySearchInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), k;
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            int poz = BinarySearchElement(v, k);

            Console.WriteLine("Elementul se afla pe pozitia " + poz);
        }
    }
}
