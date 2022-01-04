using System;
using System.Collections.Generic;

namespace set2
{
    class set2_9
    {
        public static void Main(string[] args)
        {
            int n = 0;
            Citire(ref n);
            Monoton(n);
        }

        private static void Monoton(int n)
        {
            bool cresc = true, desc = true;
            int old = 0, nevv = 0;
            if (n <= 1)
            {
                Console.WriteLine("va rog sa intrati mai multe numere");
                return;
            }
            Console.WriteLine($"Va rog sa intrati {n} de numere 1 pe o linie");
            old = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                nevv = int.Parse(Console.ReadLine());
                if (old < nevv)
                {
                    desc = false;
                }
                if (old > nevv)
                {
                    cresc = false;
                }
                old = nevv;
            }
            if (cresc == true && desc == false)
                Console.WriteLine("Monoton crescator!");
            else
                if (desc == true && cresc == false)
                Console.WriteLine("Monoton descrescator!");
            else
                Console.WriteLine("Nu-i nici crescator nici descrescator!");
        }

        static void Citire(ref int x)
        {
            Console.Write("n = ");
            x = int.Parse(Console.ReadLine());

        }


    }
}