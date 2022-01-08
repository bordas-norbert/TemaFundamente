using System;

namespace set3
{
    class set3_16
    {
        static void Main(string[] args)
        {
            DivComunInVector();
        }




        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }




        private static void DivComun(ref int[] v, ref int n)
        {
            int a = v[n - 1], b = v[n - 2], r;

            while (n != 1)
            {
                while (b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }
                n--;
                v[n - 1] = a;
                if (n != 1)
                    b = v[n - 2];
            }

        }

        private static void DivComunInVector()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Va rog sa introduceti {n} numere pe un singur rand separate cu un space.");

            int[] v = new int[n];
            string[] s = Console.ReadLine().Split();

            v = ConvertToVec(s, n);

            DivComun(ref v, ref n);


            Console.Write($"Cel mai mare divizor comun al elementelor este: {v[0]}");

        }
    }
}