using System;
using System.Collections.Generic;
namespace set3
{
    class set3_19
    {
        static void Main(string[] args)
        {
            SearchInVec();
        }
        static int[] ConvertToVec(string[] x, int n)
        {
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
                vec[i] = int.Parse(x[i]);
            return vec;
        }

        static int eOk(int[] v, int[] p, ref int poz)
        {

            int nv = v.Length, ip = 0, np = p.Length, aux = poz;

            while (aux < nv && ip < np)
            {
                if (v[aux] != p[ip])
                    return 0;
                ip++;
                aux++;
            }
            if (aux <= nv && ip == np)
            {
                poz = aux - 2;
                return 1;
            }

            return 0;
        }
        static void Cauta(int[] v, int[] p)
        {
            int nv = v.Length, np = p.Length, k = 0;
            for (int i = 0; i < nv; i++)
            {
                if (v[i] == p[0])
                {
                    k += eOk(v, p, ref i);

                }
            }
            Console.WriteLine($"In vectorul V de {k} ori apare vectorul P.");
        }
        static void Cauta2(int[] v, int[] p)
        {
            int k = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == p[0])
                    k++;
            }
            Console.WriteLine($"In vectorul V de {k} ori apare vectorul P.");
        }
        private static void SearchInVec()
        {
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"Va rog sa introduceti {n1} numere pe un singur rand separate cu un space.");

            int[] v = new int[n1];
            string[] s1 = Console.ReadLine().Split();
            
            v = ConvertToVec(s1, n1);

            Console.Write("n2= ");
            int n2 = int.Parse(Console.ReadLine());
            
            int[] p = new int[n2];

            Console.WriteLine($"Va rog sa introduceti {n2} numere pe un singur rand separate cu un space.");
            string[] s2 = Console.ReadLine().Split();
            
            p = ConvertToVec(s2, n2);
            if (n2 != 1)
                Cauta(v, p);
            else
                Cauta2(v, p);



        }
    }
}