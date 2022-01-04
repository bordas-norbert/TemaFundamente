using System;

namespace set1
{
    class set1_16
    {

        static void Main(string[] args)
        {
            Console.Write("Introduceti 5 numere: ");
            long a = long.Parse(Console.ReadLine()), b = long.Parse(Console.ReadLine());
            if (a > b)
                swap(ref a, ref b);
            long c = long.Parse(Console.ReadLine());
            sort3(ref a, ref b, ref c);
            long d = long.Parse(Console.ReadLine());
            sort4(ref a, ref b, ref c, ref d);
            long e = long.Parse(Console.ReadLine());
            sort5(ref a, ref b, ref c, ref d, ref e);

            Console.WriteLine($"{a},{b},{c},{d},{e}");
        }

        private static void sort5(ref long a, ref long b, ref long c, ref long d, ref long e)
        {
            if (e < d)
            {
                sort4(ref b, ref c, ref d, ref e);
                sort4(ref a, ref b, ref c, ref d);
            }
        }

        private static void sort4(ref long a, ref long b, ref long c, ref long d)
        {
            if (d < c)
            {
                sort3(ref b, ref c, ref d);
                sort3(ref a, ref b, ref c);
            }
        }

        static void swap(ref long a, ref long b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        private static void sort3(ref long a, ref long b, ref long c)
        {
            if (b < a)
                swap(ref a, ref b);
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