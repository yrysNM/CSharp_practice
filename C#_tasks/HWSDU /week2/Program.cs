using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static week2.Fraction;
using static week2.VectorThree;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 task
            // Fraction a = new Fraction();
            // a.num = 6;
            // a.den = 7;
            // Fraction b = new Fraction(5, 9);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a < b);
            // Console.WriteLine(a > b);
            // Console.WriteLine(a == b);
            // Console.WriteLine(a != b);

            VectorThree v1 = new VectorThree(1, 0, 5);
            VectorThree v2 = new VectorThree(0, 2, 4);
            float a = 5;
            Console.WriteLine(v1 != v2);
            Console.WriteLine((v1 - v2) == (v2 - v1));
            Console.WriteLine(v1 - v2);
            Console.WriteLine((v1 - v2) * a);
            Console.WriteLine(v1.distanceVectorThree(v1, v2));
            Console.ReadKey();
        }
    }
}