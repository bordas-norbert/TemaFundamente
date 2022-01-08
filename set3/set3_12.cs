using System;

namespace set3
{
    class set3_12
    {
        static void Main(string[] args)
        {
            SelectionSortInVector();
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
        private static void SelectionSort(ref int[] v)
        {

            int n = v.Length;


            for (int i = 0; i < n - 1; i++)
            {

                int min_poz = i;

                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[min_poz])
                        min_poz = j;

                Swap(ref v[i], ref v[min_poz]);
            }

        }

        private static void SelectionSortInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            SelectionSort(ref v);
            Console.WriteLine("Vectorul sortat:");
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");

        }


    }
}
