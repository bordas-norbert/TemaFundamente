using System;

namespace set2
{
    class set2_1
    {
        static void Main(string[] Args)
        {
            Pare();
        }
        static void Pare()
        {
            Console.Write("Introduceti numarul de numere: ");
            int n = int.Parse(Console.ReadLine()), nr, count = 0;
            Console.WriteLine("Va rog sa introduceti 1 numar pe rand.");

            for (int i = 1; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                    count++;
            }
            Console.WriteLine($"Au fost introduse {count} numere pare!");
        }
    }
}