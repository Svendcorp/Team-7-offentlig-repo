using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double phi = Math.PI;
            double radius;
            double omkreds;
            double areal;

            Console.WriteLine("Jeg kan udregne areal og omkreds af en cirkel.\nSkriv radius af en cirkel, så regner jeg arealet ud: ");
            radius = Convert.ToInt32(Console.ReadLine());

            areal = (radius * radius) * phi;
            omkreds = 2 * phi * radius;

            Console.WriteLine("Arealet af cirklen er: " + areal);
            Console.WriteLine("Omkredsen af cirklen er: " + omkreds);


        }
    }
}
