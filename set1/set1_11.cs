using System;

namespace set1
{
    class set1_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar: ");
            string numar = Console.ReadLine();
            Console.WriteLine("Numarul dupa cifrele inversate: ");
            for (int i = numar.Length - 1; i >= 0; i--)
            {
                Console.Write(numar[i]);
            }
        }
    }
}