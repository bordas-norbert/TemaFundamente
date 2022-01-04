using System;

namespace set2
{
    class set2_3
    {
        static void Main(string[] Args)
        {
            SumProdus();
        }

        static void SumProdus()
        {
            Console.Write("Va rog sa introduceti pana cat sa calculam produsul si suma numerelor: ");
            int n = int.Parse(Console.ReadLine());
            ulong produs = 1, suma = 0;
            for (int i = 1; i <= n; i++)
            {
                produs *= (ulong)i;

                suma += (ulong)i;
            }
            Console.WriteLine("Suma: {0}", suma);
            if (produs != 0)
                Console.WriteLine("Produs: {0}", produs);
            else
                Console.WriteLine("Produsul nu s-a putut reprezenta.");
        }
    }
}