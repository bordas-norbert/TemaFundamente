using System;

namespace set3
{
    class set3_11
    {
        static void Main(string[] args)
        {
            Eratostene();
        }
        
        static void Eratostene()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            bool[] ciur = new bool[n + 1];
            int[] prim = new int[n + 1];
            int k, j;
            ciur[0] = ciur[1] = false;
            for (int i = 2; i <= n; i++)
                ciur[i] = true;

            for (int i = 2; i <= n; i++)
                if (ciur[i] == true)
                {
                    j = i * i;
                    while (j <= n)
                    {
                        ciur[j] = false;
                        j += i;
                    }
                }
            k = 0;
            for (int i = 2; i <= n; i++)
                if (ciur[i] == true)
                {
                    prim[k] = i;
                    k++;
                }
            for (int i = 0; i < k; i++)
                Console.WriteLine($"{prim[i]}");
        }
    }
}
