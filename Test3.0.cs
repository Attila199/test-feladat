using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irjon be két egész számot!");
            Console.WriteLine("Első szám: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Az  első szám a nagyobb");
            }
            else
            {
                Console.WriteLine("A második szám a nagyobb");
            }
            Console.WriteLine("\nProgram vége");






            Console.ReadKey();
        }
    }
}
