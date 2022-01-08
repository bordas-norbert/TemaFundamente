using System;

namespace set3
{
    class set3_13
    {
        static void Main(string[] args)
        {
            InsertionSortInVector();
        }




        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }


        private static void InsertionSort(ref int[] v)
        {
            int n = v.Length;
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

        private static void InsertionSortInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            InsertionSort(ref v);
            Console.WriteLine("Vectorul sortat: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }
    }
}