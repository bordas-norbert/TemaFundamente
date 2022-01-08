using System;
using System.Collections.Generic;
namespace set3
{
    class set3_17
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            ConvertToB(n, b);
        }
        static void Add(ref List<char> res, int r, int b)
        {

            switch (r)
            {
                case 10: res.Add('A'); break;
                case 11: res.Add('B'); break;
                case 12: res.Add('C'); break;
                case 13: res.Add('D'); break;
                case 14: res.Add('E'); break;
                case 15: res.Add('F'); break;
                default: res.Add(Convert.ToChar(r + '0')); break;
            }


        }
        private static void ConvertToB(int n, int b)
        {

            List<char> res = new List<char>();
            int r = 0;
            while (n != 0)
            {
                r = n % b;
                Add(ref res, r, b);
                n /= b;
            }
            res.Reverse();
            string rezultat = string.Concat(res);
            Console.WriteLine("Numarul convertat in baza " + b + " este " + rezultat);
        }
    }
}