using System;

namespace set1
{
    class set1_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            if (Divide(n, k) == true)
                Console.WriteLine("{0} se divide cu {1}", n, k);
            else
                Console.WriteLine("{0} nu se divide cu {1}", n, k);

        }

        private static bool Divide(int n, int k)
        {
            if (n % k == 0)
                return true;
            return false;
        }
    }
}