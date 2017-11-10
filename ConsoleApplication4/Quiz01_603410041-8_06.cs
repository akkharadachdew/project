using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = (Math.Sqrt(3 * a * c - Math.Pow(b, 2) / 9 * Math.Pow(a, 2), 3)+(Math.Pow(d,2)));
            Console.WriteLine(x);

        }
    }
}
