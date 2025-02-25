using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BMI;
            double vægt;
            double højde;

            Console.WriteLine("BMI er en forældet måde at kategorisere mennesker i vægtklasser.\nJeg kan udregne dit BMI, hvis jeg kender din vægt og højde.\nHvad er din vægt?: ");
            string vægtSvar = Console.ReadLine();
            vægt = Convert.ToDouble(vægtSvar);

            Console.WriteLine("HVad er din højde? (skrives i meter e.g. 175 = 1.75): ");
            string højdeSvar = Console.ReadLine();
            højde = Convert.ToDouble(højdeSvar);

            BMI = vægt / (højde * højde);

            if (BMI < 18.5)
            {
                Console.WriteLine("Din BMI er " + BMI + " og ifølge modellen, så er du undervægtig");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Din BMI er " + BMI + " og ifølge modellen, så er du normalvægtig");
            }
            else if (BMI >= 25 && BMI < 29.9)
            {
                Console.WriteLine("Din BMI er " + BMI + " og ifølge modellen, så er du overvægtvægtig");
            }
            else if (BMI >= 30)
            {
                Console.WriteLine("Din BMI er " + BMI + " og ifølge modellen, så er du fed");
            }
            else
            {
                Console.WriteLine("ugyldig udregning");
            }
        }
    }
}
