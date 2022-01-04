using System;

namespace set2
{
    class set2_6
    {
        static void Main(string[] Args)
        {
            Cresc();
        }

        private static void Cresc()
        {
            Console.Write("Va rog sa introduceti numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine()), before, nevv;
            bool esteCresc = true;
            if (n == 0)
            {
                Console.WriteLine("Nu");
                return;
            }
            else
                before = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Da");
                return;
            }
            for (int i = 2; i <= n; i++)
            {
                nevv = int.Parse(Console.ReadLine());
                if (nevv < before)
                {
                    esteCresc = false;
                }
                else
                    before = nevv;
            }

            if (esteCresc == true)
                Console.WriteLine("Da, sunt in ordine crescatoare.");
            else
                Console.WriteLine("Nu sunt in ordine crescatoare.");

        }
    }
}