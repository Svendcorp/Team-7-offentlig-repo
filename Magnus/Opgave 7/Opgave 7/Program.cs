using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeg kan forstælle om et tal er større/mindre eller lig med 0.\nPrøv at skriv et tal: ");
            
            double fortegn;
            fortegn = Convert.ToInt32(Console.ReadLine());
            if (fortegn == 0)
            {
                Console.WriteLine("Dit tal er lig med 0");
            }
            else if (fortegn < 0)
            {
                Console.WriteLine("Dit tal er negativt, da det er mindre end 0");
            }
            else
            {
                Console.WriteLine("Dit tal er positivt, da det er større end 0");
            }
        }
    }
}
