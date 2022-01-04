using System;

namespace set2
{
    class Program
    {
        static void Main(string[] args)
        {
            Varf();
        }

        private static void Varf()
        {
            int n = int.Parse(Console.ReadLine()), a = 0, b = 0, i = 2, max = 0;
            bool stop = false, bitonica = true;
            if (n < 3)
            {
                Console.WriteLine("Nu poate fi bitonica.");
                return;
            }
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
                bitonica = false;
            while (i != n && stop == false)
            {

                if (b < a)
                {
                    max = a;
                    stop = true;
                }
                else
                    a = b;
                b = int.Parse(Console.ReadLine());
                ++i;
            }

            if (a <= b)
                bitonica = false;

            stop = false;

            a = b;


            while (i < n && stop == false)
            {
                b = int.Parse(Console.ReadLine());
                if (b > a)
                {
                    bitonica = false;
                    stop = true;
                }
                i++;
            }
            if (bitonica == true)
                Console.WriteLine("Bitonica");
            else
                Console.WriteLine("Nu este bitonica.");
        }
    }
}
