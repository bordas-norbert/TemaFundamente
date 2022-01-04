using System;

namespace set2
{
    class set2_3
    {
        static void Main(string[] Args)
        {
            Poz();
        }

        private static void Poz()
        {
            Console.Write("Va rog introduceti numarul de numere a secventei: ");

            int n = int.Parse(Console.ReadLine());
            Console.Write("Va rog introduceti numarul cautat: ");
            int numar = int.Parse(Console.ReadLine()), poz = 0, input, pozNr = -1;
            bool gasit = false;
            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == numar && gasit == false)
                {

                    pozNr = poz;
                    gasit = true;

                }
                else
                {
                    poz++;
                }
            }

            Console.WriteLine("Numarul este pe pozitia {0}", pozNr);

        }
    }
}