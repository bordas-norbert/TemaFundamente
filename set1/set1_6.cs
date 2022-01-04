using System;

namespace set1
{
    class set1_6
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());
            Test(a, b, c);


        }

        private static void Test(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
                Console.WriteLine("Cele trei numere pozitive {0}, {1}, {2} pot fi lungimile laturilor unui triunghi.", a, b, c);
            else
                Console.WriteLine("Cele trei numere pozitive {0}, {1}, {2} nu pot fi lungimile laturilor unui triunghi.", a, b, c);
        }
    }
}