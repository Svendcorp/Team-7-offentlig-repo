using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Jeg kan regne to tal sammen for dig.\nKom med det 1. tal: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kom med 2. tal: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(addition(x, y));
        }

        static double addition(double x, double y)
        {
            return x + y;
        }
    }
}
