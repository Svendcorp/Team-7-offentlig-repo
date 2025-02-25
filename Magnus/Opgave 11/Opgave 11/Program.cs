using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vælg hvilken dag det er idag.\n1. Januar: \n2. Februar: \n3. Marts: \n4. April: \n5. Maj\n6. Juni: ");
            Console.WriteLine("7. Juli: \n8. August: \n9. September: \n10. Oktober: \n11. November: \n12. December: ");
            double daycheck = Convert.ToInt32(Console.ReadLine());

            switch (daycheck)
            {
                case 1:
                    Console.WriteLine("Det er Januar!");
                    break;
                case 2:
                    Console.WriteLine("Det er Februar!");
                    break;
                case 3:
                    Console.WriteLine("Det er Marts!");
                    break;
                case 4:
                    Console.WriteLine("Det er April!");
                    break;
                case 5:
                    Console.WriteLine("Det er Maj!");
                    break;
                case 6:
                    Console.WriteLine("Det er Juni!");
                    break;
                case 7:
                    Console.WriteLine("Det er Juli!");
                    break;
                case 8:
                    Console.WriteLine("Det er August!");
                    break;
                case 9:
                    Console.WriteLine("Det er September!");
                    break;
                case 10:
                    Console.WriteLine("Det er Oktober!");
                    break;
                case 11:
                    Console.WriteLine("Det er November!");
                    break;
                case 12:
                    Console.WriteLine("Det er December!");
                    break;
                default:
                    Console.WriteLine("Du har ikke indtastet et gyldig tal.");
                    break;
            }
        }
    }
}
