using System;

namespace set1
{
    class set1_21
    {

        static void Main(string[] args)
        {
            Joc();
        }


        static void Joc()
        {
            Random Numar = new Random();
            int input = 0, gicit = Numar.Next() % 1024 + 1;
            while (gicit != input)
            {
                input = 0;
                do
                {
                    Console.Write($"Va rog introduceti un numar intre 1 si 1024: ");
                    input = int.Parse(Console.ReadLine());

                } while (!(input >= 1 || input <= 1024));
                if (gicit == input)
                {
                    Console.WriteLine("Ati gicit numarul!");
                }
                else
                    if (input < gicit)
                {
                    Console.WriteLine($"Numarul este mai mare decat {input}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Numarul este mai mic decat {input}");
                    Console.WriteLine();
                }
            }
        }
    }

}