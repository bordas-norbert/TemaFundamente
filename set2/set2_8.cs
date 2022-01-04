using System;

namespace set2
{
    class set2_8
    {
        static void Main(string[] Args)
        {
            Fibo();
        }

        private static void Fibo()
        {
            Console.Write("n= ");
            long n = int.Parse(Console.ReadLine()), fibo=0, a = 1, b = 1, k = 2;
            if (n == 1 || n == 2)
            {
                Console.WriteLine($"{n}. fibonacci numar: 1");
                return;
            }
            while(k < n)
            {
                fibo = a + b;
                a = b;
                b = fibo;
                k++;
            }
            Console.WriteLine($"Al {n} -lea fibonacci numar: {fibo}");
        }
    }
} 