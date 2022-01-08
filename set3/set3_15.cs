using System;

namespace set3
{
    class set3_15
    {
        static void Main(string[] args)
        {
            EliminaInVector();
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

        static void Move(ref int[] v, int poz, ref int n)
        {
            int i;
            for (i = poz; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;
        }
        private static void Elimina(ref int[] v, ref int n)
        {
            InsertionSort(ref v);

            int poz;
            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] == v[i + 1])
                {
                    Move(ref v, i, ref n);
                    i--;
                }
            }

        }

        private static void EliminaInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            Elimina(ref v, ref n);

            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }
    }
}