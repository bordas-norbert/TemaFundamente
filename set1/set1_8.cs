using System;

namespace set1
{
    class set1_8
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            swap(ref a, ref b);
            Console.WriteLine($"{a}, {b}");
        }

        private static void swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}