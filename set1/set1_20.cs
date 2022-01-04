using System;
using System.Collections.Generic;

namespace set1
{
    class set1_20
    {
        public static void Main(string[] args)
        {
            long numarator = 0, numitor = 0;
            Citire(ref numarator, ref numitor);
            string fractie = Fractie(numarator, numitor);
            Console.WriteLine("Rezultatul este: " + fractie);


        }
        static void Citire(ref long x, ref long y)
        {
            Console.Write("numarator = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("numitor = ");
            y = int.Parse(Console.ReadLine());
        }
        private static string Fractie(long num, long den)
        {
            long numarator = num;
            long numitor = den;
            if (numarator == 0 || numitor == 0)
                return "0";
            string rezultat = "";

            if (numarator * numitor < 0)
                rezultat += "-";

            if (numarator < 0)
                numarator *= -1;
            if (numitor < 0)
                numitor *= -1;

            long coeficient = numarator / numitor, rest = numarator % numitor;

            rezultat += coeficient;

            if (rest == 0)
                return rezultat;

            rezultat += ".";

            Dictionary<long, long> PozDeRest = new Dictionary<long, long>();
            long nr = 0;
            while (rest != 0)
            {
                nr = rest * 10;
                coeficient = nr / numitor;
                rest = nr % numitor;
                if (PozDeRest.ContainsKey(nr))
                    break;
                rezultat += coeficient;
                PozDeRest[nr] = rezultat.Length - coeficient.ToString().Length;
            }

            if (rest == 0)
                return rezultat;

            if (PozDeRest.ContainsKey(nr))
            {
                rezultat = rezultat.Insert((int)PozDeRest[nr], "(");
                rezultat = rezultat + ")";
                return rezultat;
            }
            return rezultat;
        }
    }
}