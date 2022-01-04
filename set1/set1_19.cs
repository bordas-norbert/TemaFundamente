using System;

namespace set1
{
    class set1_19
    {

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            FormatDinDoi(n);


        }

        private static void FormatDinDoi(long n)
        {
            int prim = -1, secund = -2;

            prim = Convert.ToInt32(n % 10);

            while (n != 0)
            {

                if (n % 10 != prim && secund == -2)
                    secund = Convert.ToInt32(n % 10);
                if (n % 10 != prim && n % 10 != secund)
                {
                    Console.WriteLine("Nu este format doar din 2 cifre.");
                    return;
                }
                n /= 10;
            }
            if (secund == -2)
                Console.WriteLine("Nu este format doar din 2 cifre.");
            else
                Console.WriteLine("Este format doar din 2 cifre.");

        }
    }

}