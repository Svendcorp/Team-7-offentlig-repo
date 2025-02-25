using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vælg hvilken dag det er idag.\n1. Søndag: \n2. Mandag: \n3. Tirsdag: \n4. Onsdag: \n5. Torsdag\n6. Fredag: \n7. Lørdag: ");
            double daycheck = Convert.ToInt32(Console.ReadLine());

            switch (daycheck)
            {
                case 1:
                    Console.WriteLine("Det er søndag!");
                    break;
                case 2:
                    Console.WriteLine("Det er mandag!");
                    break;
                case 3:
                    Console.WriteLine("Det er tirsdag!");
                    break;
                case 4:
                    Console.WriteLine("Det er onsdag!");
                    break;
                case 5:
                    Console.WriteLine("Det er torsdag!");
                    break;
                case 6:
                    Console.WriteLine("Det er fredag!");
                    break;
                case 7:
                    Console.WriteLine("Det er lørdag!");
                    break;
                default:
                    Console.WriteLine("Du har ikke indtastet et gyldig tal.");
                    break;

            }
        }
    }
}
