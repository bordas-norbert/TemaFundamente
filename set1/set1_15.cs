using System;

namespace set1
{
    class set1_15
    {

        static void Main(string[] args)
        {
            Console.Write("Introduceti 3 numere: ");
            long a = long.Parse(Console.ReadLine()), b = long.Parse(Console.ReadLine());
            if (a > b)
                swap(ref a, ref b);
            long c = long.Parse(Console.ReadLine());

            sort3(ref a, ref b, ref c);
            Console.WriteLine($"{a},{b},{c}");
        }

        static void swap(ref long a, ref long b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        private static void sort3(ref long a, ref long b, ref long c)
        {
            if (c < b || c <= a)
            {
                if (c < b)
                    swap(ref c, ref b);
                if (b < a)
                    swap(ref b, ref a);
            }
        }
    }
}