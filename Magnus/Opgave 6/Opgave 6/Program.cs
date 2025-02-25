using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double alder = 40;
            

            //is equal ==
            //is not equal !=
            //is greater >
            //is less <
            //is greater or equal >=
            //is less or equal<=

            Console.WriteLine("Lad os sammenligne vores alder, og lade programmet fortælle om forskellen.\nMåske kan du regne dig frem til min alder?: \nHvad er din alder?");
            double dinAlder = Convert.ToInt32(Console.ReadLine());

            if (dinAlder == alder)
            {
                Console.WriteLine("true, is equal");
            }
            else if (dinAlder < alder)
            {
                Console.WriteLine("false, is not equal, im older");
            }
            else if (dinAlder > alder)
            {
                Console.WriteLine("False, is not equal, im yonger");
            }

        }
    }
}
