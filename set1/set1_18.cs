using System;

namespace set1
{
    class set1_18
    {

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Descompunere(n);


        }

        private static void Descompunere(long n)
        {
            long divizor = 2, putere;
            do
            {
                putere = 0;
                while (n % divizor == 0)
                {
                    putere++;
                    n /= divizor;

                }
                if (putere != 0)
                {
                    Console.Write($"{divizor}^{putere}");
                    if (n != 1)
                        Console.Write(" x ");
                }
                divizor++;

            } while (n != 1);
        }
    }

}