using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çevrənin sahəsi:");
             Console.WriteLine(CalculateArea(10));

            Console.WriteLine("Düzbucaqlının sahəsi:");
            Console.WriteLine(CalculateArea(15,7));

            Console.WriteLine("Düzbucaqlı paralelpipedin tam səthinin sahəsi:");
            Console.WriteLine(CalculateArea(3, 5,2));
            

            Console.ReadLine();
        }
        static int CalculateArea(int r) {

            return 3 * r * r;
        }
        static int CalculateArea(int a,int b)
        {
            return a * b;

        }
        static int CalculateArea(int a, int b, int c )
        {
            return 2*(a * b + a * c + b * c);
        }
    }
}
