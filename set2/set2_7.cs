using System;

namespace set2
{
    class set2_7
    {
        static void Main(string[] Args)
        {
            MinMax();
        }

        private static void MinMax()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine()), min = 0, max = 0, nr;
            if (n == 1)
            {
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Min = Max = {0}", min);
                return;
            }
            if (n >= 2)
            {
                min = int.Parse(Console.ReadLine());
                max = int.Parse(Console.ReadLine());

                if (min > max)
                {
                    min = min + max;
                    max = min - max;
                    min = min - max;
                }
            }
            for (int i = 3; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > max)
                    max = nr;
                if (nr < min)
                    min = nr;
            }
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");

        }
    }
}