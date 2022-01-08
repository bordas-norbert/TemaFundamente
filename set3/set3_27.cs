using System;
using System.Collections.Generic;
namespace set3
{
    class set3_27
    {
        static void Main(string[] args)
        {
            OperatiiMultimiInVec();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }
        static int GetMin(int[] v, int n1, ref bool[] amFost, int max)
        {
            int min = max, min_index = 0;
            for (int i = 0; i < n1; i++)
            {
                if (min > v[i] && amFost[i] == false)
                {
                    min = v[i];
                    min_index = i;
                }
            }
            amFost[min_index] = true;
            return min;
        }
        private static void OperatiiMultimiInVec()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();

            v = ConvertToVec(s1, n1);

            Console.Write("index= ");
            int index = int.Parse(Console.ReadLine());
            if (index >= n1)
            {
                Console.WriteLine("Index is out of range.");
                return;
            }
            int min = 0, max = GetMax(v);
            bool[] amFost = new bool[n1];

            for (int i = 0; i <= index; i++)
            {
                min = GetMin(v, n1, ref amFost, max);
            }
            Console.WriteLine($"Dupa sortare pe indexul {index} numarul {min} va sta.");
        }
        static int GetMax(int[] v)
        {
            int max = v[0];
            for (int i = 1; i < v.Length; i++)
                if (max < v[i])
                    max = v[i];
            return max;
        }
    }
}