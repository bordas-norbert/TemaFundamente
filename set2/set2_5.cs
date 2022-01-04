using System;

namespace set2
{
    class set2_5
    {
        static void Main(string[] Args)
        {
            Poz();
        }

        private static void Poz()
        {
            Console.Write("Va rog sa introduceti numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine()), counter = 0, nr;

            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr == i)
                    counter++;
            }
            Console.WriteLine($"{counter} de numere sunt egale cu pozitia lor.");
        }
    }
}