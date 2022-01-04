using System;

namespace set2
{
    class set2_17
    {
        static void Main(string[] args)
        {
            Paranteze();
        }

        private static void Paranteze()
        {
            int n = int.Parse(Console.ReadLine()), nr0 = 0, nr1 = 0, x, cuib = 0;
            bool ok = true;
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    nr1++;
                }
                else
                {
                    nr0++;
                }
                if (nr1 > nr0)
                {
                    ok = false;
                }
            }

            if (ok == true && (nr1 - nr0) == 0)
            {
                Console.WriteLine($"Secventa reprezinta o secventa de paranteze corecta.");
            }
            else
                Console.WriteLine("Nu este corecta.");


        }
    }
}
