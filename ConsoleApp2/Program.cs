using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;            //16

            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());

            Console.Write("x3 = ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = double.Parse(Console.ReadLine());

            if ((x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1))
                Console.WriteLine("Точки лежат на одной прямой");
            else
                Console.WriteLine("Точки не лежат на одной прямой");
        }
    
    }
}
