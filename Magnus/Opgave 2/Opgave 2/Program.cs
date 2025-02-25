using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = 1.8;
            double farenheit = 1.8;
            
            Console.WriteLine("Jeg kan konvertere celsius til farenheit.\nPrøv at skriv den temperatur, du gerne vil konverteres farenheit: ");
            string celciusSvar = Console.ReadLine();
            double c1 = Convert.ToInt32(celciusSvar);
            double c1Resultat = c1 * farenheit + 32;
            Console.WriteLine(celciusSvar + " celcius er " + c1Resultat + " farenheit");
            
            Console.WriteLine("Jeg kan konvertere farenheit til celcius.\nPrøv at skriv den temperatur, du gerne vil konverteres farenheit: ");
            string farenheitSvar = Console.ReadLine();
            double f1 = Convert.ToInt32(farenheitSvar);
            double f1Resultat = (f1 - 32) / celcius;
            Console.WriteLine(farenheitSvar + " farenheit er " + f1Resultat + " celcius");

        }
    }
}
