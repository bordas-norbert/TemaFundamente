using System;

namespace set1
{
    class set1_9
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Numar:");
            a = int.Parse(Console.ReadLine());
            Divizori(a);
        }

        private static void Divizori(int a)
        {
            Console.Write("Divizorii numarului {0}, sunt: 1 ", a);

            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0)
                    Console.Write($"{i} ");
            Console.Write(a);
        }
    }
}