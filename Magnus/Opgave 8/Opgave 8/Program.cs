using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jeg er din personlige bedømmelses robot.\nJeg kan fortælle dig om du har bestået et fag.\nSkriv din karakter, så giver jeg dig resultatet(A-E): ");

            char bokstavcheck = char.Parse(Console.ReadLine());

            if (bokstavcheck == 'A')
            {
                Console.WriteLine("Tillykke!!! Du er bestået");
            }
            else if (bokstavcheck == 'B')
            {
                Console.WriteLine("Tillykke!!! Du er bestået");
            }
            else if (bokstavcheck == 'C')
            {
                Console.WriteLine("Tillykke!!! Du er bestået");
            }
            else if (bokstavcheck == 'D')
            {
                Console.WriteLine("Desværre... Du er ikke bestået");
            }
            else if (bokstavcheck == 'E')
            {
                Console.WriteLine("Desværre... Du er ikke bestået");
            }
            else 
            {
                return;
            }
        }
    }
}
