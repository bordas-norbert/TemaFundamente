using System;

namespace set2
{
    class set2_2
    {
        static void Main(string[] Args)
        {
            NegZeroPoz();
        }

        static void NegZeroPoz()
        {
            Console.Write("Va rog sa intrati numarul de numere: ");
            int neg = 0, zero = 0, poz = 0, n = int.Parse(Console.ReadLine()), nr;
            Console.WriteLine("Va rog sa introduceti numai 1 numar intr-un rand!");

            for (int i = 1; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr < 0)
                    neg++;
                else
                    if (nr == 0)
                    zero++;
                else
                    poz++;
            }
            Console.WriteLine($"Au fost introduse {neg} bucati de numere negative, {zero} numari de zero si {poz} numere pozitive.");
        }
    }
}