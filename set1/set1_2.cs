using System;

namespace set1_2
{
    class set1_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());
            if (Test(a, b, c) == false)
            {
                return;
            }
            long delta = b * b - 4 * a * c;

            if (delta == 0)
            {
                rez1(a, b);
            }
            else
                if (delta > 0)
            {
                rez2(delta, a, b);
            }
            else
                rez3(delta, a, b);

        }

        private static bool Test(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Nu se poate rezolva ecuatia");
                return false;
            }
            if (a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine("x1=x2={0}", (double)-c / b);
                return false;
            }
            if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine("x1={0}i", (double)Math.Sqrt(4 * a * c) / (2 * a));
                Console.WriteLine("x1={0}i", (double)-Math.Sqrt(4 * a * c) / (2 * a));
                return false;
            }
            if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("x1 si x2 pot fi orice numar posibil");
                return false;
            }
            return true;
        }

        private static void rez3(long delta, int a, int b)
        {
            double intreg, imaginar;
            intreg = (double)-b / (2 * a);
            imaginar = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine("x1={0}+{1}i", intreg, imaginar);
            Console.WriteLine("x2={0}-{1}i", intreg, imaginar);
        }

        private static void rez2(long delta, int a, int b)
        {
            double x1, x2;
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1={0}", x1);
            Console.WriteLine("x2={0}", x2);
        }

        private static void rez1(int a, int b)
        {
            Console.WriteLine("x1=x2={0}", (double)-b / (2 * a));
        }
    }
}